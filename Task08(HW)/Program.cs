// Напишите программу, которая на вход принимает число (N), а на 
// выходе показывает все чётные числа от 1 до N.

Console.Write("Write your number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    Console.Write("Error. Use only positive numbers");
}
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}