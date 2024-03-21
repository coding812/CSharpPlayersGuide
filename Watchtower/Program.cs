
Console.Write("X value: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y value: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("North East");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("North West");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("South West");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("South East");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("The Enemy is here!");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("North");
}
else if (x == 0 && y < 0)
{
    Console.WriteLine("South");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("East");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("West");
}
else
{
    Console.WriteLine("Invalid input");
}