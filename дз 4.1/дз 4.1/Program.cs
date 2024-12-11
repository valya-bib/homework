using System;

class Program
{
    static void Main()
    {
        int N = 5; // Пример нечетного числа
        int[,] array = new int[N, N];

        // Заполнение массива заданными элементами
        FillArray(array);

        // Вывод массива
        PrintArray(array);

        // Вывод элементов при обходе по спирали
        PrintSpiral(array);
    }

    static void FillArray(int[,] array)
    {
        int value = 1; // Начальное значение для заполнения
        int n = array.GetLength(0);
        int center = n / 2;

        // Заполнение массива по спирали
        for (int layer = 0; layer <= center; layer++)
        {
            for (int i = -layer; i <= layer; i++)
            {
                array[center - layer, center + i] = value++;
            }
            for (int i = -layer + 1; i <= layer; i++)
            {
                array[center + i, center + layer] = value++;
            }
            for (int i = layer - 1; i >= -layer; i--)
            {
                array[center + layer, center + i] = value++;
            }
            for (int i = layer - 1; i > -layer; i--)
            {
                array[center + i, center - layer] = value++;
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int n = array.GetLength(0);
        Console.WriteLine("Массив:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void PrintSpiral(int[,] array)
    {
        int n = array.GetLength(0);
        int center = n / 2;
        Console.WriteLine("Элементы массива при обходе по спирали, начиная с центра:");

        for (int layer = 0; layer <= center; layer++)
        {
            for (int i = -layer; i <= layer; i++)
            {
                Console.Write(array[center - layer, center + i] + " ");
            }
            for (int i = -layer + 1; i <= layer; i++)
            {
                Console.Write(array[center + i, center + layer] + " ");
            }
            for (int i = layer - 1; i >= -layer; i--)
            {
                Console.Write(array[center + layer, center + i] + " ");
            }
            for (int i = layer - 1; i > -layer; i--)
            {
                Console.Write(array[center + i, center - layer] + " ");
            }
        }
        Console.WriteLine();
    }
}
