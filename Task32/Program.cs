// Напишите программу по замене элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0) arr[i] *= -1;
    }
}


int[] array = RandomArray(-10, 10, 5);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");
InverseArray(array);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");