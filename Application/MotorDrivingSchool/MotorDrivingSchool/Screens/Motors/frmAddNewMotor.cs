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
    public partial class frmAddNewMotor : Form
    {
        public frmAddNewMotor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._addNewMotor();
        }


        private void _addNewMotor()
        {
            string chassisNumber = txtboxChassisNumber.Text.Trim();
            string model = txtboxModel.Text.Trim();
            string imagePath = txtboxImagePath.Text.Trim();
            int engineCapacity = int.Parse(comboboxCapacity.Text);

            clsMotor newMotor = new clsMotor();
            newMotor.chassisNumber = chassisNumber;
            newMotor.model = model;
            newMotor.engineCapacity = engineCapacity;
            newMotor.imagePath = imagePath;

            if(newMotor.save())
            {
                MessageBox.Show("Motor Added Successfullu","Succeed",MessageBoxButtons.OK,MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("Failed To Add New Motor", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
