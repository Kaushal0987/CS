/* using System;

class Demo
{
    public string Name;
    public int Age;

    // 1. Default Constructor
    public Demo()
    {
        Name = "Default Name";
        Age = 0;
        Console.WriteLine("Default Constructor Called");
    }

    // 2. Parameterized Constructor
    public Demo(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Parameterized Constructor Called");
    }

    // 3. Copy Constructor
    public Demo(Demo obj)
    {
        Name = obj.Name;
        Age = obj.Age;
        Console.WriteLine("Copy Constructor Called");
    }

    // 4. Static Constructor
    static Demo()
    {
        Console.WriteLine("Static Constructor Called");
    }

    // 5. Private Constructor
    private Demo(string name)
    {
        Name = name;
        Console.WriteLine("Private Constructor Called");
    }

    // Method to display data
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Default Constructor
        Demo obj1 = new Demo();
        obj1.Display();

        // Parameterized Constructor
        Demo obj2 = new Demo("Bijay", 21);
        obj2.Display();

        // Copy Constructor
        Demo obj3 = new Demo(obj2);
        obj3.Display();

        // Static Constructor is automatically invoked when the class is accessed

        // Note: Private constructor can't be used outside its class
    }
}
*/