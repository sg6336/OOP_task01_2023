using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task01_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Vvod = Console.ReadLine();
            char[] chars = Vvod.ToCharArray();
            int index = chars.Length - 1;
            for (int i = 0; i < chars.Length / 2; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    while (!Char.IsLetter(chars[index]))
                    {
                        index--;
                    }
                    char temp = chars[i];
                    chars[i] = chars[index];
                    chars[index] = temp;
                    index--;
                }
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
            }
        }
    }
}