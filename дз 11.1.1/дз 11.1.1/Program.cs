using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("строка для проверки:");
        string input = Console.ReadLine();

        string regexWholeString = @"^.*000.*$";
        string regexPartString = @"000";

        bool isWholeStringMatch = Regex.IsMatch(input, regexWholeString);
        bool isPartStringMatch = Regex.IsMatch(input, regexPartString);

        Console.WriteLine($"строка соответствует целиком: {isWholeStringMatch}");
        Console.WriteLine($"строка содержит три нуля подряд: {isPartStringMatch}");
    }
}
