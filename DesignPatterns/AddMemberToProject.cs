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
    public partial class AddMemberToProject : Form
    {
        List<int> projectIDs;
        List<int> memberIDS;
        public AddMemberToProject()
        {
            InitializeComponent();
        }

        private void AddMemberToProject_Load(object sender, EventArgs e)
        {
            projectIDs = new List<int>();
            memberIDS = new List<int>();
            var projects = Database.SelectQuery("Select * from projects");
            foreach (Dictionary<string, string> project in projects)
            {
                comboBox1.Items.Add(project["name"]);
                projectIDs.Add(int.Parse(project["ID"]));
            }

            var members = Database.SelectQuery("Select * from members");
            foreach (Dictionary<string, string> member in members)
            {
                comboBox2.Items.Add(member["name"]);
                memberIDS.Add(int.Parse(member["ID"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int projectID = projectIDs[comboBox1.SelectedIndex];
            int memberID = memberIDS[comboBox2.SelectedIndex];

            Database.CRUDQuery($"INSERT INTO `memberprojects` (`memberID`, `projectID`) VALUES ('{memberID}', '{projectID}');");
        }
    }
}
