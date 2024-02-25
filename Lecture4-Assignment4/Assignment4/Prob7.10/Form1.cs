namespace Prob7._10
{
    public partial class Form1 : Form
    {
        private Random generator;
        private int moneyEntered;
        private int moneyWon;
        private System.Drawing.Bitmap[] fruits = [Properties.Resources.Apple, Properties.Resources.Banana, Properties.Resources.Cherries, Properties.Resources.Grapes, Properties.Resources.Lemon, Properties.Resources.Lime, Properties.Resources.Orange, Properties.Resources.Pear, Properties.Resources.Strawberry, Properties.Resources.Watermelon];
        public Form1()
        {
            InitializeComponent();
            generator = new Random();
            alert.Text = "";
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            int bet;
            if (userInput.Text.Length == 0 || !int.TryParse(userInput.Text, out bet))
            {
                return;
            }

            moneyEntered += bet;

            int one = generator.Next(0, fruits.Length);
            int two = generator.Next(0, fruits.Length);
            int three = generator.Next(0, fruits.Length);

            if (one == two && two == three)
            {
                int won = bet * 3;
                moneyWon += won;
                alert.Text = $"You won ${won:n0}";
            }
            else if (one == two || two == three || one == three)
            {
                int won = bet * 2;
                moneyWon += won;
                alert.Text = $"You won ${won:n0}";
            }
            else
            {
                alert.Text = "You won $0";
            }

            slot1.Image = fruits[one];
            slot2.Image = fruits[two];
            slot3.Image = fruits[three];
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Money Entered: ${moneyEntered:n0}\n\nMoney Won: ${moneyWon:n0}", "Score");
            this.Close();
        }
    }
}
