using Opgave3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ProductRepo productRepo = new ProductRepo();


        public List<ProductViewModel> ProductsVM { get; set; }

        private ProductViewModel selectedProduct;
        public ProductViewModel SelectedProduct
        {
            get
            {
                return selectedProduct;
            }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        public MainViewModel() 
        {
             this.ProductsVM = new List<ProductViewModel>();

            foreach (Product p in productRepo.GetAll())
            {
                ProductViewModel productViewModel = new ProductViewModel(p);
                ProductsVM.Add(productViewModel);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)

        {

            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;

            if (propertyChanged != null)

            {

                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }

        }

        public void AddDefaultProduct()
        {
            Product defaultProduct = new Product ("New Product", 0.0);
            ProductViewModel productViewModel = new ProductViewModel(defaultProduct);
            ProductsVM.Add(productViewModel);

        }

    }
}
