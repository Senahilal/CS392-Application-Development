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
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txt1.Text);
                if (number >= 0) {
                    double res = CalculateFactorial(number);
                    lbl1.Text = $"Factorial {res}";
                    
                }
                else
                {
                    lbl1.Text = "Please eneter a non negative integer";
                }
            }
            catch (FormatException ex) 
                {
                    lbl1.Text = "Please eneter a non negative integer";
                }
            catch (OverflowException ex)
                {
                    lbl1.Text = "Please eneter a non negative integer";
                }
            

            
        }

        private double CalculateFactorial(int number)
        {
            double result = 1;
            for (double i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
