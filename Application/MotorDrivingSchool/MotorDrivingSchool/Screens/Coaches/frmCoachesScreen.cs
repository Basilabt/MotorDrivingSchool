using BusinessAccessLayer;
using BusinessAccessLayer.Model;
using MotorDrivingSchool.Screens.Motors;
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
    public partial class frmCoachesScreen : Form
    {
        private DataTable _coaches = new DataTable();

        public frmCoachesScreen()
        {
            InitializeComponent();
        }

        private void frmCoachesScreen_Load(object sender, EventArgs e)
        {
            this._handleDataFetchingProcess();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewCoach form = new frmAddNewCoach();
            form.ShowDialog();
            this._reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteCoach form = new frmDeleteCoach();
            form.ShowDialog();
            this._reload();
        }



        private void _handleDataFetchingProcess()
        {
            this._fetchDataFromDB();
            this._fillDataGridWithData();
            this._resizeDataGridViewColumns();
        }

        private void _fetchDataFromDB()
        {
            this._coaches = clsCoach.getAllCoaches();
        }

        private void _fillDataGridWithData()
        {
            this.dgvCoaches.DataSource = this._coaches;
        }

        private void _resizeDataGridViewColumns()
        {
            dgvCoaches.Columns[0].Width = 50;
            dgvCoaches.Columns[1].Width = 200;
            dgvCoaches.Columns[2].Width = 50;
            dgvCoaches.Columns[3].Width = 75;
            dgvCoaches.Columns[4].Width = 120;
            dgvCoaches.Columns[5].Width = 200;
        }

        private void _reload()
        {
            this._handleDataFetchingProcess();
        }

        private void dgvCoaches_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvCoaches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvCoaches.Rows[e.RowIndex];

                int coachID = (int)clickedRow.Cells[0].Value;

                clsCoach coach = new clsCoach();
                coach = clsCoach.getCoachByCoachID(coachID);


                frmUpdateCoach form = new frmUpdateCoach(coach.personID);          
                form.ShowDialog();

                this._reload();
            }
        }
    }
}
