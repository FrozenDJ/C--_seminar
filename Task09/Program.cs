// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine(number);

// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"max -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"max -> {secondDigit}");
// }
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"max -> {maxDigit}");

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit=MaxDigit(number);
Console.WriteLine($"max -> {maxDigit}");