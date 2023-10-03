// Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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

int[] array = RandomArray(0, 10, 8);
Console.Write($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");
