
use Car_Rental_DB
-- ================================================
-- Table: FuelTypes
-- ================================================
CREATE TABLE FuelTypes (
    FuelTypeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL UNIQUE
);
INSERT INTO FuelTypes (Name) VALUES
('Petrol'),
('Diesel'),
('Electric');
