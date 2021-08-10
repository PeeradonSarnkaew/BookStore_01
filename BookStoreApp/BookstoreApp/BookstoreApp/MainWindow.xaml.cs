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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookstoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainMenu mainMenu = new MainMenu();
        public MainWindow()
        {

            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void signinButton_Click(object sender, RoutedEventArgs e)
        {
            if (usernameText.Text == "Mr.Glueman" )
            {
                if (passwordText.Text == "123456")
                {
                    MessageBoxResult result = MessageBox.Show("โปรดกด OK เพื่อเข้าสู่ระบบ", "ล็อกอินสำเร็จ", MessageBoxButton.OK,MessageBoxImage.Information);

                    if (result == MessageBoxResult.OK)
                    {
                        mainMenu.Show();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("โปรดตรวจสอบข้อมูลดังกล่าว", "Password หรือ Username ไม่ถูกต้อง", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("โปรดตรวจสอบข้อมูลดังกล่าว", "Password หรือ Username ไม่ถูกต้อง", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void passwordText_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordText.Text = "";
        }


        private void usernameText_GotFocus(object sender, RoutedEventArgs e)
        {
            usernameText.Text = "";
        }

        private void forgotButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("โปรดติดต่อที่ captainglueman@gmail.com เพื่อขอรับ Password และ Username", "หากลืม Username หรือ Password",MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
