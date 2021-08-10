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
    /// Interaction logic for Book_Management.xaml
    /// </summary>
    public partial class Book_Management : Window
    {
        public Book_Management()
        {
            InitializeComponent();
            List<Item1> listdata = new List<Item1>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Books", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listdata.Add(new Item1 { Id = query.GetString(0), name = query.GetString(1), Detail = query.GetString(2), Price = query.GetString(3) });
                }

                dataGrid.ItemsSource = listdata;
                db.Close();
            }
        }
        class Item1
        {
            public string Id { get; set; }
            public string name { get; set; }
            public string Detail { get; set; }
            public string Price { get; set; }

        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("รีเฟรชข้อมูล", "Refresh", MessageBoxButton.OK);
            List<Item1> listdata = new List<Item1>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Books", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listdata.Add(new Item1 { Id = query.GetString(0), name = query.GetString(1), Detail = query.GetString(2), Price = query.GetString(3) });
                }

                dataGrid.ItemsSource = listdata;
                db.Close();
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (txtbookid.Text != "")
            {
                MessageBoxResult result = MessageBox.Show("โปรดตรวจสอบข้อมูลก่อนยืนยัน" + "\n" + "ISBN ID : " + txtbookid.Text + "Title : " + txtbookname.Text + "\n" + "Details : " + txtbookdetail.Text + "Price : " + txtprice.Text, "Verify Data", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Delete.RemoveDataBook("Books", txtbookid.Text);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง", "Remove Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void adjust_Click(object sender, RoutedEventArgs e)
        {
            if (txtbookid.Text != "")
            {
                MessageBoxResult result = MessageBox.Show("โปรดตรวจสอบข้อมูลก่อนยืนยัน" + "\n" + "ISBN ID : " + txtbookid.Text + "Title : " + txtbookname.Text + "\n" + "Details : " + txtbookdetail.Text + "Price : " + txtprice.Text, "Verify Data", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Edit.UpdatedataBook("Books", txtbookid.Text, txtbookname.Text, txtbookdetail.Text, int.Parse(txtprice.Text));
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกรหัส ISBN ให้ถูกต้อง", "Edit Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (txtbookname.Text != ""&&txtprice.Text!= ""&& txtbookdetail.Text != "" && txtbookid.Text!= "")
            {
                MessageBoxResult result = MessageBox.Show("โปรดตรวจสอบข้อมูล หาก ISBN ID ซ้ำจะถูกแทนที่" + "\n" + "ISBN ID : " + txtbookid.Text + "Title : " + txtbookname.Text + "\n" + "Detail : " + txtbookdetail.Text + "Price : " + txtprice.Text + "\n", "ยืนยันการเพิ่มข้อมูล", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Insert.AddDatabook("Books",txtbookid.Text, txtbookname.Text, txtbookdetail.Text, int.Parse(txtprice.Text));
                    List<Item1> listdata = new List<Item1>();
                    using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
                    {
                        db.Open();

                        SqliteCommand selectCommand = new SqliteCommand
                            ("SELECT * FROM Books", db);

                        SqliteDataReader query = selectCommand.ExecuteReader();

                        while (query.Read())
                        {
                            listdata.Add(new Item1 { Id = query.GetString(0), name = query.GetString(1), Detail = query.GetString(2), Price = query.GetString(3) });
                        }

                        dataGrid.ItemsSource = listdata;
                        db.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("โปรดกรอกข้อมูลหนังสือให้ครบถ้วน", "Add Data Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu fromMenu1 = new MainMenu();
            fromMenu1.Show();
            this.Close();
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            string serch = txtserch.Text;
            List<Item1> listdata = new List<Item1>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Books where ISBN like " + "'%" + serch + "%'" +
                    " or Title like" + "'%" + serch + "%'"
                    + " or Price like" + "'%" + serch + "%'", db);
                //selectCommand.Parameters.AddWithValue("@serch", serch);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listdata.Add(new Item1 { Id = query.GetString(0), name = query.GetString(1), Detail = query.GetString(2), Price = query.GetString(3) });
                }

                dataGrid.ItemsSource = listdata;
                db.Close();
            }
        }
        
    }
}
