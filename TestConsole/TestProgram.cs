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
using System.Diagnostics;

namespace TestConsole
{
    internal class TestProgram
    {
        static void Main(string[] args)
        {

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

            // Vraag voor in de klass **************************************************************************

            //User sam = new User("Employee", "Sam", "Brosky", "sam@brosky.net", "321", new DateTime(2003, 03, 11, 12, 00, 00));

            //sam.ChangeUserAttribute("Birthdate", new DateTime(2001, 03, 11, 12, 00, 00));

            //Console.WriteLine(sam.Birthdate);

            //sam.SecurityLevel = "Manager";
            //Console.WriteLine(sam.SecurityLevel);

            // Vraag voor in de klass *************************************************************************

            string str = "32 Max Baap";
            string[] words = str.Split(' ');
            int UserId = 0;
            foreach (string word in words)
            {
                if (int.TryParse(word, out _))
                {
                    UserId = Int32.Parse(word);
                    break;
                }
            }
            Console.WriteLine(UserId);
            Console.ReadKey();
        }
    }
}
