using System;

class Program
{
    static void Main(string[] args)
    {
        // Take input for the first number
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Take input for the second number
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Print the original values
        // Console.WriteLine("\nBefore Swapping:");
        // Console.WriteLine("First Number: " + num1);
        // Console.WriteLine("Second Number: " + num2);

        // Swap the numbers
        int temp = num1;
        num1 = num2;
        num2 = temp;

        // Print the swapped values
        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("First Number: " + num1);
        Console.WriteLine("Second Number: " + num2);
    }
}
