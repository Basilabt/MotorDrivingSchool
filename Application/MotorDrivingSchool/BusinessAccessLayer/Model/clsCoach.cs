using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public sealed class clsCoach
    {
        public enum enMode
        {
            AddNew = 1, Update = 2, Delete = 3
        }

        public int coachID { get; set; }
        public int personID { get; set; }

        public enMode mode { get; set; }

        // Composition
        public clsPerson person { get; set; }

        public clsCoach()
        {
            this.coachID = -1;
            this.personID = -1;
            this.mode = enMode.AddNew;

        }

        private clsCoach(int coachID, int personID)
        {
            this.coachID = coachID;
            this.personID = personID;
            this.mode = enMode.Update;
            this.person = clsPerson.getPersonByPersonID(personID);
        }

        public bool save()
        {
            switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        this.coachID = addNewCoach(this.personID);
                        return this.coachID != -1;
                    }


                case enMode.Update:
                    {
                        return false;
                    }


                case enMode.Delete:
                    {
                        return clsCoach.deleteCoachByCoachID(this.coachID);
                    }

            }


            return false;
        }


        // Static Methods

        public static DataTable getAllCoaches()
        {
            return clsCoachDataAccess.getAllCoaches();
        }

        public static clsCoach getCoachByCoachID(int coachID)
        {
            int personID = -1;

            if(clsCoachDataAccess.getCoachByCoachID(coachID,ref personID))
            {
                return new clsCoach(coachID, personID);
            }

            return null;
        }

        public static bool deleteCoachByCoachID(int coachID)
        {
            return clsCoachDataAccess.deleteCoachByCoachID(coachID);
        }

        public static int addNewCoach(int personID)
        {
            return clsCoachDataAccess.addNewCoach(personID);
        }

    }
}
