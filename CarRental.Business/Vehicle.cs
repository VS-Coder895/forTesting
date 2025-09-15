using DataAccessLayer;
using System;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class Vehicle
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int VehicleID { get; private set; }
        public string Name { get; set; }
        public int Model { get; set; }
        public int ManufacturerID { get; set; }
        public string Color { get; set; }
        public bool IsVehicleAvailable { get; set; }
        public int FuelTypeID { get; set; }
        public int EngineTypeID { get; set; }
        public decimal FuelEfficiency { get; set; }
        public int VehicleTypeID { get; set; }
        public string LPN { get; set; }
        public decimal DailyRentalPrice { get; set; }
        public decimal Mileage { get; set; }
        public string TransmissionType { get; set; }
        public int SeatingCapacity { get; set; }
        public DateTime LastServicesDate { get; set; }

        public Vehicle()
        {
            VehicleID = -1;
            Name = "";
            Model = -1;
            ManufacturerID = -1;
            Color = "";
            IsVehicleAvailable = false;
            FuelTypeID = -1;
            EngineTypeID = -1;
            FuelEfficiency = 0;
            VehicleTypeID = 0;
            LPN = "";
            DailyRentalPrice = 0;
            Mileage = 0;
            TransmissionType = "";
            SeatingCapacity = 0;
            LastServicesDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        public Vehicle(int vehicleID, string name, int model, int manufacturerID, string color,
            bool isVehicleAvailable, int fuelTypeID, int engineTypeID, decimal fuelEfficiency,
            int vehicleTypeID, string lpn, decimal dailyRentalPrice, decimal mileage,
            string transmissionType, int seatingCapacity, DateTime lastServicesDate)
        {
            VehicleID = vehicleID;
            Name = name;
            Model = model;
            ManufacturerID = manufacturerID;
            Color = color;
            IsVehicleAvailable = isVehicleAvailable;
            FuelTypeID = fuelTypeID;
            EngineTypeID = engineTypeID;
            FuelEfficiency = fuelEfficiency;
            VehicleTypeID = vehicleTypeID;
            LPN = lpn;
            DailyRentalPrice = dailyRentalPrice;
            Mileage = mileage;
            TransmissionType = transmissionType;
            SeatingCapacity = seatingCapacity;
            LastServicesDate = lastServicesDate;

            Mode = enMode.Update;
        }
        public static Vehicle FindByVehicleID(int vehicleID)
        {
            string name = "";
            string color = "";
            string lpn = "";
            string transmissionType = "";
            bool isVehicleAvailable = false;
            int model = 0;
            int manufacturerID = 0;
            int seatingCapacity = 0;
            int fuelTypeID = 0;
            int engineTypeID = 0;
            int vehicleTypeID = 0;
            decimal dailyRentalPrice = 0;
            decimal mileage = 0;
            decimal fuelEfficiency = 0;
            DateTime lastServicesDate = new DateTime();

            bool isFound = VehicleDataAccess.FindByVehicleID(vehicleID, ref name, ref model, ref manufacturerID, ref color,
                ref isVehicleAvailable, ref fuelTypeID, ref engineTypeID,
                ref fuelEfficiency, ref vehicleTypeID, ref lpn, ref dailyRentalPrice, ref mileage,
                ref transmissionType, ref seatingCapacity, ref lastServicesDate);

            if (isFound)
            {
                return new Vehicle(vehicleID, name, model, manufacturerID, color, isVehicleAvailable,
                    fuelTypeID, engineTypeID, fuelEfficiency, vehicleTypeID,
                    lpn, dailyRentalPrice, mileage, transmissionType, seatingCapacity, lastServicesDate);
            }
            else
            {
                return null;
            }
        }
        public static Vehicle FindVehicleByName(string name)
        {
            string color = "";
            string lpn = "";
            string transmissionType = "";
            bool isVehicleAvailable = false;
            int model = 0;
            int id = 0;
            int manufacturerID = 0;
            int seatingCapacity = 0;
            int fuelTypeID = 0;
            int engineTypeID = 0;
            int vehicleTypeID = 0;
            decimal dailyRentalPrice = 0;
            decimal mileage = 0;
            decimal fuelEfficiency = 0;
            DateTime lastServicesDate = new DateTime();

            bool isFound = VehicleDataAccess.FindByName(ref name, ref id, ref model, ref manufacturerID, ref color,
                ref isVehicleAvailable, ref fuelTypeID, ref engineTypeID,
                ref fuelEfficiency, ref vehicleTypeID, ref lpn, ref dailyRentalPrice, ref mileage,
                ref transmissionType, ref seatingCapacity, ref lastServicesDate);

            if (isFound)
            {
                return new Vehicle(id, name, model, manufacturerID, color, isVehicleAvailable,
                    fuelTypeID, engineTypeID, fuelEfficiency, vehicleTypeID,
                    lpn, dailyRentalPrice, mileage, transmissionType, seatingCapacity, lastServicesDate);
            }
            else
            {
                return null;
            }
        }
        private bool _AddNew()
        {
            VehicleID = VehicleDataAccess.AddNew(Name, Model, ManufacturerID, Color, IsVehicleAvailable,
                FuelTypeID, EngineTypeID, FuelEfficiency, VehicleTypeID, LPN, DailyRentalPrice,
                Mileage, TransmissionType, SeatingCapacity, LastServicesDate);

            return VehicleID != -1;
        }
        private bool _Update()
        {
            int affectedRows = VehicleDataAccess.Update(VehicleID, Name, Model, ManufacturerID, Color,
                IsVehicleAvailable, FuelTypeID, EngineTypeID, FuelEfficiency, VehicleTypeID,
                LPN, DailyRentalPrice, Mileage, TransmissionType, SeatingCapacity, LastServicesDate);

            return affectedRows > 0;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }
        public static bool DeleteByID(int id)
        {
            return VehicleDataAccess.DeleteByVehicleID(id) > 0;
        }
        public static bool DeleteByName(string name)
        {
            return VehicleDataAccess.DeleteByName(name) > 0;
        }
        public static DataTable GetAll()
        {
            return VehicleDataAccess.GetAll();
        }
        public static bool IsExistsVehicleID(int id)
        {
            return VehicleDataAccess.IsExistsVehicleID(id);
        }
        public static bool IsExistsName(string name)
        {
            return VehicleDataAccess.IsExistsName(name);
        }
        public EngineType GetEngineType()
        {
            return EngineType.FindByEngineTypeID(EngineTypeID);
        }
        public FuelType GetFuelType()
        {
            return FuelType.FindByFuelTypeID(FuelTypeID);
        }
        public Manufacturer GetManufacturer()
        {
            return Manufacturer.FindByManufacturerID(ManufacturerID);
        }
        public VehicleType GetVehicleType()
        {
            return VehicleType.FindByVehicleTypeID(VehicleTypeID);
        }
        public DataTable GetRentals()
        {
            return VehicleDataAccess.GetRentals(VehicleID);
        }
        public bool IsAvailableVehicleInRange(DateTime start, DateTime end)
        {
            DataTable rentals = GetRentals();
            if (rentals.Select().Where(
                row =>
            {
                DateTime rStart = Convert.ToDateTime(row["StartDate"].ToString());
                DateTime rEnd = Convert.ToDateTime(row["EndDate"].ToString());
                if (DateTime.Compare(start, rEnd) <= 0 && DateTime.Compare(rStart, start) <= 0)
                {
                    return true;
                }
                return false;
            }).Count() > 0)
            {
                return false;
            }
            return true;
        }
    }
}