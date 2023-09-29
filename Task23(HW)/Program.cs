// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.

Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}

void TableCube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3} -- {count * count * count,5}");
        count++;
    }
}
TableCube(number);