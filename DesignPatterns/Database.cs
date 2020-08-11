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
            connectionString = "datasource=127.0.0.1;port=3306;username=Ahmed;password=1234;database=designpatterns;"; //change username and password for your database
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


        public static List<Task> getAllTasks()
        {

            List<Dictionary<string, string>> tasks = SelectQuery("SELECT * FROM tasks");

            if (tasks == null)
            {
                return null;
            }

            List<Task> tasksList = new List<Task>();


            foreach (Dictionary<string, string> row in tasks)
            {
                Task currentTask = new Task.Builder()
                    .setID(int.Parse(row["ID"]))
                    .setTitle(row["title"])
                    .setProjectID(int.Parse(row["projectID"]))
                    .setFromDate(row["fromDate"])
                    .setToDate(row["toDate"])
                    .setStatus(row["status"])
                    .build();

                tasksList.Add(currentTask);
            }

            return tasksList;
        }

        public static List<Task> getProjectTaskByID(int projectID)
        {
            List<Dictionary<string, string>> tasks = SelectQuery($"SELECT * FROM tasks where projectID = {projectID}");

            if (tasks == null)
            {
                return null;
            }


            List<Task> tasksList = new List<Task>();


            foreach (Dictionary<string, string> row in tasks)
            {
                Task currentTask = new Task.Builder()
                    .setID(int.Parse(row["ID"]))
                    .setTitle(row["title"])
                    .setProjectID(int.Parse(row["projectID"]))
                    .setFromDate(row["fromDate"])
                    .setToDate(row["toDate"])
                    .setStatus(row["status"])
                    .build();

                tasksList.Add(currentTask);
            }

            return tasksList;
        }

        public static List<Member> getTaskMembersByID(int taskID)
        {
            List<Dictionary<string, string>> memberIDs = Database.SelectQuery($"SELECT memberID FROM membertasks where taskID = {taskID};");
            string memberSelect = "SELECT * FROM members where ";

            if (memberIDs == null)
            {
                return null;
            }

            foreach (Dictionary<string, string> row in memberIDs)
            {
                memberSelect += $"ID = {row["memberID"]} or ";
            }

            memberSelect = memberSelect.Remove(memberSelect.Length - 3);
            memberSelect += ";";

            List<Dictionary<string, string>> membersResult = Database.SelectQuery(memberSelect);

            List<Member> membersList = new List<Member>();


            foreach (Dictionary<string, string> row in membersResult)
            {
                Member currentMember = new Member.Builder()
                    .setID(int.Parse(row["ID"]))
                    .setEmail(row["email"])
                    .setName(row["name"])
                    .setphone(row["phoneNumber"])
                    .setAddress(row["address"])
                    .build();

                membersList.Add(currentMember);
            }

            return membersList;
        }

        public static Department getDepartmentByID(int departmentID)
        {
            List<Dictionary<string, string>> result = SelectQuery($"SELECT * FROM departments where ID = {departmentID}");
            if (result == null)
            {
                return null;
            }
            Department department = new Department();
            department.ID = int.Parse(result[0]["ID"]);
            department.name = result[0]["Name"];
            return department;
        }

        public static Project getProjectByID(int projectID)
        {
            List<Dictionary<string, string>> result = SelectQuery($"SELECT * FROM projects where ID = {projectID}");
            if (result == null)
            {
                return null;
            }
            Project project = new Project();
            project.ID = int.Parse(result[0]["ID"]);
            project.departmentID = int.Parse(result[0]["departmentID"]);
            project.managerID = int.Parse(result[0]["managerID"]);
            project.name = result[0]["name"];

            return project;
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
