using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassasysteem
{
    public partial class Form1 : Form
    {
        private List<Product> _products= new List<Product>();
        private double endPrice = 0.00;
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
            foreach (Product product in _products)
            {
                if (productButton.Name == product.ProductName)
                {
                    if (product.Amount == 0)
                    {
                        product.Amount = 1;
                        String[] items = { product.ProductName, product.Amount.ToString(), product.Price.ToString() };
                        ListViewItem productitem = new ListViewItem(items);
                        listView1.Items.Add(productitem);
                    }
                    else
                    {
                        product.Amount += 1;
                        String[] items = { product.ProductName, product.Amount.ToString(), product.Price.ToString() };
                        ListViewItem productitem = new ListViewItem(items);
                        int index = 0;
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (product.ProductName == item.Text)
                            {
                                listView1.Items[index] = productitem;
                            }
                            else
                            {
                                index += 1;
                            }
                        }
                    }
                    
                    foreach (ListViewItem item in listView1.Items)
                    {
                       
                    }
                    
                    //productitem.SubItems.Add(product.ProductName);
                    //productitem.SubItems[0]. = product.ProductName;
                    
                   
                    //productitem.SubItems.Add(product.Price);


                    //OrderListBox.Items.Add($"{product.ProductName} \t€{product.Price},-");
                    //if (productButton.Name.Length <= 7)
                    //{
                    //    ActiveOrder.Items.Add($"{product.ProductName}, "%-20s", € {product.Price},-");
                    //}
                    //else if (productButton.Name.Length >= 13)
                    //{
                    //    ActiveOrder.Items.Add($"{product.ProductName}, \t\t\t\t € {product.Price},-", 20);
                    //}
                    //else
                    //{
                    //    ActiveOrder.Items.Add($"{product.ProductName}, \t\t\t\t\t € {product.Price},-");
                    //}
                    //endPrice += product.Price;
                }
            }
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
    }
}
