using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkHive.Model;

namespace WorkHive.Controller
{
    public class TaskModelAccess
    {
        private static List<TaskModel> Tasks = new List<TaskModel>()
        {
            new TaskModel
            {
                TaskID = 0,
                TaskName = "Kalahati",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 50,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 1,
                TaskName = "75 percent",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 75,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 2,
                TaskName = "Tapos na",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 100,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 3,
                TaskName = "Archived",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 0,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9),
                Archived = true
            },
            new TaskModel
            {
                TaskID = 4,
                TaskName = "Tapos na din",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 100,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9),
                Archived = false
            }
        };

        public static TaskModel GetTaskInfo(int ID)
        {
            return Tasks.FirstOrDefault(i => i.TaskID == ID);
        }
        public static int GetTaskCount()
        {
            return Tasks.Count();
        }
    }
}
