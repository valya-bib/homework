int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int chast = 0;
while (a > b && b != 0)
{
    a = a - b;
    chast += 1;
}
Console.WriteLine(chast);