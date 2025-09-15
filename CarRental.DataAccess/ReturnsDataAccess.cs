using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ReturnsDataAccess
    {
        public static DataTable GetAll()
        {
            DataTable ReturnsTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM VehicleReturns";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    ReturnsTable.Load(reader);

                    //reader.Close();
                }
                finally
                {
                    conn.Close();
                }

            }
            return ReturnsTable;
        }
        public static bool FindByReturnID(int ReturnID, ref int RentalID, ref int ActualRentalDays,
                                ref DateTime ActualReturnDate, ref string DamageReport,
                                ref decimal AdditionalCharges, ref decimal CurrentMileage,
                                ref decimal ConsumedMileage)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM VehicleReturns WHERE ReturnID = @ReturnID;";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ReturnID", ReturnID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        ReturnID = (int)reader["ReturnID"];
                        RentalID = (int)reader["RentalID"];
                        ActualRentalDays = (int)reader["ActualRentalDays"];
                        ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                        DamageReport = (string)reader["DamageReport"];
                        AdditionalCharges = (decimal)reader["AdditionalCharges"];
                        CurrentMileage = (decimal)reader["CurrentMileage"];
                        ConsumedMileage = (decimal)reader["ConsumedMileage"];
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
            return isFound;
        }

        public static int AddNew(int RentalID, int ActualRentalDays, DateTime ActualReturnDate,
                                string DamageReport, decimal AdditionalCharges, decimal CurrentMileage,
                                decimal ConsumedMileage)
        {
            int newReturnID = -1;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO VehicleReturns (RentalID, ActualRentalDays, ActualReturnDate, 
                                DamageReport, AdditionalCharges, CurrentMileage, ConsumedMileage) 

                         VALUES (@RentalID, @ActualRentalDays, @ActualReturnDate, @DamageReport,
                     @AdditionalCharges, @CurrentMileage, @ConsumedMileage);
                                SELECT IDENTITY_SCOPE();";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@RentalID", RentalID);
                cmd.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                cmd.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                cmd.Parameters.AddWithValue("@DamageReport", DamageReport);
                cmd.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                cmd.Parameters.AddWithValue("@CurrentMileage", CurrentMileage);
                cmd.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int _ParsedResult))
                    {
                        newReturnID = _ParsedResult;
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
            return newReturnID;
        }
        public static int Update(int ReturnID, int RentalID, int ActualRentalDays, DateTime ActualReturnDate,
                                string DamageReport, decimal AdditionalCharges, decimal CurrentMileage,
                                decimal ConsumedMileage)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                string query = @"UPDATE VehicleReturns SET RentalID = @RentalID, ActualRentalDays=@ActualRentalDays, 
                    ActualReturnDate = @ActualReturnDate,  DamageReport=@DamageReport, AdditionalCharges=@AdditionalCharges,
                    CurrentMileage=@CurrentMileage, ConsumedMileage=@ConsumedMileage WHERE ReturnID = @ReturnID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ReturnID", ReturnID);
                cmd.Parameters.AddWithValue("@RentalID", RentalID);
                cmd.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                cmd.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                cmd.Parameters.AddWithValue("@DamageReport", DamageReport);
                cmd.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                cmd.Parameters.AddWithValue("@CurrentMileage", CurrentMileage);
                cmd.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);

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
        public static int DeleteByReturnID(int ReturnID)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM VehicleReturns WHERE ReturnID = @ReturnID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ReturnID", ReturnID);

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
        public static bool IsExistByReturnID(int ReturnID)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM VehicleReturns WHERE ReturnID = @ReturnID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ReturnID", ReturnID);

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
