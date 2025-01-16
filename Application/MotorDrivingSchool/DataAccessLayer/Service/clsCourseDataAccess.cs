using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public sealed class clsCourseDataAccess
    {

        public static int addNewCourse(int coachID , int traineeID , int licenseID , float remainingHours)
        {
            int newCourseID = -1;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string cmd = "SP_AddNewCourse";
                    using(SqlCommand command = new SqlCommand(cmd, connection)) 
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CoachID",coachID);
                        command.Parameters.AddWithValue("@TraineeID", traineeID);
                        command.Parameters.AddWithValue("@LicenseID", licenseID);
                        command.Parameters.AddWithValue("@RemainingHours", remainingHours);

                        Object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            newCourseID = id;
                        }

                    }

                }




            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.ToString()}");               
            }

            return newCourseID;
        }

        public static DataTable getAllCourses()
        {

            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetAllCourses";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using(SqlDataReader reader = command.ExecuteReader()) 
                        {                         
                            if(reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                                                                                                                    
                        }
                    }
                }


            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }




            return dataTable;
        }

        public static bool deleteCourseByCourseID(int courseID)
        {
            int numberOfAffectedRows = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_DeleteCourseByCourseID";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        
                        numberOfAffectedRows = command.ExecuteNonQuery();
                    }

                }

            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }


            return numberOfAffectedRows >= 1;
        }

        public static bool findCourseByCourseID(int courseID , ref int coachID , ref int traineeID , ref int licenseID , ref float remainingHours)
        {
            bool isFound = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetCourseByCourseID";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {   
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CourseID",courseID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;

                                coachID = (int)reader["CoachID"];
                                traineeID = (int)reader["TraineeID"];
                                licenseID = (int)reader["LicenseID"];
                                remainingHours = (float)reader["RemainingHours"];

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

        public static bool findCourseByTraineePhoneNumber(string phoneNumber,ref int courseID , ref int coachID , ref int traineeID , ref int licenseID , ref float remainingHours)
        {
            bool isFound = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string cmd = "SP_GetCourseByTraineePhoneNumber";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PhoneNumber",phoneNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                courseID = (int)reader["CourseID"];
                                coachID = (int)reader["CoachID"];
                                traineeID = (int)reader["TraineeID"];
                                licenseID = (int)reader["TraineeID"];
                                remainingHours = (float)reader["RemainingHours"];


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

        public static bool updateCourseInfo(int courseID , int coachID , int traineeID , int licenseID , float remainingHours)
        {
            int numberOfAffectedRows = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_UpdateCourseInfo";
                    using(SqlCommand command = new SqlCommand (cmd,connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@CourseID",courseID);
                        command.Parameters.AddWithValue("@CoachID", coachID);
                        command.Parameters.AddWithValue("@TraineeID", traineeID);
                        command.Parameters.AddWithValue("@LicenseID", licenseID);
                        command.Parameters.AddWithValue("@RemainingHours", remainingHours);

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
