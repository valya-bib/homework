using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("строка для проверки:");
        string input = Console.ReadLine();

        string regexWholeString = @"^.*101.*$";
        string regexPartString = @"101";

        bool isWholeStringMatch = Regex.IsMatch(input, regexWholeString);
        bool isPartStringMatch = Regex.IsMatch(input, regexPartString);

        Console.WriteLine($"строка соответствует целиком: {isWholeStringMatch}");
        Console.WriteLine($"строка содержит 101 подряд: {isPartStringMatch}");
    }
}
