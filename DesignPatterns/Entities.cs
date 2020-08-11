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

        public Department()
        { }

        public override string ToString()
        {
            return $"Department ID : {ID} , Name : {name}";
        }

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

        private Member()
        { 
        }

        public override string ToString()
        {
            return $"{ID}  , {name}  , {email}  , {phoneNumber}";
        }

        public class Builder : IMemberBuilder
        {
            private Member newMember;

            public Builder()
            {
                reset();
            }

            public void reset()
            {
                newMember = new Member();
            }

            public IMemberBuilder setAddress(string address)
            {
                newMember.addrees = address;
                return this;
            }

            public IMemberBuilder setEmail(string email)
            {
                newMember.email = email;
                return this;
            }

            public IMemberBuilder setName(string name)
            {
                newMember.name = name;
                return this;
            }

            public IMemberBuilder setpassword(string password)
            {
                newMember.password = password;
                return this;
            }

            public IMemberBuilder setphone(string phone)
            {
                newMember.phoneNumber = phone;
                return this;
            }

            public Member build()
            {
                return newMember;
            }

            public IMemberBuilder setID(int ID)
            {
                newMember.ID = ID;
                return this;
            }
        }

    }

    public class Project
    {
        public int ID { get; set; }
        public String name { get; set; }

        public int departmentID { get; set; }

        public int managerID { get; set; }

        public override string ToString()
        {
            return $"Project ID : {ID} , Name : {name}";
        }
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

        private Task()
        { 
        }

        public class Builder : ITaskBuilder
        {
            private Task newTask;

            public Builder()
            {
                reset();
            }

            public void reset()
            {
                newTask = new Task();
            }

            public Task build()
            {
                return newTask;
            }

            public ITaskBuilder setStatus(string status)
            {
                newTask.status = status;
                return this;
            }

            public ITaskBuilder setFromDate(string fromDate)
            {
                newTask.fromDate = fromDate;
                return this;
            }

            public ITaskBuilder setID(int ID)
            {
                newTask.ID = ID;
                return this;
            }

            public ITaskBuilder setProjectID(int projectID)
            {
                newTask.ProjectID = projectID;
                return this;
            }

            public ITaskBuilder setTitle(string title)
            {
                newTask.title = title;
                return this;
            }

            public ITaskBuilder setToDate(string toDate)
            {
                newTask.toDate = toDate;
                return this;
            }
        }
    }
}
