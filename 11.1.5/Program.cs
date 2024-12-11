using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("строка для проверки:");
        string input = Console.ReadLine();

        string regexNoOne = @"^[^1]*$";
        string regexNoOnePart = @"[^1]";

        bool noOneMatch = Regex.IsMatch(input, regexNoOne);
        bool noOnePartMatch = Regex.IsMatch(input, regexNoOnePart);

        Console.WriteLine($"строка не содержит 1: {noOneMatch}");
        Console.WriteLine($"строка содержит хотя бы один символ, не равный 1: {noOnePartMatch}");
    }
}
