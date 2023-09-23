// Написать программу, которая на вход принимает 2 числа и 
// проверяет, является ли первое число квадратом второго

Console.Write("Write first number: ");
int x = Convert.ToInt32(Console.ReadLine ());
Console.Write("Write second number: ");
int y = Convert.ToInt32(Console.ReadLine ());
if (x == y * y) 
{
    Console.WriteLine($"{x} / {y} = {y} -> True");
}
else
{
    Console.WriteLine($"{x} / {y} = {y} -> Wrong");
}