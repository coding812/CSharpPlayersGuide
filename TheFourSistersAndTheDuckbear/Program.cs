Console.WriteLine("How Many chocolate eggs will be devided up today?");
// The number of eggs will be devided by 4 sisters and Duckbear will have the remainder should the total not be even.
// Convert the input to an integer and store it in a variable called eggs
int eggs = Convert.ToInt16(Console.ReadLine());
// Calculate the number of eggs each sister will get and the remainder
float eggsPerPerson = eggs / 4;
float remainder = eggs % 4;
// Output the results
Console.WriteLine("Each sister will get " + eggsPerPerson + " eggs and there will be " + remainder + " left over for the Duckbear.");
// Duckbear would get more eggs than the sisters if the total were ever less than 4.