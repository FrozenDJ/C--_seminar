// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Write first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.WriteLine($"{x} > {y} -> max = {x}");
}
else if (x == y)
{
    Console.WriteLine($"{x} = {y} Try again");
}
else
{
    Console.WriteLine($"{x} < {y} -> max = {y}");
}