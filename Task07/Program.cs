// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.

Console.Write("Write number: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0)
{
    x *= -1;
}
if (x >= 100 && x <= 999)
{
    int last = x % 10;
    Console.Write(last);
}
else
{
    Console.Write("Error! Use 3 point number");
}