int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int a3 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int b3 = Convert.ToInt32(Console.ReadLine());
if ( a1 / b1 == a2 / b2 && a2 / b2 == a3 / b3)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}