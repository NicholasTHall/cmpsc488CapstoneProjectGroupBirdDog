using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dbConnector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonInsertIntoTable_Click(object sender, RoutedEventArgs e)
        {
            String tableName = textBoxTableName.Text;
            this.Content = new InsertPage(tableName);            
        }

        private void ButtonGetFromTable_Click(object sender, RoutedEventArgs e)
        {
            String tableName = textBoxTableName.Text;
            GetPage GP = new GetPage(tableName);
            this.Content = GP.Content;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List data = new List();
            int id = 0;
            string address = "1600+Pennsylvania+Ave+NW,Washington,DC,20500";

            string url = "http://www.mapquestapi.com/geocoding/v1/address?key=nOXiWChDoFPzIEHhm2YCilplmnTr0WBh&location=" + address.ToUpper();
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    string phrase = reader.ReadToEnd().ToString();
                    string[] words = phrase.Split('{');
                    Boolean islat = true;
                    double lat = 0;
                    double lng = 0;
                    
                    foreach (var word in words)
                    {
                        if (word.Contains("Lat") && word.Contains("Lng"))
                        {
                            string[] words2 = word.Split(',','}');

                            foreach (var word2 in words2)
                            {
                                if (word2.Contains("\"lat\"") || word2.Contains("\"lng\""))
                                {
                                    string[] words3 = word2.Split(':');
                                    if (islat)
                                    {
                                        lat = Convert.ToDouble(words3[1]);
                                        islat = false;
                                    }
                                    else
                                    {
                                        lng = Convert.ToDouble(words3[1]);
                                    }                                    
                                }                                
                            }                            
                        }
                    }

                    this.textBoxData.Text = this.textBoxData.Text + lat + "\n" + lng + "\n";
                    //this.textBoxData.Text = this.textBoxData.Text + phrase;
                    reader.Close();
                }
                response.Close();
                
            }
            /*
            using (SqlConnection connection = new SqlConnection("Data Source=mycsdb.civb68g6fy4p.us-east-2.rds.amazonaws.com;Initial Catalog=warehouse;User ID=masterUser;Password=master1234;"))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM product WHERE prod_id = 1", connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (reader.HasRows)
                    {
                        // Read advances to the next row.
                        while (reader.Read())
                        {
                            this.textBoxData.Text = this.textBoxData.Text + reader.GetString(reader.GetOrdinal("prod_name"))+ " " + reader.GetString(reader.GetOrdinal("prod_desc"));
                        }
                    }
                }
            }*/
        }
    }
}
