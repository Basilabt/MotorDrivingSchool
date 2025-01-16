using BusinessAccessLayer;
using MotorDrivingSchool.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Screens.Coaches
{
    public partial class frmDeleteCoach : Form
    {
        private clsCoach _coach;

        public frmDeleteCoach()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._delete();
        }



        // Private Methods

        void _delete()
        {

            frmYesOrNo confirmForm = new frmYesOrNo();


            this._getCoach();

            if(this._coach == null)
            {
                MessageBox.Show("Coach is not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Subscribe to the OnConfirmation event
            confirmForm.onConfirmation += (sender, e) =>
            {
                if (e.isConfirmed)
                {
                                 
                    this._coach.mode = clsCoach.enMode.Delete;


                    if (this._coach.save())
                    {
                        MessageBox.Show("Coach deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the coach.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Deletion canceled by the user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            confirmForm.ShowDialog();


        }


        private void _getCoach()
        {
             int coachID = int.Parse(txtboxCoachID.Text.Trim());

            this._coach = clsCoach.getCoachByCoachID(coachID);
        }
    }
}
