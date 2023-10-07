// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] RandomArray(double min, double max, int length)
{
    double[] arr = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.NextDouble() * 100;
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

double GetDifferenceMaxMinNumber(double[] arr)
{
    double max = arr[0];
    double min = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else
        {
            if (arr[i] < min) min = arr[i];
        }
    }
    double dif = max - min;
    return dif;
}

double[] array = RandomArray(0, 100, 6);
double result = GetDifferenceMaxMinNumber(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine($" -> {result}");