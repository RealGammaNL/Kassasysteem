namespace Kassasysteem
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateAccPanel = new System.Windows.Forms.Panel();
            this.Createaccount_label = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Monthbox = new System.Windows.Forms.ComboBox();
            this.Daybox = new System.Windows.Forms.ComboBox();
            this.Dateformat_label = new System.Windows.Forms.Label();
            this.Yearbox = new System.Windows.Forms.ComboBox();
            this.Securitybox = new System.Windows.Forms.ComboBox();
            this.Security_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDay_label = new System.Windows.Forms.Label();
            this.EmailAdress_label = new System.Windows.Forms.Label();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.Lastname_box = new System.Windows.Forms.TextBox();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.Firstname_box = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CreateAccBtn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.LoginPassword_Label = new System.Windows.Forms.Label();
            this.LoginPassword_Box = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.LoginEmail_Label = new System.Windows.Forms.Label();
            this.LoginEmail_Box = new System.Windows.Forms.TextBox();
            this.IncorrectLabel = new System.Windows.Forms.Label();
            this.CreateAccPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateAccPanel
            // 
            this.CreateAccPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CreateAccPanel.Controls.Add(this.Createaccount_label);
            this.CreateAccPanel.Controls.Add(this.CreateButton);
            this.CreateAccPanel.Controls.Add(this.Password_Label);
            this.CreateAccPanel.Controls.Add(this.Password_box);
            this.CreateAccPanel.Controls.Add(this.Monthbox);
            this.CreateAccPanel.Controls.Add(this.Daybox);
            this.CreateAccPanel.Controls.Add(this.Dateformat_label);
            this.CreateAccPanel.Controls.Add(this.Yearbox);
            this.CreateAccPanel.Controls.Add(this.Securitybox);
            this.CreateAccPanel.Controls.Add(this.Security_Label);
            this.CreateAccPanel.Controls.Add(this.label1);
            this.CreateAccPanel.Controls.Add(this.BirthDay_label);
            this.CreateAccPanel.Controls.Add(this.EmailAdress_label);
            this.CreateAccPanel.Controls.Add(this.Email_box);
            this.CreateAccPanel.Controls.Add(this.LastName_label);
            this.CreateAccPanel.Controls.Add(this.Lastname_box);
            this.CreateAccPanel.Controls.Add(this.FirstName_label);
            this.CreateAccPanel.Controls.Add(this.Firstname_box);
            this.CreateAccPanel.Location = new System.Drawing.Point(200, 78);
            this.CreateAccPanel.Name = "CreateAccPanel";
            this.CreateAccPanel.Size = new System.Drawing.Size(1093, 676);
            this.CreateAccPanel.TabIndex = 10;
            this.CreateAccPanel.Visible = false;
            // 
            // Createaccount_label
            // 
            this.Createaccount_label.AutoSize = true;
            this.Createaccount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createaccount_label.Location = new System.Drawing.Point(45, 327);
            this.Createaccount_label.Name = "Createaccount_label";
            this.Createaccount_label.Size = new System.Drawing.Size(125, 20);
            this.Createaccount_label.TabIndex = 40;
            this.Createaccount_label.Text = "Create Account";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(179, 314);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(177, 48);
            this.CreateButton.TabIndex = 39;
            this.CreateButton.Text = "Submit";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(45, 238);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(83, 20);
            this.Password_Label.TabIndex = 35;
            this.Password_Label.Text = "Password";
            // 
            // Password_box
            // 
            this.Password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_box.Location = new System.Drawing.Point(179, 231);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(759, 27);
            this.Password_box.TabIndex = 34;
            // 
            // Monthbox
            // 
            this.Monthbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthbox.FormattingEnabled = true;
            this.Monthbox.ItemHeight = 20;
            this.Monthbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Monthbox.Location = new System.Drawing.Point(643, 264);
            this.Monthbox.Name = "Monthbox";
            this.Monthbox.Size = new System.Drawing.Size(139, 28);
            this.Monthbox.TabIndex = 33;
            // 
            // Daybox
            // 
            this.Daybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daybox.FormattingEnabled = true;
            this.Daybox.ItemHeight = 20;
            this.Daybox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Daybox.Location = new System.Drawing.Point(485, 264);
            this.Daybox.Name = "Daybox";
            this.Daybox.Size = new System.Drawing.Size(152, 28);
            this.Daybox.TabIndex = 32;
            // 
            // Dateformat_label
            // 
            this.Dateformat_label.AutoSize = true;
            this.Dateformat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateformat_label.Location = new System.Drawing.Point(386, 267);
            this.Dateformat_label.Name = "Dateformat_label";
            this.Dateformat_label.Size = new System.Drawing.Size(93, 20);
            this.Dateformat_label.TabIndex = 31;
            this.Dateformat_label.Text = "DD:MM:YY";
            // 
            // Yearbox
            // 
            this.Yearbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearbox.FormattingEnabled = true;
            this.Yearbox.ItemHeight = 20;
            this.Yearbox.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.Yearbox.Location = new System.Drawing.Point(788, 264);
            this.Yearbox.Name = "Yearbox";
            this.Yearbox.Size = new System.Drawing.Size(149, 28);
            this.Yearbox.TabIndex = 30;
            // 
            // Securitybox
            // 
            this.Securitybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Securitybox.FormattingEnabled = true;
            this.Securitybox.ItemHeight = 20;
            this.Securitybox.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.Securitybox.Location = new System.Drawing.Point(179, 98);
            this.Securitybox.Name = "Securitybox";
            this.Securitybox.Size = new System.Drawing.Size(759, 28);
            this.Securitybox.TabIndex = 28;
            // 
            // Security_Label
            // 
            this.Security_Label.AutoSize = true;
            this.Security_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Security_Label.Location = new System.Drawing.Point(45, 106);
            this.Security_Label.Name = "Security_Label";
            this.Security_Label.Size = new System.Drawing.Size(115, 20);
            this.Security_Label.TabIndex = 27;
            this.Security_Label.Text = "Security Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Create an account:";
            // 
            // BirthDay_label
            // 
            this.BirthDay_label.AutoSize = true;
            this.BirthDay_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay_label.Location = new System.Drawing.Point(45, 267);
            this.BirthDay_label.Name = "BirthDay_label";
            this.BirthDay_label.Size = new System.Drawing.Size(102, 20);
            this.BirthDay_label.TabIndex = 24;
            this.BirthDay_label.Text = "Date of birth";
            // 
            // EmailAdress_label
            // 
            this.EmailAdress_label.AutoSize = true;
            this.EmailAdress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAdress_label.Location = new System.Drawing.Point(45, 205);
            this.EmailAdress_label.Name = "EmailAdress_label";
            this.EmailAdress_label.Size = new System.Drawing.Size(118, 20);
            this.EmailAdress_label.TabIndex = 23;
            this.EmailAdress_label.Text = "Email Address";
            // 
            // Email_box
            // 
            this.Email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_box.Location = new System.Drawing.Point(179, 198);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(759, 27);
            this.Email_box.TabIndex = 22;
            this.Email_box.Text = "xxx@mail.net";
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_label.Location = new System.Drawing.Point(45, 172);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(91, 20);
            this.LastName_label.TabIndex = 21;
            this.LastName_label.Text = "Last Name";
            // 
            // Lastname_box
            // 
            this.Lastname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname_box.Location = new System.Drawing.Point(179, 165);
            this.Lastname_box.Name = "Lastname_box";
            this.Lastname_box.Size = new System.Drawing.Size(759, 27);
            this.Lastname_box.TabIndex = 20;
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_label.Location = new System.Drawing.Point(45, 139);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(92, 20);
            this.FirstName_label.TabIndex = 19;
            this.FirstName_label.Text = "First Name";
            // 
            // Firstname_box
            // 
            this.Firstname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname_box.Location = new System.Drawing.Point(179, 132);
            this.Firstname_box.Name = "Firstname_box";
            this.Firstname_box.Size = new System.Drawing.Size(759, 27);
            this.Firstname_box.TabIndex = 18;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(15, 15);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(105, 60);
            this.LoginButton.TabIndex = 36;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.Location = new System.Drawing.Point(971, 15);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.Size = new System.Drawing.Size(105, 60);
            this.CreateAccBtn.TabIndex = 37;
            this.CreateAccBtn.Text = "Create Account";
            this.CreateAccBtn.UseVisualStyleBackColor = true;
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.TopPanel.Controls.Add(this.LoginButton);
            this.TopPanel.Controls.Add(this.CreateAccBtn);
            this.TopPanel.Location = new System.Drawing.Point(200, -3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1093, 87);
            this.TopPanel.TabIndex = 11;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LoginPanel.Controls.Add(this.IncorrectLabel);
            this.LoginPanel.Controls.Add(this.SignInButton);
            this.LoginPanel.Controls.Add(this.LoginPassword_Label);
            this.LoginPanel.Controls.Add(this.LoginPassword_Box);
            this.LoginPanel.Controls.Add(this.Loginlabel);
            this.LoginPanel.Controls.Add(this.LoginEmail_Label);
            this.LoginPanel.Controls.Add(this.LoginEmail_Box);
            this.LoginPanel.Location = new System.Drawing.Point(200, 81);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1093, 676);
            this.LoginPanel.TabIndex = 41;
            this.LoginPanel.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(179, 156);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(199, 48);
            this.SignInButton.TabIndex = 39;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LoginPassword_Label
            // 
            this.LoginPassword_Label.AutoSize = true;
            this.LoginPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword_Label.Location = new System.Drawing.Point(45, 126);
            this.LoginPassword_Label.Name = "LoginPassword_Label";
            this.LoginPassword_Label.Size = new System.Drawing.Size(83, 20);
            this.LoginPassword_Label.TabIndex = 35;
            this.LoginPassword_Label.Text = "Password";
            // 
            // LoginPassword_Box
            // 
            this.LoginPassword_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword_Box.Location = new System.Drawing.Point(179, 119);
            this.LoginPassword_Box.Name = "LoginPassword_Box";
            this.LoginPassword_Box.Size = new System.Drawing.Size(759, 27);
            this.LoginPassword_Box.TabIndex = 34;
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlabel.Location = new System.Drawing.Point(40, 25);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(128, 51);
            this.Loginlabel.TabIndex = 26;
            this.Loginlabel.Text = "Login";
            // 
            // LoginEmail_Label
            // 
            this.LoginEmail_Label.AutoSize = true;
            this.LoginEmail_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail_Label.Location = new System.Drawing.Point(45, 93);
            this.LoginEmail_Label.Name = "LoginEmail_Label";
            this.LoginEmail_Label.Size = new System.Drawing.Size(118, 20);
            this.LoginEmail_Label.TabIndex = 23;
            this.LoginEmail_Label.Text = "Email Address";
            // 
            // LoginEmail_Box
            // 
            this.LoginEmail_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail_Box.Location = new System.Drawing.Point(179, 86);
            this.LoginEmail_Box.Name = "LoginEmail_Box";
            this.LoginEmail_Box.Size = new System.Drawing.Size(759, 27);
            this.LoginEmail_Box.TabIndex = 22;
            this.LoginEmail_Box.Text = "xxx@mail.net";
            // 
            // IncorrectLabel
            // 
            this.IncorrectLabel.AutoSize = true;
            this.IncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectLabel.Location = new System.Drawing.Point(386, 172);
            this.IncorrectLabel.Name = "IncorrectLabel";
            this.IncorrectLabel.Size = new System.Drawing.Size(148, 20);
            this.IncorrectLabel.TabIndex = 40;
            this.IncorrectLabel.Text = "Incorrect, try again";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1488, 754);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.CreateAccPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.CreateAccPanel.ResumeLayout(false);
            this.CreateAccPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CreateAccPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BirthDay_label;
        private System.Windows.Forms.Label EmailAdress_label;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.TextBox Lastname_box;
        private System.Windows.Forms.Label FirstName_label;
        private System.Windows.Forms.TextBox Firstname_box;
        private System.Windows.Forms.ComboBox Securitybox;
        private System.Windows.Forms.Label Security_Label;
        private System.Windows.Forms.Label Dateformat_label;
        private System.Windows.Forms.ComboBox Yearbox;
        private System.Windows.Forms.ComboBox Monthbox;
        private System.Windows.Forms.ComboBox Daybox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Label Createaccount_label;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CreateAccBtn;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label LoginPassword_Label;
        private System.Windows.Forms.TextBox LoginPassword_Box;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label LoginEmail_Label;
        private System.Windows.Forms.TextBox LoginEmail_Box;
        private System.Windows.Forms.Label IncorrectLabel;
    }
}