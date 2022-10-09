using System;
using Microsoft.Data.Sqlite;


namespace simply_together
{
    

    internal class DatabaseManager
    {
        /// <summary>
        /// Creates a database with a table if it doesn't exist.
        /// </summary>
        /// <param name="connectionString"></param>
        internal void CreateTable(string connectionString)
        {
            using (var connection = new SqliteConnection(connectionString))
            {

                using (var tableCmd = connection.CreateCommand())
                {
                    connection.Open();

                    tableCmd.CommandText =
                        @"CREATE TABLE IF NOT EXISTS habits (
                          Id INTEGER PRIMARY KEY AUTOINCREMENT,
                          Activity TEXT,
                          Type TEXT,
                          Participants TEXT
                          Price TEXT
                          Link TEXT
                          Key TEXT
                          Accessibility TEXT
                        )";
                    
                    tableCmd.ExecuteNonQuery(); 
                }



            }
        }
    }
}











