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


        private void register(object sender, EventArgs e)
        {
            Member newMember = new Member();
            newMember.name = name.Text;
            newMember.email = email.Text;
            newMember.password = password.Text;
            newMember.phoneNumber = phone.Text;
            newMember.addrees = address.Text;

            Database.insertMember(newMember);
        }

        private void login(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> result = Database.SelectQuery($"SELECT * FROM members where email = '{loginEmail.Text}';");

            if (result == null || result[0]["password"] != loginPassword.Text)
            {
                MessageBox.Show("Invaild username or password");
            }
            else
            {
                MessageBox.Show("Success");
            }
        }
    }
}
