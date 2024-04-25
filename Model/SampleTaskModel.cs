using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    public class SampleTaskModel
    {
        //TaskID, Name, Description, Progress, Status, date added, date Completed
        private int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int TaskProgress { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskCompleted { get; set; }

        private static List<SampleTaskModel> Tasks = new List<SampleTaskModel>()
        {
            new SampleTaskModel
            {
                TaskID = 0,
                TaskName = "Kalahati",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 50,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9)
            },
            new SampleTaskModel
            {
                TaskID = 1,
                TaskName = "75 percent",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 75,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9)
            },
            new SampleTaskModel
            {
                TaskID = 2,
                TaskName = "Tapos na",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 100,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9)
            },
            new SampleTaskModel
            {
                TaskID = 3,
                TaskName = "TestName",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 50,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9)
            },
            new SampleTaskModel
            {
                TaskID = 4,
                TaskName = "Tapos na din",
                TaskDescription = "Lorem Ipsum",
                TaskProgress = 100,
                TaskStart = new DateTime(2024, 4, 16),
                TaskCompleted = new DateTime(2024, 5, 9)
            }
        };

        public static SampleTaskModel GetTaskInfo(int ID)
        {
            return Tasks.FirstOrDefault(i => i.TaskID == ID);
        }
        public static int GetTaskCount()
        {
            return Tasks.Count();
        }

    }

}
