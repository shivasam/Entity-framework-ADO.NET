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

namespace Form_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The enter text is: " + this.DescriptionText.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.w0.IsChecked = this.w1.IsChecked = this.w2.IsChecked = this.w3.IsChecked = this.w4.IsChecked = this.w5.IsChecked = this.w6.IsChecked
                = this.w7.IsChecked = this.w8.IsChecked
                = this.w0.IsChecked = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void a1(object sender, RoutedEventArgs e)
        {

        }

        private void a(object sender, RoutedEventArgs e)
        {
            this.displayText.Text += ((CheckBox)sender).Content;

        }
    }
}
