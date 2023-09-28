// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int ShowSecondDigit(int num)
{
    int lastDigit = num % 100;
    return lastDigit / 10;
}

if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <= 999)
{
    int requiredDigit = ShowSecondDigit(number);
    Console.WriteLine($"{number} -> {requiredDigit}");
}
else
{
    Console.Write("Error. Write three-digit number");
}