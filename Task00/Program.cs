// Написать программу, которая на вход принимает число и выдаёт его 
// квадрат (число, умноженное на само себя)
Console.Write("Write your number: ");
int x = Convert.ToInt32(Console.ReadLine ());
int stepen = 2;
Console.WriteLine(x);
Console.WriteLine(Math.Pow(x, stepen));