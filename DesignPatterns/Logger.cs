using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface TasksLogger
    {
        void logAllTasksStatus();
        void logProjectTaskStatus(int projectID);


    }

    public class SimpleLogger : TasksLogger
    {
        public void logAllTasksStatus()
        {
            List<Task> allTasks = Database.getAllTasks();
            if (allTasks == null)
            {
                return;
            }
            logTasks(allTasks);

        }

        public void logProjectTaskStatus(int projectID)
        {
            List<Task> tasksToLog = Database.getProjectTaskByID(projectID);
            if (tasksToLog == null)
            {
                return;
            }
            logTasks(tasksToLog);
        }

        private void logTasks(List<Task> tasks)
        {

            string toLog = "-----------------------------\n";

            foreach (Task task in tasks)
            {
                toLog += $"Task ID: {task.ID} , Status: {task.status}\n";
            }

            toLog += "-----------------------------\n";

            using (StreamWriter w = File.AppendText("simpleLog.txt"))
            {
                w.Write(toLog);
            }
        }
    }


    public class DetailedLogger : TasksLogger
    {
        public void logAllTasksStatus()
        {
            List<Task> allTasks = Database.getAllTasks();
            if (allTasks == null)
            {
                return;
            }
            logTasks(allTasks);
        }

        public void logProjectTaskStatus(int projectID)
        {
            List<Task> tasksToLog = Database.getProjectTaskByID(projectID);
            if (tasksToLog == null)
            {
                return;
            }
            logTasks(tasksToLog);
        }


        private void logTasks(List<Task> tasks)
        {

            foreach (Task task in tasks)
            {
                using (StreamWriter w = File.AppendText("detailedLog.txt"))
                {
                    log(task, w);
                }
            }

        }

        private string getMembersWorkingOnTask(int taskID)
        {
            List<Member> members = Database.getTaskMembersByID(taskID);
            if (members == null)
            {
                return "No members are currently working on this task";
            }

            string result = "ID    Name   Email   Phone\n";

            foreach (Member member in members)
            {
                result += member.ToString() + "\n";
            }

            return result;
            
        }

        private void log(Task task, TextWriter w)
        {
            w.Write("Task log Entry : \n");
            w.WriteLine($"Current time: {DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine($"Task title : {task.title}");
            w.WriteLine($"Status : {task.status}");
            w.WriteLine($"Start date : {task.fromDate}");
            w.WriteLine($"Due date : {task.toDate}");
            w.WriteLine($"************* Members working on this task *************");
            w.Write(getMembersWorkingOnTask(task.ID));
            w.WriteLine($"************* Owning project and departement *************");
            Project parent = Database.getProjectByID(task.ProjectID);
            w.WriteLine(parent.ToString());
            w.WriteLine(Database.getDepartmentByID(parent.departmentID).ToString());
            w.WriteLine("============================================");
        }
    }
}
