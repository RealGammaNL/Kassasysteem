using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassasysteem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl_1.ItemSize = new Size(0, 1);
            tabControl_1.SizeMode = TabSizeMode.Fixed;
        }

        private void InitialiseButtons()
        {
            
        }
        private void InitialiseCategories()
        {


        }

        private void CatagoryButton_1_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_1;
        }

        private void CatagoryButton_2_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_2;
        }

        private void CatagoryButton_3_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_3;
        }

        private void CatagoryButton_4_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_4;
        }

        private void CatagoryButton_5_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_5;
        }

        private void CatagoryButton_6_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_6;
        }

        private void CatagoryButton_7_Click(object sender, EventArgs e)
        {
            tabControl_1.SelectedTab = Category_7;
        }
    }
}
