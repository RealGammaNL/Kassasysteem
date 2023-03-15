using DAL;
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
using Domain;

namespace Kassasysteem
{
    public partial class Login : Form
    {
        public List<User> Users = UserDAL.GetUsers();
        public Register Register = new Register();
        public Cashregister CashregisterForm = new Cashregister();


        public Login()
        {
            InitializeComponent();
            InitializeControls();
        }


        public void InitializeControls()
        {
            LoginPanel.Show();
            CreateAccPanel.Hide();
            Manage_Panel.Hide();
            ManageAcc_Btn.Hide();
            FillPickUser_Box();
            ToCashBtn.Hide();
            CreateAccBtn.Hide();
            IncorrectLabel.Hide();
        }

        private void FillPickUser_Box()
        {
            PickUser_box.Items.Clear();
            foreach (User user in Users)
            {
                PickUser_box.Items.Add($"{user.Id} {user.Firstname} {user.Lastname}");
            }
        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            LoginPanel.Hide();
            Manage_Panel.Hide();
            CreateAccPanel.Show();
        }

        private void ManageAcc_Btn_Click(object sender, EventArgs e)
        {
            LoginPanel.Hide();
            CreateAccPanel.Hide();
            Manage_Panel.Show();
        }

        public void CreateUser()
        {    
            DateTime Birthday = new DateTime(Int32.Parse(Yearbox.Text), Int32.Parse(Monthbox.Text), Int32.Parse(Daybox.Text), 12,00,00);
            User user = new User(Securitybox.Text, Firstname_box.Text, Lastname_box.Text, Email_box.Text, Password_box.Text, Birthday);
            UserDAL.AddUser(user);
            Users = UserDAL.GetUsers(); //Public list users accessible to all methods in Login.cs.
            FillPickUser_Box();
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateUser();
            ResetCreatePanel();
        }


        public void SignInButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (User user in Users)
            {
                if ( user.Email == LoginEmail_Box.Text && user.Password == LoginPassword_Box.Text && user.SecurityLevel == "Manager")
                {
                    LoginPanel.Hide();
                    ManageAcc_Btn.Show();
                    CreateAccBtn.Show();
                    ToCashBtn.Show();
                    found = true;
                    break;
                }    
                   
                if ( user.Email == LoginEmail_Box.Text && user.Password == LoginPassword_Box.Text && user.SecurityLevel == "Employee")
                {
                    LoginPanel.Hide();
                    found = true;
                    Hide();
                    CashregisterForm.Show();
                    break;
                }
            }
            
            if (!found)
            {
                LoginPassword_Box.Clear();
                IncorrectLabel.Show();
            }
        }

    
        private void ToCashBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CashregisterForm.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PickUser_box_SelectedValueChanged(object sender, EventArgs e)
        {
            User user = DeterminePickedUser();
            SecurityLvl_Update_Box.Text = user.SecurityLevel;
            Firstname_Update_Box.Text = user.Firstname;
            Lastname_Update_Box.Text = user.Lastname;
            Email_Update_Box.Text = user.Email;
            Password_Update_Box.Text = user.Password;
            string date = user.Birthdate.ToString("yyyy MM dd");
            string[] dateparts = date.Split(' ');
            for (int i = 0; i < dateparts.Length; i++)
            {
                if (i == 0)
                {
                    Year_Update_Box.Text = dateparts[i];
                }
                if (i == 1)
                {
                    Month_Update_Box.Text = dateparts[i];
                }
                if (i == 2)
                {
                    Day_Update_Box.Text = dateparts[i];
                }
            }
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            Update_Btn.Hide();
            UpdateConfirm_Label.Visible = true;
            UpdateConfirm_Button.Show();
        }

        private void UpdateConfirm_Button_Click(object sender, EventArgs e)
        {
            User user = DeterminePickedUser();
            bool changes = false;
            bool BDChange = false;
            while (!changes)
            {
                if (SecurityLvl_Update_Box.Text != user.SecurityLevel)
                {
                    user.SecurityLevel = SecurityLvl_Update_Box.Text;
                    changes = true;
                }

                if (Firstname_Update_Box.Text != user.Firstname)
                {
                    user.Firstname = Firstname_Update_Box.Text;
                    changes = true;
                }

                if (Lastname_Update_Box.Text != user.Lastname)
                {
                    user.Lastname = Lastname_Update_Box.Text;
                    changes = true;
                }

                if (Email_Update_Box.Text != user.Email)
                {
                    user.Email = Email_Update_Box.Text;
                    changes = true;
                }

                if (Password_Update_Box.Text != user.Password)
                {
                    user.Password = Password_Update_Box.Text;
                    changes = true;
                }

                string date = user.Birthdate.ToString("yyyy MM dd");
                string[] dateparts = date.Split(' ');
                for (int i = 0; i < dateparts.Length; i++)
                {
                    if (i == 0)
                    {
                        if (Year_Update_Box.Text != dateparts[i])
                        {
                            changes = true;
                            BDChange = true;
                        }
                    }
                    if (i == 1)
                    {
                        if (Month_Update_Box.Text != dateparts[i])
                        {
                            changes = true;
                            BDChange = true;
                        }
                    }
                    if (i == 2)
                    {
                        if (Day_Update_Box.Text != dateparts[i])
                        {
                            changes = true;
                            BDChange = true;
                        }
                    }
                }

                if (changes)
                {
                    if (!BDChange)
                    {
                        UserDAL.UpdateUser(user);
                        break;
                    }
                    if (BDChange)
                    {
                        user.Birthdate = new DateTime(Int32.Parse(Year_Update_Box.Text), Int32.Parse(Month_Update_Box.Text), Int32.Parse(Day_Update_Box.Text), 12, 00, 00);
                        UserDAL.UpdateUser(user);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            Update_Btn.Show();
            UpdateConfirm_Button.Hide();
            UpdateConfirm_Label.Hide();
        }
        private void DeleteAccount_Button_Click(object sender, EventArgs e)
        {
            DeleteAccount_Button.Hide();
            ConfirmDelete_Label.Visible = true;
            ConfirmDelete_Button.Show();
        }

        private void ConfirmDelete_Button_Click(object sender, EventArgs e)
        {
            UserDAL.DeleteUser(DeterminePickedUser());
            Users = UserDAL.GetUsers();
            FillPickUser_Box();
            ResetManagementPanel();
            DeleteAccount_Button.Show();
            ConfirmDelete_Button.Hide();
            ConfirmDelete_Label.Hide();
        }

        private User DeterminePickedUser()
        {
            string[] attributes = PickUser_box.Text.Split(' ');
            int Chosen_UserId = 0;

            foreach (string attribute in attributes)
            {
                if (int.TryParse(attribute, out _))
                {
                    Chosen_UserId = Int32.Parse(attribute);
                    break;
                }
            }

            foreach (User user in Users)
            {
                if ( user.Id == Chosen_UserId )
                {
                    return user;
                }
            }

            return null;
        }

        private void ResetCreatePanel()
        {
            Securitybox.ResetText();
            Firstname_box.Clear();
            Lastname_box.Clear();
            Email_box.Text = "xxx@mail.com";
            Password_box.Clear();
            Yearbox.ResetText();
            Monthbox.ResetText();
            Daybox.ResetText();
        }
        private void ResetManagementPanel()
        {
            PickUser_box.ResetText();
            SecurityLvl_Update_Box.ResetText();
            Firstname_Update_Box.Clear();
            Lastname_Update_Box.Clear();
            Email_Update_Box.Clear();
            Password_Update_Box.Clear();
            Year_Update_Box.ResetText();
            Month_Update_Box.ResetText();
            Day_Update_Box.ResetText();
        }
    }
}
