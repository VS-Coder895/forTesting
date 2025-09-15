
use Car_Rental_DB

-- ================================================
-- Table: RentalPayments
-- ================================================
CREATE TABLE RentalPayments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    RentalID INT NOT NULL,
    PaymentDate DATETIME NOT NULL,
    PaymentStatus VARCHAR(20),
    PaymentNotes VARCHAR(100),
    TotalRefundedAmount DECIMAL(10, 2),
    InitialPaidAmount DECIMAL(10, 2) NOT NULL,
    TotalRemainingAmount DECIMAL(10, 2),
    ActualFinalAmountDue DECIMAL(10, 2),
    UpdatedPaymentDate DATETIME,
    FOREIGN KEY (RentalID) REFERENCES VehicleRentals(RentalID)
);
INSERT INTO RentalPayments (RentalID, PaymentDate, PaymentStatus, PaymentNotes, TotalRefundedAmount, InitialPaidAmount, TotalRemainingAmount, ActualFinalAmountDue, UpdatedPaymentDate) VALUES
(1, '2024-08-01', 'Paid', 'Full payment upfront', 0.00, 200.00, 0.00, 200.00, NULL),
(2, '2024-08-02', 'Partial', 'Paid half, remaining on return', 0.00, 80.00, 130.00, 210.00, '2024-08-05');
