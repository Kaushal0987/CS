using System;

class Program
{
    static void Main(string[] args)
    {
        // Input the number of marks
        Console.Write("Enter the number of marks: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Initialize the marks array
        int[] marks = new int[n];
        Console.WriteLine("Enter the marks:");

        // Input marks
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Mark {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate minimum, maximum, and average
        int min = marks[0];
        int max = marks[0];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            if (marks[i] < min) min = marks[i];
            if (marks[i] > max) max = marks[i];
            sum += marks[i];
        }

        double average = (double)sum / n;

        // Display the results
        Console.WriteLine($"\nMinimum Marks: {min}");
        Console.WriteLine($"Maximum Marks: {max}");
        Console.WriteLine($"Average Marks: {average:F2}");
    }
}
