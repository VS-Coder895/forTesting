

-- ================================================
-- Table: VehicleRentals
-- ================================================
CREATE TABLE VehicleRentals (
    RentalID INT IDENTITY(1,1) PRIMARY KEY,
    VehicleID INT NOT NULL,
    CustomerID INT NOT NULL,
    UserID INT NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    InitialCheckNotes VARCHAR(100) NOT NULL,
    PickupLocation VARCHAR(100) NOT NULL,
    DropOffLocation VARCHAR(100) NOT NULL,
    InsuranceID INT NULL,
    RentalPricePerDay DECIMAL(10, 2) NOT NULL,
    InitialRentalDays INT NOT NULL,
    InitialTotalDueAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (VehicleID) REFERENCES Vehicles(VehicleID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (InsuranceID) REFERENCES Insurances(InsuranceID)
);
INSERT INTO VehicleRentals (VehicleID, CustomerID, UserID, StartDate, EndDate, InitialCheckNotes, PickupLocation, DropOffLocation, InsuranceID, RentalPricePerDay, InitialRentalDays, InitialTotalDueAmount) VALUES
(1, 1, 2, '2024-08-01', '2024-08-05', 'No scratches, fuel full', 'Sana''a Branch', 'Aden Branch', 1, 50.00, 4, 200.00),
(2, 2, 3, '2024-08-02', '2024-08-04', 'Minor scratch on door', 'Aden Branch', 'Aden Branch', 2, 80.00, 2, 160.00);
