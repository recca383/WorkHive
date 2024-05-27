using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;
using WorkHive.Views.Admin.DashboardPages;
using WorkHive.Views.Member.DashboardPagesMember;

namespace WorkHive.Views.Cards
{
    public partial class MemberTaskCard : UserControl
    {
        TaskModel task;
        public static event Action OnUpdate;

        public MemberTaskCard(TaskModel task)
        {

            this.task = task;
            InitializeComponent();
            InitializeElements();
            OnUpdate += InitializeElements;
        }

        private void InitializeElements()
        {
            lblTask_Title.Text = task.TaskName;
            lblTask_Date.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(task.TaskStart.Month)} {task.TaskStart.Day}");
            Deadlinetxt.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(task.Deadline.Month)} {task.Deadline.Day}");
            if (task.ProjectAssigned is null) lblProjectName.Text = "No Project";
            else lblProjectName.Text = task.ProjectAssigned.Name;
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            pictureboxFinished.Image = task.TaskImage;
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {

            TaskViewMember editTask = (TaskViewMember)this.Parent.Parent;

            editTask.btnEdittasks_Click(sender, e, task.TaskID);

           OnUpdate();

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {           
                TaskViewMember parent = (TaskViewMember)this.Parent.Parent;
                parent.btnDetails_Click(sender, e, task);
        }
    }
}
