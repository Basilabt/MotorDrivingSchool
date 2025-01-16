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
    public sealed class clsCoachDataAccess
    {

        public static DataTable getAllCoaches()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetAllCoaches";
                    using(SqlCommand command = new SqlCommand(cmd, connection)) 
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

            }






            return dataTable;
        }

        public static bool getCoachByCoachID(int coachID , ref int personID)
        {
            bool isFound = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string cmd = "SP_GetCoachByCoachID";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CoachID",coachID);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isFound = true;
                                personID = (int)reader["PersonID"];
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

        public static bool deleteCoachByCoachID(int coachID)
        {
            int numberOfAffectedRows = 0;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_DeleteCoachByCoachID";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CoachID",coachID);

                        numberOfAffectedRows = command.ExecuteNonQuery();

                    }

                }

            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }


            return numberOfAffectedRows >= 1;
        }

        public static int addNewCoach(int personID)
        {
            int newCoachID = -1;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_AddNewCoach";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);
   

                        Object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            newCoachID = id;
                        }
                    }

                }

            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }


            return newCoachID;
                
        }



    }
}
