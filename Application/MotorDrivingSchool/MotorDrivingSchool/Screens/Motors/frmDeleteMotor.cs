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

namespace MotorDrivingSchool.Screens.Motors
{   
    public partial class frmDeleteMotor : Form
    {
        private DataTable _chassisNumbers = new DataTable();
      
        public frmDeleteMotor()
        {
            InitializeComponent();
        }

        private void frmDeleteMotor_Load(object sender, EventArgs e)
        {
            this._fetchChassisNumberFromDB();
            this._fillComboBoxWithChasssisNumbers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._deleteMotor();
        }


        private void _fetchChassisNumberFromDB()
        {
            this._chassisNumbers = clsMotor.getMotorsChassisNumbers();
        }

        private void _fillComboBoxWithChasssisNumbers()
        {
            this.comboBoxChassises.DataSource = this._chassisNumbers;
            this.comboBoxChassises.DisplayMember = "ChassisNumber";
        }

        private void _deleteMotor()
        {
           
            frmYesOrNo confirmForm = new frmYesOrNo();

            // Subscribe to the OnConfirmation event
            confirmForm.onConfirmation += (sender , e) =>
            {
                if (e.isConfirmed)
                {
                    
                    string chassisNumber = comboBoxChassises.Text.Trim();

                    clsMotor motorToDelete = clsMotor.getMotorByChassisNumber(chassisNumber);
                    motorToDelete.mode = clsMotor.enMode.Delete;

                    if (motorToDelete.save())
                    {
                        MessageBox.Show("Motor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the motor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
