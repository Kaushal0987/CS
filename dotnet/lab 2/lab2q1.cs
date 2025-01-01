
using System;

namespace EmployeeApp
{
    // Employee class definition
    public class Employee
    {
        // Fields for the Employee class
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        // Constructor to initialize the Employee object
        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee employee = new Employee("Bijay Koirala", "bijay@gmail.com", 10000);

            // Display the details of the employee
            Console.WriteLine("Employee Details:");
            employee.DisplayEmployeeDetails();

            // Keep the console open
            Console.ReadLine();
        }
    }
}
