using System;

class Person
{
    // 1. Read-Write Property
    public string Name { get; set; }

    // 2. Read-Only Property
    public int Age { get; } = 25;

    // 3. Write-Only Property
    private string _secret;
    public string Secret { set { _secret = value; } }

    // 4. Auto-Implemented Property
    public string Address { get; set; }

    // 5. Calculated Property
    public string Greeting => $"Hello, {Name}!";
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        // Using properties
        person.Name = "Bijay Koirala";               // Read-Write
        Console.WriteLine(person.Name);     // Output: Bijay

        Console.WriteLine(person.Age);      // Read-Only: Output: 25

        person.Secret = "Secret is I am spiderMan.";       // Write-Only (no access to get)

        person.Address = "Lalbandi 2";      // Auto-Implemented
        Console.WriteLine(person.Address);  

        Console.WriteLine(person.Greeting); // Calculated: Output: Hello, John!
    }
}
