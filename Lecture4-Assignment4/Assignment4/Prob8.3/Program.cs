using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        string modifiedString = CapitalizeFirstCharacter(inputString);

        Console.WriteLine("Modified String:");
        Console.WriteLine(modifiedString);

        Console.ReadLine(); // To keep the console window open
    }

    static string CapitalizeFirstCharacter(string input)
    {
        // Check if the input string is null or empty
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        // Split the input into sentences using '.', '?', and '!' as delimiters
        string[] sentences = input.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        // Capitalize the first character of each sentence
        for (int i = 0; i < sentences.Length; i++)
        {
            sentences[i] = sentences[i].Trim(); // Remove leading and trailing spaces
            if (!string.IsNullOrWhiteSpace(sentences[i]))
            {
                char punctuation = input[input.IndexOf(sentences[i]) + sentences[i].Length];
                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1) + punctuation;
            }
        }

        // Join the sentences back into a single string
        string result = string.Join(" ", sentences);

        return result;
    }
}