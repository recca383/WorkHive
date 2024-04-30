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
        private readonly static List<TaskModel> Tasks = new List<TaskModel>()
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
        public static void EditTask(TaskModel taskModel)
        {
            //Default valuess
            var newTaskName = taskModel.TaskName;
            var newTaskDescription = taskModel.TaskDescription;
            var newTaskProgress = taskModel.TaskProgress;
            var newArchived = taskModel.Archived;

            //if(txtTaskName.Text != default) newTaskName = txtTaskName.Text;
            //if (txtTaskDescription.Text != default) newTaskDescription= txtTaskDescription.Text;
            //if (txtTaskProgress.Text != default) newTaskProgress = txtTaskProgress.Text;
            //if (txtArchived.Text != default) newArchived = txtArchived.Text;


            Tasks.Remove(GetTaskInfo(taskModel.TaskID));
            Tasks.Add(new TaskModel
            {
                TaskID = taskModel.TaskID,
                TaskName = newTaskName,
                TaskDescription = newTaskDescription,
                TaskProgress = newTaskProgress,
                Archived = newArchived
            }
            );
            

        }
        public static void AddTask(string taskname, string taskdescription, bool archived)
        {
            Tasks.Add(new TaskModel
            {
                TaskID = GetTaskCount(),
                TaskName = taskname,
                TaskDescription = taskdescription,
                TaskStart = DateTime.Now,
                TaskProgress = 0,
                TaskCompleted = default,
                Archived = archived

            });
        }
    }
}
