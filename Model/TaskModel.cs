using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    public class TaskModel
    {
        //TaskID, Name, Description, Progress, Status, date added, date Completed
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int TaskProgress { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskCompleted { get; set; }
        public bool Archived { get; set; }

        

    }

}
