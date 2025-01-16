using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public sealed class clsTraineeDataAccess
    {

        public static int addNewTrainee(int personID)
        {
            int newTraineeID = -1;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_AddNewTrainee";
                    using(SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID",personID);

                        Object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            newTraineeID = id;
                        }

                    }
                }



            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }


            return newTraineeID;
        }

        public static bool getTraineeByPersonID(int personID , ref int traineeID)
        {
            bool isFound = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string cmd = "SP_GetTraineeByPersonID";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID",personID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if(reader.Read())
                            {
                                isFound = true;
                                traineeID = (int)reader["TraineeID"];
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


        public static bool getTraineeByTraineeID(int traineeID, ref int personID)
        {
            bool isFound = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string cmd = "SP_GetTraineeByTraineeID";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TraineeID", traineeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                isFound = true;
                                personID = (int)reader["PersonID"];

                            }

                        }
                    }

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }

            return isFound;
        }

        public static DataTable getAllTrainees()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string cmd = "SP_GetAllTrainees ";
                    using(SqlCommand command = new SqlCommand (cmd,connection)) {

                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
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


        public static bool doesTraineeExistByPhoneNumber(string phoneNumber)
        {

            bool isFound = false;

            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string cmd = "SP_DoesTraineeExistByPhoneNumber ";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PhoneNumber",phoneNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isFound = true;
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



    }
}
