// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RandomArray(int min, int max, int length)
{
    int[] arr = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] array = RandomArray(0, 1, 8);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintArray(array);


// int[] array = new int[8];
// array[0] = 3453;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.Write(array[i] + " ");
// }
//Type
// int[] array = new int[8];
// string[] arrayStr = new string[8];
// bool[] arrayBool = new bool[8];
// Random[] rndArray = new Random[8];

// int[] array = new int[8];
// int[] array1 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
// int[] array2 = new int[];
// { 1, 2, 3, 4, 5, 6, 7, 8 };
// int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8 };

// var array4 = new int[8];
