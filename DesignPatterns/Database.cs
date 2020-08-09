using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    static class Database
    {
        static string connectionString;
        static Database()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=Ahmed;password=1234;database=designpatterns;";
        }

        public static bool insertdepartment(Department newDepartment)
        {
            return CRUDQuery("INSERT INTO departments (`Name`) VALUES ('" + newDepartment.name + "');");
        }


        // used for insert, update, delete
        private static bool CRUDQuery(string query)
        {

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");

                databaseConnection.Close();

                return true;
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // for select queries
        public static List<List<string>> SelectQuery(string query)
        {
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            List<List<string>> result = null;

            // Let's do it !
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    result = new List<List<string>>();
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        List<string> row = new List<string>(reader.FieldCount);

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetString(i));
                        }

                        result.Add(row);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }

            return result;
        }
    
    }
}
