using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("строка для проверки:");
        string input = Console.ReadLine();

        string regexFirstDigitRepeated = @"^(\d)(?=.*\1)\d*$";
        string regexOnlyDigits = @"^\d+$";

        bool isOnlyDigits = Regex.IsMatch(input, regexOnlyDigits);
        bool firstDigitRepeated = isOnlyDigits && Regex.IsMatch(input, regexFirstDigitRepeated);

        Console.WriteLine(firstDigitRepeated);
    }
}
