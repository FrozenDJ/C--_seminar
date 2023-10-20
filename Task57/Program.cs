// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько 
// раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintFrequencyDictionary(int[] arr)
{
    int count = 1;
    int currentNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (currentNum == arr[i]) count++;
        else
        {
            Console.WriteLine($"{currentNum} -> {count}");
            currentNum = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{currentNum} -> {count}");
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[,] result = CreateMatrixRndInt(1, 10, 4, 4);
PrintMatrix(result);
Console.WriteLine();
int[] arrayNums = MatrixToArray(result);
Array.Sort(arrayNums);
PrintArray(arrayNums);
Console.WriteLine();
PrintFrequencyDictionary(arrayNums);