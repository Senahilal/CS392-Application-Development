using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_headsortails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Hide();
            pictureBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
        }
    }
}
