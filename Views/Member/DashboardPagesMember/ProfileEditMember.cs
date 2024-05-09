using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHive.Controller;
using WorkHive.Model;

namespace WorkHive.Views.Member.DashboardPagesMember
{
    public partial class ProfileEditMember : UserControl
    {
        MemberModel currentUser;
        public ProfileEditMember(MemberModel currentModel)
        {
            this.currentUser = currentModel;
            InitializeComponent();
            RefreshValues();
        }
        private void RefreshValues()
        {
            currentUser = MemberModelAccess.GetMemberInfo(currentUser.ID);
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (currentUser.Profile_Pic == " ")
            {
                MemberPictureBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                MemberPictureBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), currentUser.Profile_Pic));
            }

            Namelbl1.Text = currentUser.FullName;
            Positionlbl1.Text = "Member";

            //enum of positions
            memberworklbl1.Text = "Manager";

            MemberBirthdatelbl1.Text = currentUser.Birthdate.ToString();
            Membercontactlbl2.Text = currentUser.ContactNumber.ToString();
            Memberemaillbl1.Text = currentUser.Email;
            Memberaddresslbl1.Text = currentUser.Address;

            firstnametxt.Text = currentUser.FirstName;
            Lastnametxt.Text = currentUser.LastName;
            Extensiontxt.Text = currentUser.ExtensionName;
            Membercontacttxt.Text = currentUser.ContactNumber.ToString();
            Memberemailtxt.Text = currentUser.Email;

            SexDrop.DataSource = Enum.GetNames(typeof(sex));
            SexDrop.SelectedText = currentUser.Sex.ToString();

            bloodTypeDrop.DataSource = Enum.GetNames(typeof(bloodType));
            bloodTypeDrop.SelectedText = currentUser.BloodType.ToString();

            BirthPicker.Value = currentUser.Birthdate;

            HouseNumbertxt.Text = currentUser.HouseNumber.ToString();
            Streettxt.Text = currentUser.Street;
            barangaytxt.Text = currentUser.Barangay;
            EditPanel.Text = currentUser.City_Municipality;
            provincetxt.Text = currentUser.Province;
            zipcodetxt.Text = currentUser.ZipCode.ToString();

            btnConfirmEdit1.Visible = false;
            btnCancelEdit1.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPanel.Enabled = true;
            btnCancelEdit1.Visible = true;
            btnConfirmEdit1.Visible = true;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            RefreshValues();
            EditPanel.Enabled = false;
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            int contactresult;
            int zipcoderesult;
            var editedmember = new MemberModel();

            editedmember.ID = currentUser.ID;
            editedmember.Email = Memberemailtxt.Text;
            editedmember.FirstName = firstnametxt.Text;
            editedmember.LastName = Lastnametxt.Text;
            editedmember.MiddleName = Middlenametxt.Text;
            editedmember.ExtensionName = Extensiontxt.Text;
            editedmember.Sex = (sex)SexDrop.SelectedIndex;
            editedmember.BloodType = (bloodType)bloodTypeDrop.SelectedIndex;
            editedmember.Birthdate = BirthPicker.Value;
            editedmember.HouseNumber = HouseNumbertxt.Text;
            editedmember.Street = Streettxt.Text;
            editedmember.Barangay = barangaytxt.Text;
            editedmember.City_Municipality = citymunicipaltxt.Text;
            editedmember.Province = provincetxt.Text;


            if (int.TryParse(Membercontacttxt.Text, out contactresult)) editedmember.ContactNumber = contactresult;
            if (int.TryParse(zipcodetxt.Text, out zipcoderesult)) editedmember.ZipCode = zipcoderesult;

            MemberModelAccess.EditMemberInfo(editedmember, currentUser.ID);
            EditPanel.Enabled = false;
            RefreshValues();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
