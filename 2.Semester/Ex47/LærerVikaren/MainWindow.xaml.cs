using ModelPersistence.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace LærerVikaren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchoolRepo repo = new SchoolRepo();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
            repo.Add("Vuongs_Skole", "Vuong", 23423423, "Vuongsvej", "Vuong.com", false);
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            repo.Delete("Vuongs_Skole", "Vuongsvej");
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            repo.Update("Vuongs_Skole", "Vuongsvej", 321);
        }
    }
}
