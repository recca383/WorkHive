using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using WorkHive.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WorkHive.Controller
{
    internal class MemberModelAccess
    {
        private static List<MemberModel> memberModel = new List<MemberModel>()
        {
            new MemberModel()
            {
                ID = 0,
                Email = "sirpatrick121402@gmail.com",
                FirstName = "recca383",
                Password = "123",
                IsLeader = true,
                Profile_Pic = "Resources\\Default_Admin_Pics\\tatik.jpg"

            },
            {
            new MemberModel()
            {
                ID = 1,
                Email = "joko",
                FirstName = "joko",
                Password = "123",
                IsLeader = true,
                Profile_Pic = "Resources\\Default_Admin_Pics\\joko.jpg"

            }
            },
            {
            new MemberModel()
            {
                ID = 2,
                Email = "Wincel",
                FirstName = "Wincel",
                Password = "123",
                IsLeader = true,
                Profile_Pic = "Resources\\Default_Admin_Pics\\wincel.jpg"

            }
            }

        };
        public static List<MemberModel> GetMemberModel()
        {
            return memberModel;
        }
        public static void AddMember(MemberModel member)
        {
            memberModel.Add(member);
        }
        public static bool ChangePassword (MemberModel member, string currentPassword, string newPassword, string newPasswordConfirm)
        {
            bool loop = true;
            if (!(member.Password == currentPassword))
            {
                MessageBox.Show("Wrong Password");
            }
            else if (!(newPasswordConfirm == newPassword))
            {
                MessageBox.Show("Password Doesn't Match");
            }
            else if(member.Password == newPassword)
            {
                MessageBox.Show("You can't use your old password");
            }
            else
            {
                member.Password = newPassword;
                loop = false;
                MessageBox.Show("Change Password Successful");
                
            }
            return loop;
        }
        public static bool ChangePassword(MemberModel member,string newPassword, string newPasswordConfirm)
        {
            bool loop = true;
            if (!(newPasswordConfirm == newPassword))
            {
                MessageBox.Show("Password Doesn't Match");
            }
            else if (member.Password == newPassword)
            {
                MessageBox.Show("You can't use your old password");
            }
            else
            {
                member.Password = newPassword;
                loop = false;
                MessageBox.Show("Change Password Successful");
            }
            return loop;
        }
        public static MemberModel GetMemberInfo(int ID)
        {
            return memberModel.FirstOrDefault(i => i.ID == ID);
        }
        public static int GetMemberCount()
        {
            return memberModel.Count;
        }
        public static void AssignTask(int ID, int taskID)
        {
            MemberModel selectedMember = GetMemberInfo(ID);
            selectedMember.TaskID = taskID;
        }
        public static void EditMemberInfo (MemberModel editedmember, int id)
        {
            MemberModel currentMember = GetMemberInfo(id);
            var newid = currentMember.ID;
            var newEmail = currentMember.Email;
            var newFirstName = currentMember.FirstName;
            var newLastName = currentMember.LastName;
            var newMiddleName = currentMember.MiddleName;
            var newExtensionName = currentMember.ExtensionName;
            var newContactNumber = currentMember.ContactNumber;
            var newSex = currentMember.Sex;
            var newbloodType = currentMember.BloodType;
            var newbirthdate = currentMember.Birthdate;
            var newhousenumber = currentMember.HouseNumber;
            var newstreet = currentMember.Street;
            var newbarangay = currentMember.Barangay;
            var newcity = currentMember.City_Municipality;
            var newprovince = currentMember.Province;
            var newzipcode = currentMember.ZipCode;

            if(editedmember.Email != null) newEmail = editedmember.Email;
            if (editedmember.FirstName != null) newFirstName = editedmember.FirstName;
            if (editedmember.LastName != null) newLastName = editedmember.LastName;
            if (editedmember.MiddleName != null) newMiddleName = editedmember.MiddleName;
            if (editedmember.ExtensionName != null) newExtensionName = editedmember.ExtensionName;
            if (editedmember.ContactNumber != 0) newContactNumber = editedmember.ContactNumber;
            if (editedmember.Sex != sex.None) newSex = editedmember.Sex;
            if (editedmember.BloodType != bloodType.None) newbloodType = editedmember.BloodType;
            if (editedmember.Birthdate != DateTime.Now) newbirthdate = editedmember.Birthdate;
            if (editedmember.HouseNumber != null) newhousenumber = editedmember.HouseNumber;
            if (editedmember.Street != null) newstreet = editedmember.Street;
            if (editedmember.Barangay != null) newbarangay = editedmember.Barangay;
            if (editedmember.City_Municipality != null) newcity = editedmember.City_Municipality;
            if (editedmember.Province != null) newprovince = editedmember.Province;
            if (editedmember.ZipCode != 0) newzipcode = editedmember.ZipCode;

            memberModel.Remove(GetMemberInfo(id));
            memberModel.Add(new MemberModel
            {
                ID = newid,
                Email = newEmail,
                FirstName = newFirstName,
                LastName = newLastName,
                MiddleName = newMiddleName,
                ExtensionName = newExtensionName,
                ContactNumber = newContactNumber,
                Sex = newSex,
                BloodType = newbloodType,
                Birthdate = newbirthdate,
                Password = currentMember.Password,
                IsLeader = currentMember.IsLeader,
                TaskID = currentMember.TaskID,
                Profile_Pic = currentMember.Profile_Pic,
                HouseNumber = newhousenumber,
                Street = newstreet,
                Barangay = newbarangay,
                City_Municipality = newcity,
                Province = newprovince,
                ZipCode = newzipcode,

            });

        }
    }
}
