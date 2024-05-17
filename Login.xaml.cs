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

namespace MyCards
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            LoginFrame.Navigate(new Pages.Login());
        }
        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            LoginFrame.Navigate(new Pages.Login());
        }

        private void btn_missed_Passwort_Click(object sender, RoutedEventArgs e)
        {
            LoginFrame.Navigate(new Pages.MissingPassword());
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            LoginFrame.Navigate(new Pages.User_Form());
        }
    }
}
