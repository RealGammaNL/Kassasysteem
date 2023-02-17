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
        }

        private void CategoryButton_1(object sender, EventArgs e)
        {
            HidePanels();
            PanelCategory_1.Visible = true;
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HidePanels()
        {
            PanelCategory_1.Visible = false;
        }

        private void PanelCategory_1_Paint(object sender, PaintEventArgs e)
        {
            PanelCategory_1.Visible = true;
        }
    }
}
