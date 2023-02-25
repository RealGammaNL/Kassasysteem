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

        public Form1()
        {
            InitializeComponent();
            tabControl_1.ItemSize = new Size(0, 1);
            tabControl_1.SizeMode = TabSizeMode.Fixed;
        }

        private void LoadFromFile()
        {
            string json = System.IO.File.ReadAllText("Products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json);
        }
        private void InitialiseButtons()
        {
            
        }
        private void InitialiseCategories()
        {


        }

        private void CategoryButton_1_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_1;
        }

        private void CategoryButton_2_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_2;
        }

        private void CategoryButton_3_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_3;
        }

        private void CategoryButton_4_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_4;
        }

        private void CategoryButton_5_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_5;
        }

        private void CategoryButton_6_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_6;
        }

        private void CategoryButton_7_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_7;
        }

        private void ProductButton_C1_5_Click(object sender, EventArgs e)
        {

        }

        private void ProductButton_C1_10_Click(object sender, EventArgs e)
        {

        }
    }
}
