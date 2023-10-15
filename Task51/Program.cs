// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int min, int max, int rows, int columns)
{
    //                         0    1
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

int SumDiagonal(int[,] arr)
{
    int size = arr.GetLength(1);
    if (arr.GetLength(0) < arr.GetLength(1)) size = arr.GetLength(0);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine("]");
    }
}

int[,] result = CreateMatrixRndInt(1, 10, 4, 6);
int sumDiagonal = SumDiagonal(result);
PrintMatrix(result);
Console.WriteLine();
Console.WriteLine($"Diagonal sum = {sumDiagonal}");