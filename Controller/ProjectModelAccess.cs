using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                Name = "Sample Project",
                StartDate = DateTime.Now,
                DeadLine = DateTime.Now,
                Tasks = new List<TaskModel>
                {
                    TaskModelAccess.GetTaskInfo(0),
                    TaskModelAccess.GetTaskInfo(1),
                    TaskModelAccess.GetTaskInfo(2),
                    TaskModelAccess.GetTaskInfo(3)
                },
                Archived = false
            }
        };

        public static ProjectModel GetProjectDetails (int id)
        {
            return _projects.FirstOrDefault(i => i.Id == id);
        }
        public static int GetProjectProgress(int id)
        {
            ProjectModel currentproject = GetProjectDetails (id);

            int totaltasks = currentproject.Tasks.Count;
            int finishedtasks = currentproject.Tasks.Count(t => t.TaskFinished = true);

            int averageprogress = finishedtasks / totaltasks;
            currentproject.Progress = averageprogress;

            return averageprogress;
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
                Name = project.Name,
                Description = project.Description,
                StartDate = DateTime.Now,
                DeadLine = project.DeadLine,
                Progress = 0,
                Archived = project.Archived,
            });
        }
        public static void AssignTaskToProject(TaskModel task, int projectId)
        {
            ProjectModel CurrentProject = GetProjectDetails (projectId);
            if (CurrentProject == null)
            {
                new MessageBoxes("Project Unavailable");
            }
            else
            {
                CurrentProject.Tasks.Add(task);
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
            var newProjectName = CurrentprojectModel.Name;
            var newProjectDescription = CurrentprojectModel.Description;
            var newProjectTasks = CurrentprojectModel.Tasks;
            var newProjectDeadline = CurrentprojectModel.DeadLine;
            var newArchived = CurrentprojectModel.Archived;
            

            if (NewprojectModel.Name != default) newProjectName = NewprojectModel.Name;
            if (NewprojectModel.Description != default) newProjectDescription = NewprojectModel.Description;
            if (NewprojectModel.Tasks != default) newProjectTasks = NewprojectModel.Tasks;
            if (NewprojectModel.DeadLine != default) newProjectDeadline = NewprojectModel.DeadLine;
            if (NewprojectModel.Archived != default)
                newArchived = NewprojectModel.Archived;


            _projects.Remove(GetProjectDetails(projectId));
            _projects.Add(new ProjectModel
            { 
                Id = projectId,
                Name = newProjectName,
                Description = newProjectDescription,
                Tasks = newProjectTasks,
                DeadLine = newProjectDeadline,
                Archived = newArchived,
            }
            );


        }
    }
}
