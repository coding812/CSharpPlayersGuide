Console.Title = "Vin Fletcher's Arrows";
Console.Clear();

Console.WriteLine("Welcome to Vin Fletcher's Arrow Shop!");
Console.WriteLine();
Console.WriteLine("We have three types of arrows available for purchase:");
Console.WriteLine("1. Elite Arrow: Plastic fletching, Steel arrow head, 95 centimeters long");
Console.WriteLine("2. Beginner Arrow: Goose Feathers fletching, Wood arrow head, 75 centimeters long");
Console.WriteLine("3. Marksmen Arrow: Goose Feathers fletching, Steel arrow head, 65 centimeters long");
Console.WriteLine("You can also create a custom arrow by choosing the fletching, arrow head, and length.");
Console.WriteLine();
Console.Write("Which type of arrow would you like to purchase? Enter 1, 2, 3, or 4 for a custom arrow: ");

int userArrowChoice = Convert.ToInt16(Console.ReadLine());

switch (userArrowChoice)
{
    case 1:
        Arrow eliteArrow = Arrow.CreateEliteArrow();
        PrintArrow(eliteArrow , userArrowChoice);
        break;
    case 2:
        Arrow beginnerArrow = Arrow.CreateBeginnerArrow();
        PrintArrow(beginnerArrow, userArrowChoice);
        break;
    case 3:
        Arrow marksmenArrow = Arrow.CreateMarksmenArrow();
        PrintArrow(marksmenArrow, userArrowChoice);
        break;
    case 4:
        // Get the user's input using the GetCustomArrowInput method
        (Fletching fletching, ArrowHead arrowHead, float length) = GetCustomArrowInput();
        // Create an arrow object using the user's input
        Arrow arrow = new(fletching, arrowHead, length);
        // Print the arrow object using the PrintArrow method
        PrintArrow(arrow, userArrowChoice);
        break;
    default:
        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
        break;
}

// Get the user's input for the fletching, arrow head, and length of the arrow
(Fletching, ArrowHead, float) GetCustomArrowInput()
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
static void PrintArrow(Arrow arrow, int userArrowChoice)
{
    Console.WriteLine();
    switch (userArrowChoice)
    {
        case 1:
            
            Console.WriteLine("You have chosen an Elite Arrow:");
            Console.WriteLine($"It will have a {arrow.Fletching} fletching, a {arrow.ArrowHead} arrow head, and a length of {arrow.Length} centimeters.");
            Console.WriteLine($"The total cost of your arrow is ${GetCost(arrow.Fletching, arrow.ArrowHead, arrow.Length)}");
            break;
        case 2:
            Console.WriteLine("You have chosen a Beginner Arrow:");
            Console.WriteLine($"It will have a {arrow.Fletching} fletching, a {arrow.ArrowHead} arrow head, and a length of {arrow.Length} centimeters.");
            Console.WriteLine($"The total cost of your arrow is ${GetCost(arrow.Fletching, arrow.ArrowHead, arrow.Length)}");
            break;
        case 3:
            Console.WriteLine("You have chosen a Marksmen Arrow:");
            Console.WriteLine($"It will have a {arrow.Fletching} fletching, a {arrow.ArrowHead} arrow head, and a length of {arrow.Length} centimeters.");
            Console.WriteLine($"The total cost of your arrow is ${GetCost(arrow.Fletching, arrow.ArrowHead, arrow.Length)}");
            break;
        case 4:
            Console.WriteLine("You have chosen a custom arrow.");
            Console.WriteLine($"It will have a {arrow.Fletching} fletching, a {arrow.ArrowHead} arrow head, and a length of {arrow.Length} centimeters.");
            Console.WriteLine($"The total cost of your arrow is ${GetCost(arrow.Fletching, arrow.ArrowHead, arrow.Length)}");
            break;
    }
}

// Arrow class with properties for fletching, arrow head, and length
public class Arrow
{
    public Fletching Fletching { get; }
    public ArrowHead ArrowHead { get;}
    public float Length{ get; } // Level 20 Challenge makes this a read-only property

    public Arrow(Fletching fletching, ArrowHead arrowHead, float length)
    {
        this.Fletching = fletching;
        this.ArrowHead = arrowHead;
        this.Length = length;
    }
    public static Arrow CreateEliteArrow(){return new Arrow(Fletching.plastic, ArrowHead.steel, 95);}
    public static Arrow CreateBeginnerArrow(){return new Arrow(Fletching.gooseFeathers, ArrowHead.wood, 75);}
    public static Arrow CreateMarksmenArrow(){return new Arrow(Fletching.gooseFeathers, ArrowHead.steel, 65);}
}
// Enumerations for the fletching and arrow head types
public enum Fletching { plastic, turkeyFeathers, gooseFeathers };
public enum ArrowHead { steel, wood, obsidian };