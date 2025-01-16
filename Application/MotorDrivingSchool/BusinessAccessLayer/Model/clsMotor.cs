using DataAccessLayer.Service;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Model
{
    public sealed class clsMotor
    {
        public enum enMode
        {
            AddNew = 0 , Update = 1 , Delete = 2
        }

        public int motorID {  get; set; }
        public string chassisNumber { get; set; }
        public string model {  get; set; }
        public int engineCapacity { get; set; }
        public string imagePath { get; set; }
        public enMode mode { get; set; }
        
        public clsMotor()
        {
            this.chassisNumber = "";
            this.model = "";
            this.engineCapacity = -1;
            this.imagePath = "";
            this.mode = enMode.AddNew;
        }

        private clsMotor(int motorID,string chassisNumber, string model , int engineCapacity , string imagePath)
        {
            this.motorID = motorID;
            this.chassisNumber = chassisNumber;
            this.model = model;
            this.engineCapacity = engineCapacity;
            this.imagePath = imagePath;
            this.mode = enMode.Update;
        }

       
        public bool save()
        {
            switch (this.mode)
            {
                case enMode.AddNew:
                    {
                        return addNewMotor(this.chassisNumber,this.model,this.engineCapacity,this.imagePath);
                    }


                case enMode.Update:
                    {
                        return updateMotor(this.motorID,this.chassisNumber,this.model,this.engineCapacity,this.imagePath);
                    }


                case enMode.Delete:
                    {
                        return deleteMotorByChassisNumber(this.chassisNumber);
                    }

            }

            return false;
        }

        // Static Methods.

        public static DataTable getAllMotors()
        {
            return clsMotorDataAccess.getAllMotors();
        }

        public static DataTable getMotorsModels()
        {
            return clsMotorDataAccess.getMotorsModels();
        }

        public static DataTable getMotorsChassisNumbers()
        {
            return clsMotorDataAccess.getMotorsChassisNumbers();
        }

        public static bool deleteMotorByChassisNumber(string chassisNumber)
        {
            return clsMotorDataAccess.deleteMotorByChassisNumber(chassisNumber);
        }

        public static clsMotor getMotorByChassisNumber(string chassisNumber)
        {
            int motorID = -1;
            int engineCapacity = -1;
            string model = "";
            string imagePath = "";

            if (clsMotorDataAccess.getMotorByChassisNumber(ref motorID,chassisNumber,ref model,ref engineCapacity,ref imagePath))
            {
                return new clsMotor(motorID, chassisNumber, model, engineCapacity, imagePath);
            }

            return null;
        }

        public static bool addNewMotor(string chassisNumber , string model , int engineCapacity , string imagePath)
        {
            return clsMotorDataAccess.addNewMotor(chassisNumber,model,engineCapacity,imagePath);
        }

        public static bool updateMotor(int motorID , string chassisNumber , string model , int engineCapacity , string imagePath)
        {
            return clsMotorDataAccess.updateMotor(motorID,chassisNumber,model,engineCapacity,imagePath);
        }

    }
}
