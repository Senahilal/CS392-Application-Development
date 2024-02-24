using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            char mostFrequentChar = FindMostFrequentCharacter(input);

            Console.WriteLine($"The most frequent character is: {mostFrequentChar}");
            Console.ReadLine();
        }

        static char FindMostFrequentCharacter(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            KeyValuePair<char, int> mostFrequent = charCount.OrderByDescending(kv => kv.Value).First();
            return mostFrequent.Key;
        }
    }
}
