
// Original version

// Console.WriteLine("Enter a number and I'll tell you if it should make the clock tick, or tock: ");
// bool isEven = Convert.ToInt32(Console.ReadLine()) % 2 == 0;

// if (isEven)
// {
//     Console.WriteLine("tick");
// }
// else
// {
//     Console.WriteLine("tock");
// }

// Shortened version
Console.WriteLine("Enter a number and I'll tell you if it should make the clock tick, or tock: ");
Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 2 == 0 ? "tick" : "tock");