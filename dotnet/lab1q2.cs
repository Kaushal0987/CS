using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for three integers
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third integer: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum
        int sum = num1 + num2 + num3;

        // Display the sum
        Console.WriteLine("The sum of the three integers is: " + sum);
    }
}
