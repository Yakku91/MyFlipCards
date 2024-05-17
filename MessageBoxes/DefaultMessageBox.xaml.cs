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
    /// Interaction logic for DefaultMessageBox.xaml
    /// </summary>
    public partial class DefaultMessageBox : Window
    {
        public DefaultMessageBox(string message)
        {
            InitializeComponent();
            txtBox_Message.Content = message;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
