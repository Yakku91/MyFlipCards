using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       private static string pfad = "text.txt";
            private static StreamReader streamReader = new StreamReader(pfad);
        public MainWindow()
        {
            InitializeComponent();
            fillListBox();
        }
        private void fillListBox()
        { 
  
        }
        //private void textBox_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if(e.Key == Key.Enter)
        //    {
        //        Button_Click(sender, e);
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var text = streamReader.ReadToEnd();
            MessageBox.Show(text);
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !listBox.Items.Contains(textBox.Text))
            {
                listBox.Items.Add(textBox.Text.ToString());
                textBox.Clear();
                textBox.Focus();
            }

        }
    }
}
