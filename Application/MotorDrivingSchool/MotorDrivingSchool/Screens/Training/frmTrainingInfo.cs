using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorDrivingSchool.Screens.Training
{
    public partial class frmTrainingInfo : Form
    {
        public string traineePhoneNumber { get; private set; }
        public string durration { get; private set; }

        public frmTrainingInfo()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {   
            this.traineePhoneNumber = this.txtboxPhoneNumber.Text;
            this.durration = this.comboboxDurration.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
