using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    public enum Color
    {
        YellowBee,
        BlueOcean,
        CyanSky,
        RedAutumn,
        PinkPassion
        
    }

    public enum StatusProject
    {
        Finished,
        Archived
    }
    public class ProjectModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<TaskModel> Tasks { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime DeadLine { get; set; }
        public int Progress { get; set; }
        public bool Archived { get; set; }
        public string Instructor { get; set; }
        public Color ColorStatus { get; set; }
        public StatusProject ProjectStatus { get; set; }

        public Image ColorImage
        {
            get
            {
                var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

                switch (ColorStatus)
                {
                    default:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\YellowBee.png"));
                    case Color.BlueOcean:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\BlueOcean.png"));
                    case Color.CyanSky:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\CyanSky.png"));
                    case Color.RedAutumn:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\RedAutumn.png"));
                    case Color.PinkPassion:
                        return Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\PinkPassion.png"));

                }
            }
        }
    }

    
}
