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
    public partial class Form1 : Form
    {
        private List<Product> _products = new List<Product>();
        private double endPrice = 0.00;
        Receipt Receipt = new Receipt();
        FlowLayoutPanel zuivelPanel = new FlowLayoutPanel();
        FlowLayoutPanel groentePanel = new FlowLayoutPanel();
        FlowLayoutPanel fruitPanel = new FlowLayoutPanel();
        FlowLayoutPanel vleesPanel = new FlowLayoutPanel();
        FlowLayoutPanel kaasPanel = new FlowLayoutPanel();
        FlowLayoutPanel drankPanel = new FlowLayoutPanel();
        FlowLayoutPanel broodPanel = new FlowLayoutPanel();

        public Form1()
        {
            InitializeComponent();
            LoadFromFile();
            panelInitializer();
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

                if (product.Category == "Zuivel")
                {
                    zuivelPanel.Controls.Add(button);
                }
                else if (product.Category == "Groente")
                {
                    groentePanel.Controls.Add(button);
                }
                else if (product.Category == "Fruit")
                {
                    fruitPanel.Controls.Add(button);
                }
                else if (product.Category == "Vlees")
                {
                    vleesPanel.Controls.Add(button);
                }
                else if (product.Category == "Kaas")
                {
                    kaasPanel.Controls.Add(button);
                }
                else if (product.Category == "Drank")
                {
                    drankPanel.Controls.Add(button);
                }
                else if (product.Category == "Brood")
                {
                    broodPanel.Controls.Add(button);
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
                String[] ItemStr = { product.ProductName, Receipt.ProductCount(product).ToString(), product.Price.ToString() };
                bool newProduct = true;

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == product.ProductName)
                    {
                        listView1.Items[i].SubItems[1].Text = Receipt.ProductCount(product).ToString();
                        listView1.Items[i].SubItems[2].Text = (product.Price * Receipt.ProductCount(product)).ToString();
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
        }

        //public void UpdateShoppingCart()
        //{
        //    foreach (Product product in Receipt.Products)
        //    {
        //        if (Receipt.ProductCount(product) <= 1)
        //        {
        //            String[] ItemStr = { product.ProductName, Receipt.ProductCount(product).ToString(), product.Price.ToString() };
        //            ListViewItem Item = new ListViewItem(ItemStr);
        //            listView1.Items.Add(Item);
        //        }
        //        else
        //        {
        //            String[] ItemStr = { product.ProductName, Receipt.ProductCount(product).ToString(), product.Price.ToString() };
        //            ListViewItem Item = new ListViewItem(ItemStr);
        //            for (int i = 0; i < listView1.Items.Count; i++)
        //            {
        //                if (listView1.Items[i].SubItems[0].ToString() == Item.SubItems[0].ToString())
        //                {
        //                    listView1.Items[i].SubItems[1] = Item.SubItems[1];
        //                }
        //            }

                    //foreach (ListViewItem item in listView1.Items)
                    //{
                    //    if (product.ProductName == item.Text)
                    //    {
                    //        listView1.Items[index] = Item;
                    //    }
                    //    else
                    //    {
                    //        index += 1;
                    //    }
                    //}
        //        }
        //    }
        //}
            

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
    }
}
