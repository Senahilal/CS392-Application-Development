using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToF
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //If we want to enter negative value first, this allows us to enter (-) sign without converting
            if(txtC.Text=="-")
            {
                txtF.Text = "-";
            }
            //To prevent termination of program if the value is deleted
            else if (txtC.Text == "")
            {
                txtF.Text = "";
            }
            else
            {
                double F;
                F = ConvertCtoF(txtC.Text);
                txtF.Text = F.ToString();
            }
            
        }

        

        private double ConvertCtoF(String txtC)
        {
            double C, F;
            C = Convert.ToDouble(txtC);
            F = C * (9.0 / 5) + 32;
            return F;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            txtC.Text = trackBar1.Value.ToString();
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;
        private void txtC_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Allowing negative sign(Keys.Subtract or Keys.OemMinus)  only if it's the first character and no text is selected
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                if (txtC.SelectionStart != 0 || txtC.Text.Length != 0)
                {
                    // Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = true;
                }
                return; // Return here so that the rest of the checks are bypassed for minus key
            }

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

     
        }
    }
}
