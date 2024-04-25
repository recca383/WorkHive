using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    internal class SampleMemberModel
    {
        //user: Id, Username, password, role, TaskID
        public int ID { get; set; }
        public string  Username { get; set; }
        public string Password { get; set; }
        public bool IsLeader { get; set; }
        public int TaskID {  get; set; }

    }
}
