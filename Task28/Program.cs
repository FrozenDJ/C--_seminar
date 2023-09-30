// Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Error. Incorrect number.");
    return;
}

int Faktorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result = result * i;
        }
    }
    return result;
}

int fakt = Faktorial(number);
Console.WriteLine($"{number} -> {fakt}");