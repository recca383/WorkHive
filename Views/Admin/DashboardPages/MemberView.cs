using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Cards;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class MemberView : UserControl
    {
        public MemberView()
        {
            InitializeComponent();
            AddTaskElements();
        }
        private void AddTaskElements()
        {
            for (int i = 0; i < TaskModelAccess.GetTaskCount(); i++)
            {
                
            }

        }
    }
}
