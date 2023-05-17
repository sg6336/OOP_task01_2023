using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть рядок: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string reversed = new string(word.Where(char.IsLetter).Reverse().ToArray());
            string result = "";
            int j = 0;
            foreach (char c in word)
            {
                if (!char.IsLetter(c))
                {
                    result += c;
                }
                else
                {
                    result += reversed[j];
                    j++;
                }
            }
            words[i] = result;
        }
        Console.WriteLine("Результат: " + string.Join(" ", words));
    }
}
