//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
//  чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("How many numbers do you want to indicate: ");
int countNumbers = Convert.ToInt32(Console.ReadLine());

int[] UserArray(int min, int max, int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Write your numbers: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

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

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = UserArray(-1000, 1000, countNumbers);
int countPositiveNumbers = CountPositiveNumbers(array);
PrintArray(array);
Console.Write($" -> {countPositiveNumbers}");