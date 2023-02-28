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

        public Cashregister()
        {
            InitializeComponent();
            LoadFromFile();
            panelInitializer();
            this.Hide();
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

        //private void btnRemove_Click(object sender, EventArgs e)
        //{

        //    Product selectedProduct = lstReceipt.SelectedItem as Product;
        //    if (selectedProduct != null)
        //    {
        //        TotalAmount -= selectedProduct.Price;
        //        lstReceipt.Items.Remove(lstReceipt.SelectedItem);
        //    }


        //}

        private void DelProdButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            if (selectedItem != null)
            {
                if (Int32.Parse(selectedItem.SubItems[1].Text) == 0)
                {
                    listView1.Items.Remove(selectedItem);
                }
                else if (Int32.Parse(selectedItem.SubItems[1].Text) > 0)
                {
                    
                    Product product = _products.Find(p => p.ProductName == selectedItem.SubItems[0].Text);
                    int Amount = Int32.Parse(selectedItem.SubItems[1].Text);
                    Receipt.TotalPrice = Receipt.TotalPrice - product.Price;

                    selectedItem.SubItems[1].Text = (Int32.Parse(selectedItem.SubItems[1].Text) - 1).ToString();
                    selectedItem.SubItems[2].Text = String.Format("{0:€ 0.00}", (Int32.Parse(selectedItem.SubItems[1].Text) * product.Price));
                    PriceTotal.Text = String.Format("{0:€ 0.00}", Receipt.TotalPrice);

                    Receipt.DelItem(product);

                    if (Int32.Parse(selectedItem.SubItems[1].Text) == 0)
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
