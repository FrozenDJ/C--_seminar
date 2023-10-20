// Задайте двумерный массив из целых чисел. Напишите 
// программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива.


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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[] GetIndexesMinNumber(int[,] matrix)
{
    int rowMinNumber = 0;
    int columnMinNumber = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowMinNumber, columnMinNumber])
            {
                rowMinNumber = i;
                columnMinNumber = j;
            }
        }
    }
    return new int[] { rowMinNumber, columnMinNumber };
}

int[,] DeleteRowColumnMinNumber(int[,] matrix, int delRow, int delColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0, m = 0; i < newMatrix.GetLength(0); i++, m++)
    {
        if (i == delRow) m++;
        for (int j = 0, n = 0; j < newMatrix.GetLength(1); j++, n++)
        {
            if (j == delColumn) n++;
            newMatrix[i, j] = matrix[m, n];
        }
    }
    return newMatrix;
}

int[,] result = CreateMatrixRndInt(1, 10, 4, 4);
PrintMatrix(result);
Console.WriteLine();
int[] array = GetIndexesMinNumber(result);
// PrintMatrix(array); нужен метод печать одномерных массивов
Console.WriteLine();
int[,] resultMatrix = DeleteRowColumnMinNumber(result, array[0], array[1]);
PrintMatrix(resultMatrix);