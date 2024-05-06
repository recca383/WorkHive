using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Views.Admin.DashboardPages;

namespace WorkHive.Views.Admin
{
    public partial class EditTasks : UserControl
    {
        static int Id;
        public EditTasks(int id)
        {
            InitializeComponent();
            Id = id;
            txtID.Text = id.ToString();
        }

    }
}
