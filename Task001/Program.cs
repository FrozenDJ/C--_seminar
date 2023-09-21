// Написать программу, которая на вход принимает число и выдаёт его квадрат (число, умноженное на само себя)
Console.Write("Write your number: ");
//int x = Console.ReadLine ();
int x = Convert.ToInt32(Console.ReadLine ());
//int x = new Random().Next (1, 100);
int stepen = 2;
Console.WriteLine(x);
Console.WriteLine(Math.Pow(x, stepen));