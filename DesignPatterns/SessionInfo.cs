using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SessionInfo
    {

        private static SessionInfo info;

        public Member member { get; set; }


        private SessionInfo()
        {
        }


        public static SessionInfo get()
        {
            if (info == null)
            {
                info = new SessionInfo();
            }

            return info;
        }

        public bool isAManagerOf(int projectID)
        {
            List<Dictionary<string, string>> result = Database.SelectQuery($"SELECT * FROM projects where managerID = {member.ID} and ID = {projectID};");
            return result != null;
        }

        public bool isAManager()
        {
            List<Dictionary<string, string>> result = Database.SelectQuery($"SELECT * FROM projects where managerID = {member.ID};");
            return result != null;
        }

        public List<Task> getTasks()
        {
            List<Dictionary<string, string>> taskIDs = Database.SelectQuery($"SELECT taskID FROM membertasks where memberID = {member.ID};");
            string taskSelect = "SELECT * FROM tasks where ";

            if (taskIDs == null)
            {
                return null;
            }

            foreach (Dictionary<string, string> row in taskIDs)
            {
                taskSelect += $"ID = {row["taskID"]} or ";
            }

            taskSelect = taskSelect.Remove(taskSelect.Length - 3);
            taskSelect += ";";

            List<Dictionary<string, string>> tasksResult = Database.SelectQuery(taskSelect);

            List<Task> tasksList = new List<Task>();


            foreach (Dictionary<string, string> row in tasksResult)
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


    }
}
