using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Dash
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            new Cart().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately This Feature Doesn't Work Yet :(. Click the cart button to continue with the demo.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately This Feature Doesn't Work Yet :(. Click the cart button to continue with the demo.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately This Feature Doesn't Work Yet :(. Click the cart button to continue with the demo.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately This Feature Doesn't Work Yet :(. Click the cart button to continue with the demo.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately This Feature Doesn't Work Yet :(. Click the cart button to continue with the demo.");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You already are here!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops! This Doesn't Work Right Now :(");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
