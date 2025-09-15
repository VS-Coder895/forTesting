using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class FuelType
    {
        private enum _enMode{ AddNew = 0, Update = 1 }
        private _enMode _Mode { get; set; }

        public int FuelTypeID { get; set; }
        public string Name { get; set; }

        
        public FuelType()
        {
            this.FuelTypeID = 0;
            this.Name = "";

            this._Mode = _enMode.AddNew;
        }

        private FuelType(int FuelTypeID, string Name)
        {
            this.FuelTypeID = FuelTypeID;
            this.Name = Name;

            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return FuelTypeDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            FuelTypeID = FuelTypeDataAccess.AddNew(Name);

            return FuelTypeID != -1;
        }

        private bool _Update()
        {
            int affectedRows = FuelTypeDataAccess.Update(FuelTypeID, Name);

            return affectedRows > 0;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                
                case _enMode.Update:
                    return _Update();

                default:
                    return false;
            } 

        }

        public static FuelType FindByFuelTypeID(int FuelTypeID)
        {
            string Name = "";
            bool isFound = FuelTypeDataAccess.FindByFuelTypeID(ref FuelTypeID, ref Name);

            if (isFound)
            {
                return new FuelType(FuelTypeID, Name);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteByFuelTypeID(int FuelTypeID)
        {
            int affectedRows = FuelTypeDataAccess.DeleteByFuelTypeID(FuelTypeID);

            return affectedRows > 0;
        }

        public static bool IsExistsFuelTypeID(int FuelTypeID)
        {
            return FuelTypeDataAccess.IsExistsFuelTypeID(FuelTypeID);
        }
    }
}