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
using WorkHive.Model;
using WorkHive.Views.Cards;

namespace WorkHive.Views.Admin.DashboardPages
{
    public partial class TasksView : UserControl
    {
        private List<TaskCard> list = new List<TaskCard>();
        public TasksView()
        {
            InitializeComponent();
            AddTaskElements();
        }

        private void AddTaskElements()
        {
            
            for (int i = 0; i < SampleTaskModel.GetTaskCount(); i++)
            {
                SampleTaskModel TaskModel = SampleTaskModel.GetTaskInfo(i);
                TaskCard card = new TaskCard();
                card.lblTask_Title.Text = TaskModel.TaskName;
                card.lblTask_Date.Text = ($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(TaskModel.TaskStart.Month)} {TaskModel.TaskStart.Day}");
                card.TaskProgress.Value = TaskModel.TaskProgress;
                list.Add( card );
                TasksFlow.Controls.Add(card);
                
            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            TasksFlow.Controls.Clear();
            foreach (var card in list)
            {
                TasksFlow.Controls.Add(card);
            }
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            TasksFlow.Controls.Clear();
            var results = list.Where(p => p.TaskProgress.Value < 100);
            foreach ( var result in results )
            {
                TasksFlow.Controls.Add(result);
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            TasksFlow.Controls.Clear();
            var results = list.Where(p => p.TaskProgress.Value == 100);
            foreach (var result in results)
            {
                TasksFlow.Controls.Add(result);
            }
        }
    }
}
