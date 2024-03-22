Console.Title = "The Prototype";

// Welcome message, Set Font color to Red for Player 1
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("User 1, enter a number between 0 and 100: ");
int userOnePosition = Convert.ToInt16(Console.ReadLine()); // Assign user input to userOnePosition

// Validate user input
while (userOnePosition < 0 || userOnePosition > 100)
{
    Console.WriteLine("Invalid number, please enter a number between 0 and 100");
    userOnePosition = Convert.ToInt16(Console.ReadLine());
}

// Clear the console and reset the font color
Console.ResetColor();
Console.Clear();

// Set Font color to Blue for Player 2
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("User 2, Guess the number.");
Console.Write("What is your guess? ");
int userTwoGuess = Convert.ToInt16(Console.ReadLine()); // Assign user input to userTwoGuess

// Validate user input And check if the userTwoGuess is equal to userOnePosition
while (userTwoGuess != userOnePosition)
{
    if (userTwoGuess < userOnePosition)
    {
        Console.WriteLine($"{userTwoGuess} is too low.");
    }
    else
    {
        Console.WriteLine($"{userTwoGuess} is too high.");
    }

    Console.Write("What is your guess? ");
    userTwoGuess = Convert.ToInt16(Console.ReadLine());
}

// Return to user when they make correct guess and reset the font color
Console.WriteLine("Congratulations! You guessed the number!");
Console.ResetColor();