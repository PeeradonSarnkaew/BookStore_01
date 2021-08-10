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
    /// Interaction logic for Customer_Management.xaml
    /// </summary>
    public partial class Customer_Management : Window
    {
        
        public Customer_Management()
        {
            InitializeComponent();
            List<Item> listdata = new List<Item>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Customers", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listdata.Add(new Item { Id = query.GetString(0), name = query.GetString(1), Address = query.GetString(2), Email = query.GetString(3) });
                }

                dataGrid.ItemsSource = listdata;
                db.Close();
            }
        }
        class Item
        {
            public string Id { get; set; }
            public string name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }

        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("รีเฟรชข้อมูล", "Refresh", MessageBoxButton.OK);
            List<Item> listdata = new List<Item>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * FROM Customers", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listdata.Add(new Item { Id = query.GetString(0), name = query.GetString(1), Address = query.GetString(2), Email = query.GetString(3) });
                }

                dataGrid.ItemsSource = listdata;
                db.Close();
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu fromMenu1 = new MainMenu();
            fromMenu1.Show();
            this.Close();
        }
        private void adjust_Click(object sender, RoutedEventArgs e)
        {
            if (txtcusid.Text != "" )
            {
                MessageBoxResult result = MessageBox.Show("โปรดตรวจสอบข้อมูลก่อนยืนยัน" + "\n" + "Customer ID : " + txtcusid.Text + "Name-Surname : " + txtcusName.Text + "\n" + "Address : " + txtaddress.Text + "E-Mail : " + txtemail.Text + "\n", "Verify Data", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Edit.UpdatedataCus("Customers", txtcusid.Text, txtcusName.Text, txtaddress.Text, txtemail.Text);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอก Customer ID", "Edit Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (txtcusid.Text != "")
            {
                MessageBoxResult result = MessageBox.Show("ต้องการลบลูกค้าที่มี" + "\n" + "Customer ID : " + txtcusid.Text, "ยืนยันการลบข้อมูล", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Delete.RemoveDataCus("Customers", txtcusid.Text);
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง", "Remove Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (txtcusName.Text != "" && txtaddress.Text != "" && txtcusid.Text != "" && txtemail.Text != "")
            {
                MessageBoxResult result = MessageBox.Show("โปรดตรวจสอบข้อมูล หาก Customer ID ซ้ำจะถูกแทนที่" + "\n" + "Customer ID : " + txtcusid.Text + "Name-Surname : " + txtcusName.Text + "\n" + "Address : " + txtaddress.Text + "E-Mail : " + txtemail.Text + "\n" , "Verify Data", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Insert.AddDatacus("Customers",txtcusid.Text, txtcusName.Text, txtaddress.Text, txtemail.Text);
                    List<Item> listdata = new List<Item>();
                    using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
                    {
                        db.Open();

                        SqliteCommand selectCommand = new SqliteCommand
                            ("SELECT * from Customers", db);

                        SqliteDataReader query = selectCommand.ExecuteReader();

                        while (query.Read())
                        {
                            listdata.Add(new Item { Id = query.GetString(0), name = query.GetString(1), Address = query.GetString(2), Email = query.GetString(3) });
                        }

                        dataGrid.ItemsSource = listdata;
                        db.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("โปรดกรอกข้อมูลลูกค้าให้ครบถ้วน", "Add Data Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            string serch = txtserch.Text;
            List<Item> listdata = new List<Item>();
            using (SqliteConnection db = new SqliteConnection("Filename=SQLBOOK.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Customers where Customer_Id like " + "'%" + serch + "%'" +
                    " or Customer_Name like" + "'%" + serch + "%'"
                    + " or Email like" + "'%" + serch + "%'", db);
                //selectCommand.Parameters.AddWithValue("@serch", serch);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    listdata.Add(new Item { Id = query.GetString(0), name = query.GetString(1), Address = query.GetString(2), Email = query.GetString(3) });
                }

                dataGrid.ItemsSource = listdata;
                db.Close();
            }
        }
    }
}
