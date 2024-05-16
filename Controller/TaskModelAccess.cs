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
            //new TaskModel
            //{
            //    TaskID = 0,
            //    TaskName = "Kalahati",
            //    TaskDescription = "Lorem Ipsum",
            //    TaskFinished = false,
            //    TaskStart = new DateTime(2024, 4, 16),
            //    Deadline = new DateTime(2024, 5, 9),
            //    Archived = false
            //},
            //new TaskModel
            //{
            //    TaskID = 1,
            //    TaskName = "75 percent",
            //    TaskDescription = "Lorem Ipsum",
            //    TaskFinished = false,
            //    TaskStart = new DateTime(2024, 4, 16),
            //    Deadline = new DateTime(2024, 5, 3),
            //    Archived = false
            //},
            //new TaskModel
            //{
            //    TaskID = 2,
            //    TaskName = "Tapos na",
            //    TaskDescription = "Lorem Ipsum",
            //    TaskFinished = true,
            //    TaskStart = new DateTime(2024, 4, 16),
            //    Deadline = new DateTime(2024, 5, 7),
            //    Archived = false
            //},
            //new TaskModel
            //{
            //    TaskID = 3,
            //    TaskName = "Archived",
            //    TaskDescription = "Lorem Ipsum",
            //    TaskFinished = false,
            //    TaskStart = new DateTime(2024, 4, 16),
            //    Deadline = new DateTime(2024, 5, 7),
            //    Archived = true
            //},
            //new TaskModel
            //{
            //    TaskID = 4,
            //    TaskName = "Tapos na din",
            //    TaskDescription = "Lorem Ipsum",
            //    TaskFinished = true,
            //    TaskStart = new DateTime(2024, 4, 16),
            //    Deadline = new DateTime(2024, 6, 13),
            //    Archived = false
            //}
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
            var pastprojectassigned = taskModel.ProjectAssigned;
            //Default valuess
            var newTaskName = taskModel.TaskName;
            var newTaskDescription = taskModel.TaskDescription;
            var newTaskDeadLine = taskModel.Deadline;
            var newArchived = taskModel.Archived;
            var newProjectAssigned = taskModel.ProjectAssigned;
            
            if (edittaskModel.TaskName != "") newTaskName = edittaskModel.TaskName;
            if (edittaskModel.TaskDescription != "") newTaskDescription = edittaskModel.TaskDescription;
            if (edittaskModel.Deadline != default) newTaskDeadLine = edittaskModel.Deadline;
            if (edittaskModel.ProjectAssigned != null) newProjectAssigned = edittaskModel.ProjectAssigned;
            var newTaskProgress = edittaskModel.TaskFinished;

            TaskModel newtask = new TaskModel
            {
                TaskID = id,
                TaskName = newTaskName,
                TaskDescription = newTaskDescription,
                TaskStart = taskModel.TaskStart,
                TaskFinished = newTaskProgress,
                Deadline = newTaskDeadLine,
                ProjectAssigned = newProjectAssigned,
                Archived = newArchived
            };
            ProjectModelAccess.AssignTaskToProject(newtask, pastprojectassigned);
            Tasks.Remove(GetTaskInfo(taskModel.TaskID));
            Tasks.Add(newtask);
            
            

        }
        public static List<TaskModel> GetTaskModel()
        {
            return Tasks;
        }
        public static void AddTask(TaskModel newTask)
        {
            List<MemberModel> members = MemberModelAccess.GetMemberModel();
            try
            {
                Tasks.Add(newTask);
                new MessageBoxes("Task Added");
                ProjectModelAccess.AssignTaskToProject(newTask, null);
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
