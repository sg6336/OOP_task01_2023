using ConsoleAnagram.Resources;
using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");

            string input = Console.ReadLine();

            string[] words = input.Split(' ');                                 // divide string into words
            string reversed = string.Join(" ", words.Select(Anagram.Reverse)); // reverse every word and join to one string
            
            Console.WriteLine("Reversed string: " + reversed);

        }
    }
}