using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class EngineTypeDataAccess
    {
        public static int AddNew(string Name)
        {
            int _EngineTypeID = -1;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"INSERT INTO EngineTypes (Name) Values (@Name);
                                SELECT  SCOPE_IDENTITY ( ) ;";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                {
                    _EngineTypeID = _ParsedResult;
                }
            }
            catch
            {
                return _EngineTypeID;
            }
            finally 
            { 
                conn.Close();
            }
            return _EngineTypeID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable();

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM EngineTypes";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return table;
        }

        public static bool FindByEngineTypeID(ref int EngineTypeID, ref string Name)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM EngineTypes WHERE EngineTypeID = @EngineTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EngineTypeID", EngineTypeID);
            
            try
            {
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    EngineTypeID = (int)reader["EngineTypeID"];
                    Name = (string)reader["Name"];
                    
                    reader.Close();
                }
            }
            catch 
            {
                return false;
            }
            finally 
            { 
                conn.Close();
            }
            return isFound;
        }

        public static int DeleteByEngineTypeID(int EngineTypeID)
        {
            int affectedRows = 0;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM EngineTypes WHERE EngineTypeID = @EngineTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EngineTypeID", EngineTypeID);
            
            try
            {
                conn.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch
            {
                return affectedRows;
            }
            finally
            {
                conn.Close();
            }
            return affectedRows;
        }

        public static bool IsExistsEngineTypeID(int EngineTypeID)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM EngineTypes WHERE EngineTypeID = @EngineTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EngineTypeID", EngineTypeID);
            
            try
            {
                conn.Open();
                isFound = cmd.ExecuteScalar() != null;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return isFound;
        }

        public static int Update(int EngineTypeID, string Name)
        {
            int affectedRows = 0;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE EngineTypes SET Name = @Name WHERE EngineTypeID = @EngineTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EngineTypeID", EngineTypeID);
            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                conn.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch
            {
                // no affected rows
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return affectedRows;
        }
    }
}
