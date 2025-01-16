using BusinessAccessLayer;
using MotorDrivingSchool.Screens.Certificates;
using MotorDrivingSchool.Screens.Coaches;
using MotorDrivingSchool.Screens.Courses;
using MotorDrivingSchool.Screens.Motors;
using MotorDrivingSchool.Screens.Trainees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Screens.Main
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            this.lblLoggedAdmin.Text = clsGlobal.loggedInAdmin.username;
        }

        private void btnMotors_Click(object sender, EventArgs e)
        {
            frmMotorsScreen form = new frmMotorsScreen();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCoaches_Click(object sender, EventArgs e)
        {
            frmCoachesScreen form = new frmCoachesScreen();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            frmCoursesScreen form = new frmCoursesScreen();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnTrainees_Click(object sender, EventArgs e)
        {
            frmTraineesMainScreen form = new frmTraineesMainScreen();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCertificates_Click(object sender, EventArgs e)
        {
            frmCertificatesView form = new frmCertificatesView();

            this.Hide();
            form.ShowDialog();
            this.Show();

        }
    }
}
