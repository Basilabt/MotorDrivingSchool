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
    public partial class frmUpdateCoach : Form
    {
        private int _personID;

        public frmUpdateCoach(int personID)
        {
            InitializeComponent();


            this._personID = personID;
            this.ctrNewPersonInfo1.loadPersonInfo(personID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(this.ctrNewPersonInfo1.updatePerson())
            {
                MessageBox.Show("Coach Updated Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Failed To Update Coach", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
