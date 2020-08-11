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
    public partial class Add_Department : Form
    {
        public Add_Department()
        {
            InitializeComponent();
        }

        private void Add_dept_Click(object sender, EventArgs e)
        {
            if(name_textbox.Text == "")
            {
                MessageBox.Show("Please insert data in textbox");
                return;
            }

            Department department = new Department();
            department.name = name_textbox.Text.ToString();

            if (Database.insertdepartment(department))
                MessageBox.Show("Department Added Sucessfully!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
