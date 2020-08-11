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
            Member newMember = new Member.Builder()
                .setName(name.Text)
                .setEmail(email.Text)
                .setpassword(password.Text)
                .setphone(phone.Text)
                .setAddress(address.Text)
                .build();
            

            Database.insertMember(newMember);
        }

        private void login(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> result = Database.SelectQuery($"SELECT * FROM members where email = '{loginEmail.Text}';");
            TasksLogger logger = new SimpleLogger();
            logger.logProjectTaskStatus(1);
            if (result == null || result.Count > 1 || result[0]["password"] != loginPassword.Text)
            {
                MessageBox.Show("Invaild username or password");
            }
            else
            {
                MessageBox.Show("Success");
                Member loggedInMember = new Member.Builder()
                    .setID(int.Parse(result[0]["ID"]))
                    .setName(result[0]["name"])
                    .setEmail(result[0]["email"])
                    .setpassword(result[0]["password"])
                    .setphone(result[0]["phoneNumber"])
                    .setAddress(result[0]["address"])
                    .build();

                SessionInfo.get().member = loggedInMember;
            }
        }
    }
}
