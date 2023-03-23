using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int Id { get; set; } 
        public string Category { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string category, string productname, double price)
        {
            Category = category;
            ProductName = productname;
            Price = price;
        }

        public Product(int id, string category, string productname, double price)
        {
            Id = id;
            Category = category;
            ProductName = productname;
            Price = price;
        }

        public Product(int id, string category, string productname, double price, int stock)
        {
            Id = id;
            Category = category;
            ProductName = productname;
            Price = price;
            Stock = stock;
        }
    }
}
