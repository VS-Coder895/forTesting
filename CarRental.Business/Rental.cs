using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class Rental
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int RentalID { get; set; }
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InitialCheckNotes { get; set; }
        public string PickupLocation { get; set; }
        public string DropOffLocation { get; set; }
        public int? InsuranceID { get; set; }
        public decimal DailyRate { get; set; }
        public int RentalDays { get; set; }
        public decimal TotalDue { get; set; }

        public Rental()
        {
            this.RentalID = -1;
            this.VehicleID = -1;
            this.CustomerID = -1;
            this.UserID = -1;
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now.AddDays(1);
            this.InitialCheckNotes = "";
            this.PickupLocation = "";
            this.DropOffLocation = "";
            this.InsuranceID = null;
            this.DailyRate = 0;
            this.RentalDays = 0;
            this.TotalDue = 0;

            Mode = enMode.AddNew;
        }

        private Rental(int RentalID, int VehicleID, int CustomerID, int UserID,
                       DateTime StartDate, DateTime EndDate, string InitialCheckNotes,
                       string PickupLocation, string DropOffLocation, int? InsuranceID,
                       decimal DailyRate, int RentalDays, decimal TotalDue)
        {
            this.RentalID = RentalID;
            this.VehicleID = VehicleID;
            this.CustomerID = CustomerID;
            this.UserID = UserID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.InitialCheckNotes = InitialCheckNotes;
            this.PickupLocation = PickupLocation;
            this.DropOffLocation = DropOffLocation;
            this.InsuranceID = InsuranceID;
            this.DailyRate = DailyRate;
            this.RentalDays = RentalDays;
            this.TotalDue = TotalDue;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.RentalID = RentalDataAccess.AddNew(this.VehicleID, this.CustomerID, this.UserID,
                this.StartDate, this.EndDate, this.InitialCheckNotes, this.PickupLocation,
                this.DropOffLocation, this.InsuranceID, this.DailyRate, this.RentalDays, this.TotalDue);

            return (this.RentalID != -1);
        }

        private bool _Update()
        {
            return RentalDataAccess.Update(this.RentalID, this.EndDate, this.DropOffLocation, this.TotalDue);
        }

        public static Rental FindByRentalID(int RentalID)
        {
            int VehicleID = -1, CustomerID = -1, UserID = -1, RentalDays = 0;
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;
            string Notes = "", Pickup = "", DropOff = "";
            int? InsuranceID = null;
            decimal DailyRate = 0, TotalDue = 0;

            if (RentalDataAccess.FindByID(RentalID, ref VehicleID, ref CustomerID, ref UserID,
                ref StartDate, ref EndDate, ref Notes, ref Pickup, ref DropOff, ref InsuranceID,
                ref DailyRate, ref RentalDays, ref TotalDue))
            {
                return new Rental(RentalID, VehicleID, CustomerID, UserID, StartDate, EndDate,
                    Notes, Pickup, DropOff, InsuranceID, DailyRate, RentalDays, TotalDue);
            }
            else
                return null;
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
                        return false;

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static DataTable GetAll()
        {
            return RentalDataAccess.GetAll();
        }

        public static bool Delete(int RentalID)
        {
            return RentalDataAccess.Delete(RentalID);
        }

        public static bool IsRentalExist(int RentalID)
        {
            return RentalDataAccess.IsRentalExist(RentalID);
        }

        public Customer GetCustomer()
        {
            return Customer.Find(CustomerID);
        }

        public Vehicle GetVehicle()
        {
            return Vehicle.FindByVehicleID(VehicleID);
        }

        public Payment GetPayment()
        {
            return Payment.FindByRentalId(RentalID);
        }

       
    }
}
