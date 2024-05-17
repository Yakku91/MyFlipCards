using MyCards.Models;
using MyCards.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyCards.Pages
{
    /// <summary>
    /// Interaction logic for MyCards.xaml
    /// </summary>
    public partial class MyCards : Page
    {

        public MyCards()
        {
            InitializeComponent();
          
        }

        private void comboBox_Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cardViewModel = (CardViewModel)DataContext;
            if (comboBox_Categories.SelectedItem is not null)
            {
                cardViewModel.sortCardsWithComboBox(comboBox_Categories.SelectedItem as Category);
            }
        }

        private void btn_Delete(object sender, RoutedEventArgs e)
        {
            var card = ((FrameworkElement)sender).DataContext as Card;
            if (card != null)
            {
                ((CardViewModel)DataContext).deleteCard(card);
            }
        }
        
        private void btn_ChangeCard(object sender, RoutedEventArgs e)
        {
            var card = ((FrameworkElement)sender).DataContext as Card;
            Border clickedBorder = sender as Border;
            DockPanel parentDockPanel = clickedBorder.FindName("dockPanel") as DockPanel;
            Label lbl_Card = parentDockPanel.FindName("lbl_Card") as Label;

            if (lbl_Card.Content == card.Front)
            {
                lbl_Card.Content = card.Back;
            }
            else
            {
                lbl_Card.Content = card.Front;
            }
        }       
    }
}
