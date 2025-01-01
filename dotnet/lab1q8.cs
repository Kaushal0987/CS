using System;

class Program
{
    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a string to reverse: ");
        string input = Console.ReadLine();

        // Initialize an empty string for the reversed result
        string reversed = "";

        // Loop through the string in reverse order
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i]; // Add each character to the reversed string
        }

        // Display the reversed string
        Console.WriteLine("Reversed string: " + reversed);
    }
}
