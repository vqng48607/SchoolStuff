using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {

            double valueOfProducts = 0;

            //foreach (Product product in _products)
            //{
            //    valueOfProducts += product.Value;
            //}
            //return valueOfProducts;

            //double valueOfProducts = (from product in _products select product.Value).Sum();

            //return valueOfProducts;


            valueOfProducts = _products.Sum(product => product.Value);

            return valueOfProducts;
        }

        public double GetValueOfProducts(DateTime date)
        {

            //double valueOfProducts = (from product in _products where date >= product.AvailableFrom && date <= product.AvailableTo select product.Value).Sum();

            //return valueOfProducts;

            //double valueOfProducts = _products.Where(product => product.AvailableFrom <= date && product.AvailableTo >= date).Sum(product => product.Value);

            double valueOfProducts = _products.Sum(product => product.AvailableFrom <= date && product.AvailableTo >= date ? product.Value : 0);

            return valueOfProducts;
        }

        public List<Product> SortProductOrderByAvailableTo()
        {
            List<Product> result = _products.OrderBy(x => x.AvailableTo)
                             .OrderBy(x => x.AvailableFrom)
                             .OrderBy(x => x.Name)
                             .OrderBy(x => x.Value)
                             .ToList<Product>();

            return result;
        }

        List<Product> SortProductOrderBy(Func<Product, object> keySelector)
        {
            List<Product> result = _products.OrderBy(x => x.AvailableTo)
                             .OrderBy(x => x.AvailableFrom)
                             .OrderBy(x => x.Name)
                             .OrderBy(x => x.Value)
                             .ToList<Product>();

            return result;
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetBonus(DateTime date, Func<double, double> func)
        {
            return func(GetValueOfProducts(date));
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }

        public double GetTotalPrice(DateTime date, Func<double, double> func)
        {

            return GetValueOfProducts(date) - GetBonus(date, func);
        }
    }
}
