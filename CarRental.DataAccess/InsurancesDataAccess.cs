using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class InsurancesDataAccess
    {
        public static DataTable GetAll()
        {
            DataTable InsuranceTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Insurances";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        InsuranceTable.Load(reader);
                    }
                    reader.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
            return InsuranceTable;
        }
        public static bool FindByID(int InsuranceID, ref string Name)
        {
            bool isFound = false;
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Insurances WHERE InsuranceID = @InsuranceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@InsuranceID", InsuranceID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        isFound = true;

                        InsuranceID = (int)reader["InsuranceID"];
                        Name = (string)reader["Name"];
                    }
                    reader.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
            return isFound;
        }
        public static int AddNew(string Name)
        {
            int InsuranceID = -1;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Insurances (Name)
                                VALUES (@Name);
                                SELECT IDENTITY_SCOPE();";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", Name);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int _ParsedResult))
                    {
                        InsuranceID = _ParsedResult;
                    }
                }
                finally 
                { 
                    conn.Close();
                }
                return InsuranceID;
            }
        }
        public static int Update(int InsuranceID, string Name)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Insurances SET (Name)
                                VALUES (@Name);
                                WHERE InsuranceID = @InsuranceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@InsuranceID", InsuranceID);

                try
                {
                    conn.Open();
                    affectedRows = cmd.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            }
            return affectedRows;
        }
        public static int Delete(int InsuranceID)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"DELETE FROM Insurances WHERE InsuranceID = @InsuranceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@InsuranceID", InsuranceID);

                try
                {
                    conn.Open();
                    affectedRows = cmd.ExecuteNonQuery();
                }
                finally
                {
                    conn.Close();
                }
            }
            return affectedRows;
        }
        public static bool IsInsuranceExist(int InsuranceID)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"SELECT * FROM Insurances WHERE InsuranceID = @InsuranceID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@InsuranceID", InsuranceID);

                try
                {
                    conn.Open();
                    isFound = cmd.ExecuteScalar() != null;
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
