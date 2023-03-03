using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassasysteem
{
    public partial class Login : Form
    {
        public Register Register = new Register();
        public Cashregister CashregisterForm = new Cashregister();
        public Login()
        {
            InitializeComponent();
            InitializeControls();
        }

        public void InitializeControls()
        {
            CreateAccPanel.Hide();
            LoginPanel.Hide();
            IncorrectLabel.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            CreateAccPanel.Hide();
            LoginPanel.Show();
        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            LoginPanel.Hide();
            CreateAccPanel.Show();
        }

        public void CreateUser()
        {    
            DateTime Birthday = new DateTime(Int32.Parse(Yearbox.Text), Int32.Parse(Monthbox.Text), Int32.Parse(Daybox.Text), 12,00,00);
            User user = new User(Securitybox.Text, Firstname_box.Text, Lastname_box.Text, Email_box.Text, Password_box.Text, Birthday);
            Register.AddUser(user);
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateUser();
            Securitybox.ResetText();
            Firstname_box.Clear();
            Lastname_box.Clear();
            Email_box.Clear();
            Password_box.Clear();
            Yearbox.ResetText();
            Monthbox.ResetText();
            Daybox.ResetText();
        }

        public void SignInButton_Click(object sender, EventArgs e)
        {
            foreach (User user in Register.Managers)
            {
                //Debug.WriteLine(user.Email);
                if (user.Email == LoginEmail_Box.Text && user.Password == LoginPassword_Box.Text)
                {
                    Hide();
                    CashregisterForm.Show();
                }
                else
                {
                    LoginPassword_Box.Clear();
                    IncorrectLabel.Show();
                }
            }
            foreach (User user in Register.Employees)
            {
                if (user.Email == LoginButton.Text && user.Password == LoginPassword_Box.Text)
                {
                    Hide();
                    CashregisterForm.Show();
                }
                else
                {
                    LoginPassword_Box.Clear();
                    IncorrectLabel.Show();
                }
            }
        }
    }

    
}
