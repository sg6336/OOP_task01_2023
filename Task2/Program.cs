using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of matrix rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of matrix columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = GenerateMatrix(rows, columns);

        Console.WriteLine("Generated Matrix:");
        PrintMatrix(matrix);

        int trace = CalculateTrace(matrix);
        Console.WriteLine("Matrix trace: " + trace);

        Console.WriteLine("Elements in a snail shell:");
        PrintSpiralElements(matrix);
    }

    static int[,] GenerateMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(101);
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.Write(matrix[i, j] + " ");

                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }

    static int CalculateTrace(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int trace = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == j)
                {
                    trace += matrix[i, j];
                }
            }
        }

        return trace;
    }

    static void PrintSpiralElements(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int startRow = 0;
        int endRow = rows - 1;
        int startColumn = 0;
        int endColumn = columns - 1;

        while (startRow <= endRow && startColumn <= endColumn)
        {
            for (int i = startColumn; i <= endColumn; i++)
            {
                Console.Write(matrix[startRow, i] + " ");
            }
            startRow++;

            for (int i = startRow; i <= endRow; i++)
            {
                Console.Write(matrix[i, endColumn] + " ");
            }
            endColumn--;

            if (startRow <= endRow)
            {
                for (int i = endColumn; i >= startColumn; i--)
                {
                    Console.Write(matrix[endRow, i] + " ");
                }
                endRow--;
            }

            if (startColumn <= endColumn)
            {
                for (int i = endRow; i >= startRow; i--)
                {
                    Console.Write(matrix[i, startColumn] + " ");
                }
                startColumn++;
            }
        }

        Console.WriteLine();
    }
}
