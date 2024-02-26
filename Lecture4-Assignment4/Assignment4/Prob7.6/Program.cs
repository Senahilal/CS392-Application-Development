using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Path to the popular names file
            string filePath = "popular_names.txt";

            // Read all names into a List
            List<string> popularNamesList = new List<string>();

            string ans = "y";
            do
            {
                try
                {
                    // Opening the file
                    var inputFile = new StreamReader(filePath);

                    // Read the file's contents into a list.
                    while (!inputFile.EndOfStream)
                    {
                        popularNamesList.Add(inputFile.ReadLine());
                    }

                    // Close the file.
                    inputFile.Close();

                    Console.WriteLine("Enter a name:");
                    string userInput = Console.ReadLine().Trim();

                    // Check if the entered name is in the list
                    if (popularNamesList.Contains(userInput, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{userInput} is among the most popular names from 2000 through 2009.");
                    }
                    else
                    {
                        Console.WriteLine($"{userInput} is not among the most popular names from 2000 through 2009.");
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file was not found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                Console.WriteLine("Do you want to check another name? (Y/N)");
                ans = Console.ReadLine();

            } while (ans.ToUpper().Equals("Y"));



        }
    }
}
