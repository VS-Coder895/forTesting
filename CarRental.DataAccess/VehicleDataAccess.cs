using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class VehicleDataAccess
    {
        public static int AddNew(String Name, int? Model,int ManufacturerID, String Color,
            bool IsVehicleAvailable, int FuelTypeID, int EngineTypeID, Decimal FuelEfficiency, 
            int VehicleTypeID, String LPN, Decimal DailyRentalPrice, Decimal Mileage,
            String TransmissionType, int SeatingCapacity, DateTime LastServiceDate)

        {
            int _VehicleID = -1;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Vehicles(Name, Model, ManufacturerID, Color, IsVehicleAvailable, 
                                FuelTypeID, EngineTypeID, FuelEfficiency, VehicleTypeID, LPN, DailyRentalPrice, 
                                Mileage, TransmissionType, SeatingCapacity, LastServiceDate) 
                                Values ( @Name, @Model, @ManufacturerID, @Color, @IsVehicleAvailable, 
                                @FuelTypeID, @EngineTypeID, @FuelEfficiency, @VehicleTypeID, @LPN, 
                                @DailyRentalPrice, @Mileage, @TransmissionType, 
                                @SeatingCapacity, @LastServiceDate ); 
                                SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@ManufacturerID", ManufacturerID);
            cmd.Parameters.AddWithValue("@Color", Color);
            cmd.Parameters.AddWithValue("@IsVehicleAvailable", IsVehicleAvailable);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            cmd.Parameters.AddWithValue("@EngineTypeID", EngineTypeID);
            cmd.Parameters.AddWithValue("@FuelEfficiency", FuelEfficiency);
            cmd.Parameters.AddWithValue("@VehicleTypeID", VehicleTypeID);
            cmd.Parameters.AddWithValue("@LPN", LPN);
            cmd.Parameters.AddWithValue("@DailyRentalPrice", DailyRentalPrice);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@TransmissionType", TransmissionType);
            cmd.Parameters.AddWithValue("@SeatingCapacity", SeatingCapacity);
            cmd.Parameters.AddWithValue("@LastServiceDate", LastServiceDate);
            
            try
            {
                conn.Open();

                object _result = cmd.ExecuteScalar();

                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                {
                    _VehicleID = _ParsedResult;
                }
            }
            catch
            {
                return _VehicleID;
            }
            finally 
            { 
                conn.Close();
            }
            
            return _VehicleID;
        }
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Vehicles";
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
                // if there's no data in Vehicle table
                return null;
            }
            finally
            {
                conn.Close();
            }
            return table;
        }
        public static bool FindByVehicleID( int VehicleID, ref String Name, ref int Model,
            ref int ManufacturerID, ref String Color, ref bool IsVehicleAvailable,
            ref int FuelTypeID, ref int EngineTypeID, ref Decimal FuelEfficiency,
            ref int VehicleTypeID, ref String LPN, ref Decimal DailyRentalPrice,
            ref Decimal Mileage, ref String TransmissionType, ref int SeatingCapacity,
            ref DateTime LastServiceDate)
        {
            
            bool isFound = false;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Vehicles WHERE VehicleID = @VehicleID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    VehicleID  = (int)reader["VehicleID"];
                    Name = (string)reader["Name"];
                    Model = (int)reader["Model"];
                    ManufacturerID = (int)reader["ManufacturerID"];
                    Color = (String)reader["Color"];
                    IsVehicleAvailable = (int)reader["IsVehicleAvailable"] > 0;
                    FuelTypeID = (int)reader["FuelTypeID"];
                    EngineTypeID =  (int)reader["EngineTypeID"];
                    FuelEfficiency = (Decimal)reader["FuelEfficiency"];
                    VehicleTypeID = (int)reader["VehicleTypeID"];
                    LPN = (String)reader["LPN"];
                    DailyRentalPrice = (Decimal)reader["DailyRentalPrice"];
                    Mileage = (Decimal)reader["Mileage"];
                    TransmissionType = (String)reader["TransmissionType"];
                    SeatingCapacity = (int)reader["SeatingCapacity"];
                    LastServiceDate = (DateTime)reader["LastServiceDate"];

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
        public static int DeleteByVehicleID(int VehicleID)
        {
            int affectedRows = 0;
            
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            
            string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            
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
        public static bool IsExistsVehicleID(int VehicleID)
        {
            bool isFound = false;
            
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Vehicles WHERE VehicleID = @VehicleID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            
            try
            {
                conn.Open();
                isFound = (cmd.ExecuteScalar() != null);
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
        public static bool FindByName(ref String Name, ref int VehicleID, ref int Model,
            ref int ManufacturerID, ref String Color, ref Boolean IsVehicleAvailable,
            ref int FuelTypeID, ref int EngineTypeID, ref Decimal FuelEfficiency,
            ref int VehicleTypeID, ref String LPN, ref Decimal DailyRentalPrice,
            ref Decimal Mileage, ref String TransmissionType, ref int SeatingCapacity,
            ref DateTime LastServiceDate)
        {
            bool isFound = false;
            
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Vehicles WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            
            try
            {
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    VehicleID = (int)reader["VehicleID"];
                    Name = (String)reader["Name"];
                    Model = (int)reader["Model"];
                    ManufacturerID = (int)reader["ManufacturerID"];
                    Color = (String)reader["Color"];
                    IsVehicleAvailable = (Boolean)reader["IsVehicleAvailable"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    EngineTypeID = (int)reader["EngineTypeID"];
                    FuelEfficiency = (Decimal)reader["FuelEfficiency"];
                    VehicleTypeID = (int)reader["VehicleTypeID"];
                    LPN = (String)reader["LPN"];
                    DailyRentalPrice = (Decimal)reader["DailyRentalPrice"];
                    Mileage = (Decimal)reader["Mileage"];
                    TransmissionType = (String)reader["TransmissionType"];
                    SeatingCapacity = (int)reader["SeatingCapacity"];
                    LastServiceDate = (DateTime)reader["LastServiceDate"];

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
        public static int DeleteByName(String Name)
        {
            int affectedRows = 0; 
            
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            
            string query = "DELETE FROM Vehicles WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(query, conn);
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
        public static bool IsExistsName(String Name)
        {
            bool isFound = false;
            
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Vehicles WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", Name);
            
            try
            {
                conn.Open();
                isFound = (cmd.ExecuteScalar() != null);
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
        public static int Update(int VehicleID, String Name, int Model, int ManufacturerID, String Color,
            bool IsVehicleAvailable, int FuelTypeID, int EngineTypeID, Decimal FuelEfficiency,
            int VehicleTypeID, String LPN, Decimal DailyRentalPrice, Decimal Mileage, String TransmissionType,
            int SeatingCapacity, DateTime LastServiceDate)
        {
            int affectedRows = 0;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"UPDATE Vehicles SET Name = @Name, Model = @Model, ManufacturerID = @ManufacturerID, 
                                Color = @Color, IsVehicleAvailable = @IsVehicleAvailable, FuelTypeID = @FuelTypeID, 
                                EngineTypeID = @EngineTypeID, FuelEfficiency = @FuelEfficiency, VehicleTypeID = @VehicleTypeID, 
                                LPN = @LPN, DailyRentalPrice = @DailyRentalPrice, Mileage = @Mileage, 
                                TransmissionType = @TransmissionType, SeatingCapacity = @SeatingCapacity, 
                                LastServiceDate = @LastServiceDate WHERE VehicleID = @VehicleID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@ManufacturerID", ManufacturerID);
            cmd.Parameters.AddWithValue("@Color", Color);
            cmd.Parameters.AddWithValue("@IsVehicleAvailable", IsVehicleAvailable);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            cmd.Parameters.AddWithValue("@EngineTypeID", EngineTypeID);
            cmd.Parameters.AddWithValue("@FuelEfficiency", FuelEfficiency);
            cmd.Parameters.AddWithValue("@VehicleTypeID", VehicleTypeID);
            cmd.Parameters.AddWithValue("@LPN", LPN);
            cmd.Parameters.AddWithValue("@DailyRentalPrice", DailyRentalPrice);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@TransmissionType", TransmissionType);
            cmd.Parameters.AddWithValue("@SeatingCapacity", SeatingCapacity);
            cmd.Parameters.AddWithValue("@LastServiceDate", LastServiceDate);
            
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
        public static DataTable GetRentals(int VehicleID)
        {
            DataTable rentalTable = new DataTable();

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VehicleRentals WHERE VehicleID=@VehicleID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    rentalTable.Load(reader);
                }

                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return rentalTable;
        }
    }
}