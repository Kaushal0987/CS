using System;
using MySql.Data.MySqlClient;

namespace CrudExample
{
    class Program
    {
        // Connection string (update with your database credentials)
        private const string connectionString = "Server=localhost;Database=crud_example;User ID=root;Password=;";

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\nCRUD Operations Menu:");
                Console.WriteLine("1. Create (Insert)");
                Console.WriteLine("2. Read (Select)");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Create(); break;
                    case 2: Read(); break;
                    case 3: Update(); break;
                    case 4: Delete(); break;
                    case 5: Console.WriteLine("Exiting..."); break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            } while (choice != 5);
        }

        static void Create()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Position: ");
            string position = Console.ReadLine();

            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO employees (Name, Position, Salary) VALUES (@Name, @Position, @Salary)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Record inserted successfully.");
            }
        }

        static void Read()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM employees";
                MySqlCommand cmd = new MySqlCommand(query, con);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\nEmployees:");
                    Console.WriteLine("ID\tName\tPosition\tSalary");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]}\t{reader["Name"]}\t{reader["Position"]}\t{reader["Salary"]}");
                    }
                }
            }
        }

        static void Update()
        {
            Console.Write("Enter Employee ID to Update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter New Position: ");
            string position = Console.ReadLine();

            Console.Write("Enter New Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE employees SET Name=@Name, Position=@Position, Salary=@Salary WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@Id", id);
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine(rowsAffected > 0 ? "Record updated successfully." : "Employee ID not found.");
            }
        }

        static void Delete()
        {
            Console.Write("Enter Employee ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM employees WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine(rowsAffected > 0 ? "Record deleted successfully." : "Employee ID not found.");
            }
        }
    }
}
