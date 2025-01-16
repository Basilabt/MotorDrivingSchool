using BusinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Controls
{
    public partial class ctrNewPersonInfo : UserControl
    {
        public clsPerson person = new clsPerson();
        public string title {  get; set; }

        public ctrNewPersonInfo()
        {
            InitializeComponent();
        }

        private void groupboxPersonInfo_Enter(object sender, EventArgs e)
        {
            this.groupboxPersonInfo.Text = this.title;
        }

        public bool loadPersonInfo(int personID)
        {
            this.person = clsPerson.getPersonByPersonID(personID);
            this.person.mode = clsPerson.enMode.Update;
           
            this._loadPersonInfo();

            return this.person.personID != -1;
        }

        public int addNewPerson()
        {
            if(!this._isValidValues())
            {
                MessageBox.Show("Invalid Values", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            this._assignValues();

            this.person.mode = clsPerson.enMode.AddNew;

            if(this.person.save())
            {
                MessageBox.Show("Person Added Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("Failed To Add New Person", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return this.person.personID;
        } 

        private void _assignValues()
        {
            this.person.firstName = this.txtFirstName.Text.Trim();
            this.person.secondName = this.txtboxSecondName.Text.Trim();
            this.person.thirdName = this.txtboxThirdName.Text.Trim();
            this.person.lastName = this.txtboxLastName.Text.Trim();
            this.person.gender = (this.comboboxGender.SelectedItem.ToString() == "Male") ? clsPerson.enGender.Male : clsPerson.enGender.Female;
            this.person.birthDate = this.dtpBirthDate.Value;
            this.person.phoneNumber = this.txtboxPhoneNumber.Text.Trim();
            this.person.email = this.txtboxEmail.Text.Trim();
            this.person.imagePath = this.txtboxImagePath.Text.Trim();
        }

        private bool _isValidValues()
        {
            if(this.txtFirstName.Text == "" || this.txtboxSecondName.Text == "" || this.txtboxThirdName.Text == "" || this.txtboxLastName.Text == "" || this.txtboxPhoneNumber.Text == "" || this.txtboxEmail.Text == "")
            {
                return false;
            }

            if(this.comboboxGender.SelectedItem.ToString() == "")
            {
                return false;
            }
         
            return true;
        }

        private void _loadPersonInfo()
        {
            this.txtFirstName.Text = this.person.firstName;
            this.txtboxSecondName.Text = this.person.secondName;
            this.txtboxThirdName.Text = this.person.thirdName;
            this.txtboxLastName.Text = this.person.lastName;
            this.comboboxGender.SelectedItem = (this.person.gender == clsPerson.enGender.Male) ? "Male" : "Female";
            this.dtpBirthDate.Value = this.person.birthDate;
            this.txtboxPhoneNumber.Text = this.person.phoneNumber;
            this.txtboxEmail.Text = this.person.email;
            this.txtboxImagePath.Text = this.person.imagePath;
        }

        private void _updatePersonInfo()
        {
            this.person.firstName = this.txtFirstName.Text.Trim();
            this.person.secondName = this.txtboxSecondName.Text.Trim();
            this.person.thirdName = this.txtboxThirdName.Text.Trim();
            this.person.lastName = this.txtboxLastName.Text.Trim();
            this.person.gender = (this.comboboxGender.SelectedItem.ToString() == "Male") ? clsPerson.enGender.Male : clsPerson.enGender.Female;
            this.person.birthDate = this.dtpBirthDate.Value;
            this.person.phoneNumber = this.txtboxPhoneNumber.Text.Trim();
            this.person.email = this.txtboxEmail.Text.Trim();
            this.person.imagePath = this.txtboxImagePath.Text.Trim();
        }

        public bool updatePerson()
        {

            if(!_isValidValues())
            {
                return false;
            }

            this._updatePersonInfo();

            return this.person.save();
        }

    }
}
