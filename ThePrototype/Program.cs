Console.Title = "The Prototype";

// Welcome message, Set Font color to Red for Player 1
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;

int userOnePosition = AskForRange("User 1, enter a number between 0 and 100: ", 0, 100); // New shorter way to get user input suggested in level 13 using a method defined below

// Console.Write("User 1, enter a number between 0 and 100: ");
// int userOnePosition = Convert.ToInt16(Console.ReadLine()); // Assign user input to userOnePosition

// // Validate user input
// while (userOnePosition < 0 || userOnePosition > 100)
// {
//     Console.WriteLine("Invalid number, please enter a number between 0 and 100");
//     userOnePosition = Convert.ToInt16(Console.ReadLine());
// }

// Clear the console and reset the font color
Console.ResetColor();
Console.Clear();

// Set Font color to Blue for Player 2
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("User 2, Guess the number.");

// Console.Write("What is your guess? ");
// int userTwoGuess = Convert.ToInt16(Console.ReadLine()); // Assign user input to userTwoGuess

int userTwoGuess = AskForNumber("What is your guess? "); // New shorter way to get user input suggested in level 13 using a method defined below

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
    userTwoGuess = AskForNumber("What is your guess? "); // New shorter way to get user input suggested in level 13 using a method defined below


    // Console.Write("What is your guess? ");
    // userTwoGuess = Convert.ToInt16(Console.ReadLine());
}

// Return to user when they make correct guess and reset the font color
Console.WriteLine("Congratulations! You guessed the number!");
Console.ResetColor();

// Defined methods for getting and validation user input as suggested in level 13
int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AskForRange(string text, int min, int max)
{
    int number = AskForNumber(text);
    while (number < min || number > max)
    {
        Console.WriteLine($"Number must be between {min} and {max}");
        number = AskForNumber(text);
    }
    return number;
}