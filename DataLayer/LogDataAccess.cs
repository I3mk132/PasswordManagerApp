using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsLogDataAccess
    {
        public static int AddLog(DateTime Date, string Type, string Description)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Logs " +
                "(Date, Type, Description) VALUES " +
                "(@Date, @Type, @Description);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Type", Type);
            command.Parameters.AddWithValue("@Description", Description);

            int ID = -1;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    ID = id;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ID;
        }

    }
}
