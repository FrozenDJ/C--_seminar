// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

Console.Write("Write first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Write third number: ");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;
if (x > max) max = x;
if (y > max) max = y;
if (z > max) max = z;
Console.Write($"{x},{y},{z} max = {max}");