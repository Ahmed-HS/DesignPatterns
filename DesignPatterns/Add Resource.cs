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
    public partial class AddResourceForm : Form
    {
        private List<Dictionary<string, string>> tasksTable;
        public AddResourceForm()
        {
            InitializeComponent();
        }

        private void AddResourceForm_Load(object sender, EventArgs e)
        {
            tasksTable = Database.SelectQuery("select ID, title from tasks;");
            if (tasksTable == null) return;
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

        private void AddResourceBtn_Click(object sender, EventArgs e)
        {
            if (ResourceNameTxtBox.Text == "") return;
            if(TaskIDCmbBox.SelectedItem != null)
            {
                if(Database.addResource(ResourceNameTxtBox.Text, FindTaskID(tasksTable,TaskIDCmbBox.SelectedItem.ToString())))
                    MessageBox.Show("Resource added!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Database.addResource(ResourceNameTxtBox.Text))
                    MessageBox.Show("Resource added!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
