using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessAccessLayer
{
    public sealed class clsPerson
    {
        public enum enMode
        {
            AddNew = 1 , Update = 2 , Delete = 3
        }

        public enum enGender
        {
            Male = 1 , Female = 2 , Empty = 3
        }

        public int personID {  get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string thirdName { get; set; }
        public string lastName { get; set; }
        public enGender gender { get; set; }
        public DateTime birthDate { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string imagePath { get; set; }

        public string fullname
        {
            get
            {
                return this.firstName + " " + this.secondName + " " + this.thirdName + " " + this.lastName;
            }
        }

        public enMode mode { get; set; }

        public clsPerson()
        {
            this.personID = -1;
            this.firstName = "";
            this.secondName = "";
            this.thirdName = "";
            this.lastName = "";
            this.gender = enGender.Empty;
            this.birthDate = DateTime.MinValue;
            this.phoneNumber = "";
            this.email = "";
            this.imagePath = "";
            this.mode = enMode.AddNew;
        }

        private clsPerson(int personID, string firstName, string secondName, string thirdName, string lastName, enGender gender, DateTime birthDate, string phoneNumber, string email, string imagePath)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.imagePath = imagePath;
            this.mode = enMode.Update;
        }

        public bool save()
        {
            switch(this.mode)
            {

                case enMode.AddNew:
                    {
                        this.personID = addNewPerson(this.firstName,this.secondName,this.thirdName,this.lastName,this.gender,this.birthDate,this.phoneNumber,this.email,this.imagePath);
                        return this.personID != -1;
                    }


                case enMode.Update:
                    {
                        return updatePerson(this.personID,this.firstName, this.secondName, this.thirdName, this.lastName, this.gender, this.birthDate, this.phoneNumber, this.email, this.imagePath);
                    }


                case enMode.Delete:
                    {
                        return false;
                    }

            }


            return false;
        }

        // Static Methods

        public static clsPerson getPersonByPersonID(int personID)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "", phoneNumber = "", email = "", imagePath = "";
            bool isMale = false;
            DateTime birthDate = DateTime.Now;

            if (clsPersonDataAccess.getPersonByPersonID(personID, ref firstName, ref secondName, ref thirdName, ref lastName,ref isMale,ref birthDate,ref phoneNumber,ref email,ref imagePath))
            {
                return new clsPerson(personID,firstName,secondName,thirdName,lastName,isMale ? enGender.Male :enGender.Female,birthDate,phoneNumber,email,imagePath);
            }


            return null;
        }

        public int addNewPerson(string firstName, string secondName, string thirdName, string lastName, enGender gender, DateTime birthDate, string phoneNumber, string email, string imagePath)
        {
            return clsPersonDataAccess.addNewPerson(firstName,secondName,thirdName,lastName,(gender == enGender.Male),birthDate,phoneNumber,email,imagePath);
        }


        public bool updatePerson(int personID , string firstName, string secondName, string thirdName, string lastName, enGender gender, DateTime birthDate, string phoneNumber, string email, string imagePath)
        {
            return clsPersonDataAccess.updatePerson(personID,firstName,secondName,thirdName,lastName, (gender == enGender.Male), birthDate,phoneNumber,email,imagePath);
        }


    }
}
