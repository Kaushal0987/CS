using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Prompt the user for their address
        Console.Write("Enter your address: ");
        string address = Console.ReadLine();

        // Prompt the user for their email
        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        // Print the details on separate lines
        Console.WriteLine("\nHere are your details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Email: " + email);
    }
}
