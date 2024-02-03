using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calc
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private double BMI_1(String F, String I, String P)
        {
            Double bmi, feet, inch, weight;
            inch = Convert.ToDouble(I);
            feet = Convert.ToDouble(F);
            weight = Convert.ToDouble(P);
            bmi = weight /(((feet * 12) + inch)* ((feet * 12) + inch)) * 703;
            return bmi;
        }

        private double BMI_2(String C, String K )
        {
            Double bmi, meter, weight;
            meter = Convert.ToDouble(C);
            meter = meter / 100;
            weight = Convert.ToDouble(K);
            bmi = weight /(meter*meter);
            return bmi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bmi;
            if (txt2.Visible)
            {
                
                bmi = BMI_1(txt1.Text, txt2.Text, txt3.Text);
                //txt4.Text = bmi.ToString();
            }
            else
            {
                
                bmi = BMI_2(txt1.Text, txt3.Text);
                //txt4.Text = bmi.ToString();
            }
            if (bmi < 18.5)
            {
                txt4.Text = "underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                txt4.Text = "healthy weight";
            }
            else if (bmi >=25.0 && bmi <= 29.9)
            {
                txt4.Text = "overweight";
            }
            else
            {
                txt4.Text = "obese";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt2.Visible = false;
            label2.Visible = false;
            lbl_feet.Text = "centimeter";
            label4.Text = "Kilogram";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt2.Visible = true;
            label2.Visible = true;
            lbl_feet.Text = "Feet";
            label4.Text = "Pounds";

        }
    }
}
