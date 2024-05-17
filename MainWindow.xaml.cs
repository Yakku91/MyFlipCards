using MyCards.Models;
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


namespace MyCards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            InitializeComponent();
            ContentFrame.Navigate(new Pages.MyCards());
            lbl_Name.Content = App.currentUser.Surname;
        }

        private void My_Cards_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Pages.MyCards());
        }

        private void Add_Category_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Pages.AddCategory());

        }

        private void add_Card_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Pages.AddCard());

        }

        private void My_Profile_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Pages.Edit_User());

        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            App.currentUser = null;
            this.Close();
        }
    }
}
