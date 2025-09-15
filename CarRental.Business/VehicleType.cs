using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class VehicleType
    {
        public enum _enMode { AddNew = 0, Update = 1 };
        public _enMode _Mode = _enMode.AddNew;
        public int VehicleTypeID { get; set; }
        public string Name { get; set; }

        public VehicleType()
        {
            this.VehicleTypeID = 0;
            this.Name = "";

            this._Mode = _enMode.AddNew;
        }

        private VehicleType(int VehicleTypeID, string Name)
        {
            this.VehicleTypeID = VehicleTypeID;
            this.Name = Name;

            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return VehicleTypeDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            VehicleTypeID = VehicleTypeDataAccess.AddNew(Name);
            return VehicleTypeID != -1;
        }

        private bool _Update()
        {
            int affectedRows = VehicleTypeDataAccess.Update(VehicleTypeID, Name);
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

        public static VehicleType FindByVehicleTypeID(int VehicleTypeID)
        {
            string Name = default;
            bool isFound = VehicleTypeDataAccess.FindByVehicleTypeID(ref VehicleTypeID, ref Name);

            if (isFound)
            {
                return new VehicleType(VehicleTypeID, Name);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteByVehicleTypeID(int VehicleTypeID)
        {
            int affectedRows = VehicleTypeDataAccess.DeleteByVehicleTypeID(VehicleTypeID);
            return affectedRows > 0;
        }

        public static bool IsExistsVehicleTypeID(int VehicleTypeID)
        {
            return VehicleTypeDataAccess.IsExistsVehicleTypeID(VehicleTypeID);
        }
    }
}