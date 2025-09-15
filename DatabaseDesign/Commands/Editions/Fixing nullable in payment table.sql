USE Car_Rental_DB;
SELECT * FROM Customers
SELECT * FROM RentalPayments WHERE PaymentStatus like 'paid'

ALTER Table RentalPayments
ALTER COLUMN TotalRefundedAmount decimal(10, 2) null

ALTER Table RentalPayments
ALTER COLUMN ActualFinalAmountDue decimal(10, 2) null


ALTER Table RentalPayments
ALTER COLUMN PaymentNotes VARCHAR(MAX) null

UPDATE RentalPayments SET TotalRefundedAmount=null, ActualFinalAmountDue=null WHERE UpdatedPaymentDate is null

