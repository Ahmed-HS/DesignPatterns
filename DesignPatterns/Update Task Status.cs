using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class UpdateTaskStatus : Form
    {
        private List<Dictionary<string, string>> table;
        private string taskIDSending;
        public UpdateTaskStatus()
        {
            InitializeComponent();
        }

        private void UpdateTaskStatus_Load(object sender, EventArgs e)
        {
            //string[] StatusValues = { "Unstarted", "In Progress", "Done" };
            //for (int i = 0; i < StatusValues.Length; ++i) StatusCmbBox.Items.Add(StatusValues[i]);
            table = Database.SelectQuery("select ID, title, status from tasks;");
            if (table == null) return;
            for (int i = 0; i < table.Count; ++i) TaskIDCmbBox.Items.Add(table[i]["title"]);
        }
        private string FindTaskID(List<Dictionary<string, string>> table, string taskName)
        {
            for (int i = 0; i < table.Count; ++i)
                if (table[i]["title"] == taskName)
                    return table[i]["ID"];
            return null;
        }

        private void TaskIDCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusCmbBox.Items.Clear();
            CurrentStatusLbl.Text = "Current Status: ";
            string taskID = FindTaskID(table, TaskIDCmbBox.Text);
            string currentStatus = null;
            if (taskID == null) return;
            List<string> statusValues = new List<string>() { "unstarted", "in progress", "done" };
            for (int i = 0; i < table.Count; ++i)
                if (table[i]["ID"] == taskID)
                {
                    currentStatus = capitalize(table[i]["status"].ToLower().Trim());
                    statusValues.Remove(table[i]["status"].ToLower().Trim());
                }
            StatusCmbBox.Items.AddRange(statusValues.ToArray());
            if(currentStatus != null)
            {
                CurrentStatusLbl.Text += capitalize(currentStatus);
                CurrentStatusLbl.Visible = true;
            }
            taskIDSending = taskID;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string capitalize(string word)
        {
            char[] delimiter = { ' ' };
            string[] str = word.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            str[0] = Char.ToUpper(str[0][0]) + str[0].Substring(1);
            if (str.Length > 1)
                str[1] = Char.ToUpper(str[1][0]) + str[1].Substring(1);
            return String.Join(" ",str);
        }

        private void UpdateStatusBtn_Click(object sender, EventArgs e)
        {
            if (StatusCmbBox.SelectedItem == null) return;
            if (Database.updateTaskStatus(taskIDSending, capitalize(StatusCmbBox.SelectedItem.ToString())))
                MessageBox.Show("Task status updated!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
