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

namespace WorkHive.Controller
{
    internal class MemberModelAccess
    {
        private static List<MemberModel> memberModel = new List<MemberModel>()
        {
            new MemberModel()
            {
                ID = 0,
                Email = "Pat",
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
        public static void ChangePassword (MemberModel member, string currentPassword, string newPassword, string newPasswordConfirm)
        {
            if (!(member.Password == currentPassword))
            {
                MessageBox.Show("Wrong Password");
            }
            else if (!(member.Password == newPassword))
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
                MessageBox.Show("Change Password Successful");
            }
        }

    }
}
