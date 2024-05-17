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
    /// Interaction logic for Edit_User.xaml
    /// </summary>
    public partial class Edit_User : Page
    {
        
        public Edit_User()
        {
            InitializeComponent();
        }
        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_Password1.Password != "" || txtBox_Password2.Password != "")
            {
                if (txtBox_Password1.Password != txtBox_Password2.Password)
                {
                    new DefaultMessageBox("Passwörter sind nicht gleich!").ShowDialog();
                }
            }
            var userViewModel = (UserViewModel)DataContext;
            userViewModel.updateUser(txtBox_Password1.Password);
        }

        private void btn_DeleteUser_Click(object sender, RoutedEventArgs e)
        {
             var userViewModel = (UserViewModel)DataContext;
             userViewModel.removeUser();
           
        }
    }
}
