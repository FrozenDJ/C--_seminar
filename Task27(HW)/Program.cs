// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Error. Incorrect number");
    return;
}

int SumDigits(int num)
{
    if (num < 0)
    {
        num *= -1;
    }

    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
int result = SumDigits(number);
Console.WriteLine($"{number} -> {result}");