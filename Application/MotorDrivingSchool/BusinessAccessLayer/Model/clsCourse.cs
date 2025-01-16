using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Model
{
    public sealed class clsCourse
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }
        
        public int courseID {  get; set; }
        public int coachID { get; set; }
        public int traineeID { get; set; }
        public int licenseID {  get; set; }
        public float remainingHours { get; set; }
        public enMode mode { get; set; }
        public clsCoach coach { get; set; }
        public clsTrainee trainee { get; set; }

        public clsCourse()
        {
            this.courseID = -1;
            this.coachID = -1;
            this.traineeID = -1;
            this.licenseID = -1;
            this.remainingHours = -1;
            this.mode = enMode.AddNew;
        }

        private clsCourse(int courseID, int coachID, int traineeID, int licenseID, float remainingHours)
        {
            this.courseID = courseID;
            this.coachID = coachID;
            this.traineeID = traineeID;
            this.licenseID = licenseID;
            this.remainingHours = remainingHours;

            this.mode = enMode.Update;
            this.coach = clsCoach.getCoachByCoachID(coachID);
            this.trainee = clsTrainee.getTraineeByTraineeID(traineeID);
        }


        public bool save()
        {
            switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        this.courseID = addNewCourse(this.coachID,this.traineeID,this.licenseID,this.remainingHours);
                        return this.coachID != -1;
                    }

                case enMode.Update:
                    {   
                        return clsCourseDataAccess.updateCourseInfo(this.courseID,this.coachID,this.traineeID,this.licenseID,this.remainingHours);
                    }

                
                case enMode.Delete:
                    {
                        return deleteCourseByCourseID(this.courseID);
                    }

            }

            return false;
        }


        public static int addNewCourse(int coachID, int traineeID, int licenseID, float remainingHours)
        {
            return clsCourseDataAccess.addNewCourse(coachID,traineeID,licenseID,remainingHours);
        }


        public static DataTable getAllCourses()
        {
            return clsCourseDataAccess.getAllCourses();
        }

        public static bool deleteCourseByCourseID(int coachID)
        {
            return clsCourseDataAccess.deleteCourseByCourseID(coachID);
        }

        public static clsCourse findCourseByCourseID(int courseID)
        {
            int coachID = -1;
            int traineeID = -1;
            int licenseID = -1;
            float remainingHours = -1;

            if(clsCourseDataAccess.findCourseByCourseID(courseID,ref coachID,ref traineeID,ref licenseID,ref remainingHours))
            {
                return new clsCourse(courseID,coachID,traineeID,licenseID,remainingHours);
            }

            return null;
        }


        public static clsCourse findCourseByTraineePhoneNumber(string phoneNumber)
        {

            int courseID = -1;
            int coachID = -1;
            int traineeID = -1;
            int licenseID = -1;
            float remainingHours = -1;

            if (clsCourseDataAccess.findCourseByTraineePhoneNumber(phoneNumber,ref courseID, ref coachID, ref traineeID, ref licenseID, ref remainingHours))
            {
                return new clsCourse(courseID, coachID, traineeID, licenseID, remainingHours);
            }

            return null;
        }


    }
}
