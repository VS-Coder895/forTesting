using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PaymentDataAccess
    {
        public static DataTable GetAll()
        {
            DataTable paymentTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM RentalPayments";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        paymentTable.Load(reader);
                    }

                    reader.Close();
                }
                finally
                {
                    conn.Close();
                }
                return paymentTable;
            }
        }
        public static bool FindByPaymentID(int PaymentID, ref int RentalID, ref DateTime PaymentDate,
                                    ref string PaymentStatus, ref string PaymentNotes, ref decimal? TotalRefundedAmount,
                                        ref decimal InitialPaidAmount, ref decimal TotalRemainingAmount,
                                        ref decimal? ActualFinalAmountDue, ref DateTime? UpdatedPaymentDate)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM RentalPayments WHERE PaymentID = @PaymentID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        RentalID = (int)reader["RentalID"];
                        PaymentDate = (DateTime)reader["PaymentDate"];
                        PaymentStatus = (string)reader["PaymentStatus"];
                        PaymentNotes = (string)reader["PaymentNotes"];
                        TotalRefundedAmount = Convert.IsDBNull(reader["TotalRefundedAmount"]) ? null : (Decimal?)reader["TotalRefundedAmount"];
                        InitialPaidAmount = (decimal)reader["InitialPaidAmount"];
                        TotalRemainingAmount = (decimal)reader["TotalRemainingAmount"];
                        ActualFinalAmountDue = Convert.IsDBNull(reader["ActualFinalAmountDue"]) ? null : (Decimal?)reader["ActualFinalAmountDue"];
                        UpdatedPaymentDate = Convert.IsDBNull(reader["UpdatedPaymentDate"]) ? null : (DateTime?)reader["UpdatedPaymentDate"];
                    }
                    reader.Close();
                }
                catch
                {
                    isFound = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return isFound;
        }
        public static bool FindByRentalID(int RentalID, ref int PaymentID, ref DateTime PaymentDate,
                                    ref string PaymentStatus, ref string PaymentNotes, ref decimal? TotalRefundedAmount,
                                        ref decimal InitialPaidAmount, ref decimal TotalRemainingAmount,
                                        ref decimal? ActualFinalAmountDue, ref DateTime? UpdatedPaymentDate)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM RentalPayments WHERE RentalID = @RentalID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@RentalID", RentalID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        PaymentID = (int)reader["PaymentID"];
                        PaymentDate = (DateTime)reader["PaymentDate"];
                        PaymentStatus = (string)reader["PaymentStatus"];
                        PaymentNotes = (string)reader["PaymentNotes"];
                        TotalRefundedAmount = Convert.IsDBNull(reader["TotalRefundedAmount"]) ? null : (Decimal?)reader["TotalRefundedAmount"];
                        InitialPaidAmount = (decimal)reader["InitialPaidAmount"];
                        TotalRemainingAmount = (decimal)reader["TotalRemainingAmount"];
                        ActualFinalAmountDue = Convert.IsDBNull(reader["ActualFinalAmountDue"]) ? null : (Decimal?)reader["ActualFinalAmountDue"];
                        UpdatedPaymentDate = Convert.IsDBNull(reader["UpdatedPaymentDate"]) ? null : (DateTime?)reader["UpdatedPaymentDate"];
                    }
                    reader.Close();
                }
                catch
                {
                    isFound = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return isFound;
        }
        public static int AddNew(int RentalID, DateTime PaymentDate, string PaymentStatus, string PaymentNotes,
            decimal? TotalRefundedAmount, decimal InitialPaidAmount, decimal TotalRemainingAmount,
            decimal? ActualFinalAmountDue, DateTime? UpdatedPaymentDate)
        {
            int PaymentID = -1;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO RentalPayments (RentalID, PaymentDate,
                 PaymentStatus, PaymentNotes, TotalRefundedAmount, InitialPaidAmount,
                 TotalRemainingAmount, ActualFinalAmountDue, UpdatedPaymentDate)

                 VALUES (@RentalID, @PaymentDate, @PaymentStatus, @PaymentNotes, 
                        @TotalRefundedAmount, @InitialPaidAmount, @TotalRemainingAmount, 
                        @ActualFinalAmountDue, @UpdatedPaymentDate);

                 SELECT  SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@RentalID", RentalID);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                cmd.Parameters.AddWithValue("@PaymentNotes", PaymentNotes);
                cmd.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@InitialPaidAmount", InitialPaidAmount);
                cmd.Parameters.AddWithValue("@TotalRemainingAmount", TotalRemainingAmount);
                cmd.Parameters.AddWithValue("@ActualFinalAmountDue", ActualFinalAmountDue ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@UpdatedPaymentDate", UpdatedPaymentDate ?? Convert.DBNull);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int _ParsedResult))
                    {
                        PaymentID = _ParsedResult;
                    }

                }
                finally
                {
                    conn.Close();
                }
            }
            return PaymentID;
        }
        public static int Update(int PaymentID, int RentalID, DateTime PaymentDate, string PaymentStatus, string PaymentNotes,
            decimal? TotalRefundedAmount, decimal InitialPaidAmount, decimal TotalRemainingAmount,
            decimal? ActualFinalAmountDue, DateTime? UpdatedPaymentDate)
        {
            int affectedRows = 0;
            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                string query = @"UPDATE RentalPayments SET RentalID = @RentalID, PaymentDate=@PaymentDate,
                    PaymentStatus=@PaymentStatus, PaymentNotes=@PaymentNotes, TotalRefundedAmount=@TotalRefundedAmount, 
                    InitialPaidAmount=@InitialPaidAmount, TotalRemainingAmount=@TotalRemainingAmount, ActualFinalAmountDue=@ActualFinalAmountDue, UpdatedPaymentDate=@UpdatedPaymentDate
                    WHERE PaymentID = @PaymentID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@RentalID", RentalID);
                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                cmd.Parameters.AddWithValue("@PaymentNotes", PaymentNotes);
                cmd.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@InitialPaidAmount", InitialPaidAmount);
                cmd.Parameters.AddWithValue("@TotalRemainingAmount", TotalRemainingAmount);
                cmd.Parameters.AddWithValue("@ActualFinalAmountDue", ActualFinalAmountDue ?? Convert.DBNull);
                cmd.Parameters.AddWithValue("@UpdatedPaymentDate", UpdatedPaymentDate ?? Convert.DBNull);

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
        public static int DeleteByPaymentID(int PaymentID)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM RentalPayments WHERE PaymentID = @PaymentID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);

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
        public static bool IsExistByPaymentID(int PaymentID)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM RentalPayments WHERE PaymentID = @PaymentID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);

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
