using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kassasysteem
{
    public partial class Cashregister : Form
    {
        private List<Product> _products = new List<Product>();
        Receipt Receipt = new Receipt();
        FlowLayoutPanel zuivelPanel = new FlowLayoutPanel();
        FlowLayoutPanel groentePanel = new FlowLayoutPanel();
        FlowLayoutPanel fruitPanel = new FlowLayoutPanel();
        FlowLayoutPanel vleesPanel = new FlowLayoutPanel();
        FlowLayoutPanel kaasPanel = new FlowLayoutPanel();
        FlowLayoutPanel drankPanel = new FlowLayoutPanel();
        FlowLayoutPanel broodPanel = new FlowLayoutPanel();

        //private Login LoginForm;

        public Cashregister()
        {
            InitializeComponent();// Form Login
            LoadFromFile();
            panelInitializer();
            Hide();
            //LoginForm = loginForm;
            Register register = new Register();
            User user = new User("Manager", "Cas", "Olischalger", "Jemoeder123@gmail.com", "Jemoeder123", DateTime.Now);
            register.ChangeUser(user);
        }

        private void panelInitializer()
        {
            zuivelPanel.Size = placeholderPanel.Size;
            zuivelPanel.Name = "Zuivel";
            zuivelPanel.Visible = true; //This is the first panel you see
            groentePanel.Size = placeholderPanel.Size;
            groentePanel.Name = "Groente";
            fruitPanel.Size = placeholderPanel.Size;
            fruitPanel.Name = "Fruit";
            vleesPanel.Size = placeholderPanel.Size;
            vleesPanel.Name = "Vlees";
            kaasPanel.Size = placeholderPanel.Size;
            kaasPanel.Name = "Kaas";
            drankPanel.Size = placeholderPanel.Size;
            drankPanel.Name = "Drank";
            broodPanel.Size = placeholderPanel.Size;
            broodPanel.Name = "Brood";

            placeholderPanel.Controls.Add(zuivelPanel);
            placeholderPanel.Controls.Add(groentePanel);
            placeholderPanel.Controls.Add(fruitPanel);
            placeholderPanel.Controls.Add(vleesPanel);
            placeholderPanel.Controls.Add(kaasPanel);
            placeholderPanel.Controls.Add(drankPanel);
            placeholderPanel.Controls.Add(broodPanel);

        }
        private void LoadFromFile()
        {
            string json = System.IO.File.ReadAllText("Products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json);

            foreach (Product product in _products)
            {
                Button button = new Button();
                button.Width = 100;
                button.Height = 100;

                button.Name = product.ProductName;
                button.Text = product.ProductName;
                button.Click += buttonProduct_Click;

                //if (product.Category == "Zuivel")
                //{
                //    zuivelPanel.Controls.Add(button);
                //}
                //else if (product.Category == "Groente")
                //{
                //    groentePanel.Controls.Add(button);
                //}
                //else if (product.Category == "Fruit")
                //{
                //    fruitPanel.Controls.Add(button);
                //}
                //else if (product.Category == "Vlees")
                //{
                //    vleesPanel.Controls.Add(button);
                //}
                //else if (product.Category == "Kaas")
                //{
                //    kaasPanel.Controls.Add(button);
                //}
                //else if (product.Category == "Drank")
                //{
                //    drankPanel.Controls.Add(button);
                //}
                //else if (product.Category == "Brood")
                //{
                //    broodPanel.Controls.Add(button);
                //}

                //Better version of the If/Else statement

                switch (product.Category)
                {
                    case "Zuivel":
                        zuivelPanel.Controls.Add(button);
                        break;
                    case "Groente":
                        groentePanel.Controls.Add(button);
                        break;
                    case "Fruit":
                        fruitPanel.Controls.Add(button);
                        break;
                    case "Vlees":
                        vleesPanel.Controls.Add(button);
                        break;
                    case "Kaas":
                        kaasPanel.Controls.Add(button);
                        break;
                    case "Drank":
                        drankPanel.Controls.Add(button);
                        break;
                    case "Brood":
                        broodPanel.Controls.Add(button);
                        break;
                    default:
                        break;
                }
            }
        }
        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Button productButton = (Button)sender;
            Product product = _products.Find(p => p.ProductName == productButton.Name);
            if (productButton.Name == product.ProductName)
            {
                Receipt.AddProduct(product);
                String[] ItemStr = { product.ProductName, Receipt.ProductCount(product).ToString(), String.Format("{0:€ 0.00}", (product.Price * Receipt.ProductCount(product))) };
                bool newProduct = true;

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == product.ProductName)
                    {
                        listView1.Items[i].SubItems[1].Text = Receipt.ProductCount(product).ToString();
                        listView1.Items[i].SubItems[2].Text = String.Format("{0:€ 0.00}", (product.Price * Receipt.ProductCount(product)));
                        
                        newProduct = false;
                        break;
                    }
                }

                if (newProduct)
                {
                    ListViewItem Item = new ListViewItem(ItemStr);

                    listView1.Items.Add(Item);
                }
            }
            PriceTotal.Text = String.Format("{0:€ 0.00}", Receipt.TotalPrice);
        }

        private void switchPanel(object sender, EventArgs e)
        {
            Button categoryButton = (Button)sender;
            foreach (Control control in placeholderPanel.Controls)
            {
                FlowLayoutPanel panel = (FlowLayoutPanel)control;
                if (panel.Name == categoryButton.Text)
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }

        private void DelProdButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            if (selectedItem != null)
            {
                int Amount = Int32.Parse(selectedItem.SubItems[1].Text);
                if (Amount == 0)
                {
                    listView1.Items.Remove(selectedItem);
                }
                else if (Amount > 0)
                {
                    
                    Product product = _products.Find(p => p.ProductName == selectedItem.SubItems[0].Text);
                    Receipt.TotalPrice -= product.Price;
                    Amount--;
                    selectedItem.SubItems[1].Text = (Amount).ToString();
                    selectedItem.SubItems[2].Text = String.Format("{0:€ 0.00}", (Amount * product.Price));
                    PriceTotal.Text = String.Format("{0:€ 0.00}", Receipt.TotalPrice);

                    Receipt.DelItem(product);

                    if (Amount == 0)
                    {
                        listView1.Items.Remove(selectedItem);
                    }
                }
                
            }
        }

        private void DelLineButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            if (selectedItem != null)
            {
                Product product = _products.Find(p => p.ProductName == selectedItem.SubItems[0].Text);
                int Amount = Int32.Parse(selectedItem.SubItems[1].Text);

                Receipt.TotalPrice = Receipt.TotalPrice - (Amount * product.Price);
                listView1.Items.Remove(selectedItem);
                PriceTotal.Text = String.Format("{0:€ 0.00}", Receipt.TotalPrice);

                Receipt.DelAllItems(product);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Receipt.TotalPrice = 0.00;
            PriceTotal.Text = String.Format("{0:€ 0.00}", Receipt.TotalPrice);
            Receipt.ClearList();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            Form form1 = this;
            form1.Hide();
            Form form2 = new Form();
            form2.Size = new Size(500, 700);
            form2.Location = new Point(0,0);
            form2.ShowDialog();
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    Visible = false;
        //    ShowInTaskbar = false;
        //    base.OnLoad(e);
        //}
    }
}
