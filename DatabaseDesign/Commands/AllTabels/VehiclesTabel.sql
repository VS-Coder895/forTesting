
select * from VehicleTypes
-- ================================================
-- Table: Vehicles
-- ================================================
CREATE TABLE Vehicles (
    VehicleID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Model INT,
    ManufacturerID INT NOT NULL,
    Color VARCHAR(20) NOT NULL,
    IsVehicleAvailable INT DEFAULT 1,
    FuelTypeID INT NOT NULL,
    EnginTypeID INT NOT NULL,
    FuelEfficiency DECIMAL(10, 2),
    VehicleTypeID INT NOT NULL,
    LPN VARCHAR(30) NOT NULL UNIQUE,
    DailyRentalPrice DECIMAL(10, 2),
    Mileage DECIMAL(10, 2),
    TransmissionType VARCHAR(30),
    SeatingCapacity INT,
    LastServiceDate DATETIME,
    FOREIGN KEY (ManufacturerID) REFERENCES Manufacturers(ManufacturerID),
    FOREIGN KEY (FuelTypeID) REFERENCES FuelTypes(FuelTypeID),
    FOREIGN KEY (EnginTypeID) REFERENCES EnginTypes(EnginTypeID),
    FOREIGN KEY (VehicleTypeID) REFERENCES VehicleTypes(VehicleTypeID)
);
INSERT INTO Vehicles (Name, Model, ManufacturerID, Color, IsVehicleAvailable, FuelTypeID, EnginTypeID, FuelEfficiency, VehicleTypeID, LPN, DailyRentalPrice, Mileage, TransmissionType, SeatingCapacity, LastServiceDate) VALUES
('Corolla', 2020, 1, 'White', 1, 1, 1, 15.5, 1, 'ABC-123', 50.00, 20000, 'Automatic', 5, '2024-05-15'),
('Santa Fe', 2021, 2, 'Black', 1, 1, 2, 12.0, 2, 'XYZ-789', 80.00, 15000, 'Automatic', 7, '2024-07-01'),
('F-150', 2019, 3, 'Blue', 1, 2, 2, 10.0, 3, 'TRK-555', 100.00, 50000, 'Manual', 3, '2024-04-10');
