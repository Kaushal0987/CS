using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number to print its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Print the multiplication table
        Console.WriteLine($"\nMultiplication Table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
