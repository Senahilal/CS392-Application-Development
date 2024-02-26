namespace _06_Present_Value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The PresentValue method returns the value you need to deposit today in order
        // to have a specified value at some point in the future. The method accepts the
        // desired future value, the annual interest rate, and the number of years the
        // money will be left to accumulate interest.
        private decimal PresentValue(decimal futureValue, decimal interestRate, int years)
        {
            return (decimal)((double)futureValue / Math.Pow((1 + (double)interestRate), years));
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal futureValue;
            decimal interestRate;
            int years;

            // Get the future value.
            if (decimal.TryParse(futureValueTextBox.Text, out futureValue))
            {
                // Get the interest rate.
                if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
                {
                    // Get the number of years.
                    if (int.TryParse(yearsTextBox.Text, out years))
                    {
                        // Move the decimal point in the interest rate.
                        interestRate /= 100m;

                        // Get the present value.
                        decimal presentValue = PresentValue(futureValue, interestRate, years);

                        // Display the result.
                        presentValueLabel.Text = presentValue.ToString("c");
                    }
                    else
                    {
                        // Prompt the user to reenter the number of years.
                        MessageBox.Show("Enter a valid value for the years.");
                    }
                }
                else
                {
                    // Prompt the user to reenter the interest rate.
                    MessageBox.Show("Enter a valid value for the interest rate.");
                }
            }
            else
            {
                // Prompt the user to reenter the future value.
                MessageBox.Show("Enter a valid value for the desired future value.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes.
            futureValueTextBox.Clear();
            interestRateTextBox.Clear();
            yearsTextBox.Clear();

            // Clear the previous results.
            presentValueLabel.Text = "";

            // Reset the focus.
            futureValueTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}