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

namespace MotorDrivingSchool.Screens.Courses
{
    public partial class frmCoursesScreen : Form
    {

        private DataTable _coursesDataTable = new DataTable();

        public frmCoursesScreen()
        {
            InitializeComponent();
        }

        private void frmCoursesScreen_Load(object sender, EventArgs e)
        {
            this._handleDataFetching();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewCourse form = new frmAddNewCourse();
           
            this.Hide();
            form.ShowDialog();
            this.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteCourse form = new frmDeleteCourse();

            this.Hide();
            form.ShowDialog();
            this.Show();

        }

        private void _handleDataFetching()
        {
            this._fetchDataFromDB();
            this._fillDataGridWithData();

            if(this._coursesDataTable.Rows.Count > 0 )
            {
                this._resizeDataGridView();
            }

            
        }

        private void _fetchDataFromDB()
        {
            this._coursesDataTable = clsCourse.getAllCourses();
        }

        private void _fillDataGridWithData()
        {
            this.dgvCourses.DataSource = this._coursesDataTable;
        }

        private void _resizeDataGridView()
        {
            this.dgvCourses.Columns[0].Width = 80;
            this.dgvCourses.Columns[1].Width = 200;
            this.dgvCourses.Columns[2].Width = 150;
            this.dgvCourses.Columns[3].Width = 150;
            this.dgvCourses.Columns[4].Width = 100;
         
        }


    }
}
