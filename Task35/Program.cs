// Задайте одномерный массив из 123 случайных чисел.Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// В своём решении сделайте для 123

int[] RandomArray(int min, int max, int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int CountInInterval(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max)
        {
        count++;
    }
}
return count;
}

int[] array = RandomArray(1, 150, 12);
int countPositions = CountInInterval(array, 10, 99);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write($" -> {countPositions}");