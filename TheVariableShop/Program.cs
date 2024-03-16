byte playerScore = 42;                          // Range is from 0 to 255
short teamPoints = 22_679;                      // Range is from -32,768 to 32,767
int totalPlayers = 2_296_532;                   // Range is from -2,147,483,648 to 2,147,483,647
long totalPopulation = 7_700_000_000;           // Range is from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
sbyte temperature = -23;                        // Range is from -128 to 127
ushort totalVotes = 65_535;                     // Range is from 0 to 65,535
uint totalVoters = 1_234_567;                   // Range is from 0 to 4,294,967,295
ulong totalStars = 9_461_000_000_000_000_000;   // Range is from 0 to 18,446,744,073,709,551,615
float pi = 3.141592653589793238f;               // Range is from -3.402823e38 to 3.402823e38
double pi2 = 3.141592653589793238;              // Range is from -1.79769313486232e308 to 1.79769313486232e308
decimal pi3 = 3.141592653589793238m;            // Range is from -79228162514264337593543950335 to 79228162514264337593543950335
char grade = 'A';                               // Range is from U+0000 to U+ffff
bool isPass = true;                             // Can only be true or false
string name = "John Doe";                       // Can only be a string of characters

Console.WriteLine(playerScore);
Console.WriteLine(teamPoints);
Console.WriteLine(totalPlayers);
Console.WriteLine(totalPopulation);
Console.WriteLine(temperature);
Console.WriteLine(totalVotes);
Console.WriteLine(totalVoters);
Console.WriteLine(totalStars);
Console.WriteLine(pi);
Console.WriteLine(pi2);
Console.WriteLine(pi3);
Console.WriteLine(grade);
Console.WriteLine(isPass);
Console.WriteLine(name);
