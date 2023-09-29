// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.Write("Write your number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 9999 && number < 100000)
// {
//     bool IsPalindrom(int num)
//     {
//         string n = num.ToString();
//         for (int i = 0; i < n.Length / 2; i++)

//             if (n[i] != n[n.Length - i - 1])
//                 return false;
//         return true;
//     }
//     bool result = IsPalindrom(number);
//     Console.WriteLine($"{number} -> {result}");
// }
// else
// {
//     Console.WriteLine($"{number} -> Not five digit number");
//     Console.Write(false);
// }

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Введите свое решение ниже
        string n = number.ToString();
        if (n.Length == 5)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - i - 1])
                    return false;
            }
            return true;
        }
        else
        {
            Console.WriteLine($"Число не пятизначное");
            return false;
        }
    }
    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 128981;
        }
        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
