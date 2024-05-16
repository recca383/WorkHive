using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkHive.Model
{

   public enum Status 
    { 
        Ongoing,
        Finished,
        Archived
    }
    public class TaskModel
    {
        //TaskID, Name, Description, Progress, Status, date added, date Completed
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskCompleted { get; set; }
        public Status TaskStatus { get; set; }
        public DateTime Deadline { get; set; }
        public ProjectModel ProjectAssigned { get; set; }

        public Image TaskImage { get
            {
                var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

                switch (TaskStatus)
                {
                    default:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Tasks Cards P1.png"));
                    case Status.Finished:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Tasks - CHECKED.png"));
                    case Status.Archived:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Tasks - LOCK.png"));

                }
            } 
        }
        
            

        
        

    }

}
