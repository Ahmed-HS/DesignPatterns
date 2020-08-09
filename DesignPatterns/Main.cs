using MySql.Data.MySqlClient;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Your query,
            string query = "SELECT * FROM departments";

            List<List<string>> result = Database.SelectQuery(query);

            if (result == null)
            {
                return;
            }
            foreach (List<String> row in result)
            {
                string output = "";
                foreach (string field in row)
                {
                    output += field + " ";
                }

                MessageBox.Show(output);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database.insertdepartment(new Department("Ahmed"));
        }
    }
}
