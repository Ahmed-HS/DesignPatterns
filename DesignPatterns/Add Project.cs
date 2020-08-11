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
    public partial class Add_Project : Form
    {
        public Add_Project()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_pro_Click(object sender, EventArgs e)
        {
            if (name_textbox.Text == "" || deptID_textbox.Text == "" || managerID_textbox.Text == "")
            {
                MessageBox.Show("Please insert data in each textbox");
                return;
            }

            Project project = new Project();
            project.name = name_textbox.Text.ToString();
            project.departmentID = int.Parse(deptID_textbox.Text);
            project.managerID = int.Parse(managerID_textbox.Text);

            if (Database.insertProject(project))
                MessageBox.Show("Project Added Sucessfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Manager_id_Click(object sender, EventArgs e)
        {

        }
    }
}
