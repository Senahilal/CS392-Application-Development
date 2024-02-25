using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prob7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Answer Key
            char[] answers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };
            // Storing students' answers
            char[] studentAnswers = new char[20];
            char[] student2Answers = new char[20]; // For the second student

            // Read students' answers from files
            string filePath1 = "studentAnswers.txt"; // First student's answers
            string filePath2 = "student2Answers.txt"; // Second student's answers

            Console.WriteLine("Grading first student...");
            Grading(studentAnswers, answers, filePath1);

            Console.WriteLine("\nGrading second student...");
            Grading(student2Answers, answers, filePath2);

            Console.ReadLine(); 
        }

        static void Grading(char[] studentAnswers, char[] answerKey, string filePath)
        {
            if (ReadAnswersFromFile(studentAnswers, filePath))
            {
                // Grading the exam
                int correctCount = 0;
                int[] incorrectQuestions = new int[20];
                int incorrectIndex = 0;

                for (int i = 0; i < 20; i++)
                {
                    if (studentAnswers[i] == answerKey[i])
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectQuestions[incorrectIndex] = i + 1; // Store question numbers starting from 1
                        incorrectIndex++; 
                    }
                }

                // Display the results
                if (correctCount >=15)
                {
                    Console.WriteLine($"Student passed the test with a score of {correctCount}/20");
                }
                else
                {
                    Console.WriteLine($"Student failed the test!");
                }
                    
                Console.WriteLine($"Total Correct: {correctCount}, Total Incorrect: {20 - correctCount}");

                if ((20 - correctCount) > 0)
                {
                    Console.Write("Incorrectly answered questions: ");
                    for (int i = 0; i < incorrectIndex; i++)
                    {
                        Console.Write($"{incorrectQuestions[i]} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Failed to read the student's answer file");
            }
        }
        static bool ReadAnswersFromFile(char[] answers, string filePath)
        {
            try
            {
                int index = 0;
                foreach (string line in File.ReadLines(filePath))
                {
                    // Checking if the line is empty or consists only of whitespace
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        answers[index] = 'X'; // Assigning a default value that indicates an incorrect answer
                    }
                    else if (index < answers.Length)
                    {
                        answers[index] = line[0]; // Assuming each line has a single character followed by a newline
                    }
                    index++;
                }
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred reading the file: {e.Message}");
                return false;
            }
        }
    }
}
