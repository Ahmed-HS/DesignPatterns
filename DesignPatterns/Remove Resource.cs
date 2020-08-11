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
    public partial class RemoveResourceForm : Form
    {
        List<Dictionary<string, string>> resourceTable;
        public RemoveResourceForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RemoveResourceForm_Load(object sender, EventArgs e)
        {
            ResourceCmbBox.Items.Clear();
            resourceTable = Database.SelectQuery("select ID, name from resources;");
            if (resourceTable == null) return;
            for (int i = 0; i < resourceTable.Count; ++i)
                ResourceCmbBox.Items.Add(resourceTable[i]["name"]);
        }

        private string FindResourceID(List<Dictionary<string, string>> table, string resourceName)
        {
            for (int i = 0; i < table.Count; ++i)
                if (table[i]["name"] == resourceName)
                    return table[i]["ID"];
            return null;
        }

        private void RemoveResourceBtn_Click(object sender, EventArgs e)
        {
            if (ResourceCmbBox.SelectedItem == null) return;
            if(Database.removeResource(FindResourceID(resourceTable, ResourceCmbBox.SelectedItem.ToString())))
                MessageBox.Show("Resource removed!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error Has Occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
