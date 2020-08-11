using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class AddTaskForm : Form
    {
        private List<Dictionary<string, string>> table;
        public AddTaskForm()
        {
            InitializeComponent();
        }
        // the manager should have a widow where they can add task and/or add members to a task;
        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            string[] StatusValues = { "Unstarted", "In Progress", "Done" };
            for (int i = 0; i < StatusValues.Length; ++i) StatusCmbBox.Items.Add(StatusValues[i]);
            table = Database.SelectQuery("select id, name from projects;");
            if (table == null)
                return;
            for (int i = 0; i < table.Count; ++i) ProjectIDCmbBox.Items.Add(table[i]["ID"]);
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (DescriptionTxtBox.Text == "" || ProjectIDCmbBox.SelectedItem.ToString() == "" || StatusCmbBox.SelectedItem.ToString() == "" || ToDatePicker.Value == null || FromDatePicker == null)
            {
                MessageBox.Show("Please Select/Input data into all fields");
                return;
            }
            Task task = new Task();
            task.title = DescriptionTxtBox.Text;
            task.fromDate = FromDatePicker.MinDate.ToString();
            task.toDate = ToDatePicker.MinDate.ToString();
            task.status = StatusCmbBox.SelectedItem.ToString();
            task.ProjectID = FindProjectID(table, ProjectIDCmbBox.SelectedItem.ToString());
            if (Database.insertTask(task))
                MessageBox.Show("Task added!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int FindProjectID(List<Dictionary<string,string>> table, string projectName)
        {
            for (int i = 0; i < table.Count; ++i)
                if (table[i]["ID"] == projectName)
                    return i;
            return -1;
        }
    }
}
