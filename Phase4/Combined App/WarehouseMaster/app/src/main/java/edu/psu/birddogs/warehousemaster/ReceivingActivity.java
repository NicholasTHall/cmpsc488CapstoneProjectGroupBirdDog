package edu.psu.birddogs.warehousemaster;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Handler;
import android.os.Looper;
import android.support.annotation.NonNull;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.SparseArray;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.widget.Toast;

import com.google.android.gms.vision.CameraSource;
import com.google.android.gms.vision.Detector;
import com.google.android.gms.vision.barcode.Barcode;
import com.google.android.gms.vision.barcode.BarcodeDetector;

import java.io.IOException;

public class ReceivingActivity extends AppCompatActivity {
    BarcodeDetector barcodeDetector;
    CameraSource cameraSource;
    private int productID;
    private final static int CAMERA_PERMISSION = 5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_receiving);

        if (ContextCompat.checkSelfPermission(this, Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED)
            requestPermissions(new String[] {Manifest.permission.CAMERA}, CAMERA_PERMISSION);
        else continueCreate();
    }

    private void continueCreate() {
        setContentView(R.layout.activity_receiving);
        barcodeDetector = new BarcodeDetector.Builder(this).setBarcodeFormats(Barcode.QR_CODE).build();
        cameraSource = new CameraSource.Builder(this, barcodeDetector).setRequestedPreviewSize(1920, 1280).setAutoFocusEnabled(true).build();

        barcodeDetector.setProcessor(new Detector.Processor<Barcode>() {
            @Override
            public void release() {}

            @Override
            public void receiveDetections(Detector.Detections<Barcode> detections) {
                final SparseArray barcodeList = detections.getDetectedItems();
                if (barcodeList.size() == 0) return;
                try {
                    String value = ((Barcode) barcodeList.valueAt(0)).displayValue;
                    productID = Integer.parseInt(value);
                } catch (ClassCastException ccex) { return; }
                System.out.println(productID);

                // cameraSource.stop() can not be called in this thread due to deadlock issue with API implementation
                Handler handler = new Handler(Looper.getMainLooper());
                handler.post(new Runnable() {
                    @Override
                    public void run() {
                        if (cameraSource != null) cameraSource.stop();
                        if (barcodeDetector != null) barcodeDetector.release();
                    }
                });

                DatabaseManager.getProduct(productID, new DatabaseManager.OnGetProductListener() {
                    @Override
                    public void onGetProduct(StockProduct stockProduct) {
                        if (stockProduct != null) {
                            Intent intent = new Intent(ReceivingActivity.this, ProductReceiveActivity.class);
                            intent.putExtra("stockProduct", stockProduct);
                            startActivityForResult(intent, 0);
                        } else {
                            Intent intent = new Intent(ReceivingActivity.this, NewProductActivity.class);
                            intent.putExtra("id", productID);
                            startActivityForResult(intent, 0);
                        }
                    }
                });
            }
        });

        ((SurfaceView) findViewById(R.id.camera)).getHolder().addCallback(new SurfaceHolder.Callback() {
            @Override
            public void surfaceCreated(SurfaceHolder holder) {
                try {
                    cameraSource.start(((SurfaceView) findViewById(R.id.camera)).getHolder());
                } catch (IOException ioex) {
                    finish();
                } catch (SecurityException scex) {
                    Toast.makeText(ReceivingActivity.this, getResources().getString(R.string.camera_needed), Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {}

            @Override
            public void surfaceDestroyed(SurfaceHolder holder) { cameraSource.stop(); }
        });
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        if (cameraSource != null) cameraSource.release();
        if (barcodeDetector != null) barcodeDetector.release();
    }

    @Override
    public void onActivityResult(int reqCode, int resCode, Intent result) {
        if (cameraSource != null) cameraSource.release();
        continueCreate();
    }

    @Override
    public void onRequestPermissionsResult(int reqCode, @NonNull String[] permissions, @NonNull int[] results) {
        if (reqCode == CAMERA_PERMISSION) {
            if (results.length != 0 && results[0] == PackageManager.PERMISSION_GRANTED) {
                continueCreate();
            } else finish();
        } else super.onRequestPermissionsResult(reqCode, permissions, results);
    }
}

