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
using System.Windows.Forms.VisualStyles;

namespace MotorDrivingSchool.Screens.Certificates
{
    public partial class frmCertificatesView : Form
    {
        private DataTable _certificates = new DataTable();

        public frmCertificatesView()
        {
            InitializeComponent();
        }

        private void frmCertificatesView_Load(object sender, EventArgs e)
        {
            this._handleCertificatesFetching();
        }


        private void _handleCertificatesFetching()
        {
            this._fetchDataFromDB();
            this._fillDataGridWithData();

            if(this._certificates.Rows.Count > 0)
            {
                this._resizeDataGridColumns();
            }
        }

        private void _fetchDataFromDB()
        {
            this._certificates = clsCertificate.getCertificates();
        }

        private void _fillDataGridWithData()
        {
            this.dgvCertificatees.DataSource = this._certificates;
        }

        private void _resizeDataGridColumns()
        {
            this.dgvCertificatees.Columns[0].Visible = false;
            this.dgvCertificatees.Columns[1].Width = 300;
            this.dgvCertificatees.Columns[2].Width = 150;
        }
    }
}
