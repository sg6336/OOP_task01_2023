using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string output = ReverseWords(input);
            Console.WriteLine("Output: " + output);
            Console.ReadLine();
        }

        static string ReverseWords(string input)
        {
            char[] chars = input.ToCharArray();
            int start = 0;

            for (int i = 0; i <= chars.Length; i++)
            {
                if (i == chars.Length || char.IsWhiteSpace(chars[i]))
                {
                    int end = i - 1;
                    while (start < end)
                    {
                        if (!char.IsLetter(chars[start]))
                        {
                            start++;
                            continue;
                        }

                        if (!char.IsLetter(chars[end]))
                        {
                            end--;
                            continue;
                        }

                        char temp = chars[start];
                        chars[start] = chars[end];
                        chars[end] = temp;
                        start++;
                        end--;
                    }

                    start = i + 1;
                }
            }

            return new string(chars);
        }
    }
}
