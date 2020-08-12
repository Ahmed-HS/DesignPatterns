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
    public partial class AddMembertodep : Form
    {
        public AddMembertodep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.CRUDQuery($"INSERT INTO `designpatterns`.`departmentmember` (`departmentID`, `memberID`) VALUES ('{depid.Text}', '{memberid.Text}');");
        }
    }
}
