using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
using MyCards.ViewModels;

namespace MyCards.Pages
{
    /// <summary>
    /// Interaction logic for MissingPassword.xaml
    /// </summary>
    public partial class MissingPassword : Page
    {
        public MissingPassword()
        {
            InitializeComponent();
        }

        private void btn_callPasswort_Click(object sender, RoutedEventArgs e)
        {
            var userViewModel = (UserViewModel)DataContext;
            userViewModel.lostPasswordResque(txtBox_Email.Text, txtBox_Username.Text);
        }
    }
}
