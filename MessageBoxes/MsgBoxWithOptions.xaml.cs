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
    /// Interaction logic for MsgBoxWithOptions.xaml
    /// </summary>
    public partial class MsgBoxWithOptions : Window
    {
        public MsgBoxWithOptions(string message)
        {
            InitializeComponent();
            txtBox_Message.Text = message;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = null;
            this.Close();
        }
    }
}
