Console.WriteLine("How many estates do you have?");
int estates = (Convert.ToUInt16(Console.ReadLine()));
Console.WriteLine("How many duchies do you have?");
int duchies = (Convert.ToUInt16(Console.ReadLine())) * 3;
Console.WriteLine("How many provinces do you have?");
int provinces = (Convert.ToUInt16(Console.ReadLine())) * 6;
int total = estates + duchies + provinces;
Console.WriteLine("Your kindom's total is " + total);