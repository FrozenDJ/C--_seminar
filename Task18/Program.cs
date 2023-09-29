// Напишите программу, которая по заданному номеру четверти показывает
// диапазон возможных координат точек в этой чеверти (х и у)

Console.WriteLine("Write quarter number: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

string Quarter(int num)
{
    if (num == 1) return $"x > 0, y > 0";
    if (num == 2) return $"x < 0, y > 0";
    if (num == 3) return $"x < 0, y < 0";
    if (num == 4) return $"x > 0, y < 0";
    return null;
}
string result = Quarter(quarterNumber);
Console.WriteLine(result != null ? result : "Error. Incorrect quarter number");
