using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Maintenance
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int MaintenanceID { set; get; }
        public int VehicleID { set; get; }
        public string Description { set; get; }
        public DateTime MaintenanceDate { set; get; }
        public decimal Cost { set; get; }


        public Maintenance()
        {
            this.MaintenanceID = -1;
            this.VehicleID = -1;
            this.Description = "";
            this.MaintenanceDate = DateTime.Now;
            this.Cost = -1;

            Mode = enMode.AddNew;
        }
        private Maintenance(int MaintenanceID, int VehicleID, string Description,
            DateTime MaintenanceDate, decimal Cost)
        {
            this.MaintenanceID = MaintenanceID;
            this.VehicleID = VehicleID;
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;

            Mode = enMode.Update;
        }

        public static DataTable GetAll()
        {
            return MaintenanceDataAccess.GetAll();
        }

        public static Maintenance FindByMaintenanceID(int MaintenanceID)
        {
            int VehicleID = -1;
            string Description = "";
            DateTime MaintenanceDate = DateTime.Now;
            decimal Cost = 0;

            bool isFound = MaintenanceDataAccess.FindByMaintenanceID(MaintenanceID, ref VehicleID, 
                ref Description, ref MaintenanceDate, ref Cost);

            if (isFound)
            {
                return new Maintenance(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNew()
        {
            int MaintenanceID = MaintenanceDataAccess.AddNew(VehicleID, Description,
                MaintenanceDate, Cost);

            return MaintenanceID != -1;
        }

        private bool _Update()
        {
            return MaintenanceDataAccess.Update(MaintenanceID, VehicleID, Description,
                MaintenanceDate, Cost) > 0;
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

        public static bool DeleteByMaintenanceID(int MaintenanceID)
        {
            return MaintenanceDataAccess.Delete(MaintenanceID) > 0;
        }

        public static bool IsExistByMaintenanceID(int MaintenanceID)
        {
            return MaintenanceDataAccess.IsExist(MaintenanceID);
        }
    }
}
