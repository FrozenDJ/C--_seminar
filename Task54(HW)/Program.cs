// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки 
// двумерного массива.

using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}" + "\t");
            }
            Console.WriteLine();
        }
    }


    public static void SortRowsDescending(int[,] matrix)
    {
        // Введите свое решение ниже
        // for (int j = 1; j < matrix.GetLength(1); j++)
        // {
        //     for (int i = 0; i < matrix.GetLength(0); i++)
        //     {
        //         int temp = matrix[i, 0];
        //         if (matrix[i, 0] > matrix[i, j]) j++;
        //         else
        //         {
        //             matrix[i, 0] = matrix[matrix.GetLength(0) - 1, j];
        //             matrix[matrix.GetLength(0) - 1, j] = temp;
        //         }   
        //     }
        // }
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount - 1; j++)
            {
                for (int k = j + 1; k < colCount; k++)
                {
                    if (matrix[i, k] > matrix[i, j])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }

    }
    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {5, 2, 9},
                {8, 1, 4},
                {6, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}