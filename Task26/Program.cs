// Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountOfNumber(int num)
{
    if (number == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

int res = CountOfNumber(number);
Console.WriteLine($"{number} -> {res}");