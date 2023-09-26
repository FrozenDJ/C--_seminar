// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(99, 1000);
Console.WriteLine(number);
int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int trirdDigit = num % 10;
    return firstDigit*10+trirdDigit;
}

// int firstDigit = number / 100;
// int trirdDigit = number % 10;
// Console.WriteLine(firstDigit);
// Console.WriteLine(trirdDigit);
// int newNumber = firstDigit*10+trirdDigit;
// Console.WriteLine($"{number} -> {newNumber}");
int newNumber = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {newNumber}");
