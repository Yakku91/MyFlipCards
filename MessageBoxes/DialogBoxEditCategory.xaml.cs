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
using System.Windows.Shapes;

namespace MyCards.MessageBoxes
{
    /// <summary>
    /// Interaction logic for DialogBoxEditCategory.xaml
    /// </summary>
    public partial class DialogBoxEditCategory : Window
    {
        private readonly CategoryRepository categoryRepository;
        private Category category { get; set; }

        public DialogBoxEditCategory(Category category)
        {
            InitializeComponent();
            categoryRepository = new CategoryRepository();
            this.category = category;
            txtBox_Name.Text = category.Name;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            category.Name = txtBox_Name.Text;
            categoryRepository.update(category);
            this.Close();
        }

        private void btnDeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxMitOptions = new MsgBoxWithOptions("Wens Sie diese Kategorie löschen, werden alle Karten unter dieser Kategorie mitgelöscht. Möchten Sie trotzdem weitermachen?");
            var result = messageBoxMitOptions.ShowDialog();
            if (result == true)
            {
               categoryRepository.delete(category);
            }
            this.Close();
        }
    }
}
