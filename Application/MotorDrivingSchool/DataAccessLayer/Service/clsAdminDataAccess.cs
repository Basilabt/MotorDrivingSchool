using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Odbc;

namespace DataAccessLayer.Service
{
    public sealed class clsAdminDataAccess
    {        

        public static bool login(string username , string password , ref int personID , ref int adminID , ref bool isActive)
        {
            bool isSucceed = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_Login";
                    using (SqlCommand command = new SqlCommand(cmd, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username",username);
                        command.Parameters.AddWithValue("@Password", password);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isSucceed = true;

                                adminID = (int)reader["AdminID"];
                                username = (string)reader["Username"];
                                password = (string)reader["Password"];
                                isActive = (bool)reader["IsActive"];

                            }

                        }

                    }

                }



            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }

            return isSucceed;
        }

        public static bool isAdminAccountActive(string username)
        {
            bool isActive = false;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {   
                    connection.Open();

                    string cmd = "SP_IsAdminAccountActive";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username",username);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                isActive = true;
                            }

                        }

                    }

                }

            } catch(Exception exception)
            {
                Console.WriteLine($"DEBUG: {exception.Message}");
            }

                return isActive;
        }




    }
}
