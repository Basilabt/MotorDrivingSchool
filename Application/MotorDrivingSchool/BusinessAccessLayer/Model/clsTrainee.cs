using DataAccessLayer.Service;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public sealed class clsTrainee
    {
        public enum enMode
        {
            AddNew = 1, Update = 2, Delete = 3
        }

        public int traineeID { get; set; }
        public int personID { get; set; }

        public enMode mode { get; set; }

        // Composition
        public clsPerson person { get; set; }

        public clsTrainee()
        {
            this.traineeID = -1;
            this.personID = -1;
            this.mode = enMode.AddNew;

        }

        private clsTrainee(int traineeID, int personID)
        {
            this.traineeID = traineeID;
            this.personID = personID;
            this.mode = enMode.Update;
            this.person = clsPerson.getPersonByPersonID(personID);

        }

        public bool save()
        {
            switch (this.mode)
            {
                case enMode.AddNew:
                    {
                        this.traineeID = addNewTrainee(this.personID);
                        return this.traineeID != -1;
                    }


                case enMode.Update:
                    {
                        return false;

                    }


                case enMode.Delete:
                    {
                        return false;

                    }
            }



            return false;
        }


        public static int addNewTrainee(int personID)
        {
            return clsTraineeDataAccess.addNewTrainee(personID);
        }

        public static clsTrainee getTraineeByPersonID(int personID)
        {
            int traineeID = -1;

            if(clsTraineeDataAccess.getTraineeByPersonID(personID,ref traineeID))
            {
                return new clsTrainee(traineeID, personID);
            }

            return null;
        }

        public static clsTrainee getTraineeByTraineeID(int traineeID)
        {
            int personID = -1;

            if (clsTraineeDataAccess.getTraineeByTraineeID(traineeID, ref personID))
            {
                return new clsTrainee(traineeID, personID);
            }

            return null;
        }



        public static DataTable getAllTrainees()
        {
            return clsTraineeDataAccess.getAllTrainees();
        }

        public static bool doesTraineeExistByPhoneNumber(string phoneNumber)
        {
            return clsTraineeDataAccess.doesTraineeExistByPhoneNumber(phoneNumber);
        }

    }
}
