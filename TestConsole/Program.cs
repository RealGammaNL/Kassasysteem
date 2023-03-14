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
            //List<Product> _products = new List<Product>();

            //string json = System.IO.File.ReadAllText("Products.json");
            //_products = JsonSerializer.Deserialize<List<Product>>(json);

            //foreach (Product product in _products)
            //{
            //    Console.WriteLine(product.ProductName);
            //    Console.ReadKey();
            //}

            //User max = new User("Manager", "Max", "Brosky", "max@brosky.net", "123", new DateTime(2003, 03, 11, 12, 00, 00));

            //UserDAL.AddUser(max);

            //User sam = new User("Employee", "Sam", "Brosky", "sam@brosky.net", "321", new DateTime(2003, 03, 11, 12, 00, 00));

            //UserDAL.AddUser(sam);

            //List<User> users = new List<User>();
            //users = UserDAL.GetUsers();

            //foreach (User user in UserDAL.GetUsers())
            //{
            //    Console.WriteLine(user.Email);
            //    Console.WriteLine(user.Id);
            //}

            //UserDAL.DeleteUser(users[1]);

            //foreach (User user in UserDAL.GetUsers())
            //{
            //    Console.WriteLine(user.Email);
            //    Console.WriteLine(user.Id);
            //}
            Console.ReadKey();


        }
    }
}
