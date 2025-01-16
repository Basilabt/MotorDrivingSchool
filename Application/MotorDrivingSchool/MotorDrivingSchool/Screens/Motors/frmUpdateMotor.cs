using BusinessAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Screens.Motors
{
    public partial class frmUpdateMotor : Form
    {
        private clsMotor _motor;
        private string _chassisNumber;

        public frmUpdateMotor(string chassisNumber)
        {
            InitializeComponent();

            this._chassisNumber = chassisNumber;
        }

        private void frmUpdateMotor_Load(object sender, EventArgs e)
        {
            this._getMotorByChassisNumber();
            this._fillComponentsWithMotorInfo();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._updateMotor(); 
        }







        private void _getMotorByChassisNumber()
        {
            this._motor = clsMotor.getMotorByChassisNumber(this._chassisNumber);
        }

        private void _fillComponentsWithMotorInfo()
        {
            this.txtboxChassisNumber.Text = this._chassisNumber;
            this.txtboxModel.Text = this._motor.model;
            this.txtboxImagePath.Text = this._motor.imagePath;
            
        }

        private void _updateMotor()
        {
            this._motor.mode = clsMotor.enMode.Update;

            this._motor.chassisNumber = txtboxChassisNumber.Text.Trim();
            this._motor.model = txtboxModel.Text.Trim();
            this._motor.imagePath = txtboxImagePath.Text.Trim();
            this._motor.engineCapacity = int.Parse(comboboxCapacity.Text);



            if (this._motor.save())
            {
                MessageBox.Show("Motor Updated Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Update Motor", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
