using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a string array
        Console.Write("Enter the number of strings: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] stringArray = new string[n];

        // Input strings into the array
        Console.WriteLine("Enter the strings:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"String {i + 1}: ");
            stringArray[i] = Console.ReadLine();
        }

        // Convert the string array to a single string
        string result = string.Join(" ", stringArray);

        // Display the result
        Console.WriteLine("\nThe combined string is:");
        Console.WriteLine(result);
    }
}
