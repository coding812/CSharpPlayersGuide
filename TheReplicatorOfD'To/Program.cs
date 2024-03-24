Console.Title = "The Replicator of D'To";

// Create an array of integers with a length of 5
int[] firstArray = new int[5]; 
// Prompt the user to enter five numbers
Console.WriteLine("Enter five numbers pressing enter after each number:"); 
// Loop through the array and assign the user input to each element
for (int index = 0; index < firstArray.Length; index++)
{
    firstArray[index] = Convert.ToInt32(Console.ReadLine());
}

// Create a second array of integers with the same length as the first array
// and copy the elements from the first array to the second array
int[] secondArray = new int[firstArray.Length];
for (int index = 0; index < firstArray.Length; index++)
{
    secondArray[index] = firstArray[index];
}

// Display the elements of the first and second arrays
// using a loop
Console.Write("The first array is: ");
for (int index = 0; index < firstArray.Length; index++)
{
    Console.Write(firstArray[index]);
}

Console.WriteLine();

Console.Write("The second array is: ");
for (int index = 0; index < secondArray.Length; index++)
{
    Console.Write(secondArray[index]);
}