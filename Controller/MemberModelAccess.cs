﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Username = "recca383",
                Password = "123",
                IsLeader = true,
                Profile_Pic = "Resources\\Default_Admin_Pics\\tatik.jpg"

            },
            {
            new MemberModel()
            {
                ID = 1,
                Email = "joko",
                Username = "joko",
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
                Username = "Wincel",
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

    }
}