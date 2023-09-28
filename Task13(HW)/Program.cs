// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Write your number: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
int FindThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
        count++;
    }
    return num % 10;
}

if (startNumber < 100)
{
    Console.WriteLine($"{startNumber} -> No third digit");
    return;
}

int result = FindThirdDigit(startNumber);
Console.WriteLine($"{startNumber} -> {result}");