/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQEmployeeFilter
{
    // Employee class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Bijay", Salary = 60000, Address = "Kathmandu" },
                new Employee { Id = 2, Name = "Kaushal", Salary = 45000, Address = "Pokhara" },
                new Employee { Id = 3, Name = "Bibek", Salary = 52000, Address = "Kathmandu" },
                new Employee { Id = 4, Name = "Roshni", Salary = 70000, Address = "Bhaktapur" },
                new Employee { Id = 5, Name = "Game", Salary = 30000, Address = "Kathmandu" }
            };

            // Step 2: Use LINQ to filter employees
            var filteredEmployees = employees
                .Where(e => e.Salary > 50000 && e.Address == "Kathmandu")
                .ToList();

            // Step 3: Display the filtered employees
            Console.WriteLine("Employees with Salary > 50000 and Address = Kathmandu:");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
            }
        }
    }
}
*/