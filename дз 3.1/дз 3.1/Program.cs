using System;

class Program
{
    static void Main()
    {
        Console.Write("введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        string binary1 = Convert.ToString(num1, 2).PadLeft(32, '0');
        string binary2 = Convert.ToString(num2, 2).PadLeft(32, '0');

        Console.WriteLine(binary1);
        Console.WriteLine(binary2);

        int sum = num1 + num2;
        string binarySum = Convert.ToString(sum, 2).PadLeft(32, '0');

        Console.WriteLine(binarySum);

        Console.WriteLine(sum);
    }
}
