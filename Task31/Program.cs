// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
// элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int min, int max, int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int[] array = CreateArrayRndInt(-9, 9, 12);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

// int[] GetSumPositiveNegativeElement(int[] arr)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sumPositive += arr[i];
//         else sumNegative += arr[i];
//     }
//     return new int[] { sumNegative, sumPositive };
// }

int GetSumPositiveElement(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElement(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}


Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
// int[] sumPositiveNegativeElement = GetSumPositiveNegativeElement(array);
// Console.WriteLine($"Sum negative elements {sumPositiveNegativeElement[0]}");
// Console.WriteLine($"Sum positive elements {sumPositiveNegativeElement[1]}");

int sumPositiveElement = GetSumPositiveElement(array);
int sumNegativeElement = GetSumNegativeElement(array);
Console.WriteLine($"Sum positive elements {sumPositiveElement}");
Console.WriteLine($"Sum negative elements {sumNegativeElement}");
