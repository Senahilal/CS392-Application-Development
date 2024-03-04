namespace _04_Joes_Automotive
{
    public partial class Form1 : Form
    {

        decimal oilChange = 5m;
        decimal lubeJob = 40;
        decimal radiatorFlush = 100;
        decimal transmissionFlush = 120;
        decimal inspection = 35;
        decimal mufflerReplacement = 150;
        decimal tireRotation = 25;
        decimal hourlyRate = 75;
        decimal taxRate = 0.07m;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalculateOilChangeCharges()
        {
            decimal charges = 0m;

            if (CheckBox1.Checked == true)
                charges = oilChange;
            return charges;
        }

        private decimal CalculateLubeCharges()
        {
            decimal charges = 0m;

            if (CheckBox2.Checked == true)
                charges = lubeJob;
            return charges;
        }

        private decimal CalculateRadiatorFlushCharges()
        {
            decimal charges = 0m;

            if (CheckBox3.Checked == true)
                charges = radiatorFlush;
            return charges;
        }

        private decimal CalculateTransmissionFlushCharges()
        {
            decimal charges = 0m;

            if (CheckBox4.Checked == true)
                charges = transmissionFlush;
            return charges;
        }

        private decimal CalculateInspectionCharges()
        {
            decimal charges = 0m;

            if (CheckBox5.Checked == true)
                charges = inspection;
            return charges;
        }

        private decimal CalculateMufflerCharges()
        {
            decimal charges = 0m;

            if (CheckBox6.Checked == true)
                charges = mufflerReplacement;
            return charges;
        }

        private decimal CalculateTireRotationCharges()
        {
            decimal charges = 0m;

            if (CheckBox7.Checked == true)
                charges = tireRotation;
            return charges;
        }

        private decimal CalculateParts()
        {
            decimal cost = 0m;

            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                if (decimal.TryParse(TextBox1.Text, out cost))
                {
                }
                else
                {
                    MessageBox.Show("Enter a valid value for parts.");
                }
            }

            return cost;
        }

        private decimal CalculateLaborCost()
        {
            double hours = 0.0;
            decimal cost = 0m;

            if (!string.IsNullOrEmpty(TextBox2.Text))
            {
                if (double.TryParse(TextBox2.Text, out hours))
                {
                    cost = (decimal)hours * hourlyRate;
                }
                else
                {
                    MessageBox.Show("Enter a valid value for labor hours.");
                }
            }

            return cost;
        }

        private decimal CalculateTax(decimal amount)
        {
            decimal tax = 0m;

            if (amount > 0)
            {
                tax = amount * taxRate;
            }
            return tax;
        }

        private decimal CalculateTotalCharges()
        {
            decimal total = CalculateOilChangeCharges() + CalculateLubeCharges() + CalculateRadiatorFlushCharges() +
                            CalculateTransmissionFlushCharges() + CalculateInspectionCharges() +
                            CalculateMufflerCharges() + CalculateTireRotationCharges() + CalculateParts() +
                            CalculateLaborCost() + CalculateTax(CalculateParts());
            return total;
        }

        private void ClearForm()
        {
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox6.Checked = false;
            CheckBox7.Checked = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            serviceAndLaborTotalLabel.Text = "";
            partsTotalLabel.Text = "";
            taxLabel.Text = "";
            totalFeesLabel.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal all = CalculateOilChangeCharges() + CalculateLubeCharges() + CalculateRadiatorFlushCharges() +
                                      CalculateTransmissionFlushCharges() + CalculateInspectionCharges() +
                                      CalculateMufflerCharges() + CalculateTireRotationCharges() + CalculateLaborCost();
            decimal partsall = CalculateParts();
            decimal tax = CalculateTax(partsall);
            decimal total = CalculateTotalCharges();

            serviceAndLaborTotalLabel.Text = all.ToString("c");
            partsTotalLabel.Text = partsall.ToString("c");
            taxLabel.Text = tax.ToString("c");
            totalFeesLabel.Text = total.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
