using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySQLClient;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class EventForm : Form
    {
        //create a connectionstring
        string connString = "server=localhost;user id=root;database=db_calendar;sslmode=none";


        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }
    }
}
