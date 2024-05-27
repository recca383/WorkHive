using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Data;
using WorkHive.Model;
using WorkHive.Views.LandingPage.LandingPagePages;

namespace WorkHive.Controller
{
    public class TaskModelAccess
    {
        private static List<TaskModel> Tasks = SQLConnect.GetTasksFromDB("Select * From Tasks");

        //{x`
        //    new TaskModel
        //    {
        //        TaskID = 0,
        //        TaskName = "Kalahati",
        //        TaskDescription = "Lorem Ipsum",
        //        TaskStatus = Status.Ongoing,
        //        TaskStart = new DateTime(2024, 4, 16),
        //        Deadline = new DateTime(2024, 5, 9),
        //        ProjectAssigned = ProjectModelAccess.GetProjectDetails(0)
        //    },
        //    new TaskModel
        //    {
        //        TaskID = 1,
        //        TaskName = "Done",
        //        TaskDescription = "Lorem Ipsum",
        //        TaskStatus = Status.Finished,
        //        TaskStart = new DateTime(2024, 4, 16),
        //        Deadline = new DateTime(2024, 5, 3),
        //        ProjectAssigned = ProjectModelAccess.GetProjectDetails(0)
        //    },
        //    new TaskModel
        //    {
        //        TaskID = 2,
        //        TaskName = "Archived",
        //        TaskDescription = "Lorem Ipsum",
        //        TaskStatus = Status.Archived,
        //        TaskStart = new DateTime(2024, 4, 16),
        //        Deadline = new DateTime(2024, 5, 7),
        //        ProjectAssigned = ProjectModelAccess.GetProjectDetails(0)

        //    },

        //};

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
            var newProjectAssigned = taskModel.ProjectAssigned;
            
            if (edittaskModel.TaskName != "" && edittaskModel.TaskName != null) newTaskName = edittaskModel.TaskName;
            if (edittaskModel.TaskDescription != "" && edittaskModel.TaskDescription != null) newTaskDescription = edittaskModel.TaskDescription;
            if (edittaskModel.Deadline != default) newTaskDeadLine = edittaskModel.Deadline;
            if (edittaskModel.ProjectAssigned != null) newProjectAssigned = edittaskModel.ProjectAssigned;
            var newTaskStatus = edittaskModel.TaskStatus;

            TaskModel newtask = new TaskModel
            {
                TaskID = id,
                TaskName = newTaskName,
                TaskDescription = newTaskDescription,
                TaskStart = taskModel.TaskStart,
                TaskStatus = newTaskStatus,
                Deadline = newTaskDeadLine,
                ProjectAssigned = newProjectAssigned,
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

                string DateNow = DateTime.Now.ToString("yyyy-MM-dd");
                string Deadline = newTask.Deadline.ToString("yyyy-MM-dd");
                string template = "Insert into Tasks (TaskName, TaskDescription, TaskStatus,TaskStartDate, ProjectAssigned,Deadline) Values ( " +
                $"\"{newTask.TaskName}\"," +
                $"\"{newTask.TaskDescription}\"," +
                $"{(int)newTask.TaskStatus}," +
                $"\"{DateNow}\"," +
                $"\"{newTask.ProjectAssigned.Id}\"," +
                $"\"{Deadline}\"" +
                $");";

                
                SQLConnect.ExecuteNonQuery(template);
                foreach (var member in members)
                {
                    new MailNotif(member.Email, newTask);
                }
                new MessageBoxes("Task Added");
            }
            catch (Exception e)
            {

                new MessageBoxes(e.Message);
            }
        }
    }
}
