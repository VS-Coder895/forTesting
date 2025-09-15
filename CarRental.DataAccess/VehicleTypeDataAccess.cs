using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class VehicleTypeDataAccess
    {
        public static int AddNew(string Name)
        {
            int _VehicleTypeID = -1;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO VehicleTypes(Name) Values ( @Name ); SELECT  SCOPE_IDENTITY ( ) ;  ";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                conn.Open();

                object _result = cmd.ExecuteScalar();

                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                {
                    _VehicleTypeID = _ParsedResult;
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
            return _VehicleTypeID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable();

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleTypes";
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

        public static bool FindByVehicleTypeID(ref int VehicleTypeID, ref string Name)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleTypes WHERE VehicleTypeID = @VehicleTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleTypeID", VehicleTypeID);
            
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    VehicleTypeID = (int)reader["VehicleTypeID"];
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

        public static int DeleteByVehicleTypeID(int VehicleTypeID)
        {
            int affectedRows = 0;
            
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM VehicleTypes WHERE VehicleTypeID = @VehicleTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleTypeID", VehicleTypeID);
            
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

        public static bool IsExistsVehicleTypeID(int VehicleTypeID)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleTypes WHERE VehicleTypeID = @VehicleTypeID";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleTypeID", VehicleTypeID);
            
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

        public static int Update(int VehicleTypeID, string Name)
        {
            int affectedRows = 0;
            
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE VehicleTypes SET Name = @Name WHERE VehicleTypeID = @VehicleTypeID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleTypeID", VehicleTypeID);
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
