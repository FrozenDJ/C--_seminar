// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Write first integer number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write second integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

void RangeOfNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) Console.WriteLine($"{num1}");
    else if (num1 > num2)
    {
        Console.Write($"{num1}, ");
        RangeOfNaturalNumbers(num1 - 1, num2);
    }
    else 
    {
        Console.Write($"{num1}, ");
        RangeOfNaturalNumbers(num1 + 1, num2);
    }
}
RangeOfNaturalNumbers(M, N);