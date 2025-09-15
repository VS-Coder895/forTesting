

-- ================================================
-- Table: VehicleReturns
-- ================================================
CREATE TABLE VehicleReturns (
    ReturnID INT IDENTITY(1,1) PRIMARY KEY,
    RentalID INT NOT NULL,
    ActualRentalDays INT NOT NULL,
    ActualReturnDate DATETIME NOT NULL,
    DamageReport VARCHAR(250) NOT NULL,
    AdditionalCharges DECIMAL(10, 2) NOT NULL,
    CurrentMileage DECIMAL(10, 2) NOT NULL,
    ConsumedMileage DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (RentalID) REFERENCES VehicleRentals(RentalID)
);
SELECT * from VehicleRentals
SELECT * from VehicleReturns
INSERT INTO VehicleReturns (RentalID, ActualRentalDays, ActualReturnDate, 
DamageReport, AdditionalCharges, 
CurrentMileage, ConsumedMileage) VALUES

(1, 4, '2024-08-05', 'No damage', 0.00, 20500, 500),
(2, 3, '2024-08-05', 'Small dent on rear bumper', 50.00, 15500, 500);
