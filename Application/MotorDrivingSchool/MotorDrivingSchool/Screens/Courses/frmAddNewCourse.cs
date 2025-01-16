using BusinessAccessLayer;
using BusinessAccessLayer.Model;
using MotorDrivingSchool.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Screens.Courses
{
    public partial class frmAddNewCourse : Form
    {
        public frmAddNewCourse()
        {
            InitializeComponent();
        }

        private void frmAddNewCourse_Load(object sender, EventArgs e)
        {
            ctrNewPersonInfo1.title = "New Trainee Info";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int newPersonID = ctrNewPersonInfo1.addNewPerson();
            int newCoachID = ctrNewCourseInfo1.getSelectedCoachID();
            int newLicenseTypeID = ctrNewCourseInfo1.getSelectedLicenseTypeID();


            clsTrainee trainee = new clsTrainee();
            trainee.mode = clsTrainee.enMode.AddNew;
            trainee.personID = newPersonID; 

            if(!trainee.save())
            {
                MessageBox.Show("Failed To Add New Trainee", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            

            clsCourse course = new clsCourse();

            course.mode = clsCourse.enMode.AddNew;
            course.coachID = newCoachID;
            course.traineeID = trainee.traineeID;
            course.licenseID = newLicenseTypeID;
            course.remainingHours = 10;

            if(course.save())
            {

                MessageBox.Show("New Course added successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Failed To Add New Course", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
