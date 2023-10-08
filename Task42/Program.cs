// Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.WriteLine("Write your decimal number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

int ConvertToBinary(int num)
{
    int bin = 0;
    int multy = 1;
    while (num > 0)
    {
        bin += num % 2 * multy;
        num /= 2;
        multy *= 10;
    }
    return bin;
}

Console.WriteLine(ConvertToBinary(decimalNumber));

string ConvertToBinaryString(int num)
{
    string bin = string.Empty;
    while (num > 0)
    {
        bin = num % 2 + bin;
        num /= 2;
    }
    return bin;
}

Console.WriteLine(ConvertToBinaryString(decimalNumber));