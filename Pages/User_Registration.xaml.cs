using MyCards.MessageBoxes;
using MyCards.Models;
using MyCards.Repository;
using MyCards.ViewModels;
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

namespace MyCards.Pages
{
    /// <summary>
    /// Interaction logic for User_Form.xaml
    /// </summary>
    public partial class User_Form : Page
    {
        public User_Form()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_Password1.Password == "" || txtBox_Password2.Password == "")
            {
                new DefaultMessageBox("Geben Sie Passwort ein!").ShowDialog();
            }
            else if (txtBox_Password1.Password != txtBox_Password2.Password)
            {
                new DefaultMessageBox("Passwörter sind unterschiedlich!").Show();
                txtBox_Password1.Clear();
                txtBox_Password2.Clear();
            }
            else
            {
                var userViewModel = (UserViewModel)DataContext;
                userViewModel.addUser(txtBox_Password1.Password);
                Window.GetWindow(this).Content = new Login();
            }
        }
    }
}
