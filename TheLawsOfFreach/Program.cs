// Initialize an array of integers and calculate the average of all elements in the array.
int[] array = new int[] { 4, 51, -7, 13, -99, 15, 8, 45, 90 };

int total = 0;

foreach (int i in array)
{
    total += i;
}

float average = (float)total / array.Length;

Console.WriteLine(average);