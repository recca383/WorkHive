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

namespace WorkHive.Views.Admin
{
    public partial class ProfileEdit : UserControl
    {
        int currentUserID;
        MemberModel currentUser;
        string newPicture = "";
        
        public ProfileEdit(MemberModel _Currentuser)
        {
            this.currentUser = _Currentuser;
            this.currentUserID = _Currentuser.ID;
            InitializeComponent();
            RefreshValues();
        }
        private void RefreshValues()
        {
            currentUser = MemberModelAccess.GetMemberInfo(currentUserID);
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            if (currentUser.Profile_Pic.Contains("C:\\") || currentUser.Profile_Pic.Contains("D:\\"))
            {
                ProfilePic.Image = Image.FromFile(currentUser.Profile_Pic);
            }
            else if (currentUser.Profile_Pic == " ")
            {
                ProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), "Resources\\Default_Pics\\Userdefault.png"));
            }
            else
            {
                ProfilePic.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(parent), currentUser.Profile_Pic));
            }

            Namelbl.Text = currentUser.FullName;
            Positionlbl.Text = "ADMIN";

            //enum of positions
           // worklbl.Text = "Manager";
            
            Birthdatelbl.Text = (currentUser.Birthdate.ToString("MMMM dd, yyyy"));
            contactlbl.Text = currentUser.ContactNumber.ToString();
            emaillbl.Text = currentUser.Email;
            addresslbl.Text = currentUser.Address;

            firstnametxt.Text = currentUser.FirstName;
            Lastnametxt.Text = currentUser.LastName;
            Extensiontxt.Text = currentUser.ExtensionName;
            contacttxt.Text = currentUser.ContactNumber.ToString();
            emailtxt.Text = currentUser.Email;

            SexDrop.DataSource = Enum.GetNames(typeof(sex)) ;
            SexDrop.SelectedIndex = ((int)currentUser.Sex);

            bloodTypeDrop.DataSource = Enum.GetNames(typeof(bloodType));
            bloodTypeDrop.SelectedIndex = ((int)currentUser.BloodType);

            BirthPicker.Value = currentUser.Birthdate;

            HouseNumbertxt.Text = currentUser.HouseNumber.ToString();
            Streettxt.Text = currentUser.Street;
            barangaytxt.Text = currentUser.Barangay;
            citymunicipaltxt.Text = currentUser.City_Municipality;
            provincetxt.Text = currentUser.Province;
            zipcodetxt.Text = currentUser.ZipCode.ToString();

            btnConfirmEdit.Visible = false;
            btnCancelEdit.Visible = false;

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
                editedmember.Profile_Pic = newPicture;

            if (Utility.IsEmailValid(emailtxt.Text)) editedmember.Email = emailtxt.Text;
            if (int.TryParse(contacttxt.Text, out contactresult))editedmember.ContactNumber = contactresult;
            if (int.TryParse(zipcodetxt.Text, out zipcoderesult)) editedmember.ZipCode = zipcoderesult;

            MemberModelAccess.EditMemberInfo(editedmember, currentUser.ID);
            EditPanel.Enabled = false;
            RefreshValues();
            Dashboard_Admin dashboard = (Dashboard_Admin) Parent.Parent;
            dashboard.RefreshPicture();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPanel.Enabled = true;
            btnCancelEdit.Visible = true;
            btnConfirmEdit.Visible = true;
            Editpicture.Visible = true;
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

                }
                ProfilePic.Image = Image.FromFile(newPicture);
            }

        }
    }
}
