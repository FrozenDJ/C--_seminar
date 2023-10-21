// Напишите программу, которая будет принимать на вход 
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9;

Console.Write("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitOfNumber(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigitOfNumber(num / 10);
}
Console.Write($"{number} -> {SumDigitOfNumber(number)}");