// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.Length;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{number} -> {count[2]}");
}
Console.WriteLine($"{number} -> No third digit");