/*using System;
using System.Data.SqlClient;

class Class3
{
    static void Main(string[] args)
    {
        string connectionString = "Server=localhost;Integrated Security=true;"; // Change to your connection string

        // Establish connection to the SQL Server
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            Console.WriteLine("Connected to the database successfully.");

            // Create a new table if it doesn't exist
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Students (
                                        ID INT PRIMARY KEY,
                                        Name NVARCHAR(100)
                                        )";
            using (SqlCommand command = new SqlCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Table 'Students' created successfully.");
            }

            // Insert data into the table
            string insertQuery = "INSERT INTO Students (ID, Name) VALUES (1, 'John Doe')";
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Record inserted successfully.");
            }

            // Query data from the table
            string selectQuery = "SELECT * FROM Students";
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["Name"]}");
                }
            }
        }
    }
}
*/