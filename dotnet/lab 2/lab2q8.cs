/* using System;

class Number
{
    public int Value;

    public Number(int value)
    {
        Value = value;
    }

    // Arithmetic Operators
    public static Number operator +(Number a, Number b)
    {
        return new Number(a.Value + b.Value);
    }

    public static Number operator -(Number a, Number b)
    {
        return new Number(a.Value - b.Value);
    }

    public static Number operator *(Number a, Number b)
    {
        return new Number(a.Value * b.Value);
    }

    public static Number operator /(Number a, Number b)
    {
        return new Number(a.Value / b.Value);
    }

    // Comparison Operators
    public static bool operator >(Number a, Number b)
    {
        return a.Value > b.Value;
    }

    public static bool operator <(Number a, Number b)
    {
        return a.Value < b.Value;
    }

    // Equality Operators
    public static bool operator ==(Number a, Number b)
    {
        return a.Value == b.Value;
    }

    public static bool operator !=(Number a, Number b)
    {
        return a.Value != b.Value;
    }

}

class Program
{
    static void Main()
    {
        Number num1 = new Number(20);
        Number num2 = new Number(10);

        // Arithmetic
        Console.WriteLine((num1 + num2).Value); // Output: 30
        Console.WriteLine((num1 - num2).Value); // Output: 10
        Console.WriteLine((num1 * num2).Value); // Output: 200
        Console.WriteLine((num1 / num2).Value); // Output: 2

        // Comparison
        Console.WriteLine(num1 > num2); // Output: True
        Console.WriteLine(num1 < num2); // Output: False

        // Equality
        Console.WriteLine(num1 == num2); // Output: False
        Console.WriteLine(num1 != num2); // Output: True
    }
}
*/