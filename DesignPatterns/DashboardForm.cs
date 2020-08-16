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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewTasksForm tasksForm = new ViewTasksForm();
            tasksForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            logForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddTaskMembersForm addTaskMembersForm = new AddTaskMembersForm();
            addTaskMembersForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddResourceForm r = new AddResourceForm();
            r.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RemoveResourceForm r = new RemoveResourceForm();
            r.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RemoveTaskForm r = new RemoveTaskForm();
            r.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RemoveTaskMemberForm r = new RemoveTaskMemberForm();
            r.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateTaskStatus u = new UpdateTaskStatus();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTaskForm a = new AddTaskForm();
            a.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Add_Project addProject = new Add_Project();
            addProject.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Add_Department addDepartment = new Add_Department();
            addDepartment.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new AddMembertodep().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new AddMemberToProject().Show();
        }
    }
}
