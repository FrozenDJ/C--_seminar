// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Write first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int y = Convert.ToInt32(Console.ReadLine());
// int result = x % y;
// if (result == 0)
// {
//     Console.WriteLine($"{x} / {y} -> yes");
// }
// else
// {
//     Console.WriteLine($"{x} / {y} -> no, remainder {result}");
// }
int RemainderNumber(int num1, int num2)
{
    return num1 % num2;
}
int rem = RemainderNumber(x, y);
if (rem == 0)
{
    Console.WriteLine($"{x} / {y} -> yes");
}
else
{
    Console.WriteLine($"{x} / {y} -> no, remainder {rem}");
}
