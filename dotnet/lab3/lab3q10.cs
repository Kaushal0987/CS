using System;
using MySql.Data.MySqlClient;

namespace TourismInformation
{
    class Program
    {
        // Update this connection string with your database credentials
        private const string connectionString = "Server=localhost;Database=TourismDB;User ID=root;Password=your_password;";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tourism Information Entry");

            // Prompt the user to enter information
            Console.Write("Enter Tour Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Tour Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Tour Duration (in days): ");
            int duration = int.Parse(Console.ReadLine());

            // Insert data into the database
            SaveTourDestination(title, description, duration);

            Console.WriteLine("Tour information saved successfully!");
        }

        static void SaveTourDestination(string title, string description, int duration)
        {
            try
            {
                // Establish connection with MySQL
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to insert data
                    string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) " +
                                   "VALUES (@Title, @Description, @Duration, NOW())";

                    // Prepare the SQL command
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Duration", duration);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
