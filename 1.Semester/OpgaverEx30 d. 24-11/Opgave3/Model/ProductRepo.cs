using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3.Model
{
    public class ProductRepo
    {
        private List<Product> products = new List<Product>();
        public ProductRepo()
        {
            InitialzeRepo();
        }

        public void InitialzeRepo()
        {
            Add("Apple", 7.95);
            Add("Orange", 5.50);
            Add("Banana", 8.25);
        }

        public Product Add(string name, double price)
        {
            Product product = new Product(name, price);
            products.Add(product);
            return product;
        }

        public List<Product> GetAll()
        {
            return products;
        }
    }
}
