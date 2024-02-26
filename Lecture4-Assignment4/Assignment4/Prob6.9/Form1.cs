namespace _09_Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        enum GameChoice
        {
            None = 0,
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }

        private GameChoice computerChoice;
        private GameChoice playerChoice;

        public Form1()
        {
            InitializeComponent();
        }

        private GameChoice GetPlayerChoice()
        {
            if (RadioButton1.Checked) return GameChoice.Rock;
            if (RadioButton2.Checked) return GameChoice.Paper;
            if (RadioButton3.Checked) return GameChoice.Scissors;
            return GameChoice.None;
        }

        private string GetChoiceText(GameChoice choice)
        {
            switch (choice)
            {
                case GameChoice.Rock: return "Rock";
                case GameChoice.Paper: return "Paper";
                case GameChoice.Scissors: return "Scissors";
                default: return "None";
            }
        }
        private void DisplayChoices()
        {
            playerChoiceLabel.Text = GetChoiceText(playerChoice);
            computerChoiceLabel.Text = GetChoiceText(computerChoice);
        }

        private void GenerateComputerChoice()
        {
            var rand = new Random();
            computerChoice = (GameChoice)rand.Next(1, 4);
        }


        private void ResetGame()
        {
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            playerChoiceLabel.Text = "";
            computerChoiceLabel.Text = "";
            GenerateComputerChoice();
        }

        private void DisplayWinner()
        {
            string resultsMessage = DetermineOutcome();
            MessageBox.Show($"{resultsMessage}\n\nLet's play again!");
            ResetGame();
        }

        private string DetermineOutcome()
        {
            if (playerChoice == computerChoice)
                return "It's a tie!";

            bool isPlayerWinner = (playerChoice == GameChoice.Rock && computerChoice == GameChoice.Scissors) ||
                                  (playerChoice == GameChoice.Paper && computerChoice == GameChoice.Rock) ||
                                  (playerChoice == GameChoice.Scissors && computerChoice == GameChoice.Paper);

            if (isPlayerWinner)
                return $"You Win! {GetChoiceText(playerChoice)} beats {GetChoiceText(computerChoice)}.";
            else
                return $"Computer Wins! {GetChoiceText(computerChoice)} beats {GetChoiceText(playerChoice)}.";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playerChoice = GetPlayerChoice();
            DisplayChoices();
            DisplayWinner();
        }

        private void playerChoiceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}