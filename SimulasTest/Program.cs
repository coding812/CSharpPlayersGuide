Console.Title = "Simula's Test";
// Set initial state of the chest
Chest currentChestState = Chest.locked;

// Loop forever until the user closes the console
while (true)
{
    currentChestState = ChestState(currentChestState);
}

// Method to handle the state of the chest
static Chest ChestState(Chest current)
{
    Console.Write($"Chest is {current}. What would you like to do? ");
    // Get user input and convert to lowercase
    Chest userInput = Console.ReadLine()?.ToLower() switch
        {   
            // Set the state of the chest based on user input
            "open" => Chest.open,
            "close" => Chest.closed,
            "lock" => Chest.locked,
            "unlock" => Chest.unlocked,
            _ => current // If the user input is invalid, keep the current state
        };
    // If the user input is the same as the current state, return the current state
    if (userInput == current)
    {
        return current;
    }
    // Checks for impossible states such as opening a locked chest without unlocking first.
    else
    {
        // Cant open a locked chest
        if(userInput == Chest.open && current == Chest.locked)
        {
            return current;
        }
        // Cant close a locked or unlocked chest
        else if(userInput == Chest.closed && current == Chest.locked || userInput == Chest.closed && current == Chest.unlocked)
        {
            return current;
        }
        // Cant lock or unlock an open chest
        else if(userInput == Chest.locked && current == Chest.open || userInput == Chest.unlocked && current == Chest.open)
        {
            return current;
        }
        else
        {
            return userInput; // if the state is possible, return the new state
        }
    }
}
// Enum to represent the state of the chest
enum Chest {open, closed, locked, unlocked}
