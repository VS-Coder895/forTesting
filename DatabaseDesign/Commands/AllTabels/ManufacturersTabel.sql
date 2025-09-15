

-- ================================================
-- Table: Manufacturers
-- ================================================
CREATE TABLE Manufacturers (
    ManufacturerID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL UNIQUE
);
INSERT INTO Manufacturers (Name) VALUES
('Toyota'),
('Hyundai'),
('Ford');
