using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Product
    {
        public string Category { get; private set; }
        public string ProductName { get; private set; }
        public double Price { get; private set; }

        
        public Product(string _category, string _productname, double _price) 
        {
            Category = _category;
            ProductName = _productname;
            Price = _price;
        }
    }
}
