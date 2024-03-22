Console.Title = "Buying Inventory";

int Rope = 10, Torches = 15, ClimbingEquipment = 25, CleanWater = 1, Machete = 20, Canoe = 200, FoodSupplies = 1;

Console.Write(@"The Following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies
What number do you want to see the price of? ");

int userInput = Convert.ToInt16(Console.ReadLine());

string response = userInput switch
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

Console.WriteLine(response);
