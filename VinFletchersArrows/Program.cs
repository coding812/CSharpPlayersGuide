using System.Runtime.CompilerServices;

Console.Title = "Vin Fletcher's Arrows";
Console.Clear();

// Get the user's input using the GetArrowInput method
(Fletching fletching, ArrowHead arrowHead, float length) = GetArrowInput();
// Create an arrow object using the user's input
Arrow arrow = new(fletching, arrowHead, length);
// Print the arrow object using the PrintArrow method
PrintArrow(arrow);

// Get the user's input for the fletching, arrow head, and length of the arrow
static (Fletching, ArrowHead, float) GetArrowInput()
{
    // Declare variables for the fletching, arrow head, and length
    // Set the fletching and arrow head properties of the arrow object using the fletching and arrow head variables per Level 20 Challenge
    Fletching fletching = GetFletchingInput(); // Level 20 Challenge 
    ArrowHead arrowHead = GetArrowHeadInput();
    Console.Write("How many centimeters do you want your arrow to be? ");
    float length = Convert.ToInt16(Console.ReadLine());
    
    Arrow Arrow = new Arrow(fletching, arrowHead, length);
    
    // return the fletching, arrow head, and length
    return (Arrow.Fletching, Arrow.ArrowHead, Arrow.Length); // Level 20 Challenge

    // Method to get the user's input for the fletching and validate input is valid or call the method again
    static Fletching GetFletchingInput()
    {
        Console.Write("What type of fletching do you want? Plastic, Turkey Feathers, or Goose Feathers? ");
        string fletchingInput = Console.ReadLine().ToLower();
        Fletching fletching = fletchingInput switch
        {
            "plastic" => Fletching.plastic,
            "turkey feathers" => Fletching.turkeyFeathers,
            "goose feathers" => Fletching.gooseFeathers,
            _ => GetFletchingInput(),
        };
        return fletching;
    }
    // Method to get the user's input for the arrow head and validate input is valid or call the method again
    static ArrowHead GetArrowHeadInput()
    {
        Console.Write("What type of arrow head do you want? Steel, Wood, or Obsidian? ");
        string arrowHeadInput = Console.ReadLine().ToLower();
        ArrowHead arrowHead = arrowHeadInput switch
        {
            "steel" => ArrowHead.steel,
            "wood" => ArrowHead.wood,
            "obsidian" => ArrowHead.obsidian,
            _ => GetArrowHeadInput(),
        };
        return arrowHead;
    }
}
// Method to calculate the cost of the arrow based on the fletching, arrow head, and length
static float GetCost(Fletching fletching, ArrowHead arrowHead, float length)
{
    Arrow Arrow = new Arrow(Fletching.plastic, ArrowHead.steel, 0);
    float fletchingPrice = Arrow.Fletching switch
    {
        Fletching.plastic => 10f,
        Fletching.turkeyFeathers => 5f,
        Fletching.gooseFeathers => 3f,
        _ => 0,
    };

    float arrowHeadPrice = Arrow.ArrowHead switch
    {
        ArrowHead.steel => 10f,
        ArrowHead.wood => 3f,
        ArrowHead.obsidian => 5f,
        _ => 0,
    };

    float lengthPrice = length * .05f;

    float totalPrice = fletchingPrice + arrowHeadPrice + lengthPrice;

    return totalPrice;
}

// Method to print the arrow object
static void PrintArrow(Arrow arrow)
{
    Console.WriteLine($"You have chosen a {arrow.Fletching} fletching, a {arrow.ArrowHead} arrow head, and a length of {arrow.Length} centimeters.");
    Console.WriteLine($"The total cost of your arrow is ${GetCost(arrow.Fletching, arrow.ArrowHead, arrow.Length)}");
}

// Arrow class with properties for fletching, arrow head, and length
public class Arrow
{
    public Fletching Fletching { get; set; } = Fletching.plastic;
    public ArrowHead ArrowHead { get; set; } = ArrowHead.steel;
    public float Length{ get; } = 0; // Level 20 Challenge makes this a read-only property

    public Arrow(Fletching fletching, ArrowHead arrowHead, float length)
    {
        this.Fletching = fletching;
        this.ArrowHead = arrowHead;
        this.Length = length;
    }
}
// Enumerations for the fletching and arrow head types
public enum Fletching { plastic, turkeyFeathers, gooseFeathers };
public enum ArrowHead { steel, wood, obsidian };