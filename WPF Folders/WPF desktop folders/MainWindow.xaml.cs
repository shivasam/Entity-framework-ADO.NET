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

namespace WPF_desktop_folders
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var item in Directory.GetLogicalDrives())
            {
                var i = new TreeViewItem();
                //getting drives from pc
                i.Header = item;
                //adding subfolders to the existing folders
                i.Tag = item;
                i.Items.Add(null);
                //list the items which are expanded
                i.Expanded += I_Expanded;
                treeIndex.Items.Add(i);
            }
        }

        private void I_Expanded(object sender, RoutedEventArgs e)
        {
            var i = (TreeViewItem)sender;
            if (i.Items.Count != 0 || i.Items != null)
                return;
            i.Items.Clear();

            var fullPath = (string)i.Tag;
            var y = new List<string>();
            try
            {
                var d = Directory.GetDirectories(fullPath);
                if (d.Length > 0)
                {
                    y.AddRange(d);
                }
            }
            catch
            {
         
            }
            throw new NotImplementedException();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
