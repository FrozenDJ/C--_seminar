// Напишите программу, которая на вход принимает два числа 
// A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Write first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int PowRecursive(int num1, int num2) // 3, 5
{
    if (num2 == 0) return 1;
    return num1 * PowRecursive(num1, num2 - 1);
}
Console.Write($"A = {numberA}; B = {numberB} -> {PowRecursive(numberA, numberB)}");