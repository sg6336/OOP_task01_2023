using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter strings: ");
            string line = Console.ReadLine();
            char[] delimiterChars = { ' ' };
            string[] arr = line.Split(delimiterChars);

            foreach (var word in arr)
            {
                System.Console.Write(reverse(word) + " ");
            }


            Console.ReadLine();
        }

        private static string reverse(string str)
        {
            char[] chars = str.ToCharArray();
            int firstChar = 0;
            int lastChar = str.Length - 1;
            int count = 0;
            while (count != str.Length / 2)
            {
                if (Char.IsLetter(chars[firstChar]) && Char.IsLetter(chars[lastChar]))
                {
                    char tmp = chars[firstChar];
                    chars[firstChar] = chars[lastChar];
                    chars[lastChar] = tmp;
                    lastChar--;
                    firstChar++;
                }
                else if (Char.IsLetter(chars[firstChar]) && !Char.IsLetter(chars[lastChar]))
                {
                    lastChar--;
                    char tmp = chars[firstChar];
                    chars[firstChar] = chars[lastChar];
                    chars[lastChar] = tmp; lastChar--;
                    firstChar++;
                }
                else if (!Char.IsLetter(chars[firstChar]) && Char.IsLetter(chars[lastChar]))
                {
                    firstChar++;
                    char tmp = chars[firstChar];
                    chars[firstChar] = chars[lastChar];
                    chars[lastChar] = tmp; lastChar--;
                    firstChar++;
                }
                count++;
            }

            str = new string(chars);
            return str;
        }
    }
}
