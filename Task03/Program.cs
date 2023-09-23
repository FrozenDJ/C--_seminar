// Написать программу, которая будет выдавать название дня недели по
// заданному номеру.


Console.Write ("Write your day number: ");
int user = Convert.ToInt32(Console.ReadLine ());
if (user == 1)
{
    Console.WriteLine ("1 -> Monday");
}
else if (user == 2)
{
    Console.WriteLine ("2 -> Tuesday");
}
else if (user == 3)
{
    Console.WriteLine ("3 -> Wednesday");
}
else if (user == 4)
{
    Console.WriteLine ("4 -> Thursday");
}
else if (user == 5)
{
    Console.WriteLine ("5 -> Friday");
}
else if (user == 6)
{
    Console.WriteLine ("6 -> Saturday");
}
else if (user == 7)
{
    Console.WriteLine ("7 -> Sunday");
}
else
{
    Console.WriteLine ("wrong day number");
}