using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Payment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PaymentID { get; set; }
        public int RentalID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentNotes { get; set; }
        public decimal? TotalRefundedAmount { get; set; }
        public decimal InitialPaidAmount { get; set; }
        public decimal TotalRemainingAmount { get; set; }
        public decimal? ActualFinalAmountDue { get; set; }
        public DateTime? UpdatedPaymentDate { get; set; }
        public Payment()
        {
            this.PaymentID = -1;
            this.RentalID = -1;
            this.PaymentDate = DateTime.Now;
            this.PaymentStatus = "";
            this.PaymentNotes = null;
            this.TotalRefundedAmount = null;
            this.InitialPaidAmount = 0;
            this.TotalRemainingAmount = 0;
            this.ActualFinalAmountDue = null;
            this.UpdatedPaymentDate = null;

            Mode = enMode.AddNew;

        }
        private Payment(int paymentId, int rentalId, DateTime paymentDate, string paymentStatus,
            string paymentNotes, decimal? totalRefundedAmount, decimal initialPaidAmount, 
            decimal totalRemainingAmount, decimal? actualFinalAmountDue, DateTime? updatedPaymentDate)
        {
            this.PaymentID = paymentId;
            this.RentalID = rentalId;
            this.PaymentDate = paymentDate;
            this.PaymentStatus = paymentStatus;
            this.PaymentNotes = paymentNotes;
            this.TotalRefundedAmount = totalRefundedAmount;
            this.InitialPaidAmount = initialPaidAmount;
            this.TotalRemainingAmount = totalRemainingAmount;
            this.ActualFinalAmountDue = actualFinalAmountDue;
            this.UpdatedPaymentDate = updatedPaymentDate;

            Mode = enMode.Update;
        }

        public static DataTable GetAll()
        {
            return PaymentDataAccess.GetAll();
        }

        public static Payment FindByPaymentID(int PaymentID)
        {
            int RentalID = -1;
            DateTime PaymentDate = DateTime.Now;
            string PaymentStatus = "";
            string PaymentNotes = "";
            decimal? TotalRefundedAmount = null;
            decimal InitialPaidAmount = 0;
            decimal TotalRemainingAmount = 0;
            decimal? ActualFinalAmountDue = null;
            DateTime? UpdatedPaymentDate = null;

            bool isFound = PaymentDataAccess.FindByPaymentID(PaymentID, ref RentalID, ref PaymentDate,
                ref PaymentStatus, ref PaymentNotes, ref TotalRefundedAmount, ref InitialPaidAmount, 
                ref TotalRemainingAmount, ref ActualFinalAmountDue, ref UpdatedPaymentDate);

            if (isFound)
            {
                return new Payment(PaymentID, RentalID, PaymentDate,
                 PaymentStatus, PaymentNotes, TotalRefundedAmount, InitialPaidAmount,
                 TotalRemainingAmount, ActualFinalAmountDue, UpdatedPaymentDate);
            }
            else
            {
                return null;
            }
        }
        public static Payment FindByRentalId(int RentalID)
        {
            int PaymentID = -1;
            DateTime PaymentDate = DateTime.Now;
            string PaymentStatus = "";
            string PaymentNotes = "";
            decimal? TotalRefundedAmount = null;
            decimal InitialPaidAmount = 0;
            decimal TotalRemainingAmount = 0;
            decimal? ActualFinalAmountDue = null;
            DateTime? UpdatedPaymentDate = null;

            bool isFound = PaymentDataAccess.FindByRentalID(RentalID, ref PaymentID, ref PaymentDate,
                ref PaymentStatus, ref PaymentNotes, ref TotalRefundedAmount, ref InitialPaidAmount, 
                ref TotalRemainingAmount, ref ActualFinalAmountDue, ref UpdatedPaymentDate);

            if (isFound)
            {
                return new Payment(PaymentID, RentalID, PaymentDate,
                 PaymentStatus, PaymentNotes, TotalRefundedAmount, InitialPaidAmount,
                 TotalRemainingAmount, ActualFinalAmountDue, UpdatedPaymentDate);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNew()
        {
            PaymentID = PaymentDataAccess.AddNew(RentalID, PaymentDate,
                 PaymentStatus, PaymentNotes, TotalRefundedAmount, InitialPaidAmount, TotalRemainingAmount,
                 ActualFinalAmountDue, UpdatedPaymentDate);
            return PaymentID != -1;
        }

        private bool _Update()
        {
            return (PaymentDataAccess.Update(PaymentID, RentalID, PaymentDate, PaymentStatus, PaymentNotes, 
                TotalRefundedAmount, InitialPaidAmount, TotalRemainingAmount, ActualFinalAmountDue, 
                UpdatedPaymentDate) != -1);
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

        public static bool DeleteByPaymentID(int PaymentID)
        {
            return PaymentDataAccess.DeleteByPaymentID(PaymentID) != 0;
        }

        public bool IsExistByPaymentID(int PaymentID)
        {
            return PaymentDataAccess.IsExistByPaymentID(PaymentID);
        }

        public Rental GetVehicleRentalByRentalID()
        {
            return Rental.FindByRentalID(RentalID); 
        }
    }
}
