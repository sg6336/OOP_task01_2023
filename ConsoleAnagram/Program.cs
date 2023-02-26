using System.Resources;
using LibraryAnagram;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using ConsoleAnagram.Resources;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine(Messages.Greeting);

            Anagram obj = new Anagram();
            do
            {
                Console.WriteLine($"\n{Messages.InputText}");
                string str = Console.ReadLine();
                str = obj.Reverse(str);
                Console.WriteLine($"\n{Messages.Result}");
                Console.WriteLine($"{str}");
                Console.WriteLine($"\n{Messages.AskToContinue}");
                Console.WriteLine($"Yes: Press Enter");
                Console.WriteLine($"No: Press any Key");
            } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }

    }
}

