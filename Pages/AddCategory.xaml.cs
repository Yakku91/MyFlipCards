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
    /// Interaction logic for AddCategory.xaml
    /// </summary>
    public partial class AddCategory : Page
    {
        public AddCategory()
        {
            InitializeComponent();
            
        }

            private void btn_Add_Category_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_Category.Text == "")
            {
                var messageBox = new DefaultMessageBox("Bitte geben Sie einen Kategorienamen!");
                messageBox.ShowDialog();
            }
            else
            {
                var categoryViewModel = (CategoryViewModel)DataContext;
                categoryViewModel.addCategory();
            }
        }
        private void btn_Edit(object sender, RoutedEventArgs e)
        {
            var category = ((FrameworkElement)sender).DataContext as Category;
            if (category != null)
            {
                var categoryViewModel = (CategoryViewModel)DataContext;
                categoryViewModel.editCategory(category);
            }
        }
    }
}
