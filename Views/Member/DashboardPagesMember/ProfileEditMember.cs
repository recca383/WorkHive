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
        private string newPicture = "";
        public static event Action OnUpdate;
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
            
            if (currentUser.Profile_Pic.Contains("C:\\") || currentUser.Profile_Pic.Contains("D:\\"))
            {
                MemberPictureBox.Image = Image.FromFile(currentUser.Profile_Pic);
            }
            else if (currentUser.Profile_Pic == " ")
            {
                MemberPictureBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                MemberPictureBox.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), currentUser.Profile_Pic));
            }

            Namelbl1.Text = currentUser.FullName;
            Positionlbl1.Text = "MEMBER";

            //enum of positions
            //memberworklbl1.Text = "Manager";

            MemberBirthdatelbl1.Text = currentUser.Birthdate.ToString("d");
            Membercontactlbl2.Text = currentUser.ContactNumber.ToString();
            Memberemaillbl1.Text = currentUser.Email;
            Memberaddresslbl1.Text = currentUser.Address;

            firstnametxt.Text = currentUser.FirstName;
            Lastnametxt.Text = currentUser.LastName;
            Extensiontxt.Text = currentUser.ExtensionName;
            Membercontacttxt.Text = currentUser.ContactNumber.ToString();
            Memberemailtxt.Text = currentUser.Email;

            SexDrop.DataSource = Enum.GetNames(typeof(sex));
            SexDrop.SelectedIndex = ((int)currentUser.Sex);

            bloodTypeDrop.DataSource = Enum.GetNames(typeof(bloodType));
            bloodTypeDrop.SelectedIndex = ((int)currentUser.BloodType);

            BirthPicker.Value = currentUser.Birthdate;

            HouseNumbertxt.Text = currentUser.HouseNumber.ToString();
            Streettxt.Text = currentUser.Street;
            barangaytxt.Text = currentUser.Barangay;
            EditPanel.Text = currentUser.City_Municipality;
            provincetxt.Text = currentUser.Province;
            zipcodetxt.Text = currentUser.ZipCode.ToString();

            btnConfirmEdit1.Visible = false;
            btnCancelEdit1.Visible = false;
            Editpicture.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPanel.Enabled = true;
            btnCancelEdit1.Visible = true;
            btnConfirmEdit1.Visible = true;
            Editpicture.Visible = true;
        }

        private void btnCancelEdit1_Click(object sender, EventArgs e)
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
            editedmember.ContactNumber = Membercontacttxt.Text;
            if (newPicture == "") editedmember.Profile_Pic = currentUser.Profile_Pic;
            else editedmember.Profile_Pic = newPicture;


            if (Utility.IsEmailValid(Memberemailtxt.Text)) editedmember.Email = Memberemailtxt.Text;
            if (int.TryParse(zipcodetxt.Text, out zipcoderesult)) editedmember.ZipCode = zipcoderesult;

            MemberModelAccess.EditMemberInfo(editedmember, currentUser.ID);
            EditPanel.Enabled = false;
            RefreshValues();
            OnUpdate();
            Dashboard_Member dashboard = (Dashboard_Member)Parent.Parent;
            dashboard.RefreshImage();
            Editpicture.Visible = false;
        }
        private void Editpicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;| All files (*.*)|*.*";
                openFileDialog.Title = "Select Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    newPicture = openFileDialog.FileName;
                    MemberPictureBox.Image = Image.FromFile(newPicture);

                }
                
            }
            
        }
    }
}
