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
    public partial class ViewTasksForm : Form
    {
        public ViewTasksForm()
        {
            InitializeComponent();

            List<Task> tasks = SessionInfo.get().getTasks();
            if (tasks != null)
            {
                foreach (Task task in tasks)
                {
                    Project project = Database.getProjectByID(task.ProjectID);
                    dataGridView1.Rows.Add(task.ID, task.title, task.fromDate, task.toDate, project.name, task.status);
                }
            }

        }

        private void addTask(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.Show();
        }
    }
}
