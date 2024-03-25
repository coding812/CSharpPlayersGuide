int AskForNumber(string text)
{
    Console.WriteLine(text);
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