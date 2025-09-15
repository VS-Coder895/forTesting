using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Insurances
    {
        private enum _enMode{AddNew = 0, Update = 1}
        private _enMode Mode=_enMode.AddNew;
        public int InsuranceID { get; set; }
        public string Name { get; set; }

        public Insurances()
        {
            this.InsuranceID = -1;
            this.Name = "";

            Mode = _enMode.AddNew;
        }

        public Insurances(int InsuranceID, string Name)
        {
            this.InsuranceID = InsuranceID;
            this.Name = Name;

            Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return InsurancesDataAccess.GetAll();
        }

        public static Insurances FindByInsuranceID(int InsuranceID)
        {
            string Name = "";

            if (InsurancesDataAccess.FindByID(InsuranceID, ref Name))
            {
                return new Insurances(InsuranceID, Name);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNew()
        {
            int newInsuranceID = InsurancesDataAccess.AddNew(Name);
            return newInsuranceID != -1;
        }

        private bool _Update()
        {
            int affectedRows = InsurancesDataAccess.Update(InsuranceID, Name);
            return affectedRows > 0;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = _enMode.Update;
                        return true;
                    }

                    return false;
                case _enMode.Update:
                    return _Update();
            }
            return false;

        }

        public static bool DeleteByInsuranceID(int InsuranceID)
        {
            int affectedRows = InsurancesDataAccess.Delete(InsuranceID);
            return affectedRows > 0;
        }

        public static bool IsExistsInsuranceID(int InsuranceID)
        {
            return InsurancesDataAccess.IsInsuranceExist(InsuranceID);
        }
}
}
