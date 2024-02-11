using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbFrom.SelectedIndex = 1;
            lbTo.SelectedIndex = 1;
        }

        private void calculate()
        {
            try
            {
                string fromUnit = lbFrom.SelectedItem.ToString();
                string toUnit = lbTo.SelectedItem.ToString();
                if (string.IsNullOrEmpty(fromUnit) || string.IsNullOrEmpty(toUnit))
                {
                    throw new InvalidOperationException("Please select units for conversion.");
                }

                double result = double.Parse(txtBefore.Text);

                switch (fromUnit)
                {
                    case "Inches":
                        result *= 36;
                        break;
                    case "Feet":
                        result *= 12;
                        break;
                }

                switch (toUnit)
                {
                    case "Inches":
                        result /= 36;
                        break;
                    case "Feet":
                        result /= 12;
                        break;
                }

                txtAfter.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void txtBefore_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
