using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public sealed class clsMotorDataAccess
    {
        public static DataTable getAllMotors()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetAllMotors";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using(SqlDataReader reader =  command.ExecuteReader())
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

        public static DataTable getMotorsModels()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetMotorsModels";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
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

        public static DataTable getMotorsChassisNumbers()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetMotorsChassisNumbers";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }

            return dataTable;

        }

        public static bool deleteMotorByChassisNumber(string chassisNumber)
        {
            int numberOfAffectedNumbers = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_DeleteMotorByChassisNumber";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ChassisNumber", chassisNumber);

                        numberOfAffectedNumbers = command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }



            return numberOfAffectedNumbers >= 1;
        }

        public static bool getMotorByChassisNumber(ref int motorID ,  string chassisNumber , ref string model , ref int engineCapacity , ref string imagePath)
        {
            bool isFound = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetMotorByChassisNumber";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ChassisNumber", chassisNumber);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {

                            if(reader.Read())
                            {
                                isFound = true;

                                motorID = (int)reader["MotorID"];
                                model = (string)reader["Model"];
                                engineCapacity = (int)reader["EngineCapacity"];
                                imagePath = (string)reader["ImagePath"];

                            }
                        }
                    }
                }

            } catch (Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }



            return isFound;
        }

        public static bool addNewMotor(string chassisNumber , string model , int engineCapacity , string imagePath)
        {
            int numberOfAffectedRows = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_AddNewMotor";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ChassisNumber", chassisNumber);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@EngineCapacity", engineCapacity);
                        command.Parameters.AddWithValue("@ImagePath", imagePath);

                        numberOfAffectedRows = command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }



            return numberOfAffectedRows >= 1;
        }

        public static  bool updateMotor(int motorID, string chassisNumber, string model, int engineCapacity, string imagePath)
        {
            int numberOfAffectedRows = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_UpdateMotor";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MotorID", motorID);
                        command.Parameters.AddWithValue("@ChassisNumber",chassisNumber);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@EngineCapacity", engineCapacity);
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
