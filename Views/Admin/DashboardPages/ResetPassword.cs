using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;

namespace WorkHive.Views.Admin
{
    public partial class ResetPassword : UserControl
    {
        MemberModel CurrentUser;
        public ResetPassword(MemberModel _CurrentUser)
        {
            this.CurrentUser = _CurrentUser;
            InitializeComponent();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!(MemberModelAccess.ChangePassword(CurrentUser, txtCurrentPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text)))
            {
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            
        }
    }
}
