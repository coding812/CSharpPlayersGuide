Console.WriteLine("I am a C# program that will help you determine the area of a triangle!");
// Prompt the user to enter the base of the triangle and assign to a variable
Console.WriteLine("Please enter the base of the triangle: ");
double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
// prompt the user to enter the height of the triangle and assign to a variable
Console.WriteLine("Please enter the height of the triangle: ");
double heightOfTriangle = Convert.ToDouble(Console.ReadLine());
// Assign the area of the triangle to a variable and print it to the console
double areaOfTriangle = (baseOfTriangle * heightOfTriangle) / 2;
Console.WriteLine("The area of the triangle is: " + areaOfTriangle);