/* Re-wrote program with descriptive variable names 
    Also commented what each line does*/
string ofDoom = "of Doom";
string modelNumber = "3000";
// Prompt user for input and assign to variable
Console.WriteLine("What kind of thing are we talking about?");
string thing = Console.ReadLine();
// Prompt user for input and assign to variable
Console.WriteLine("how would you describe it? Big? Azure? Tattered?");
string description = Console.ReadLine();
// Print out the result of all variables to the console
Console.WriteLine("The " + description + " " + thing + " " + ofDoom + " " + modelNumber + "!");
