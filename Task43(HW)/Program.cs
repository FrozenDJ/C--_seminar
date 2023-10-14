// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * ((b2 - b1) / (k1 - k2)) + b1
// x = (b2 - b1) / (k1 - k2)


Console.Write("Write first coordinates of the first segment: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second coordinates of the first segment: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write first coordinates of the second segment: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second coordinates of the second segment: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if 

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
