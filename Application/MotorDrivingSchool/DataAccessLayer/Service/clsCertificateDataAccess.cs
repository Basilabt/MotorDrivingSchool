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
    public class clsCertificateDataAccess
    {

        public static DataTable getCertificates()
        {
            DataTable dataTable = new DataTable();

            try
            {                    
                string connectionString = ConfigurationManager.ConnectionStrings["Database_Connection_String"].ConnectionString;

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmd = "SP_GetCertificates";
                    using(SqlCommand command = new SqlCommand(cmd,connection))
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

    }
}
