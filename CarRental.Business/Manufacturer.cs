using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Manufacturer
    {
        public enum _enMode { AddNew = 0, Update = 1 };
        private _enMode _Mode { get; set; }
        public int ManufacturerID { get; set; }
        public string Name { get; set; }

        public Manufacturer()
        {
            this.ManufacturerID = 0;
            this.Name = "";

            this._Mode = _enMode.AddNew;
        }

        private Manufacturer(int ManufacturerID, string Name)
        {
            this.ManufacturerID = ManufacturerID;
            this.Name = Name;

            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return ManufacturerDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            ManufacturerID = ManufacturerDataAccess.AddNew(Name);
            return ManufacturerID != -1;
        }

        private bool _Update()
        {
            int affectedRows = ManufacturerDataAccess.Update(ManufacturerID, Name);
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

        public static Manufacturer FindByManufacturerID(int ManufacturerID)
        {
            string Name = "";
            bool isFound = ManufacturerDataAccess.FindByManufacturerID(ref ManufacturerID, ref Name);

            if (isFound)
            {
                return new Manufacturer(ManufacturerID, Name);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteByManufacturerID(int ManufacturerID)
        {
            int affectedRows = ManufacturerDataAccess.DeleteByManufacturerID(ManufacturerID);
            return affectedRows > 0;
        }

        public static bool IsExistsManufacturerID(int ManufacturerID)
        {
            return ManufacturerDataAccess.IsExistsManufacturerID(ManufacturerID);
        }
    }
}