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
            
            switch (task.TaskStatus)
            {
                case Status.Ongoing:
                    btnMarkAsDone.Text = "Mark As Done";
                    break;
                case Status.Finished:
                    btnMarkAsDone.Text = "Mark As Not Done";
                    break;
            }

            pictureboxFinished.Image = task.TaskImage;


        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {

            if (task.TaskStatus != Status.Finished)
            {
                TaskModelAccess.EditTask(new TaskModel { TaskStatus = Status.Finished }, task.TaskID);
                btnMarkAsDone.Text = "Mark As Not Done";
            }
            else
            {
                TaskModelAccess.EditTask(new TaskModel { TaskStatus = Status.Ongoing }, task.TaskID);
                btnMarkAsDone.Text = "Mark As Done";
            }

            OnUpdate();

        }
    }
}
