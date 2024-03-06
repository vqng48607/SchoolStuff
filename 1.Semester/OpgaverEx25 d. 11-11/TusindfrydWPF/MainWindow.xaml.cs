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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();


        }

        private void btnCreateFlowerSort_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSortDialog= new CreateFlowerSortDialog();

            if (createFlowerSortDialog.ShowDialog() == true)
            {
                flowerSorts.Add(createFlowerSortDialog.Flowersort);

                var textBlock = (TextBlock)FindName("tbblock");

                foreach (FlowerSort sort in flowerSorts)
                {
                    textBlock.Text = textBlock.Text + sort.Name;
                }
            }
            else
                throw new Exception("Det virker ikke");
            
            
            
        }
    }
}
