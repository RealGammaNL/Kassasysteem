using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using DAL;
using Domain;
using Kassasysteem;


namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> _products = new List<Product>();

            string json = System.IO.File.ReadAllText("Products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json);

            foreach (Product product in _products)
            {
                Console.WriteLine(product.ProductName);
                Console.ReadKey();
            }
        }
    }
}
