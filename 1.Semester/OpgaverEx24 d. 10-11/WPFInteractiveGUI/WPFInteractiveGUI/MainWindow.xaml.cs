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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
        }

        public void EmptyRepo()
        {
            if (controller.CurrentPerson == null)
            {
                tbFirstName.IsEnabled = false;
                tbLastName.IsEnabled = false;
                tbAge.IsEnabled = false;
                tbTelephoneNO.IsEnabled = false;

                btNewPerson.IsEnabled = true;
                btDeletePerson.IsEnabled = false;
                btUp.IsEnabled = false;
                btDown.IsEnabled = false;
            }
        }

        private void New_Person_Button(object sender, RoutedEventArgs e)
        {
            EmptyRepo();
        }

        private void Delete_Person_Button(object sender, RoutedEventArgs e)
        {
            EmptyRepo();
        }

        private void Up_Button(object sender, RoutedEventArgs e)
        {
            EmptyRepo();
        }

        private void Down_Button(object sender, RoutedEventArgs e)
        {
            EmptyRepo();
        }
    }
}
