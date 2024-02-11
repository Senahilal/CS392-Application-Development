using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob3._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRA_TextChanged(object sender, EventArgs e)
        {
        
      
        }

        private void txtRB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRT_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, c = 0;
                int.TryParse(txtRA.Text, out a);
                int.TryParse(txtRB.Text, out b);
                int.TryParse(txtRC.Text, out c);
                int result = a + b + c;
                txtRT.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numeric values only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("One of the numbers is too big or too small. Please enter a smaller number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtTA_TextChanged(object sender, EventArgs e)
        {
            
            if (txtTA.Text != "")
            {
                int a = int.Parse(txtTA.Text);
                int result = 15 * a;
                txtRA.Text = result.ToString();
            }
            
        }

        private void txtTB_TextChanged(object sender, EventArgs e)
        {
            ////To prevent termination of program if the value is deleted
            //if (txtTB.Text == "")
            //{
            //    int z = 0;
            //    txtTB.Text = z.ToString();
            //}
            //int b = int.Parse(txtTB.Text);
            //int result = 12 * b;
            //txtRB.Text = result.ToString();

            if (txtTB.Text != "")
            {
                int a = int.Parse(txtTB.Text);
                int result = 12 * a;
                txtRB.Text = result.ToString();
            }

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text != "")
            {
                int a = int.Parse(txtTC.Text);
                int result = 9 * a;
                txtRC.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing the text boxes by setting their contents to an empty string
            txtTA.Text = "";
            txtTB.Text = "";
            txtTC.Text = "";
            txtRT.Text = "";
            txtRA.Text = "";
            txtRB.Text = "";
            txtRC.Text = "";
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Canceling the keypress event
            }
        }

        private void txtTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Canceling the keypress event
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Canceling the keypress event
            }

        }
    }
}
