using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "";
        private string hint = "";
        private StringBuilder displayWord;

        private int incorrectGuesses = 0;
        private int lettersGuessed = 0;
        private readonly int maxIncorrectGuesses = 6;

        public Form1()
        {
            InitializeComponent();
            GetRandomWordAndHint();
            UpdateDisplayWord();
            AssignLetterButtonClickEventHandlers();
        }

        private void AssignLetterButtonClickEventHandlers()
        {
            // Assuming your buttons are named buttonA, buttonB, ..., buttonZ
            for (int i = 0; i < 26; i++)
            {
                // Construct the button name
                string buttonName = "button" + i;
                // Find the button control by name
                Button btn = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    // Assign the event handler
                    btn.Click += Letter_Click;
                }
            }
        }

        private void panelHangman_Paint(object sender, PaintEventArgs e)
        {
            DrawHangman(e.Graphics);
        }

        private void DrawHangman(Graphics g)
        {
            // Adjust these values based on the size of your panel
            int baseLineY = panelHangman.Height - 20;
            int headCenterX = panelHangman.Width / 2;
            int headCenterY = 20;

            // Draw the gallows
            g.DrawLine(Pens.Black, headCenterX - 50, baseLineY, headCenterX + 50, baseLineY); // Base
            g.DrawLine(Pens.Black, headCenterX, baseLineY, headCenterX, baseLineY - 100); // Stand
            g.DrawLine(Pens.Black, headCenterX, baseLineY - 100, headCenterX - 20, baseLineY - 80); // Support

            if (incorrectGuesses > 0) // Head
                g.DrawEllipse(Pens.Black, headCenterX - 30, baseLineY - 78, 20, 20);
            if (incorrectGuesses > 1) // Body
                g.DrawLine(Pens.Black, headCenterX - 20, baseLineY - 58, headCenterX - 20, baseLineY - 28);
            if (incorrectGuesses > 2) // Left arm
                g.DrawLine(Pens.Black, headCenterX - 20, baseLineY - 53, headCenterX - 35, baseLineY - 43);
            if (incorrectGuesses > 3) // Right arm
                g.DrawLine(Pens.Black, headCenterX - 20, baseLineY - 53, headCenterX - 5, baseLineY - 43);
            if (incorrectGuesses > 4) // Left leg
                g.DrawLine(Pens.Black, headCenterX - 20, baseLineY - 28, headCenterX - 35, baseLineY - 13);
            if (incorrectGuesses > 5) // Right leg
                g.DrawLine(Pens.Black, headCenterX - 20, baseLineY - 28, headCenterX - 5, baseLineY - 13);
        }

        private void GetRandomWordAndHint()
        {
            // Connect to DB
            SqlConnection conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\Words.mdf;Integrated Security=True");
            conn.Open();
            
            // Get all the words and hints from the DB
            using (SqlCommand cmd = new SqlCommand("select Word,Hint FROM \"Table\"", conn))
            {
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    
                    // Pick a random word from the DB results
                    Random random = new Random();
                    DataRow selected = dt.Rows[random.Next(0, dt.Rows.Count)];
                    wordToGuess = selected["Word"].ToString().ToUpper();
                    hint = selected["Hint"].ToString();

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "SQL Error");
                }

            }
            conn.Close();

            TxtHint.Text = hint;
            // Initialize the display word
            displayWord = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                displayWord.Append('_');
            }
        }

        private void UpdateDisplayWord()
        {
            TxtDisplay.Text = "";
            foreach (char c in displayWord.ToString())
            {
                TxtDisplay.Text += c + " ";
            }
        }
        
        private void Letter_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                char guessedLetter = btn.Text[0];
                bool found = false;

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessedLetter)
                    {
                        displayWord[i] = guessedLetter;
                        found = true;
                    }
                }

                if (found)
                {
                    UpdateDisplayWord();
                    lettersGuessed++;
                    if (lettersGuessed == wordToGuess.Distinct().Count())
                    {
                        MessageBox.Show("You Win!");
                        Application.Exit();
                    }
                }
                else
                {
                    incorrectGuesses++;
                    panelHangman.Invalidate();
                    if (incorrectGuesses >= maxIncorrectGuesses)
                    {
                        // Handle game over (all guesses used)
                        MessageBox.Show("Game over! The correct word was: " + wordToGuess);
                        Application.Exit();
                    }
                }

                btn.Enabled = false;
            }
        }
    }
}
