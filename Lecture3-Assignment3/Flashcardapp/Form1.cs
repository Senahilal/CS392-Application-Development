using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcardapp
{
    public partial class Form1 : Form
    {
        private int question_number;    // Which question the user is on
        private int questions_correct;  // How many questions the user has gotten correct
        private int question_attempts;  // How many attempts the user has made to answer the current question
        private int question_answer;    // The answer to the current question
        private Random generator;

        public Form1()
        {
            InitializeComponent();
            generator = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start with addition
            add_sub.SelectedItem = "Addition";
            new_problem();
        }

        // Change from addition/subtraction
        private void add_sub_dropdown_change(object sender, EventArgs e)
        {
            // Set the operator
            if (add_sub.SelectedItem.ToString() == "Addition")
            {
                num_operator.Text = "+";
            }
            else
            {
                num_operator.Text = "-";
            }
            // Clear out the toast text
            toast.Text = "";
            // Reset counters
            question_number = 0;
            questions_correct = 0;
            progress_bar.Value = 0;
            // Generate a new problem
            new_problem();
        }

        private void new_problem()
        {
            // Keep track of question count/attempts
            question_number++;
            question_attempts = 0;

            // Generate 2 random numbers
            var num1 = generator.Next(0, 10);
            var num2 = generator.Next(0, 10);


            // For addition numbers can be in any order
            if (add_sub.SelectedItem.ToString() == "Addition")
            {
                question_answer = num1 + num2;
                num_top.Text = num1.ToString();
                num_bottom.Text = num2.ToString();
            }
            // For subtraction, ensure higher number is on top
            else
            {
                var top = Math.Max(num1, num2);
                var bottom = Math.Min(num1, num2);

                question_answer = top - bottom;
                num_top.Text = top.ToString();
                num_bottom.Text = bottom.ToString();
            }
            // Clear out previous answer
            user_input.Text = "";
            // Return input focus to text box so the user doesn't need to click it again
            user_input.Focus();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            // If the user has not selected a problem type, do nothing
            if(add_sub.SelectedItem == null)
            {
                return;
            }

            // Check if the answer is correct
            if(user_input.Text == question_answer.ToString())
            {
                toast.Text = "Correct!";
                questions_correct++;
            }
            else
            {
                // Allow 3 attempts to answer each question before moving on
                if (question_attempts < 2)
                {
                    toast.Text = "Incorrect, try again.";
                    question_attempts++;
                    return;
                }
                toast.Text = "Let's try something different.";
            }

            // Move the progress bar forward between questions
            progress_bar.Increment(10);

            // Show the score after answering 10 questions
            if (question_number >= 10)
            {
                show_score();
            }
            else
            {
                new_problem();
            }
        }

        private void show_score()
        {
            // Pop up a box with the score
            MessageBox.Show("Your Score is " + questions_correct.ToString() + " out of 10", "Score");

            // Request the user to select a problem type to start the game over
            toast.Text = "Please select a problem type from the dropdown menu";
            add_sub.Text = "Select a problem type";
        }

    }
}
