using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter the string: ");
        string inputSentence = Console.ReadLine();
        string result = ReverseWords(inputSentence);
        Console.WriteLine("Result: " + result);
    }

    static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        StringBuilder reversedSentence = new StringBuilder();

        foreach (string word in words)
        {

            string prefix = "";
            string suffix = "";
            string currentWord = word;

            while (currentWord.Length > 0 && !Char.IsLetter(currentWord[0]))
            {
                prefix += currentWord[0];
                currentWord = currentWord.Substring(1);
            }
            while (currentWord.Length > 0 && !Char.IsLetter(currentWord[currentWord.Length - 1]))
            {
                suffix = currentWord[currentWord.Length - 1] + suffix;
                currentWord = currentWord.Substring(0, currentWord.Length - 1);
            }


            if (currentWord.Length > 1)
            {
                char[] characters = currentWord.ToCharArray();
                Array.Reverse(characters);
                currentWord = new string(characters);
            }


            reversedSentence.Append(prefix + currentWord + suffix + " ");
        }

        return reversedSentence.ToString().Trim();
    }
}
