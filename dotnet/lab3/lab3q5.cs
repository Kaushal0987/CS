using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Code that may cause an exception
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                int result = 100 / number; // Might cause DivideByZeroException
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}
