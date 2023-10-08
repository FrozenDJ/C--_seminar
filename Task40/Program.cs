// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Write first side: ");
int firstSideNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write second side: ");
int secondSideNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write third side: ");
int thirdSideNumber = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

bool result = IsExistTriangle(firstSideNumber, secondSideNumber, thirdSideNumber);
Console.WriteLine(result ? "Triangle is exist" : "Triangle is not exist");