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

namespace WpfDemoSolution.first
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void UP_Click(object sender, RoutedEventArgs e)
        {
            b.Text = "|";
            d.Text = null;
            h.Text = null;
            f.Text = null;
        }

        private void LEFT_Click(object sender, RoutedEventArgs e)
        {
            b.Text = null;
            d.Text = "--";
            h.Text = null;
            f.Text = null;
        }

        private void DOWN_Click(object sender, RoutedEventArgs e)
        {
            b.Text = null;
            d.Text = null;
            h.Text = "|";
            f.Text = null;
        }

        private void RIGHT_Click(object sender, RoutedEventArgs e)
        {
            b.Text = null;
            d.Text = null;
            h.Text = null;
            f.Text = "--";
        }
    }
}
