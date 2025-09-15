-- ================================================
-- Table: VehicleTypes
-- ================================================
CREATE TABLE VehicleTypes (
    VehicleTypeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);
INSERT INTO VehicleTypes (Name) VALUES
('Sedan'),
('SUV'),
('Truck');
