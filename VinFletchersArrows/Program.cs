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
    int length;
    Fletching fletching = GetFletchingInput();
    ArrowHead arrowHead = GetArrowHeadInput();
    Console.Write("How many centimeters do you want your arrow to be? ");
    length = Convert.ToInt16(Console.ReadLine());
    
    // return the fletching, arrow head, and length
    return (fletching, arrowHead, length);

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
    float fletchingPrice = fletching switch
    {
        Fletching.plastic => 10,
        Fletching.turkeyFeathers => 5,
        Fletching.gooseFeathers => 3,
        _ => 0,
    };

    float arrowHeadPrice = arrowHead switch
    {
        ArrowHead.steel => 10,
        ArrowHead.wood => 3,
        ArrowHead.obsidian => 5,
        _ => 0,
    };

    float lengthPrice = (float)(length * .05);

    float totalPrice = fletchingPrice + arrowHeadPrice + lengthPrice;

    return totalPrice;
}

// Method to print the arrow object
static void PrintArrow(Arrow arrow)
{
    Console.WriteLine($"You have chosen a {arrow.fletching} fletching, a {arrow.arrowHead} arrow head, and a length of {arrow.length} centimeters.");
    Console.WriteLine($"The total cost of your arrow is ${GetCost(arrow.fletching, arrow.arrowHead, arrow.length)}");
}

// Arrow class with properties for fletching, arrow head, and length
class Arrow
{
    public Fletching fletching;
    public ArrowHead arrowHead;
    public float length;

    public Arrow(Fletching fletching, ArrowHead arrowHead, float length)
    {
        this.fletching = fletching;
        this.arrowHead = arrowHead;
        this.length = length;
    }

}
// Enumerations for the fletching and arrow head types
enum Fletching { plastic, turkeyFeathers, gooseFeathers };
enum ArrowHead { steel, wood, obsidian };