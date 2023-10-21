// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа 
// m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Write first number: ");
string input1 = Console.ReadLine();
int m;
Console.WriteLine("Write second number: ");
string input2 = Console.ReadLine();
int n;

if (int.TryParse(input1, out m) && m >= 0 && int.TryParse(input2, out n) && n >= 0)
{
    int result = AckFunction(m, n);
    Console.Write($"m = {m}; n = {n} -> A(m,n) = {result}");
}
else
{
    Console.WriteLine("Error. Write down a valid non-negative integer..");
    return;
}

int AckFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AckFunction(n - 1, 1);
    else return AckFunction(n - 1, AckFunction(n, m - 1));
}