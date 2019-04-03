package edu.psu.birddogs.warehousemaster;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.text.Editable;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class ProductReceiveActivity extends AppCompatActivity {
    private StockProduct stockProduct;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_product_receive);
        Intent intent = getIntent();
        stockProduct = intent.getParcelableExtra("stockProduct");
        if (stockProduct == null) stockProduct = new StockProduct();
        this.setTitle(stockProduct.getProductName());
        ((TextView) findViewById(R.id.byManufacturer)).setText("by " + stockProduct.getManufacturer());
        ((TextView) findViewById(R.id.shelfStockQuantity)).setText(String.valueOf(stockProduct.getShelfStock()));
        ((TextView) findViewById(R.id.bulkStockQuantity)).setText(String.valueOf(stockProduct.getBulkStock()));
        ((TextView) findViewById(R.id.description)).setText(String.valueOf(stockProduct.getDescription()));
        ((Button) findViewById(R.id.pickUpButton)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Editable toMoveS = ((EditText) findViewById(R.id.receiveQuantity)).getText();
                int toMove;
                if (TextUtils.isEmpty(toMoveS) || (toMove = Integer.parseInt(toMoveS.toString())) <= 0)
                    Toast.makeText(ProductReceiveActivity.this, getResources().getString(R.string.negative_quantity_response), Toast.LENGTH_LONG).show();
                else {
                    DatabaseManager.receiveProduct(stockProduct.getID(), toMove);
                    finish();
                }
            }
        });
    }
}
