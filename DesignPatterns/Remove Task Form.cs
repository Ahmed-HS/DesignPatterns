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
    public partial class RemoveTaskForm : Form
    {
        private List<Dictionary<string, string>> tasksTable;
        public RemoveTaskForm()
        {
            InitializeComponent();
        }

        private void RemoveTaskForm_Load(object sender, EventArgs e)
        {
            TaskIDCmbBox.Items.Clear();
            tasksTable = Database.SelectQuery("select ID, title from tasks;");
            for (int i = 0; i < tasksTable.Count; ++i) TaskIDCmbBox.Items.Add(tasksTable[i]["title"]);
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

        private void RemoveTaskBtn_Click(object sender, EventArgs e)
        {
            if (TaskIDCmbBox.SelectedItem == null) return;
            if(Database.removeTask(FindTaskID(tasksTable, TaskIDCmbBox.SelectedItem.ToString())))
                MessageBox.Show("Task and all related entries have been removed!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
