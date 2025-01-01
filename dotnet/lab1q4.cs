using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for principal, time, and rate
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principal * time * rate) / 100;

        // Display the result
        Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}
