using System;

class Program
{
    static void Main(string[] args)
    {
        // Take the first number as input
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Take the second number as input
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Take the operator as input
        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar; // Reads a single character input
        Console.WriteLine();

        // Perform the operation based on the input
        double result;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid operator entered.");
                break;
        }
    }
}
