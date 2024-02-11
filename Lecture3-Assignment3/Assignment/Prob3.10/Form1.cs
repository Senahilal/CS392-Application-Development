using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob3._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //To prevent termination of program if the value is deleted
            if (txt1.Text == "")
            {
                double z = 0;
                txt1.Text = "$" + z.ToString("F2");
            }
            double total = double.Parse(txt1.Text.Substring(1)) + 1.20;
            //double total =  + value;
            txt1.Text = "$" + total.ToString("F2");
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            //To prevent termination of program if the value is deleted
            if (txt1.Text == "")
            {
                int z = 0;
                txt1.Text = "$" + z.ToString("F2");
            }

        }

        private void boxOrange_Click(object sender, EventArgs e)
        {
            //To prevent termination of program if the value is deleted
            if (txt1.Text == "")
            {
                double z = 0;
                txt1.Text = "$" + z.ToString();
            }
            double total = double.Parse(txt1.Text.Substring(1)) + 1.60;
            //double total =  + value;
            txt1.Text = "$" + total.ToString("F2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            double z = 0.00;
            txt1.Text = "$" + z.ToString();
        }

        private void boxbanana_Click(object sender, EventArgs e)
        {
            //To prevent termination of program if the value is deleted
            if (txt1.Text == "")
            {
                double z = 0;
                txt1.Text = "$" + z.ToString();
            }
            double total = double.Parse(txt1.Text.Substring(1)) + 0.65;
            //double total =  + value;
            txt1.Text = "$" + total.ToString("F2");
        }

        private void boxApple_Click(object sender, EventArgs e)
        {
            //To prevent termination of program if the value is deleted
            if (txt1.Text == "")
            {
                double z = 0;
                txt1.Text = "$" + z.ToString();
            }
            double total = double.Parse(txt1.Text.Substring(1)) + 1.35;
            //double total =  + value;
            txt1.Text = "$" + total.ToString("F2");
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
