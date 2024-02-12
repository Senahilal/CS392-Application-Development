using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMI_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


            string health;

            if (int.Parse(textBox1.Text) > 15)
            {
                if (bmi < 18.5)
                {
                    health = "Underweight";
                }
                else if (bmi >= 25 && bmi < 25)
                {
                    health = "Healthy";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    health = "Overweight";
                }
                else
                {
                    health = "Obese";
                }
            }
            else
            {
                if (comboBox1.Text == "Male")
                {
                    if (bmi < 14.2)
                    {
                        health = "Underweight";
                    }
                    else if (bmi >= 14.2 && bmi < 19.4)
                    {
                        health = "Healthy";
                    }
                    else if (bmi >= 19.4 && bmi < 22)
                    {
                        health = "Overweight";
                    }
                    else
                    {
                        health = "Obese";
                    }
                }
                else
                {
                    if (bmi < 14)
                    {
                        health = "Underweight";
                    }
                    else if (bmi >= 14 && bmi < 19.5)
                    {
                        health = "Healthy";
                    }
                    else if (bmi >= 19.5 && bmi < 22.5)
                    {
                        health = "Overweight";
                    }
                    else
                    {
                        health = "Obese";
                    }
                }
            }

            label6.Text = "Your BMI is " + bmi + " / " + health;
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
