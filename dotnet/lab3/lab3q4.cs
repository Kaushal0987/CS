using System;
using MySql.Data.MySqlClient;

namespace EmployeeDatabase
{
    class Program
    {
        static string connectionString = "Server=localhost;Database=db_employee;User ID=root;Password=;";

        static void Main()
        {
            Console.WriteLine("Choose an operation:\n1. Edit Employee\n2. Delete Employee");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EditEmployee();
                    break;

                case "2":
                    DeleteEmployee();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        // Method to edit (update) an employee's information
        static void EditEmployee()
        {
            Console.Write("Enter EmployeeID to Edit: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter New First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter New Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter New Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter New Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter New Hire Date (yyyy-MM-dd): ");
            string hireDate = Console.ReadLine();

            Console.Write("Enter New Address: ");
            string address = Console.ReadLine();

            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = @"UPDATE tb_Employee 
                                 SET FirstName = @FirstName, 
                                     LastName = @LastName, 
                                     Email = @Email, 
                                     Salary = @Salary, 
                                     HireDate = @HireDate, 
                                     Address = @Address 
                                 WHERE EmployeeID = @EmployeeID";

                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@HireDate", hireDate);
                cmd.Parameters.AddWithValue("@Address", address);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Method to delete an employee
        static void DeleteEmployee()
        {
            Console.Write("Enter EmployeeID to Delete: ");
            int employeeId = int.Parse(Console.ReadLine());

            using MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "DELETE FROM tb_Employee WHERE EmployeeID = @EmployeeID";

                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
