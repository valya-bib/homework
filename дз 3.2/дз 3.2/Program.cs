using System;

class Program
{
    static void Main()
    {
        int radius = 10; 
        double s = 2.0; // cоотношение сторон

        for (double y = -radius; y <= radius; y++)
        {
            for (double x = -radius * s; x <= radius * s; x++)
            {
                if (Math.Pow(x / s, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
