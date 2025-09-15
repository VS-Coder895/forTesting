using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserDataAccess
    {
        public static bool FindByUserID(ref int ID, ref string Username,
            ref string Password, ref string Role)

        {
            bool isFound = false;
            string query = "";
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                query = "SELECT * FROM Users WHERE UserID = @ID";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        ID = (int)reader["UserID"];
                        Username = reader["Username"].ToString();
                        Password = reader["Password"].ToString();
                        Role = reader["Role"].ToString();

                        isFound = true;
                    }

                }
                catch
                {
                    isFound = false;
                }
                finally
                {
                    connection.Close();
                }

            }

            return isFound;
        }
        public static bool FindByUserNameAndPassword(ref string Username,
            ref string Password, ref int ID, ref string Role)
        {
            bool isFound = false;
            string query = "";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserName", Username);
                command.Parameters.AddWithValue("@Password", Password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        ID = (int)reader["UserID"];
                        Username = reader["Username"].ToString();
                        Password = reader["Password"].ToString();
                        Role = reader["Role"].ToString();

                        isFound = true;
                    }

                }
                catch
                {
                    isFound = false;
                }
                finally { connection.Close(); }

            }

            return isFound;
        }
        public static bool AddNewUser(string Username, string Password, string Role)
        {
            int newID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Users (Username, Password, Role) 
                                VALUES (@Username, @Password, @Role); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Role", Role);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (int.TryParse(result.ToString(), out int ParsedID))
                {
                    newID = ParsedID;
                }
            }
            finally
            {
                connection.Close();
            }

            return newID != -1;
        }
        public static bool UpdateUser(int UserID, string Username, string Password, string Role)
        {
            int RowAffected = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET Username=@Username, Password=@Password, Role=@Role where UserID=@UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Role", Role);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

            return RowAffected != -1;
        }
        public static int DeleteByUserID(int UserID)
        {
            int rowsAffected = -1;
            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch
                {
                    connection.Close();
                }
            }

            return rowsAffected;
        }
        public static bool IsExistsByID(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT 1 FROM Users WHERE ID = @ID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                isFound = command.ExecuteScalar() != null;

            }
            catch
            {
                connection.Close();
            }

            return isFound;
        }
        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "Select * from Users";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

    }
}
