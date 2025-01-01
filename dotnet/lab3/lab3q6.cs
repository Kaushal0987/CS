using System;

namespace CustomExceptionExample
{
    // Step 1: Define a custom exception by inheriting from Exception
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Step 2: Throw the custom exception if condition fails
                if (age < 0 || age > 120)
                {
                    throw new InvalidAgeException("Age must be between 0 and 120.");
                }

                Console.WriteLine($"Your age is: {age}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Custom Exception: {ex.Message}");
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
