// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write degree number: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree < 1)
{
    Console.WriteLine("Error. Incorrect degree");
    return;
}

int DegreeNumber(int num, int degr)
{
    int rate = 1;
    for (int i = 0; i < degr; i++)
    {
        checked
        {
            rate = rate * num;
        }
    }
    return rate;
}
int res = DegreeNumber(number, degree);
Console.WriteLine($"{number}, {degree} -> {res}");