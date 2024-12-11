using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("строка для проверки:");
        string input = Console.ReadLine();

        string regexContainsOne = @"1";
        string regexStartsWithOne = @"^1.*$";

        bool containsOneMatch = Regex.IsMatch(input, regexContainsOne);
        bool startsWithOneMatch = Regex.IsMatch(input, regexStartsWithOne);

        Console.WriteLine($"строка содержит 1: {containsOneMatch}");
        Console.WriteLine($"строка начинается с 1: {startsWithOneMatch}");
    }
}
