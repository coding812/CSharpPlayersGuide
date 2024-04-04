Console.Title = "Hunting the Manticore";

// Initialize variables
int manticoreHealth = 10;
int cityHealth = 15;
int roundNumber = 1;
int damage;
string barrier = "----------------------------------------------------------------------------------------------";
// Clear console to begin game
Console.Clear();

// Get the distance of the Manticore from the city from Player 1
int manticoreDistance = PlayerOneInput();

// Prompt Player 2 for their turn
Console.WriteLine("Player 2, it is your turn.");

// Main game loop
while (manticoreHealth > 0 && cityHealth > 0)
{
    // Calculate the damage based on the round number
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {
        damage = 10;
    }
    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
    {
        damage = 3;
    }
    else
    {
        damage = 1;
    }
    
    // Print the game status
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(barrier);
    Console.WriteLine($"STATUS: Round: {roundNumber} City: {cityHealth} Manticore: {manticoreHealth} ");
    Console.WriteLine($"The Cannon is expected to deliver {damage} damage this round. ");
    
    // Get the cannon range from Player 2
    int cannonRange = PlayerTwoShot();
    
    // Determine the result of the shot
    switch (cannonRange)
    {
        case int range when range < manticoreDistance:
            Console.WriteLine("That round FELL SHORT of the target. ");
            break;
        case int range when range > manticoreDistance:
            Console.WriteLine("That round went OVERSHOT the target.");
            break;
        case int range when range == manticoreDistance:
            Console.WriteLine("That round was a DIRECT HIT!");
            manticoreHealth -= damage;
            break;
    }
    
    // Increment round number and decrease city health
    roundNumber++;
    cityHealth--;
}

// Print the game result
if (manticoreHealth <= 0)
{
    Console.WriteLine(barrier);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.WriteLine(barrier);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The Manticore Destroyed the city!");
    Console.ForegroundColor = ConsoleColor.White;
}

// Function to get the distance of the Manticore from the city from Player 1
int PlayerOneInput()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
    int manticoreDistance = Convert.ToInt16(Console.ReadLine());

    // Validate the input
    if (manticoreDistance < 0 || manticoreDistance > 100)
    {
        Console.WriteLine("The Manticore must be stationed between 0 and 100 units away from the city. ");
        PlayerOneInput();
    }
    
    Console.Clear();
    return manticoreDistance;
}

// Function to get the cannon range from Player 2
int PlayerTwoShot()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Enter desired cannon range: ");
    int cannonRange = Convert.ToInt16(Console.ReadLine());

    // Validate the input
    if (cannonRange < 0 || cannonRange > 100)
    {
        Console.WriteLine("The cannon range must be between 0 and 100. ");
        PlayerTwoShot();
    }
    
    return cannonRange;
}

