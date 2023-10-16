// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // Console.Write("[");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже

        int[,] matrix = new int[n, m];
        Random rnd = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(1, 10) + k;
            }
        }
        return matrix;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] findNumber = { rowPosition, columnPosition };
        for (int i = 0; rowPosition < matrix.GetLength(0); i++)
        {
            for (int j = 0; columnPosition < matrix.GetLength(1); j++)
            {
                findNumber[i] = rowPosition;
                findNumber[i + 1] = columnPosition;
            }
        }
        return findNumber;
    }


    public static void PrintCheckIfError(int[] results, int x, int y)
    {
        // Введите свое решение ниже
        if (results.GetLength(0) < x || results.GetLength(1) < y)
        {
            Console.WriteLine("There is no such index");
        }
        else
        {
            Console.WriteLine($"The number in [{x}, {y}]");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
            x = 2;
            y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        Console.WriteLine();
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}