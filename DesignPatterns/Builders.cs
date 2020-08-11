using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IMemberBuilder
    {
        IMemberBuilder setID(int ID);
        IMemberBuilder setName(string name);
        IMemberBuilder setEmail(string email);
        IMemberBuilder setpassword(string password);
        IMemberBuilder setphone(string phone);
        IMemberBuilder setAddress(string address);

        Member build();
    }

    public interface ITaskBuilder
    {
        ITaskBuilder setID(int ID);
        ITaskBuilder setProjectID(int projectID);
        ITaskBuilder setTitle(string title);
        ITaskBuilder setFromDate(string fromDate);
        ITaskBuilder setToDate(string toDate);
        ITaskBuilder setStatus(string status);

        Task build();
    }

}
