using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Model
{
    public enum sex
    {
        Male,
        Female
    }
    public enum bloodType
    {
        A,
        B,
        AB,
        O
    }

    public class MemberModel
    {
        //user: Id, Username, password, role, TaskID
        public int ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExtensionName { get; set; }
        public string  FullName 
        { get 
            {
                return FirstName + " " + LastName + " " + ExtensionName;
            } 
        }

        public int ContactNumber { get; set; }
        public sex Sex { get; set; }
        public bloodType BloodType { get; set; }
        public DateTime Birthdate { get; set; }
        public string Password { get; set; }
        public bool IsLeader { get; set; }
        public int TaskID {  get; set; }
        public string Profile_Pic { get; set; }

    }
}
