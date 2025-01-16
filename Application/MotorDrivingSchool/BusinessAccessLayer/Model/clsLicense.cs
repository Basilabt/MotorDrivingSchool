using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Model
{
    public sealed class clsLicense
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3 
        }

        public enum enLicenseType
        {
            MotorBike = 11 , Scooter = 12
        }

        public int licenseID {  get; set; }
        public enLicenseType licenseType { get; set; }
        public string description { get; set; }
        public enMode mode { get; set; }

        public clsLicense()
        {
            this.licenseID = -1;
            this.licenseType = enLicenseType.Scooter;
            this.description = "";
            this.mode = enMode.AddNew;
        }


        private clsLicense(int licenseID , enLicenseType licenseType , string description)
        {
            this.licenseID = licenseID;
            this.licenseType = licenseType;
            this.description = description;
            this.mode = enMode.Update;
        }


        public bool save()
        {
            return false;
        }


        // Static Methods.

        public static DataTable getLicenses()
        {
            return clsLicenseDataAccess.getLicenses();
        }



    }
}
