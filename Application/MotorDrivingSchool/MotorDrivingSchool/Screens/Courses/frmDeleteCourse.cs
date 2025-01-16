using BusinessAccessLayer.Model;
using MotorDrivingSchool.Components;
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
    public partial class frmDeleteCourse : Form
    {
        public frmDeleteCourse()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._deleteCourse();
        }


        private  void _deleteCourse()
        {

            frmYesOrNo confirmForm = new frmYesOrNo();

            // Subscribe to the OnConfirmation event
            confirmForm.onConfirmation += (sender, e) =>
            {
                if (e.isConfirmed)
                {

                    int courseID = int.Parse(txtboxCourseID.Text.Trim());

                    clsCourse courseToDelete = clsCourse.findCourseByCourseID(courseID);
                    courseToDelete.mode = clsCourse.enMode.Delete;

                    if (courseToDelete.save())
                    {
                        MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Deletion canceled by the user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            confirmForm.ShowDialog();

        }

  
    }
}
