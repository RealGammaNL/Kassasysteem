using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Customer
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime Birthdate { get; private set; }

        public Customer(string firstname, string lastname, string email, string password, DateTime birthdate)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Birthdate = birthdate;
        }
    }
}
