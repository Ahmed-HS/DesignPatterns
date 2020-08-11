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
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (simple.Checked)
            {
                createLogger("simple").logAllTasksStatus();
            }
            else
            {
                createLogger("detailed").logAllTasksStatus();
            }
        }

        TasksLogger createLogger(string type)
        {
            if (type == "simple")
            {
                return new SimpleLogger();
            }
            else
            {
                return new DetailedLogger();
            }
        }
    }
}
