using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookstoreApp
{
    /// <summary>
    /// Interaction logic for Book_Order.xaml
    /// </summary>
    public partial class Book_Order : Window
    {
        public Book_Order()
        {
            InitializeComponent();
            List<Item1> listdata = new List<Item1>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand1 = new SqliteCommand
                    ("SELECT Books.ISBN, Title, Customers.Customer_Id, Customer_Name, Email, Quatity, Price, Total_Price " +
                    "FROM Books, Transactions, Customers" +
                    " WHERE Books.ISBN = Transactions.ISBN AND Customers.Customer_Id = Transactions.Customer_Id;", db);

                SqliteDataReader query = selectCommand1.ExecuteReader();

                while (query.Read())
                {
                    listdata.Add(new Item1
                    {
                        ID_BOOK = query.GetString(0),
                        BOOK_NAME = query.GetString(1),
                        ID_CUS = query.GetString(2),
                        CUS_NAME = query.GetString(3),
                        Email = query.GetString(4),
                        Unit = int.Parse(query.GetString(5)),
                        Price = int.Parse(query.GetString(6)),
                        TotalPrice = int.Parse(query.GetString(7))
                    });
                }

                dataGrid.ItemsSource = listdata;

                //CommboBox ID Book
                SqliteCommand selectCommand2 = new SqliteCommand
                    ("SELECT * FROM Books ", db);

                SqliteDataReader query2 = selectCommand2.ExecuteReader();

                while (query2.Read())
                {
                    cbbidbook.Items.Add(query2.GetString(0));
                }



                SqliteCommand selectCommand3 = new SqliteCommand
                    ("SELECT * FROM Customers ", db);

                SqliteDataReader query3 = selectCommand3.ExecuteReader();

                while (query3.Read())
                {
                    cbbidcus.Items.Add(query3.GetString(0));
                }

                db.Close();
            }


        }

        class Item1
        {
            public string ID_BOOK { get; set; }
            public string BOOK_NAME { get; set; }
            public string ID_CUS { get; set; }
            public string CUS_NAME { get; set; }
            public string Email { get; set; }
            public int Unit { get; set; }
            public int Price { get; set; }
            public int TotalPrice { get; set; }

        }

        private void btncalculate_Click(object sender, RoutedEventArgs e)
        {
            string idboox = (string)cbbidbook.SelectedItem;
            int price;
            int totalprice;

            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();
                SqliteCommand selectCommand4 = new SqliteCommand
                 ("SELECT * FROM Books WHERE ISBN = " + idboox, db);

                SqliteDataReader query4 = selectCommand4.ExecuteReader();

                while (query4.Read())
                {
                    txtnamebook.Text = query4.GetString(1);
                    txtdetail.Text = query4.GetString(2);
                    txtbprice.Text = query4.GetString(3);
                }
                price = int.Parse(txtbprice.Text);
                totalprice = price * int.Parse(txtunit.Text);

                txtbtotleprice.Text = totalprice.ToString(); ;


                db.Close();
            }
            MessageBoxResult result = MessageBox.Show("เลขประจำตัวหนังสือ : " + idboox +
                "\n" + "ชื่อหนังสือ : " + txtnamebook.Text + "\n" +
                "เลขสมาชิก : " + cbbidcus.Text + "\n" +
                "จำนวนที่สั่ง : " + txtunit.Text + "\n" +
                "ราคารวม : " + txtbtotleprice.Text, "รายละเอียดการสั่งซื้อ", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                Insert.AddDataTran("Transactions", cbbidbook.Text, cbbidcus.Text, int.Parse(txtunit.Text), int.Parse(txtbtotleprice.Text));
                MessageBoxResult result1 = MessageBox.Show("ทำการสั่งซื้อเสร็จสิ้น" + "\n" + "\n" + "เลขประจำตัวหนังสือ : " + idboox +
               "\n" + "ชื่อหนังสือ : " + txtnamebook.Text + "\n" +
               "เลขสมาชิก : " + cbbidcus.Text + "\n" +
               "จำนวนที่สั่ง : " + txtunit.Text + "\n" +
               "ราคารวม : " + txtbtotleprice.Text, "รายละเอียดการสั่งซื้อ", MessageBoxButton.OK, MessageBoxImage.Information);

                if (result1 == MessageBoxResult.OK)
                {
                    List<Item1> listdata = new List<Item1>();
                    using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
                    {
                        db.Open();

                        SqliteCommand selectCommand1 = new SqliteCommand
                            ("SELECT Books.ISBN, Title, Customers.Customer_Id, Customer_Name, Email, Quatity, Price, Total_Price " +
                            "FROM Books, Transactions, Customers" +
                            " WHERE Books.ISBN = Transactions.ISBN AND Customers.Customer_Id = Transactions.Customer_Id;", db);

                        SqliteDataReader query = selectCommand1.ExecuteReader();

                        while (query.Read())
                        {
                            listdata.Add(new Item1
                            {
                                ID_BOOK = query.GetString(0),
                                BOOK_NAME = query.GetString(1),
                                ID_CUS = query.GetString(2),
                                CUS_NAME = query.GetString(3),
                                Email = query.GetString(4),
                                Unit = int.Parse(query.GetString(5)),
                                Price = int.Parse(query.GetString(6)),
                                TotalPrice = int.Parse(query.GetString(7))
                            });
                        }

                        dataGrid.ItemsSource = listdata;

                        db.Close();
                    }
                }
            }


        }

        private void cbbidbook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string idboox = (string)cbbidbook.SelectedItem;

            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();
                SqliteCommand selectCommand4 = new SqliteCommand
                 ("SELECT * FROM Books WHERE ISBN = " + idboox, db);

                SqliteDataReader query4 = selectCommand4.ExecuteReader();

                while (query4.Read())
                {
                    txtnamebook.Text = query4.GetString(1);
                    txtdetail.Text = query4.GetString(2);
                    txtbprice.Text = query4.GetString(3);
                }

                db.Close();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu fromMenu = new MainMenu();
            fromMenu.Show();
            this.Close();
        }
    }
}
