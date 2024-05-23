using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TaskModel> Tasks { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime DeadLine { get; set; }
        public int Progress { get; set; }
        public bool Archived { get; set; }
        public string Instructor { get; set; }
    }
}
