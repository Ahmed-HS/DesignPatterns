using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class RemoveTaskMemberForm : Form
    {
        private List<Dictionary<string, string>> tasksTable;
        private List<Dictionary<string, string>> taskMembersTable;
        private string taskIDSending;

        public RemoveTaskMemberForm()
        {
            InitializeComponent();
        }
        private string FindTaskID(List<Dictionary<string, string>> table, string taskName)
        {
            for (int i = 0; i < table.Count; ++i)
                if (table[i]["title"] == taskName)
                    return table[i]["ID"];
            return null;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RemoveTaskMemberForm_Load(object sender, EventArgs e)
        {
            tasksTable = Database.SelectQuery("select ID, title, projectID from tasks;");
            if (tasksTable == null) return;
            for (int i = 0; i < tasksTable.Count; ++i) TaskIDCmbBox.Items.Add(tasksTable[i]["title"]);
        }

        private void TaskIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveMemberCmbBox.Items.Clear();
            string taskID = FindTaskID(tasksTable, TaskIDCmbBox.Text);
            if (taskID == null) return;
            taskMembersTable = Database.SelectQuery($"select memberID from membertasks where taskID = '{taskID}';");
            if (taskMembersTable == null) return;
            for (int i = 0; i < taskMembersTable.Count; ++i)
                RemoveMemberCmbBox.Items.Add(taskMembersTable[i]["memberID"]);
            taskIDSending = taskID;
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            if (RemoveMemberCmbBox.SelectedItem == null) return;
            if(Database.removeTaskMember(taskIDSending, RemoveMemberCmbBox.SelectedItem.ToString()))
                MessageBox.Show("Member removed!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
