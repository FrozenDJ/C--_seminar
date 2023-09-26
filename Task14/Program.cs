// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Write your number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int firstNumber = x % 7;
// int secondNumber = x % 23;

// if (firstNumber == 0)
// {
//     if (secondNumber == 0)
//     {
//         Console.WriteLine($"{x} -> yes");
//     }
//     else
//     {
//         Console.WriteLine($"{x} -> no");
//     }
// }
// else
// {
//     Console.WriteLine($"{x} -> no");
// }


// if (firstNumber == 0 && secondNumber == 0)
//     {
//         Console.WriteLine($"{x} -> yes");
//     }
// else
//     {
//      Console.WriteLine($"{x} -> no");
//     }

Console.Write("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = 7;
int secondNumber = 23;
bool MultypleTwoNumbers(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}
bool result = MultypleTwoNumbers(number, firstNumber, secondNumber);
Console.WriteLine(result ? $"{number} -> yes" : $"{number} -> no");