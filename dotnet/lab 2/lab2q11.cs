/* using System;

// Generic class
class Box<T>
{
    public T Value { get; set; }
}

// Class with a generic method
class Utils
{
    public void Show<T>(T item)
    {
        Console.WriteLine($"Item: {item}");
    }
}

class Program
{
    static void Main()
    {
        // Using generic class
        Box<int> intBox = new Box<int> { Value = 100 };
        Console.WriteLine($"Box Value: {intBox.Value}"); // Output: Box Value: 100

        // Using generic method
        Utils util = new Utils();
        util.Show("Hello Generics!"); // Output: Item: Hello Generics!
        util.Show(123);              // Output: Item: 123
    }
}
*/