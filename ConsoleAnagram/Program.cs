using ConsoleAnagram.Resources;
using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.Greetings);                                          
            
            var obj = new Anagram();

            string input = Console.ReadLine();
            
            Console.WriteLine("Reversed string: " + obj.Reverse(input));

        }
    }
}   