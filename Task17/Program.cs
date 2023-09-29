// Напишите программу, которая проинимает на вход координаты точки (Х и У),
// причём Х не равно 0 и У не равно 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Write your coordinates: ");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 ? $"It's quarter number {quarter}" : "Error. Incorrect coordinates";
Console.WriteLine(result);