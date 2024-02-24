using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);
            int consonantCount = CountConsonants(input);

            Console.WriteLine($"Number of vowels: {vowelCount}");
            Console.WriteLine($"Number of consonants: {consonantCount}");
            Console.ReadLine();
        }

        static int CountVowels(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (IsVowel(c))
                    count++;
            }
            return count;
        }

        static int CountConsonants(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c) && !IsVowel(c))
                    count++;
            }
            return count;
        }

        static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
