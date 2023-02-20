using System.Resources;
using LibraryAnagram;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;


namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Hello!");

            Anagram obj = new Anagram();
            do
            {
                Console.WriteLine("\nEnter Your Text:");
                string str = Console.ReadLine();
                str = obj.Reverse(str);
                Console.WriteLine($"\nResult:");
                Console.WriteLine($"{str}");
                Console.WriteLine($"\nContinue?");
                Console.WriteLine($"Yes: Press Enter");
                Console.WriteLine($"No: Press any Key");
            } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }
    }
}
