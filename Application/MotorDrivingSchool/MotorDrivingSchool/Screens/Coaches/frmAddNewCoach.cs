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

namespace MotorDrivingSchool.Screens.Coaches
{
    public partial class frmAddNewCoach : Form
    {        
        private clsCoach _coach = new clsCoach();


        public frmAddNewCoach()
        {
            InitializeComponent();
        }

        private void frmAddNewCoach_Load(object sender, EventArgs e)
        {
            this.ctrNewPersonInfo1.title = "New Coach Info";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int personID = this.ctrNewPersonInfo1.addNewPerson();

            if(personID == -1)
            {
                return;
            }
            

            this._coach.personID = personID;
            this._coach.mode = clsCoach.enMode.AddNew;

            if (this._coach.save())
            {
                MessageBox.Show("New coach added successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("Failed to add new coach.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

 
    }
}
