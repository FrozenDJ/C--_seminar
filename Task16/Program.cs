// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Write first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int y = Convert.ToInt32(Console.ReadLine());

bool IsSquareTwoNumbers(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
bool result = IsSquareTwoNumbers(x, y);
Console.WriteLine(result ? $"{x} , {y} -> yes" : $"{x} ,{y} -> no");