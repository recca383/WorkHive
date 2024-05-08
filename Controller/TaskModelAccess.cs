using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                Deadline = new DateTime(2024, 5, 9),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 1,
                TaskName = "75 percent",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 75,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 5, 3),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 2,
                TaskName = "Tapos na",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 100,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 5, 7),
                Archived = false
            },
            new TaskModel
            {
                TaskID = 3,
                TaskName = "Archived",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 0,
                TaskStart = new DateTime(2024, 4, 16),
                Deadline = new DateTime(2024, 5, 7),
                Archived = true
            },
            new TaskModel
            {
                TaskID = 4,
                TaskName = "Tapos na din",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 100,
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
            var newTaskProgress = taskModel.TaskProgress;
            var newArchived = edittaskModel.Archived;

            if (edittaskModel.TaskName != default) newTaskName = edittaskModel.TaskName;
            if (edittaskModel.TaskDescription != default) newTaskDescription = edittaskModel.TaskDescription;
            if (edittaskModel.TaskProgress != default) newTaskProgress = edittaskModel.TaskProgress;
            


            Tasks.Remove(GetTaskInfo(taskModel.TaskID));
            Tasks.Add(new TaskModel
            {
                TaskID = id,
                TaskName = newTaskName,
                TaskDescription = newTaskDescription,
                TaskProgress = newTaskProgress,
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
                    TaskProgress = 0,
                    Deadline = deadline,
                    TaskCompleted = default,
                    Archived = !archived
                };
                Tasks.Add(newTask);
                MessageBox.Show("Task Added");
                foreach(var member in members)
                {
                    new MailNotif(member.Email, newTask);
                }
                
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
