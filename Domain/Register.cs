using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Register
    {
        public List<User> Managers { get; private set; } = new List<User>();
        public List<User> Employees { get; private set; } = new List<User>();
        public Register() { }
    
        public void AddUser(User user)
        {
            switch (user.SecurityLevel)
            {
                case "Manager":
                    Managers.Add(user);
                    break;
                case "Employee":
                    Employees.Add(user);
                    break;
                default:
                    break;
            }
        }

        public List<User> ChangeUser(User user)
        {
            switch (user.SecurityLevel)
            {
                case "Manager":
                    User UserInList_managers = Managers.Find(u => u.Email == user.Email);
                    UserInList_managers = user;
                    return Managers;
                case "Employee":
                    User UserInList_employees = Employees.Find(u => u.Email == user.Email);
                    UserInList_employees = user;
                    return Employees;
                default:
                    return null;
            }
        }

        public void RemoveUser(User user)
        {
            switch (user.SecurityLevel)
            {
                case "Manager":
                    Managers.Remove(user);
                    break;
                case "Employee":
                    Employees.Remove(user);
                    break;
                default:
                    break;
            }
        }
    }
}
