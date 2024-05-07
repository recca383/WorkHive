using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class CalendarCurrentDaysMember : UserControl
    {
        public CalendarCurrentDaysMember()
        {
            InitializeComponent();
        }

        private void CalendarCurrentDaysMember_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays)
        {
            lblDays.Text = numdays + "";
        }
    }
}
