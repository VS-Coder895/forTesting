using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Return
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ReturnID { get; set; }
        public int RentalID { get; set; }
        public int ActualRentalDays { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public string DamageReport { get; set; }
        public decimal AdditionalCharges { get; set; }
        public decimal CurrentMileage { get; set; }
        public decimal ConsumedMileage { get; set; }

        public Return()
        {
            this.ReturnID = -1;
            this.RentalID = -1;
            this.ActualRentalDays = 0;
            this.ActualReturnDate = DateTime.Now;
            this.DamageReport = "";
            this.AdditionalCharges = 0;
            this.CurrentMileage = 0;
            this.ConsumedMileage = 0;

            Mode = enMode.AddNew;
        }

        private Return(int ReturnID, int RentalID, int ActualRentalDays, DateTime ActualReturnDate, 
            string DamageReport, decimal AdditionalCharges, decimal CurrentMileage, decimal ConsumedMileage)
        {
            this.ReturnID = ReturnID;
            this.RentalID = RentalID ;
            this.ActualRentalDays = ActualRentalDays ;
            this.ActualReturnDate = ActualReturnDate ;
            this.DamageReport = DamageReport ;
            this.AdditionalCharges = AdditionalCharges ;
            this.CurrentMileage = CurrentMileage ;
            this.ConsumedMileage = ConsumedMileage ;

            Mode = enMode.Update;
        }

        public static DataTable GetAll()
        {
            return ReturnsDataAccess.GetAll();
        }

        public static Return FindByReturnID(int ReturnID)
        {
            int RentalID = -1;
            int ActualRentalDays = 0;
            DateTime ActualReturnDate = DateTime.Now;
            string DamageReport = "";
            decimal AdditionalCharges = 0;
            decimal CurrentMileage = 0;
            decimal ConsumedMileage = 0;

            bool isFound = ReturnsDataAccess.FindByReturnID(ReturnID, ref RentalID, 
                ref ActualRentalDays, ref ActualReturnDate, ref DamageReport, 
                ref AdditionalCharges, ref CurrentMileage, ref ConsumedMileage);


            if (isFound)
            {
                return new Return(ReturnID, RentalID, ActualRentalDays, ActualReturnDate, DamageReport,
                     AdditionalCharges, CurrentMileage, ConsumedMileage);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNew()
        {
            int newReturnID = ReturnsDataAccess.AddNew(RentalID, ActualRentalDays, ActualReturnDate, DamageReport,
                     AdditionalCharges, CurrentMileage, ConsumedMileage);
            return (newReturnID != -1);
        }

        private bool _Update()
        {
            return (ReturnsDataAccess.Update(ReturnID, RentalID, ActualRentalDays, ActualReturnDate, 
                DamageReport, AdditionalCharges, CurrentMileage, ConsumedMileage) != 0);
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
                    break;
                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static bool DeleteByReturnID(int ReturnID)
        {
            return ReturnsDataAccess.DeleteByReturnID(ReturnID) > 0;
        }

        public bool IsExistByReturnID(int ReturnID)
        {
            return ReturnsDataAccess.IsExistByReturnID(ReturnID);
        }

        public Rental GetRentalByID(int RentalID)
        {
            return Rental.FindByRentalID(RentalID);   
        }
    }
}
