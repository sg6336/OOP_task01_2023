using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calculator!");

        Console.WriteLine("Select the mode:");
        Console.WriteLine("1. Console Application");
        Console.WriteLine("2. File Processing");

        Console.Write("Enter your choice (1 or 2): ");
        string modeChoice = Console.ReadLine();

        switch (modeChoice)
        {
            case "1":
                Console.WriteLine("You selected the Console Application mode.");
                RunConsoleMode();
                break;
            case "2":
                Console.WriteLine("You selected the File Processing mode.");
                RunFileProcessingMode();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting the program.");
                break;
        }

        Console.WriteLine("Thank you for using the Calculator. Goodbye!");
    }

    static void RunConsoleMode()
    {
        Console.WriteLine("Enter the expression to calculate (without brackets):");
        string expression = Console.ReadLine();

        try
        {
            double result = CalculateExpression(expression);
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static void RunFileProcessingMode()
    {
        Console.Write("Enter the path of the input file: ");
        string inputFile = Console.ReadLine();

        Console.Write("Enter the path of the output file: ");
        string outputFile = Console.ReadLine();

        try
        {
            List<string> lines = ReadFileLines(inputFile);
            List<string> results = new List<string>();

            foreach (string line in lines)
            {
                try
                {
                    string result = CalculateExpressionWithBrackets(line);
                    results.Add(line + " = " + result);
                }
                catch (Exception ex)
                {
                    results.Add(line + " = Exception. " + ex.Message);
                }
            }

            WriteResultsToFile(outputFile, results);
            Console.WriteLine("Calculation completed. Results written to the output file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }

    static double CalculateExpression(string expression)
    {
        expression = RemoveSpaces(expression);

        // Перевірка виразу
        if (!IsValidExpression(expression))
        {
            throw new Exception("Invalid expression.");
        }

        // Оцінка виразу на основі математичних пріоритетів
        double result = EvaluateExpression(expression);
        return result;
    }

    static string CalculateExpressionWithBrackets(string expression)
    {
        expression = RemoveSpaces(expression);

        // Перевірка виразу
        if (!IsValidExpressionWithBrackets(expression))
        {
            throw new Exception("Invalid expression.");
        }

        // Обчисліть вираз, рекурсивно обчислюючи вирази в дужках
        string result = EvaluateExpressionWithBrackets(expression);
        return result;
    }

    static double EvaluateExpression(string expression)
    {
        // Розбийте вираз на числа та оператори
        string[] numbers = Regex.Split(expression, @"[+\-*/]");

        // Розбийте вираз на оператори
        string[] operators = Regex.Split(expression, @"\d+");

        double result = double.Parse(numbers[0]);

        for (int i = 1; i < numbers.Length; i++)
        {
            double number = double.Parse(numbers[i]);
            string op = operators[i];

            switch (op)
            {
                case "+":
                    result += number;
                    break;
                case "-":
                    result -= number;
                    break;
                case "*":
                    result *= number;
                    break;
                case "/":
                    if (number == 0)
                    {
                        throw new Exception("Divide by zero error.");
                    }
                    result /= number;
                    break;
                default:
                    throw new Exception("Invalid operator.");
            }
        }

        return result;
    }

    static string EvaluateExpressionWithBrackets(string expression)
    {
        int openingBracketIndex = expression.IndexOf("(");

        while (openingBracketIndex != -1)
        {
            int closingBracketIndex = FindClosingBracketIndex(expression, openingBracketIndex);

            if (closingBracketIndex == -1)
            {
                throw new Exception("Closing bracket not found.");
            }

            string subExpression = expression.Substring(openingBracketIndex + 1, closingBracketIndex - openingBracketIndex - 1);
            double subResult = CalculateExpression(subExpression);

            expression = expression.Remove(openingBracketIndex, closingBracketIndex - openingBracketIndex + 1);
            expression = expression.Insert(openingBracketIndex, subResult.ToString());

            openingBracketIndex = expression.IndexOf("(");
        }

        // Оцініть кінцевий вираз без дужок
        double result = CalculateExpression(expression);
        return result.ToString();
    }

    static bool IsValidExpression(string expression)
    {
        //Використовуйте регулярний вираз, щоб перевірити, чи містить вираз лише дійсні символи
        return Regex.IsMatch(expression, @"^[\d+\-*/]+$");
    }

    static bool IsValidExpressionWithBrackets(string expression)
    {
        // Використовуйте регулярний вираз, щоб перевірити, чи містить вираз лише дійсні символи
        return Regex.IsMatch(expression, @"^[\d+\-*/()\s]+$");
    }

    static int FindClosingBracketIndex(string expression, int openingBracketIndex)
    {
        int bracketCount = 1;

        for (int i = openingBracketIndex + 1; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                bracketCount++;
            }
            else if (expression[i] == ')')
            {
                bracketCount--;

                if (bracketCount == 0)
                {
                    return i;
                }
            }
        }

        return -1;
    }

    static string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
    }

    static List<string> ReadFileLines(string filePath)
    {
        List<string> lines = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        return lines;
    }

    static void WriteResultsToFile(string filePath, List<string> results)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string result in results)
            {
                writer.WriteLine(result);
            }
        }
    }
}
