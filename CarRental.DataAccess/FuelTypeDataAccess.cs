using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class FuelTypeDataAccess
    {
        public static int AddNew(string Name)
        {
            int _FuelTypeID = -1;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"INSERT INTO FuelTypes (Name) Values (@Name);
                            SELECT  SCOPE_IDENTITY ();";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                conn.Open();

                object _result = cmd.ExecuteScalar();
                
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                {
                    _FuelTypeID = _ParsedResult;
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
            return _FuelTypeID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable();

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM FuelTypes";
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

        public static bool FindByFuelTypeID(ref int FuelTypeID, ref string Name)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM FuelTypes WHERE FuelTypeID = @FuelTypeID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            
            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    FuelTypeID = (int)reader["FuelTypeID"];
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
                isFound = false;
            }
            finally 
            { 
                conn.Close();
            }
            return isFound;
        }

        public static int DeleteByFuelTypeID(int FuelTypeID)
        {
            int affectedRows = 0; 
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM FuelTypes WHERE FuelTypeID = @FuelTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            
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

        public static bool IsExistsFuelTypeID(int FuelTypeID)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM FuelTypes WHERE FuelTypeID = @FuelTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);

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

        public static int Update(int FuelTypeID, string Name)
        {
            int affectedRows = 0;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE FuelTypes SET Name = @Name WHERE FuelTypeID = @FuelTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
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