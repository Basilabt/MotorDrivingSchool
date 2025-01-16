using BusinessAccessLayer;
using MotorDrivingSchool.Screens.Main;
using MotorDrivingSchool.Screens.Training;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Screens.Login
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this._login();
        }


        // Private Methods

        private void _login()
        {
            string username = txtboxUsername.Text.Trim();
            string password = clsEncryption.ComputeHash(txtboxPassword.Text.Trim());       

            if (clsAdmin.login(username,password))
            {
                clsEventLogger.logSuccessfullLogin();

                MessageBox.Show("Logged in successfully", "Login Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               

                frmTrainingScreen form1 = new frmTrainingScreen();
                frmMainScreen form2 = new frmMainScreen();
                
                this.Hide();

                form1.Show();
                form2.Show();
               
                return;
            }

            clsEventLogger.logFailedLogin();

            MessageBox.Show("Incorrect username or password","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
