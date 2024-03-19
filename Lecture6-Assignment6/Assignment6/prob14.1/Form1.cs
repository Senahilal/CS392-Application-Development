using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace prob14._1
{
    public partial class Form1 : Form
    {
        public List<int> GetList()
        {
            // Path to the file
            string filePath = "random.txt";

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Initialize a list to hold the numbers
            List<int> numbers = new List<int>();

            // Parse the numbers and add them to the list
            foreach (string line in lines)
            {
                string[] tokens = line.Split(new char[] { ',', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string token in tokens)
                {
                    if (int.TryParse(token, out int number))
                    {
                        numbers.Add(number);
                    }
                }
            }

            return numbers;
        }
        
        public Form1()
        {
            InitializeComponent();

            List<int> numbers = new List<int>();
            numbers = GetList();

            foreach (int number in numbers)
            {
               listBox1.Items.Add(number);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<int> numbers = new List<int>();
            numbers = GetList();
            numbers.RemoveAll(n => n < 0);
            foreach (int number in numbers)
            {
                listBox2.Items.Add(number);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<int> numbers = new List<int>();
            numbers = GetList();
            List<int> filteredNumbers = numbers.FindAll(n => n >= 1 && n <= 10);
            foreach (int number in filteredNumbers)
            {
                listBox2.Items.Add(number);
            }
        }
    }
    
}
