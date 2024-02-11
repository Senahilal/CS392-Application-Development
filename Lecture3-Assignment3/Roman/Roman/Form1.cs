namespace Roman
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

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtN.Text);

                if (number < 1 || number > 10)
                {
                    throw new ArgumentOutOfRangeException("Number must be between 1 and 10");
                }

                string[] romanNumerals = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
                txtR.Text = romanNumerals[number];
            }
            catch (FormatException)
            {
                txtR.Text = "";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                txtN.Text = "";
            }
        }
    }
}
