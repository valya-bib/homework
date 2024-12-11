using System;

class Program
{
    static void Main()
    {
        int n = 20;
        Console.WriteLine($"итеративный факториал {n}: {FactorialIterative(n)}");
        Console.WriteLine($"рекурсивный факториал {n}: {FactorialRecursive(n)}");
    }

    static long FactorialIterative(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static long FactorialRecursive(int n)
    {
        if (n <= 1) return 1;
        return n * FactorialRecursive(n - 1);
    }
}
