using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Model;
using WorkHive.Views.LandingPage.LandingPagePages;

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
                TaskFinished = false,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 5, 9),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 1,
                TaskName = "75 percent",
                TaskDescription = "Lorem Ipsum",
                TaskFinished = false,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 5, 3),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 2,
                TaskName = "Tapos na",
                TaskDescription = "Lorem Ipsum",
                TaskFinished = true,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 5, 7),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 3,
                TaskName = "Archived",
                TaskDescription = "Lorem Ipsum",
                TaskFinished = false,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 5, 7),
                Archived = true
            },
            new TaskModel
            {
                TaskID = 4,
                TaskName = "Tapos na din",
                TaskDescription = "Lorem Ipsum",
                TaskFinished = true,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 6, 13),
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
        public static void EditTask(TaskModel edittaskModel, int id)
        {
            TaskModel taskModel = GetTaskInfo(id);
            //Default valuess
            var newTaskName = taskModel.TaskName;
            var newTaskDescription = taskModel.TaskDescription;
            var newTaskProgress = taskModel.TaskFinished;
            var newArchived = edittaskModel.Archived;

            if (edittaskModel.TaskName != default) newTaskName = edittaskModel.TaskName;
            if (edittaskModel.TaskDescription != default) newTaskDescription = edittaskModel.TaskDescription;
            if (edittaskModel.TaskFinished != default) newTaskProgress = edittaskModel.TaskFinished;
            


            Tasks.Remove(GetTaskInfo(taskModel.TaskID));
            Tasks.Add(new TaskModel
            {
                TaskID = id,
                TaskName = newTaskName,
                TaskDescription = newTaskDescription,
                TaskFinished = newTaskProgress,
                Archived = newArchived
            }
            );
            

        }
        public static List<TaskModel> GetTaskModel()
        {
            return Tasks;
        }
        public static void AddTask(int ID, string taskname, string taskdescription, bool archived, DateTime deadline)
        {
            List<MemberModel> members = MemberModelAccess.GetMemberModel();

            try
            {
                TaskModel newTask = new TaskModel
                {
                    TaskID = ID,
                    TaskName = taskname,
                    TaskDescription = taskdescription,
                    TaskStart = DateTime.Now,
                    TaskFinished = false,
                    Deadline = deadline,
                    TaskCompleted = default,
                    Archived = !archived
                };
                Tasks.Add(newTask);
                new MessageBoxes("Task Added");
                foreach(var member in members)
                {
                    new MailNotif(member.Email, newTask);
                }
                
                
            }
            catch (Exception e)
            {

                new MessageBoxes(e.Message);
            }
        }
    }
}
