using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHive.Views.Admin
{
    public partial class CalendarCurrentDays : UserControl
    {
        public CalendarCurrentDays()
        {
            InitializeComponent();
        }

        private void CalendarCurrentDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numdays)
        {
            lblDays.Text = numdays + "";
        }
    }
}
