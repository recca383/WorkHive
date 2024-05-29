using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WorkHive.Data;
using WorkHive.Model;
using WorkHive.Views.LandingPage.LandingPagePages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkHive.Controller
{
    class ProjectModelAccess
    {
        static List<ProjectModel> _projects = new List<ProjectModel>()
        {
            new ProjectModel
            {
                Id = 0,
                ProjectName = "Sample Project",
                Instructor = "Johnny Villanueva",
                StartDate = DateTime.Now,
                Tasks = new List<TaskModel>(),
                DeadLine = DateTime.Now,
                Archived = false
            },
            new ProjectModel
            {
                Id = 1,
                ProjectName = "Sample Project 2",
                Instructor = "Johnny Kasalanan",
                StartDate = DateTime.Now,
                Tasks = new List<TaskModel>(),
                DeadLine = DateTime.Now,
                Archived = false
            }
        };

        public static ProjectModel GetProjectDetails (int id)
        {
            return _projects.FirstOrDefault(i => i.Id == id);
        }
        public static int GetProjectProgress(int id)
        {
            ProjectModel currentproject = GetProjectDetails(id);
            List<TaskModel> selectedtasks = currentproject.Tasks;

            if(selectedtasks.Count() > 0)
            {
                int totaltasks = selectedtasks.Count(t => t.TaskStatus != Status.Archived);
                int finishedtasks = selectedtasks.Count(t => t.TaskStatus == Status.Finished);

                decimal average = (decimal)finishedtasks / totaltasks * 100;
                currentproject.Progress = (int)Math.Round(average, 2);

                return (int)Math.Round(average, 2);
            }
            return 0;
        }
        public static List<ProjectModel> GetProjects () 
        {  
            return _projects;
        }
        public static void AddProject(ProjectModel project)
        {
            _projects.Add(new ProjectModel
            {
                Id = _projects.Count,
                ProjectName = project.ProjectName,
                Description = project.Description,
                StartDate = DateTime.Now,
                DeadLine = project.DeadLine,
                Progress = 0,
                Archived = project.Archived,
                Instructor = project.Instructor,
                ColorStatus = project.ColorStatus,
                Tasks = new List<TaskModel>()
            });
        }
        public static void AssignTaskToProject(TaskModel task, ProjectModel pastprojectassigned)
        {
            ProjectModel CurrentProject = task.ProjectAssigned;
            if (CurrentProject == null) new MessageBoxes("Project Unavailable");
            {
                if (pastprojectassigned != null)
                {
                    TaskModel oldtask = pastprojectassigned.Tasks.FirstOrDefault(t => t.TaskID == task.TaskID);
                    pastprojectassigned.Tasks.Remove(oldtask);
                }
                if (!CurrentProject.Tasks.Contains(task))
                {
                    CurrentProject.Tasks.Add(task);
                }
            }
            
        }
        public static void DeleteProject(int projectId)
        {
            _projects.Remove(GetProjectDetails (projectId));
        }
        public static void EditProject(ProjectModel CurrentprojectModel, ProjectModel NewprojectModel)
        {
            //Default valuess
            var projectId = CurrentprojectModel.Id;
            var newProjectName = CurrentprojectModel.ProjectName;
            var newProjectDescription = CurrentprojectModel.Description;
            var newProjectTasks = CurrentprojectModel.Tasks;
            var newProjectDeadline = CurrentprojectModel.DeadLine;
            var newArchived = CurrentprojectModel.Archived;
            var newInstructor = CurrentprojectModel.Instructor;


            if (NewprojectModel.ProjectName != default) newProjectName = NewprojectModel.ProjectName;
            if (NewprojectModel.Description != default) newProjectDescription = NewprojectModel.Description;
            if (NewprojectModel.Tasks != default) newProjectTasks = NewprojectModel.Tasks;
            if (NewprojectModel.DeadLine != default) newProjectDeadline = NewprojectModel.DeadLine;
            if (NewprojectModel.Archived != default) newArchived = NewprojectModel.Archived;
            if (NewprojectModel.Instructor != default) newInstructor = NewprojectModel.Instructor;

            _projects.Remove(GetProjectDetails(projectId));
            _projects.Add(new ProjectModel
            { 
                Id = projectId,
                ProjectName = newProjectName,
                Description = newProjectDescription,
                Tasks = newProjectTasks,
                DeadLine = newProjectDeadline,
                Archived = newArchived,
                Instructor = newInstructor,
            }
            );


        }
    }
}
