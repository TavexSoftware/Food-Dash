using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Dash
{
    public partial class splashscreen : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );


        public splashscreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Prograssbar1.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                Prograssbar1.Value += 1;
                Prograssbar1.Text = Prograssbar1.Value.ToString() + "%";

                if (Prograssbar1.Value == 100)
                {
                    timer1.Enabled = false;
                    loginsignup se_form = new loginsignup();
                    se_form.Show();
                    this.Hide();
                }
            }
        }

        private void splashscreen_Load(object sender, EventArgs e)
        {

        }

        private void Prograssbar1_Click(object sender, EventArgs e)
        {

        }
    }
}