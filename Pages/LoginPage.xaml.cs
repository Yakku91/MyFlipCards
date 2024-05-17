using MyCards.Models;
using MyCards.Repository;
using MyCards.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MyCards.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
   
        public Login()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            var userViewModel = (UserViewModel)DataContext;
            userViewModel.userLogin(txtBox_Username.Text, txtBox_Passwort.Password, Window.GetWindow(this));
            txtBox_Username.Focus();
        }
    }
}
