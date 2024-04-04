Console.Title = "Simula's Soup";

// Get the order from the user and assign the result to a tuple with type and name
(FoodType Type, MainIngredient Ingredient, Seasoning Seasoning) food = GetOrder();

// Display the order details
Console.WriteLine($"You ordered {food.Seasoning} {food.Ingredient} {food.Type}.");

// Method to get the user's order
static (FoodType, MainIngredient, Seasoning) GetOrder()
{
    // Welcome message
    Console.WriteLine("Welcome to Simula's Soup!");

    // Prompt for food type
    Console.WriteLine("What type of food would you like?");
    Console.WriteLine("Soup");
    Console.WriteLine("Stew");
    Console.WriteLine("Gumbo");
    FoodType foodType = (FoodType)Enum.Parse(typeof(FoodType), Console.ReadLine().ToLower());
    
    // Prompt for main ingredient
    Console.WriteLine("What is the main ingredient?");
    Console.WriteLine("Mushrooms");
    Console.WriteLine("Chicken");
    Console.WriteLine("Carrots");
    Console.WriteLine("Potatoes");
    MainIngredient mainIngredient = (MainIngredient)Enum.Parse(typeof(MainIngredient), Console.ReadLine().ToLower());
    
    // Prompt for seasoning
    Console.WriteLine("What seasoning would you like?");
    Console.WriteLine("Spicy");
    Console.WriteLine("Salty");
    Console.WriteLine("Sweet");
    Seasoning seasoning = (Seasoning)Enum.Parse(typeof(Seasoning), Console.ReadLine().ToLower());

    // Return the order as a tuple
    return (foodType, mainIngredient, seasoning);
}

// Enum for food types
enum FoodType {soup, stew, gumbo};

// Enum for main ingredients
enum MainIngredient {mushrooms, chicken, carrots, potatoes};

// Enum for seasonings
enum Seasoning {spicy, salty, sweet};