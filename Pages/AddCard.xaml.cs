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
    /// Interaction logic for AddCard.xaml
    /// </summary>
    public partial class AddCard : Page
    {
        public AddCard()
        {
            InitializeComponent();
            txtBox_Front.IsEnabled = false;
            txtBox_Back.IsEnabled = false;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_Front.Text == "")
            {
                new DefaultMessageBox("Bitte geben Sie den Inhalt der vorderen Seite!").ShowDialog();
            }
            else if (txtBox_Back.Text == "")
            {
                new DefaultMessageBox("Bitte geben Sie den Inhalt der hinteren Seite!").ShowDialog();
            }
            else
            {
                var cardViewModel = (AddCardViewModel)DataContext;
                cardViewModel.addCard();
            }

        }

        private void combobox_Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtBox_Front.IsEnabled = true;
            txtBox_Back.IsEnabled = true;
        }
    }
}
