Console.Title = "Countdown";
// Countdown function
// RECURSIVE FUNCTION that will check to see if the number is 0,
// if it is, it will return 0, if not, it will print the number and call itself with the number - 1
// This will continue until the number is 0
void Countdown(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    Countdown(number - 1);
}

Countdown(10);
