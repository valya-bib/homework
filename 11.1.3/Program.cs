using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("строка для проверки:");
        string input = Console.ReadLine();

        string regexStartsWith = @"^101.*$";
        string regexEndsWith = @".*101$";

        bool isStartsWithMatch = Regex.IsMatch(input, regexStartsWith);
        bool isEndsWithMatch = Regex.IsMatch(input, regexEndsWith);

        Console.WriteLine($"строка начинается с 101': {isStartsWithMatch}");
        Console.WriteLine($"строка заканчивается на 101': {isEndsWithMatch}");
    }
}
