
// Namespace 1: Contains the class
namespace NamespaceOne
{
    public class Employee
    {
        // Fields
        public string Name;
        public double Salary;

        // Constructor
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Method
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
}

// Namespace 2: Accessing the class from NamespaceOne
namespace NamespaceTwo
{
    using NamespaceOne; // Importing NamespaceOne

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Employee class
            Employee emp = new Employee("Bijay", 10000);

            // Access fields and methods
            Console.WriteLine("Accessing from NamespaceTwo:");
            emp.DisplayDetails();

            Console.ReadLine(); // Keeps the console open
        }
    }
}
