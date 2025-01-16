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
    public partial class frmMotorsScreen : Form
    {
        private DataTable _motors = new DataTable();

        public frmMotorsScreen()
        {
            InitializeComponent();
        }


        private void frmMotorsScreen_Load(object sender, EventArgs e)
        {
            this._handleDataFetchingProcess();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewMotor form = new frmAddNewMotor();
            form.ShowDialog();

            this._reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteMotor from = new frmDeleteMotor();
            from.ShowDialog();

            this._reload();
        }

        private void dgvMotors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not the header cell.

            if(e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvMotors.Rows[e.RowIndex];

                string chassisNumber = clickedRow.Cells[4].Value?.ToString();

                frmUpdateMotor form = new frmUpdateMotor(chassisNumber);
                form.ShowDialog();

                this._reload();
            }
        }




        private void _handleDataFetchingProcess()
        {
            this._fetchDataFromDB();
            this._fillDataGridWithData();
            this._resizeDataGridViewColumns();
        }

        private void _fetchDataFromDB()
        {
            this._motors = clsMotor.getAllMotors();
        }

        private void _fillDataGridWithData()
        {
            this.dgvMotors.DataSource = this._motors;
        }

        private void _resizeDataGridViewColumns()
        {
            dgvMotors.Columns[0].Visible = false;
            dgvMotors.Columns[1].Width = 200; 
            dgvMotors.Columns[2].Width = 50;
            dgvMotors.Columns[3].Width = 75;
            dgvMotors.Columns[4].Width = 100;
            dgvMotors.Columns[5].Width = 200;
        }

        private void _reload()
        {
            this._handleDataFetchingProcess();
        }

   
    }
}
