// Написать программу, которая на вход принимает одно целое число (N),
// а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Write your number: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while(count<=n)
{
    Console.Write($"{count} ");
    count++;
}