using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Linq.Expressions;


namespace DataLayer
{
    public class clsUserDataAccess
    {
        public static int AddNewUser(string Email, string Password, string Username)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Users " +
                "(Email, Password, Username) VALUES " +
                "(@Email, @Password, @Username);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Username", Username);
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
                clsLogDataAccess.AddLog(DateTime.Now, "Add User", ex.Message);
                
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }   
        public static bool UpdateUser(int ID, string Email, string Password, string Username)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE Users SET " +
                "Email = @Email, " +
                "Password = @Password, " +
                "Username = @Username " +
                "WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@UserID", ID);

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
        public static bool DeleteUser(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE Records WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

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
        public static DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable users = new DataTable();

            string query = "SELECT * FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    users.Load(reader);
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
            return users;
        }
        public static bool GetUser(ref int ID, ref string Email,
            ref string Password, ref string Username)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users " +
                "WHERE UserID = @UserID or Email = @Email or Username = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Username", Username);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["UserID"];
                    Email = (string)reader["Email"];
                    Password = (string)reader["Password"];
                    Username = (string)reader["Username"];

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch(Exception ex)
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
        public static bool isUserExists(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            bool isFound = false;

            string query = "SELECT found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);

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
                isFound=false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
            
        }
        public static bool isUserExists(string Email)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            bool isFound = false;

            string query = "SELECT found=1 FROM Users WHERE Email = @Email";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email);

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
