using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Product
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public Product() 
        {
            Amount = 0;
        }
    }
}
