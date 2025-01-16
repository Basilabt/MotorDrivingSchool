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

namespace MotorDrivingSchool.Screens.Trainees
{
    public partial class frmTraineesMainScreen : Form
    {
        private DataTable _trainees = new DataTable();

        public frmTraineesMainScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmTraineesMainScreen_Load(object sender, EventArgs e)
        {
            this._handleTraineesFetchingProcess();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this._search();
        }

        // Private Methods.

        private void _handleTraineesFetchingProcess()
        {
            this._fetchTraineesFromDB();

            if(this._trainees.Rows.Count > 0 )
            {
                this._fillDataGridWithData();
                this._resizeDataGridColumns();
            }
        }

        private void _fetchTraineesFromDB()
        {
            this._trainees = clsTrainee.getAllTrainees();
        }

        private void _resizeDataGridColumns() 
        {
            this.dgvTrainees.Columns[0].Visible = false;
            this.dgvTrainees.Columns[1].Width = 300;
            this.dgvTrainees.Columns[2].Width = 250;
   
        }


        private void _fillDataGridWithData()
        {
            this.dgvTrainees.DataSource = this._trainees;
        }


        private void _search()
        {
            string phoneNumber = txtboxPhoneNumber.Text.Trim();

            if(phoneNumber == "")
            {
                MessageBox.Show("Phone Number Can't be Empty","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsTrainee.doesTraineeExistByPhoneNumber(phoneNumber)) 
            {

                MessageBox.Show("Trainee Exist", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("There is not trainee exist !", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
 
    }
}
