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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort Flowersort { get; set; }
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            btnOK.IsEnabled = false;
        }
        private void btnOKCheck()
        {
            if (tbName.Text != "" && tbPicturePath.Text != "" && tbProductionTime.Text != "" && tbHalfLifeTime.Text != "" && tbSize.Text != "")
            {
                btnOK.IsEnabled = true;
            }
            
        }
        private void changeImage()
        {
            Image img = new Image();
            Uri resourceUri = new Uri(tbPicturePath.Text);
            img.Source = new BitmapImage(resourceUri);
        }
    private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnOKCheck();
        }

        private void tbPicturePath_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnOKCheck();
           
        }

        private void tbProductionTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnOKCheck();
        }

        private void tbHalfLifeTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnOKCheck();
        }

        private void tbSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnOKCheck();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Flowersort = new FlowerSort(tbName.Text, tbPicturePath.Text, int.Parse(tbProductionTime.Text), int.Parse(tbHalfLifeTime.Text), int.Parse(tbSize.Text));
            DialogResult = true;
            
        }
            
    }
}
