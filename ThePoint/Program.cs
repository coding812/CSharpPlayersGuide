Console.Title = "The Point";
Console.Clear();

Point point1 = new(2, 3);
Point point2 = new(-4, 0);

Console.WriteLine($"Point 1: ({point1.X}, {point1.Y})");
Console.WriteLine($"Point 2: ({point2.X}, {point2.Y})");

class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
