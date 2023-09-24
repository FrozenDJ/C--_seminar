//Напишите программу, которая на вход принимает число, и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Write your number: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = n % 2;
if (0 == x)
{
    Console.WriteLine($"{n} -> yes");
}
else
{
    Console.WriteLine($"{n} -> no");
}