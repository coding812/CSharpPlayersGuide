Console.Title = "Hunting the Manticore";

int manticoreHealth = 10;
int cityHealth = 15;
int roundNumber = 1;
int damage;

int manticoreDistance = PlayerOneInput();

Console.WriteLine("Player 2, it is your turn.");

while (manticoreHealth > 0 && cityHealth > 0)
{
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
    
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("----------------------------------------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {roundNumber} City: {cityHealth} Manticore: {manticoreHealth} ");
    Console.WriteLine($"The Cannon is expected to deliver {damage} damage this round. ");
    int cannonRange = PlayerTwoShot();
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

    // Console.Clear();

    roundNumber++;
    cityHealth--;
}

if (manticoreHealth <= 0)
{
    Console.WriteLine("----------------------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.WriteLine("----------------------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The Manticore Destroyed the city!");
    Console.ForegroundColor = ConsoleColor.White;
}

int PlayerOneInput()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
    int manticoreDistance = Convert.ToInt16(Console.ReadLine());

    if (manticoreDistance < 0 || manticoreDistance > 100)
    {
        Console.WriteLine("The Manticore must be stationed between 0 and 100 units away from the city. ");
        PlayerOneInput();
    }
    Console.Clear();
    return manticoreDistance;
}

int PlayerTwoShot()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    // Console.WriteLine("Player 2, it is your turn. ");
    Console.Write("Enter desired cannon range: ");
    int cannonRange = Convert.ToInt16(Console.ReadLine());

    if (cannonRange < 0 || cannonRange > 100)
    {
        Console.WriteLine("The cannon range must be between 0 and 100. ");
        PlayerTwoShot();
    }
    return cannonRange;
}

