// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить 
// с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Write first integer number: ");
string input1 = Console.ReadLine();
int M;
Console.WriteLine("Write second integer number: ");
string input2 = Console.ReadLine();
int N;

if (int.TryParse(input1, out M) && M >= 1 && int.TryParse(input2, out N) && N >= 1)
{
    int result = SumOfElementsInInterval(M, N);
    Console.Write($"M = {M}; N = {N} -> {result}");
}
else
{
    Console.WriteLine("Error. Write a valid natural integer number.");
    return;
}


int SumOfElementsInInterval(int num1, int num2)
{
    if (num1 < num2) return num1 + SumOfElementsInInterval(num1 + 1, num2);
    else if (num1 > num2)
    {
        return num1 + SumOfElementsInInterval(num1 - 1, num2);
    }
    else
    {
        return num1;
    }
}