/* using System;

// Base class: Shape
class Shape
{
    public int Length { get; set; }
    public int Breadth { get; set; }

    // Default Constructor
    public Shape()
    {
        Length = 0;
        Breadth = 0;
    }

    // Parameterized Constructor
    public Shape(int length, int breadth)
    {
        Length = length;
        Breadth = breadth;
    }
}

// Derived class: Rectangle
class Rectangle : Shape
{
    // Constructor inheriting from Shape
    public Rectangle(int length, int breadth) : base(length, breadth) { }

    // Method to calculate area
    public int CalculateArea()
    {
        return Length * Breadth;
    }
}

class Program
{
    static void Main()
    {
        // Create a Rectangle object with length 10 and breadth 5
        Rectangle rect = new Rectangle(10, 5);

        // Display the area of the rectangle
        Console.WriteLine($"Area of Rectangle: {rect.CalculateArea()}"); // Output: 50
    }
}
*/