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
using System.Windows.Media.Animation;

namespace Form_WPF_
{
    /// <summary>
    /// Interaction logic for Imagefade.xaml
    /// </summary>
    public partial class Imagefade : Window
    {
        public Imagefade()
        {
            InitializeComponent();
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            DoubleAnimation da = new DoubleAnimation(0,TimeSpan.FromSeconds(2));
            img.BeginAnimation(Image.OpacityProperty, da);
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            DoubleAnimation da = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            img.BeginAnimation(Image.OpacityProperty, da);
        }
    }
}
