using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public string SecurityLevel { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime Birthdate { get; private set; }

        public User(string securityLevel, string firstname, string lastname, string email, string password, DateTime birthdate)
        {
            SecurityLevel = securityLevel; // Manager or Employee
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Birthdate = birthdate;
        }
    }
}
