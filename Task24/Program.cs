// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Write your positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1)
{
    Console.WriteLine("Error. Incorrect number");
    return;
}

int SumNumber(int num)
{
    int count = 1;
    int sum = 0;
    while (count <= num)
    {
        checked
        {
            sum = sum + count;
            count++;
        }
    }
    return sum;
}

int res = SumNumber(a);
Console.WriteLine($"{a} -> {res}");