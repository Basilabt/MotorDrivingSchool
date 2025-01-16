using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public sealed class clsAdmin
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public int adminID {  get; set; }
        public int personID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool isActive { get; set; }
        public enMode mode { get; set; }

        // Composition
        public clsPerson person { get; set; }

        public clsAdmin() 
        {
            this.adminID = -1;
            this.personID = -1;
            this.mode = enMode.AddNew;
            
        }

        private clsAdmin(int adminID , int personID,string username, string password , bool isActive)
        {
            this.adminID = adminID;
            this.personID = personID;
            this.username = username;
            this.password = password;
            this.isActive = isActive;

            this.mode = enMode.Update;
            this.person = clsPerson.getPersonByPersonID(personID);
        }

        public bool save()
        {
            return false;
        }


        // Static Methods.

        public static bool login(string username , string password)
        {
            int personID = -1;
            int adminID = -1;
            bool isActive = false;

            if(clsAdminDataAccess.login(username,password,ref personID, ref adminID, ref isActive))
            {
                clsGlobal.loggedInAdmin = new clsAdmin(adminID,personID,username,password,isActive);
                return true;
            }


            return false;
        }

        public static bool isAdminAccountActive(string username)
        {
            return clsAdminDataAccess.isAdminAccountActive(username);
        }

    }
}
