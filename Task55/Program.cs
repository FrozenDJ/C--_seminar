// Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int min, int max, int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void RepaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)           // i=1; i < matrix.GetLength(0);
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)       // j=0; j<i;
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] result = CreateMatrixRndInt(1, 10, 4, 4);
PrintMatrix(result);
Console.WriteLine();
if (result.GetLength(0) != result.GetLength(1))
{
    Console.WriteLine("It's impossible to replace rows with columns");
    return;
}
RepaceRowsColumns(result);
PrintMatrix(result);