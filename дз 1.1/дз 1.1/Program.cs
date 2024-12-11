int chislo = Convert.ToInt32(Console.ReadLine());
for (int count = 0, i = 1; i < chislo; i++)
{
    for (int k = 1; k <= i; k++)
    {
        if (i % k == 0) count = count + 1;
    }
    if (count == 2)
    {
        Console.WriteLine(i);
    }
    count = 0;
}