using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int Id;
        public string SecurityLevel { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }

        public User(string securityLevel, string firstname, string lastname, string email, string password, DateTime birthdate)
        {
            SecurityLevel = securityLevel; // Manager or Employee
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Birthdate = birthdate;
        }

        public User(int id, string securityLevel, string firstname, string lastname, string email, string password, DateTime birthdate)
        {
            Id = id;
            SecurityLevel = securityLevel; // Manager or Employee
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Birthdate = birthdate;
        }

        public void ChangeUserAttribute(string attribute, object newValue)
        {
            switch (attribute)
            {
                case "SecurityLevel":
                    SecurityLevel = newValue.ToString(); 
                    break;
                case "Firstname":
                    Firstname = newValue.ToString(); 
                    break;
                case "Lastname":
                    Lastname = newValue.ToString();
                    break;
                case "Email":
                    Email = newValue.ToString();
                    break;
                case "Password":
                    Password = newValue.ToString();
                    break;
                case "Birthdate":
                    Birthdate = (DateTime)newValue;
                    break;
                default:
                    break;
            }
        }
    }
}
