// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// А(3,6); В(2,1) -> 5,09

Console.WriteLine("Write first coordinates: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write second coordinates: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int Stepen(int anyCoordinate1, int anyCoordinate2)
{
    int stepen = (anyCoordinate2 - anyCoordinate1) * (anyCoordinate2 - anyCoordinate1);
    return stepen;
}
// int squareSum = Stepen(x1, x2) + Stepen(y1, y2);
double result = Math.Sqrt(Stepen(x1, x2) + Stepen(y1, y2));
Console.WriteLine($"A({x1},{y1}); B({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");