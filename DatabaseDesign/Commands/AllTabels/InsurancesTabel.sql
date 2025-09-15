use Car_Rental_DB

-- ================================================
-- Table: Insurances
-- ================================================
CREATE TABLE Insurances (
    InsuranceID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);
INSERT INTO Insurances (Name) VALUES
('Basic Coverage'),
('Full Coverage'),
('Premium Coverage');
