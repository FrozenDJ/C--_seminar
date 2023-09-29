// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// А(3,6,8); В(2,1,-7) -> 15,84

Console.WriteLine("Write first coordinates: ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write second coordinates: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int Stepen(int anyCoordinate1, int anyCoordinate2)
{
    int stepen = (anyCoordinate2 - anyCoordinate1) * (anyCoordinate2 - anyCoordinate1);
    return stepen;
}
int squareSum = Stepen(x1, x2) + Stepen(y1, y2) + Stepen(z1, z2);
double result = Math.Sqrt(squareSum);   //(Stepen(x1, x2) + Stepen(y1, y2) + Stepen(z1, z2));
Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");