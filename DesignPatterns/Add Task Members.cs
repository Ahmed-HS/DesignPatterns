using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class AddTaskMembersForm : Form
    {
        private List<Dictionary<string, string>> tasksTable;
        private List<Dictionary<string, string>> projectsTable;
        private List<Dictionary<string, string>> departmentMembersTable;
        private List<Dictionary<string, string>> taskMembersTable;
        private string taskIDSending;
        public AddTaskMembersForm()
        {
            InitializeComponent();
        }

        private void UpdateMembersForm_Load(object sender, EventArgs e)//from projectID get departmentID and memberID from departmentmembertable
        {
            tasksTable = Database.SelectQuery("select ID, title, projectID from tasks;");
            if (tasksTable == null) return;
            for (int i = 0; i < tasksTable.Count; ++i) TaskIDCmbBox.Items.Add(tasksTable[i]["title"]);
            AddMembersTxtBox.Text = "";
            AddMembersTxtBox.ReadOnly = true;
        }

        private string FindTaskID(List<Dictionary<string, string>> table, string taskName)
        {
            for (int i = 0; i < table.Count; ++i)
                if (table[i]["title"] == taskName)
                    return table[i]["ID"];
            return null;
        }

        private string FindProjectIDFromTasks(List<Dictionary<string,string>> table, string taskID)
        {
            for (int i = 0; i < tasksTable.Count; ++i)
                if (table[i]["ID"] == taskID)
                    return table[i]["projectID"];
            return null;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TaskIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberIDCmbBox.Items.Clear();
            AddMembersTxtBox.Text = "";
            AddMembersTxtBox.ReadOnly = true;
            RemoveMemberCmbBox.Items.Clear();
            string taskID = FindTaskID(tasksTable, TaskIDCmbBox.Text);
            if (taskID == null) return;
            string projectID = FindProjectIDFromTasks(tasksTable, taskID);
            if (projectID == null) return;
            projectsTable = Database.SelectQuery($"select departmentID from projects where ID = '{projectID}';");
            if (projectsTable == null) return;
            string departmentID = projectsTable[0]["departmentID"];
            departmentMembersTable = Database.SelectQuery($"select memberID from departmentmember where departmentID = '{departmentID}';");
            if (departmentMembersTable == null) return;
            List<string> eligible = new List<string>();
            for (int i = 0; i < departmentMembersTable.Count; ++i)
                eligible.Add(departmentMembersTable[i]["memberID"]);
            taskMembersTable = Database.SelectQuery($"select memberID from membertasks where taskID = '{taskID}';");
            List<string> exisiting = new List<string>();
            if(taskMembersTable != null)
                for (int i = 0; i < taskMembersTable.Count; ++i)
                    exisiting.Add(taskMembersTable[i]["memberID"]);
            MemberIDCmbBox.Items.AddRange(eligible.Except(exisiting).ToList().ToArray());
            taskIDSending = taskID;
        }

        private void MemberIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddMembersTxtBox.Text += " " + MemberIDCmbBox.SelectedItem + " ";
            RemoveMemberCmbBox.Items.Add(MemberIDCmbBox.SelectedItem);
            MemberIDCmbBox.Items.Remove(MemberIDCmbBox.SelectedItem);
        }

        private void RemoveMemberCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberIDCmbBox.Items.Add(RemoveMemberCmbBox.SelectedItem);
            char[] delimiter = { ' ' };
            string[] str = AddMembersTxtBox.Text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            List<string> strList = new List<string>(str);
            strList.Remove(RemoveMemberCmbBox.SelectedItem.ToString());
            AddMembersTxtBox.Text = String.Join(" ", strList.ToArray());
            RemoveMemberCmbBox.Items.Remove(RemoveMemberCmbBox.SelectedItem);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (taskIDSending == null) return;
            if (AddMembersTxtBox.Text.Trim() == "") return;
            List<bool> sending = new List<bool>();
            char[] delimiter = { ' ' };
            foreach(string member in AddMembersTxtBox.Text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries))
                sending.Add(Database.insertTaskMember(taskIDSending, member));
            if (sending.Contains(false))
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Member added!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
