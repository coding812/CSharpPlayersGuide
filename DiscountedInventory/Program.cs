Console.Title = "Discounted Inventory";
string shopKeeperName = "Steve"; // Declare 'shopKeeperName' variable

// Declare variables for the prices of the items
int Rope = 10, Torches = 15, ClimbingEquipment = 25, CleanWater = 1, Machete = 20, Canoe = 200, FoodSupplies = 1;

// Ask the user for their name
Console.Write("What is your name? ");
string userName = Console.ReadLine();

// Display the available items and ask the user for their choice
Console.Write(@"The Following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies
What number do you want to see the price of? ");

// Get the user's input
int userInput = Convert.ToInt16(Console.ReadLine());

string response; // Declare 'response' variable
// Check if the user has the same name as the shopkeeper, and if so, apply a discount of 50%
if (userName == shopKeeperName)
{
    response = userInput switch
    {
        1 => $"Rope costs {Rope / 2} gold.",
        2 => $"Torches cost {Torches / 2} gold.",
        3 => $"Climbing Equipment costs {ClimbingEquipment / 2} gold.",
        4 => $"Clean Water costs {CleanWater / 2} gold.",
        5 => $"Machete costs {Machete / 2} gold.",
        6 => $"Canoe costs {Canoe / 2} gold.",
        7 => $"Food Supplies costs {FoodSupplies / 2} gold.",
        _ => "Invalid Input"
    };
}
else
{
    response = userInput switch
    {
        1 => $"Rope costs {Rope} gold.",
        2 => $"Torches cost {Torches} gold.",
        3 => $"Climbing Equipment costs {ClimbingEquipment} gold.",
        4 => $"Clean Water costs {CleanWater} gold.",
        5 => $"Machete costs {Machete} gold.",
        6 => $"Canoe costs {Canoe} gold.",
        7 => $"Food Supplies costs {FoodSupplies} gold.",
        _ => "Invalid Input"
    };
}

// Display the response
Console.WriteLine(response);
