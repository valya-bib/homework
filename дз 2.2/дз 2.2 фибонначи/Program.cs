using System;

class Program
{
    static void Main()
    {
        int n = 20;
        Console.WriteLine($"итеративное число фибоначчи {n}: {FibonacciIterative(n)}");
        Console.WriteLine($"рекурсивное число фибоначчи {n}: {FibonacciRecursive(n)}");
    }

    static long FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    static long FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
}
