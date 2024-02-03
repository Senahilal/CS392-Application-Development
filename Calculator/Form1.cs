using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operand1 = "";
        string operand2 = "";
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtMain.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtMain.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtMain.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtMain.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtMain.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtMain.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtMain.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtMain.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtMain.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtMain.Text += 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMain.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = txtMain.Text;
            operation = '+';
            txtMain.Text = "";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            operand1 = txtMain.Text;
            operation = '*';
            txtMain.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = txtMain.Text;
            operation = '-';
            txtMain.Text = "";
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            operand1 = txtMain.Text;
            operation = '/';
            txtMain.Text = "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtMain.Text += ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = txtMain.Text;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result=num1+num2;
                txtMain.Text=result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtMain.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtMain.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 == 0) {
                    txtMain.Text = "Div0";
                }
                else
                {
                    result = num1 / num2;
                    txtMain.Text = result.ToString();
                }
            }
        }
    }
}
