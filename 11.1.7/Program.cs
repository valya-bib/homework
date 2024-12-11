using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("строка для проверки:");
        string input = Console.ReadLine();

        string regexFirstDigitUnique = @"^(\d)(?!.*\1)\d*$";
        string regexOnlyDigits = @"^\d+$";

        bool isOnlyDigits = Regex.IsMatch(input, regexOnlyDigits);
        bool firstDigitUnique = isOnlyDigits && Regex.IsMatch(input, regexFirstDigitUnique);

        Console.WriteLine(firstDigitUnique);
    }
}
