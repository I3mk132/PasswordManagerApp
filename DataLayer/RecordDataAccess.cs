using System;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace DataLayer
{
    public class clsRecordDataAccess
    {
        public static int AddNewRecord(string Email, string Username,
            string Password, DateTime Date, string Note, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Records " +
                "(Email, Username, Password, Date, Note, UserID) VALUES " +
                "(@Email, @Username, @Password, @Date, @Note, @UserID);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Note", Note);
            command.Parameters.AddWithValue("@UserID", UserID);

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
                Console.WriteLine(ex.Message);
                // Send to Log
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool UpdateRecord(int ID, string Email, string Username,
            string Password, DateTime Date, string Note, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE Records SET " +
                "Email = @Email, " +
                "Username = @Username, " +
                "Password = @Password, " +
                "Date = @Date, " +
                "Note = @Note, " +
                "UserID = @UserID " +
                "WHERE RecordID = @RecordID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RecordID", ID);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Note", Note);
            command.Parameters.AddWithValue("@UserID", UserID);

            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Send To Log
                return false;
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }
        public static bool DeleteRecord(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE Records WHERE RecordID = @RecordID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RecordID", ID);

            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Send to Log
                return false;
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }
        public static DataTable GetAllRecords()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable records = new DataTable();

            string query = "SELECT RecordID, Email, Username, Password, Date, Note, Users.Username FROM Records JOIN Users ON Records.UserID = Users.UserID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    records.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();

            }
            return records;
        }
        public static DataTable GetUsersAllRecords(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable records = new DataTable();

            string query = "SELECT RecordID, Email, Username, Password, Date, Note FROM Records WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    records.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();

            }
            return records;
        }
        public static DataTable GetUsersAllRowsForColumn(int ID, string col)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable records = new DataTable();

            string query = $"SELECT DISTINCT {col} " +
                "FROM Records " +
                $"WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);
            

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    records.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                clsLogDataAccess.AddLog(DateTime.Now, "GetUsersAllRecords", ex.Message);
            }
            finally
            {
                connection.Close();

            }
            return records;
        }
        public static DataTable GetUsersAllRecordsUsingLike(int ID, string keyword)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable records = new DataTable();

            string query = "SELECT RecordID, Email, Username, Password, Date, Note " +
                "FROM Records " +
                $"WHERE UserID = @UserID and (" +
                $"Email LIKE '%' + @keyword + '%' OR " +
                $"Username LIKE '%' + @keyword + '%' OR " +
                $"Password LIKE '%' + @keyword + '%' OR " +
                $"Note LIKE '%' + @keyword + '%')";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);
            command.Parameters.AddWithValue($"@keyword", keyword);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    records.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                clsLogDataAccess.AddLog(DateTime.Now, "GetUsersAllRecordsUsingLike", ex.Message);

            }
            finally
            {
                connection.Close();

            }
            return records;
        }
        public static DataTable GetUsrsAllRecordsUsingColumnAndKeyward(int ID, string col, string value, string keyword)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable records = new DataTable();

            string query = $"SELECT * " +
                "FROM Records " +
                $"WHERE UserID = @UserID and " +
                $"{col} = @value and ( " +
                $"Email LIKE '%' + @keyword + '%' OR " +
                $"Username LIKE '%' + @keyword + '%' OR " +
                $"Password LIKE '%' + @keyword + '%' OR " +
                $"Note LIKE '%' + @keyword + '%' )";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);
            command.Parameters.AddWithValue("@value", value);
            command.Parameters.AddWithValue("@keyword", keyword);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    records.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                clsLogDataAccess.AddLog(DateTime.Now, "GetUsersAllRecords", ex.Message);
            }
            finally
            {
                connection.Close();

            }
            return records;
        }
        public static bool GetRecord(ref int ID, ref string Email, ref string Username,
            ref string Password, ref DateTime Date, ref string Note, ref int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Records " +
                "WHERE RecordID = @RecordID or Username = @Username or Email = @Email";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RecordID", ID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Email", Email);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["RecordID"];
                    Email = (string)reader["Email"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    Date = (DateTime)reader["Date"];
                    Note = (string)reader["Note"];
                    UserID = (int)reader["UserID"];

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
                // Send to Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool isRecordExists(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            bool isFound = false;

            string query = "SELECT found=1 FROM Records WHERE RecordID = @RecordID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RecordID", ID);

            try
            {
                connection.Open();
                object data = command.ExecuteScalar();

                if (data != null)
                {
                    isFound = true;
                }

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static bool isRecordExists(string UserOrEmail)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            bool isFound = false;

            string query = "SELECT found=1 FROM Records WHERE Username = @UserOrEmail or Email = @UserOrEmail";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserOrEmail", UserOrEmail);
            

            try
            {
                connection.Open();
                object data = command.ExecuteScalar();

                if (data != null)
                {
                    isFound = true;
                }

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        
    }
}
