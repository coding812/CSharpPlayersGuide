for (int blast = 1; blast <= 100; blast++)
{
    if (blast % 3 == 0 && blast % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{blast}: Electric and Fire");
        Console.ResetColor();
    }
    else if (blast % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{blast}: Fire");
        Console.ResetColor();
    }
    else if (blast % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{blast}: Electric");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine($"{blast}: Normal");
    }
}


// for (int blast = 1; blast <= 100; blast++)
// {
//     string blastType;
//     blastType = (blast % 3 == 0 && blast % 5 == 0) ? "Electric and Fire" :
//                 (blast % 3 == 0) ? "Fire" :
//                 (blast % 5 == 0) ? "Electric" : "Normal";
//     Console.WriteLine($"{blast}: {blastType}");
// }