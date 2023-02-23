using ConsoleAnagram.Resources;
using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible= true;
            Console.WriteLine(Messages.Greetings);
            ConsoleKeyInfo Button;

            do
            {
                var obj = new Anagram();
                Console.WriteLine();
                Console.WriteLine(Messages.Action);
                Console.WriteLine();

                string input = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine(Messages.Result + obj.Reverse(input));
                Console.WriteLine();
                Console.WriteLine(Messages.Last_Action);

                Button = Console.ReadKey();
                if (Button.Key == ConsoleKey.Spacebar)
                {
                    Environment.Exit(0);
                }
            } while (Button.Key == ConsoleKey.Enter);
        }
    }
}   