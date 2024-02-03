using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Joke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "...to access the parallel universe where the chicken's algorithm was optimized for crossing efficiency!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Why did the CS major cross the road?";
        }
    }
}
