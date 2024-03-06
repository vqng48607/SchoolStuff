using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSimpleGUI
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

        private void Scroll_Up(object sender, RoutedEventArgs e)
        {
            tbLine5.Text = tbLine4.Text;
            tbLine4.Text = tbLine3.Text;
            tbLine3.Text = tbLine2.Text;
            tbLine2.Text = tbLine1.Text;
            tbLine1.Text = tbLine5.Text;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            tbLine1.Clear();
            tbLine2.Clear();
            tbLine3.Clear();
            tbLine4.Clear();
        }

        private void Scroll_Down(object sender, RoutedEventArgs e)
        {
            tbLine5.Text = tbLine1.Text;
              
            tbLine1.Text = tbLine2.Text;
            tbLine2.Text = tbLine3.Text;
            tbLine3.Text = tbLine4.Text;
            tbLine4.Text = tbLine5.Text;
            
        }
    }
}
