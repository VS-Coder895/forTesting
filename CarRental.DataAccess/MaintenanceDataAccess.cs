using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class MaintenanceDataAccess
    {
        public static DataTable GetAll()
        {
            DataTable maintenanceTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Maintenance";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        maintenanceTable.Load(reader);
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
                return maintenanceTable;
            }
        }
        public static bool FindByMaintenanceID(int MaintenanceID, ref int VehicleID, ref string Description,
            ref DateTime MaintenanceDate, ref decimal Cost)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Maintenance WHERE MaintenanceID = @MaintenanceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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
        }
        public static int AddNew(int VehicleID, string Description, 
            DateTime MaintenanceDate, decimal Cost)
        {
            int MaintenanceID = -1;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Maintenance (VehicleID, Description, MaintenanceDate, Cost)
                                VALUES (@VehicleID, @Description, @MaintenanceDate, @Cost)
                                SELECT IDENTITY_SCOPE();";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
                cmd.Parameters.AddWithValue("@Cost", Cost);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int _ParsedResult))
                    {
                        MaintenanceID = _ParsedResult;
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
                return MaintenanceID;
            }
        }
        public static int Update(int MaintenanceID, int VehicleID, string Description,
            DateTime MaintenanceDate, decimal Cost)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Maintenance SET (VehicleID, Description, MaintenanceDate, Cost)
                                VALUES (@VehicleID, @Description, @MaintenanceDate, @Cost)
                                WHERE MaintenanceID = @MaintenanceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);
                cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
                cmd.Parameters.AddWithValue("@Cost", Cost);

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
            }
            return affectedRows;
        }
        public static int Delete(int MaintenanceID)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM Maintenance WHERE MaintenanceID = @MaintenanceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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
            }
            return affectedRows;
        }
        public static bool IsExist(int MaintenanceID)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Maintenance WHERE MaintenanceID = @MaintenanceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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
            }
            return isFound;
        }
    }
}
