using System; // Necessary directive
using MySql.Data.MySqlClient; // Required for MySQL operations

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Database connection string (update credentials if necessary)
            string connectionString = "Server=localhost;Database=db_employee;User ID=root;Password=;";

            try
            {
                // Insert a new employee
                InsertEmployee(connectionString, "Bijay", "Koirala", "bijaykoirala@game.com", 55000.00m, "2024-01-01", "Ktm Sahar");

                // Retrieve and display all employees
                SelectEmployees(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Insert a new employee into the database
        static void InsertEmployee(string connectionString, string firstName, string lastName, string email, decimal salary, string hireDate, string address)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = @"INSERT INTO tb_Employee (FirstName, LastName, Email, Salary, HireDate, Address) 
                             VALUES (@FirstName, @LastName, @Email, @Salary, @HireDate, @Address);";

            using MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@HireDate", hireDate);
            cmd.Parameters.AddWithValue("@Address", address);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"{rows} row(s) inserted successfully.");
        }

        // Select and display all employees
        static void SelectEmployees(string connectionString)
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "SELECT EmployeeID, FirstName, LastName, Email, Salary, HireDate, Address FROM tb_Employee";

            using MySqlCommand cmd = new MySqlCommand(query, conn);
            using MySqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Employee Records:");
            Console.WriteLine("ID\tFirstName\tLastName\tEmail\t\t\tSalary\t\tHireDate\tAddress");

            while (reader.Read())
            {
                Console.WriteLine($"{reader["EmployeeID"]}\t{reader["FirstName"]}\t{reader["LastName"]}\t{reader["Email"]}\t{reader["Salary"]}\t{reader["HireDate"]}\t{reader["Address"]}");
            }
        }
    }
}
