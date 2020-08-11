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
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=OODP;database=designpatterns;"; //change username and password for your database
        }

        public static bool insertdepartment(Department newDepartment)
        {
            return CRUDQuery($"INSERT INTO departments (`Name`) VALUES ('{newDepartment.name}');");
        }

        public static bool insertMember(Member newMember)
        {
            return CRUDQuery($"INSERT INTO `members` (`name`, `email`, `password`, `phoneNumber`, `address`)" +
                $" VALUES ('{newMember.name}', '{newMember.email}', '{newMember.password}', '{newMember.phoneNumber}', '{newMember.addrees}');");
        }

        public static bool insertTask(Task newTask)
        {
            return CRUDQuery($"INSERT INTO `tasks` (`title`, `fromDate`, `toDate`, `status`, `projectID`)" +
                $" VALUES ('{newTask.title}', '{String.Join("-", newTask.fromDate.Split(' ')[0].Split('/').Reverse())}', '{String.Join("-",newTask.toDate.Split(' ')[0].Split('/').Reverse())}', '{newTask.status}', '{newTask.ProjectID}')");
        }

        public static bool insertTaskMember(string taskID, string memberID)
        {
            return CRUDQuery($"INSERT INTO `membertasks` (`memberID`, `taskID`)" + $" VALUES ('{memberID}', '{taskID}')");
        }

        public static bool removeTaskMember(string taskID, string memberID)
        {
            return CRUDQuery($"DELETE FROM `membertasks` WHERE memberID = '{memberID}' AND taskID = '{taskID}'");
        }

        public static bool updateTaskStatus(string taskID, string status)
        {
            return CRUDQuery($"UPDATE `tasks` SET status = '{status}' WHERE ID = '{taskID}' ");
        }

        public static bool addResource(string resourceName)
        {
            return CRUDQuery($"INSERT INTO `resources` (`name`) VALUES ('{resourceName}')");
        }

        public static bool addResource(string resourceName, string taskID)
        {
            return CRUDQuery($"INSERT INTO `resources` (`name`, `taskID`) VALUES ('{resourceName}', '{taskID}')");
        }

        public static bool removeResource(string resourceID)
        {
            return CRUDQuery($"DELETE FROM `resources` WHERE ID = '{resourceID}'");
        }

        public static bool removeTask(string taskID)
        {
            return CRUDQuery($"UPDATE `resources` SET taskID = null WHERE taskID = '{taskID}' ") &&
                CRUDQuery($"DELETE FROM `membertasks` WHERE taskID = '{taskID}'") &&
                CRUDQuery($"DELETE FROM `tasks` WHERE ID = '{taskID}'");
        }

        // used for insert, update, delete
        public static bool CRUDQuery(string query)
        {

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Succesfully excuted");

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
        public static List<Dictionary<string, string>> SelectQuery(string query)
        {
            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            List<Dictionary<string, string>> result = null;

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
                    result = new List<Dictionary<string, string>>();
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        Dictionary<string, string> row = new Dictionary<string, string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetName(i),reader.GetString(i));
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
