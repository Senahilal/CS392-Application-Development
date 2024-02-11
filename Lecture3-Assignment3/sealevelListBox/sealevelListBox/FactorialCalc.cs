using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sealevelListBox
{
    public partial class FactorialCalc : Form
    {
        public FactorialCalc()
        {
            InitializeComponent();
        }

        private void PopulateListBox()
        {
            const double annualRise = 1.5; // Ocean's level rising rate per year in millimeters
            for (int year = 1; year <= 10; year++)
            {
                double totalRise = annualRise * year;
                listBox1.Items.Add($"Year {year}: {totalRise} mm");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }
    }
}
