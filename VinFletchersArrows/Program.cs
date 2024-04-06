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
    // Get the user's input for the fletching and arrow head using the GetFletchingInput and GetArrowHeadInput methods
    // Set the fletching and arrow head properties of the arrow object using getter and setter methods per Level 19 Challenge
    Arrow Arrow = new Arrow(Fletching.plastic, ArrowHead.steel, 0);
    Arrow.SetFletching(GetFletchingInput()); 
    Arrow.SetArrowHead(GetArrowHeadInput());
    // Fletching fletching = GetFletchingInput();
    // ArrowHead arrowHead = GetArrowHeadInput();
    Console.Write("How many centimeters do you want your arrow to be? ");
    int length = Convert.ToInt16(Console.ReadLine());
    
    
    // return the fletching, arrow head, and length
    return (Arrow.GetFletching(), Arrow.GetArrowHead(), length);

    // Method to get the user's input for the fletching and validate input is valid or call the method again
    static Fletching GetFletchingInput()
    {
        Fletching fletching;
        Console.Write("What type of fletching do you want? Plastic, Turkey Feathers, or Goose Feathers? ");
        string fletchingInput = Console.ReadLine().ToLower();
        fletching = fletchingInput switch
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
        ArrowHead arrowHead;
        Console.Write("What type of arrow head do you want? Steel, Wood, or Obsidian? ");
        string arrowHeadInput = Console.ReadLine().ToLower();
        arrowHead = arrowHeadInput switch
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
    float fletchingPrice = Arrow.GetFletching() switch
    {
        Fletching.plastic => 10f,
        Fletching.turkeyFeathers => 5f,
        Fletching.gooseFeathers => 3f,
        _ => 0,
    };

    float arrowHeadPrice = Arrow.GetArrowHead() switch
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
    Console.WriteLine($"You have chosen a {arrow.GetFletching()} fletching, a {arrow.GetArrowHead()} arrow head, and a length of {arrow.GetLength()} centimeters.");
    Console.WriteLine($"The total cost of your arrow is ${GetCost(arrow.GetFletching(), arrow.GetArrowHead(), arrow.GetLength())}");
}

// Arrow class with properties for fletching, arrow head, and length
class Arrow
{
    private Fletching fletching;
    private ArrowHead arrowHead;
    private float length;

    public Arrow(Fletching fletching, ArrowHead arrowHead, float length)
    {
        this.fletching = fletching;
        this.arrowHead = arrowHead;
        this.length = length;
    }

    // Getters and setters for the fletching, arrow head, and length per Level 19 Challenge
    public Fletching GetFletching() => fletching;
    public ArrowHead GetArrowHead() => arrowHead;
    public float GetLength() => length;
    public void SetFletching(Fletching fletching) => this.fletching = fletching;
    public void SetArrowHead(ArrowHead arrowHead) => this.arrowHead = arrowHead;

}
// Enumerations for the fletching and arrow head types
enum Fletching { plastic, turkeyFeathers, gooseFeathers };
enum ArrowHead { steel, wood, obsidian };