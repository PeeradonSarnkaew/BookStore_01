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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    ///
    public partial class MainMenu : Window
    {
        Book_Management book = new Book_Management();
        Book_Order order = new Book_Order();
        Customer_Management customer = new Customer_Management();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CustomerManagerButton_Click(object sender, RoutedEventArgs e)
        {
            customer.Show();
            this.Close();
        }
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("ต้องการออกจากระบบหรือไม่", "ออกจากระบบ", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("ออกจากระบบเสร็จสิ้น", "ออกจากระบบ", MessageBoxButton.OK);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void BookOrderButton_Click(object sender, RoutedEventArgs e)
        {
            order.Show();
            this.Close();
        }

        private void BookManagementButton_Click(object sender, RoutedEventArgs e)
        {
            book.Show();
            this.Close();
        }
    }
}
