using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public sealed class clsPersonDataAccess
    {

        public static bool getPersonByPersonID(int personID , ref string firstName , ref string secondName , ref string thirdName , ref string lastName , ref bool gender , ref DateTime birthDate , ref string phoneNumber , ref string email , ref string imagePath)
        {
            bool isFound = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "Sp_GetPersonByPersonID";
                    using(SqlCommand command = new SqlCommand(cmd,connection)) 
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);

                        using(SqlDataReader reader = command.ExecuteReader()) 
                        {
                            if(reader.Read())
                            {
                                isFound = true;
                          
                                firstName = (string)reader["FirstName"];
                                secondName = (string)reader["SecondName"];
                                thirdName = (string)reader["ThirdName"];
                                lastName = (string)reader["LastName"];
                                gender = (bool)reader["Gender"];
                                birthDate = (DateTime)reader["BirthDate"];
                                phoneNumber = (string)reader["PhoneNumber"];
                                email = (string)reader["Email"];
                                imagePath = (string)reader["ImagePath"];

                            }
                        }                                        
                    }
                }

            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }

            return isFound;
        }

        public static int addNewPerson(string firstName, string secondName, string thirdName, string lastName, bool gender, DateTime birthDate, string phoneNumber, string email, string imagePath)
        {
            int newPersonID = -1;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_AddNewPerson";
                    using(SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@SecondName", secondName);
                        command.Parameters.AddWithValue("@ThirdName", thirdName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gender", gender); 
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@ImagePath", imagePath);

                        Object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            newPersonID = id;
                        }
                    }

                }

            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }

            return newPersonID;
        }

        public static bool updatePerson(int personID , string firstName, string secondName, string thirdName, string lastName, bool gender, DateTime birthDate, string phoneNumber, string email, string imagePath)
        {
            int numberOfAffectedRows = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_UpdatePerson";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID",personID);
                        command.Parameters.AddWithValue("@FirstName",firstName);
                        command.Parameters.AddWithValue("@SecondName", secondName);
                        command.Parameters.AddWithValue("@ThirdName", thirdName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@ImagePath", imagePath);

                        numberOfAffectedRows = command.ExecuteNonQuery();
                    }

                }



            } catch(Exception exception) 
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }
            



            return numberOfAffectedRows >= 1;
        }


    }
}
