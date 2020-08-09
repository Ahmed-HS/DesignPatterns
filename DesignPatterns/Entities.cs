using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Department
    {
        public int ID { get; set; }
        public String name { get; set; }

        public Department(String name)
        {
            this.name = name;
        }
    }

    public class Member
    {
        public int ID { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String phoneNumber { get; set; }
        public String addrees { get; set; }
    }

    public class Project
    {
        public int ID { get; set; }
        public String name { get; set; }

        public int departmentID { get; set; }

        public int managerID { get; set; }
    }

    public class Resources
    {
        public int ID { get; set; }
        public String name { get; set; }
        public int taskID { get; set; }
    }

    public class Task
    {
        public int ID { get; set; }
        public String title { get; set; }
        public int ProjectID { get; set; }
        public String fromDate { get; set; }
        public String toDate { get; set; }
        public String status { get; set; }
    }
}
