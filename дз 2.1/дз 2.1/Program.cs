using System;

class Program
{
    static void Main()
    {
        string S = "ababcabcab";
        string S1 = "abc";

        int count = CountOccurrences(S, S1);

        Console.WriteLine($"количество вхождений '{S1}' в '{S}': {count}");
    }

    static int CountOccurrences(string S, string S1)
    {
        int count = 0;
        int index = 0;

        while ((index = S.IndexOf(S1, index)) != -1)
        {
            count++;
            index += S1.Length;
        }

        return count;
    }
}
