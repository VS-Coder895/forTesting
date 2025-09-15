using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class EngineType
    {
        private enum _enMode {AddNew = 0, Update = 1}
        private _enMode _Mode { get; set; }
        public int EngineTypeID { get; set; }
        public string Name { get; set; }


        public EngineType()
        {
            this.EngineTypeID = -1;
            this.Name = "";

            this._Mode = _enMode.AddNew;
        }

        private EngineType(int EngineTypeID, string Name)
        {
            this.EngineTypeID = EngineTypeID;
            this.Name = Name;

            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return EngineTypeDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            EngineTypeID = EngineTypeDataAccess.AddNew(Name);

            return EngineTypeID != -1;
        }

        private bool _Update()
        {
            int affectedRows = EngineTypeDataAccess.Update(EngineTypeID, Name);

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

        public static EngineType FindByEngineTypeID(int EngineTypeID)
        {
            string Name = "";
            bool isFound = EngineTypeDataAccess.FindByEngineTypeID(ref EngineTypeID, ref Name);
            
            if (isFound)
            {
                return new EngineType(EngineTypeID, Name);
            }
            else
            {
                return null;
            }
        }
        public static bool DeleteByEngineTypeID(int EngineTypeID)
        {
            int affectedRows = EngineTypeDataAccess.DeleteByEngineTypeID(EngineTypeID);

            return affectedRows > 0;
        }

        public static bool IsExistsEngineTypeID(int EngineTypeID)
        {
            return EngineTypeDataAccess.IsExistsEngineTypeID(EngineTypeID);
        }
    }
}