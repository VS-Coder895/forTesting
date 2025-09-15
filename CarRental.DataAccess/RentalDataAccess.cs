using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class RentalDataAccess
    {
        public static bool FindByID(int RentalID, ref int VehicleID, ref int CustomerID,
                                    ref int UserID, ref DateTime StartDate, ref DateTime EndDate,
                                    ref string InitialCheckNotes, ref string PickupLocation,
                                    ref string DropOffLocation, ref int? InsuranceID,
                                    ref decimal DailyRate, ref int RentalDays, ref decimal TotalDue)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM VehicleRentals WHERE RentalID = @RentalID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RentalID", RentalID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    VehicleID = (int)reader["VehicleID"];
                    CustomerID = (int)reader["CustomerID"];
                    UserID = (int)reader["UserID"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    InitialCheckNotes = reader["InitialCheckNotes"].ToString();
                    PickupLocation = reader["PickupLocation"].ToString();
                    DropOffLocation = reader["DropOffLocation"].ToString();
                    InsuranceID = reader["InsuranceID"] == DBNull.Value ? (int?)null : (int)reader["InsuranceID"];
                    DailyRate = (decimal)reader["RentalPricePerDay"];
                    RentalDays = (int)reader["InitialRentalDays"];
                    TotalDue = (decimal)reader["InitialTotalDueAmount"];
                }
                reader.Close();
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

        public static int AddNew(int VehicleID, int CustomerID, int UserID, DateTime StartDate, DateTime EndDate,
                                 string InitialCheckNotes, string PickupLocation, string DropOffLocation,
                                 int? InsuranceID, decimal DailyRate, int RentalDays, decimal TotalDue)
        {
            int RentalID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"INSERT INTO VehicleRentals 
                (
                    VehicleID, CustomerID, UserID, StartDate, EndDate, InitialCheckNotes,
                    PickupLocation, DropOffLocation, InsuranceID, RentalPricePerDay, 
                    InitialRentalDays, InitialTotalDueAmount
                )
                VALUES
                (
                    @VehicleID, @CustomerID, @UserID, @StartDate, @EndDate, @Notes,
                    @PickupLocation, @DropOffLocation, @InsuranceID, @DailyRate,
                    @RentalDays, @TotalDue
                );
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@Notes", InitialCheckNotes ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
            command.Parameters.AddWithValue("@DropOffLocation", DropOffLocation);
            command.Parameters.AddWithValue("@InsuranceID", (object)InsuranceID ?? DBNull.Value);
            command.Parameters.AddWithValue("@DailyRate", DailyRate);
            command.Parameters.AddWithValue("@RentalDays", RentalDays);
            command.Parameters.AddWithValue("@TotalDue", TotalDue);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    RentalID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return RentalID;
        }

        public static bool Update(int RentalID, DateTime EndDate, string DropOffLocation, decimal TotalDue)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE VehicleRentals  
                             SET EndDate = @EndDate, 
                                 DropOffLocation = @DropOffLocation, 
                                 InitialTotalDueAmount = @TotalDue
                             WHERE RentalID = @RentalID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RentalID", RentalID);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@DropOffLocation", DropOffLocation);
            command.Parameters.AddWithValue("@TotalDue", TotalDue);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VehicleRentals";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool Delete(int RentalID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"DELETE FROM VehicleRentals 
                             WHERE RentalID = @RentalID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RentalID", RentalID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool IsRentalExist(int RentalID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM VehicleRentals WHERE RentalID = @RentalID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RentalID", RentalID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
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

