

use Car_Rental_DB

-- ================================================
-- Table: Maintenance
-- ================================================
CREATE TABLE Maintenance (
    MaintenanceID INT IDENTITY(1,1) PRIMARY KEY,
    VehicleID INT NOT NULL,
    Description VARCHAR(250) NOT NULL,
    MaintenanceDate DATETIME NOT NULL,
    Cost DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (VehicleID) REFERENCES Vehicles(VehicleID)
);
INSERT INTO Maintenance (VehicleID, Description, MaintenanceDate, Cost) VALUES
(1, 'Oil change and filter replacement', '2024-06-01', 30.00),
(2, 'Brake pad replacement', '2024-07-10', 120.00),
(3, 'Tire replacement', '2024-05-20', 400.00);
