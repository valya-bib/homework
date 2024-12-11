int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int k = 0;
for (int i = 0; n >= m; i++)
{
    n = n - m;
    Console.WriteLine(i);
}
