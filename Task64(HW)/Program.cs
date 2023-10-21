// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Write your natural integer number: ");
string input = Console.ReadLine();
int number;

if (int.TryParse(input, out number) && number >= 1)
{
    Console.Write($"N = {number} -> ");
    NaturalNumbers(number);
}
else
{
    Console.WriteLine("Error. Write a valid natural integer number.");
    return;
}

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
}