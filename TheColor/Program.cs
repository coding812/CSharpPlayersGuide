Console.Title = "The Color";
Console.Clear();

Color color1 = new Color (255, 100, 100);
Color color2 = Color.Red;

Console.WriteLine($"Color 1: {color1.RedLevel}, {color1.GreenLevel}, {color1.BlueLevel}");
Console.WriteLine($"Color 2: {color2.RedLevel}, {color2.GreenLevel}, {color2.BlueLevel}");

public class Color
{
    public int RedLevel { get; set; }
    public int GreenLevel { get; set; }
    public int BlueLevel { get; set; }

    public Color(int red, int green, int blue)
    {
        RedLevel = red;
        GreenLevel = green;
        BlueLevel = blue;
    }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);
}


