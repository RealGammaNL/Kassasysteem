using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Receipt
    {
        // price
        // list met producten
        // amount van hoevaak die producten in de lijst voorkomen.
        public List<Product> Products { get; private set; } = new List<Product>();
        private int productAmount;

        public double TotalPrice { get; set; } = 0.00;

        public int ProductCount(Product product)
        {
            return productAmount = Products.Count(s => s == product);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            TotalPrice += product.Price;
        }

    }
}
