using System;

class Program
{
    static void Main()
    {
        // Ввод размеров матрицы
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        // Создание и заполнение матрицы случайными числами
        int[,] matrix = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(101); // Генерация случайного числа от 0 до 100
            }
        }

        // Вывод матрицы с выделением главной диагонали
        Console.WriteLine("Матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == j)
                    Console.ForegroundColor = ConsoleColor.Yellow; // Выделение главной диагонали цветом
                else
                    Console.ResetColor();

                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ResetColor();

        // Вычисление и вывод трассировки матрицы
        int trace = 0;
        for (int i = 0; i < Math.Min(rows, columns); i++)
        {
            trace += matrix[i, i];
        }

        Console.WriteLine("Трассировка матрицы: " + trace);

        // Вывод элементов матрицы в раковинном порядке
        Console.WriteLine("Элементы матрицы в раковинном порядке:");
        PrintMatrixElementsInSpiralOrder(matrix, rows, columns);
    }

    static void PrintMatrixElementsInSpiralOrder(int[,] matrix, int rows, int columns)
    {
        int topRow = 0;
        int bottomRow = rows - 1;
        int leftColumn = 0;
        int rightColumn = columns - 1;

        while (topRow <= bottomRow && leftColumn <= rightColumn)
        {
            // Вывод верхней строки
            for (int i = leftColumn; i <= rightColumn; i++)
            {
                Console.Write(matrix[topRow, i] + " ");
            }
            topRow++;

            // Вывод правого столбца
            for (int i = topRow; i <= bottomRow; i++)
            {
                Console.Write(matrix[i, rightColumn] + " ");
            }
            rightColumn--;

            // Вывод нижней строки
            if (topRow <= bottomRow)
            {
                for (int i = rightColumn; i >= leftColumn; i--)
                {
                    Console.Write(matrix[bottomRow, i] + " ");
                }
                bottomRow--;
            }

            // Вывод левого столбца
            if (leftColumn <= rightColumn)
            {
                for (int i = bottomRow; i >= topRow; i--)
                {
                    Console.Write(matrix[i, leftColumn] + " ");
                }
                leftColumn++;
            }
        }

        Console.WriteLine();
    }
}
