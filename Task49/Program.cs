// Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.
// Например, изначально массив     Новый массив будет выглядеть
// выглядел вот так:               вот так:
// 1 4 7 2                         1 4 7 2
// 5 9 2 3                         5 81 2 9
// 8 4 2 4                         8 4 2 4

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

void ReplaceСellsWithEvenIndexesOnSquares(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] result = CreateMatrixRndInt(1, 10, 5, 5);
PrintMatrix(result);
Console.WriteLine();
ReplaceСellsWithEvenIndexesOnSquares(result);
PrintMatrix(result);



