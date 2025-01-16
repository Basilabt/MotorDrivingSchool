using BusinessAccessLayer;
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

namespace MotorDrivingSchool.Controls
{
    public partial class ctrNewCourseInfo : UserControl
    {
        public ctrNewCourseInfo()
        {
            InitializeComponent();
        }

        private void ctrNewCourseInfo_Load(object sender, EventArgs e)
        {
            this._fillComboBoxesWithData();
        }

        public int getSelectedCoachID()
        {
            int selectedCoachID = Convert.ToInt32(comboboxCoaches.SelectedValue);
            return selectedCoachID;
        }

        public int getSelectedLicenseTypeID()
        {
            int selectedLicenseTypeID = Convert.ToInt32(comboboxLicenseTypes.SelectedValue);
            return selectedLicenseTypeID;
        }






        private void _fillComboBoxesWithData()
        {
            this._fillCoachesComboBox();
            this._fillLicenseTypesComboBox();
        }

        private void _fillCoachesComboBox()
        {
            DataTable dataTable =  clsCoach.getAllCoaches();

            comboboxCoaches.DataSource = dataTable;

            if (dataTable == null || dataTable.Rows.Count == 0)
            {                
                return;
            }

            comboboxCoaches.DisplayMember = "Fullname"; 
            comboboxCoaches.ValueMember = "CoachID";
        }

        private void _fillLicenseTypesComboBox()
        {
            DataTable dataTable = clsLicense.getLicenses();

            comboboxLicenseTypes.DataSource = dataTable;

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                return;
            }

            comboboxLicenseTypes.DisplayMember = "Description";
            comboboxLicenseTypes.ValueMember = "LicenseID";
        }

      


    }
}
