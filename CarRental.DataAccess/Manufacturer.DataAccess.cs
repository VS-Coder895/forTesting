using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ManufacturerDataAccess
    {
        public static int AddNew(string Name)
        {
            int _ManufacturerID = -1;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO Manufacturers(Name) Values ( @Name ); SELECT  SCOPE_IDENTITY ( ) ;  ";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();

                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                {
                    _ManufacturerID = _ParsedResult;
                }
            }
            catch
            {
                return -1;
            }
            finally 
            { 
                conn.Close();
            }
            return _ManufacturerID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable();

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Manufacturers";
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
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return table;
        }
        public static bool FindByManufacturerID(ref int ManufacturerID, ref string Name)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Manufacturers WHERE ManufacturerID = @ManufacturerID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ManufacturerID", ManufacturerID);
            
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ManufacturerID = (int)reader["ManufacturerID"];
                    Name = (string)reader["Name"];
                    reader.Close();
                }
                else
                {
                    isFound = false;
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

        public static int DeleteByManufacturerID(int ManufacturerID)
        {
            int affectedRows = 0;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM Manufacturers WHERE ManufacturerID = @ManufacturerID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ManufacturerID", ManufacturerID);
            
            try
            {
                conn.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return affectedRows;
        }

        public static bool IsExistsManufacturerID(int ManufacturerID)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Manufacturers WHERE ManufacturerID = @ManufacturerID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ManufacturerID", ManufacturerID);
            
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
        public static int Update(int ManufacturerID, string Name)
        {
            int affectedRows = 0;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE Manufacturers SET Name = @Name WHERE ManufacturerID = @ManufacturerID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ManufacturerID", ManufacturerID);
            cmd.Parameters.AddWithValue("@Name", Name);
            
            try
            {
                conn.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch
            {
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
