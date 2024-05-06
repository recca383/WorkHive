using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHive.Views.Cards
{
    public partial class TaskSummaryCard : UserControl
    {
        public TaskSummaryCard(string name, DateTime deadline, int id)
        {
            InitializeComponent();
            TaskName.Text = name;
            TaskDeadline.Text = deadline.ToString();
            TaskId.Text = id.ToString();
        }
    }
}
