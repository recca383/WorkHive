using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    public class MemberModel
    {
        //user: Id, Username, password, role, TaskID
        public int ID { get; set; }
        public string Email { get; set; }
        public string  Username { get; set; }
        public string Password { get; set; }
        public bool IsLeader { get; set; }
        public TaskModel TaskID {  get; set; }
        public string Profile_Pic { get; set; }

    }
}
