


use Car_Rental_DB


CREATE TABLE FuelTypes_New (
    FuelTypeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(14)
	)

	
INSERT INTO FuelTypes_New (Name)
SELECT Name FROM FuelTypes;


UPDATE Vehicles
SET Vehicles.FuelTypeID = FT_New.FuelTypeID
FROM Vehicles 
JOIN FuelTypes  ON Vehicles.FuelTypeID = FuelTypes.FuelTypeID
JOIN FuelTypes_New FT_New ON FuelTypes.FuelTypeID = FT_New.FuelTypeID;

SELECT name FROM sys.foreign_keys
	where parent_object_id=OBJECT_ID('Vehicles')

ALTER TABLE Vehicles
DROP CONSTRAINT FK__Vehicles__FuelTy__4CA06362;

DROP TABLE FuelTypes;
EXEC sp_rename 'FuelTypes_New', 'FuelTypes';

ALTER TABLE Vehicles
ADD CONSTRAINT FY_Vehicles_FuelTypeID
FOREIGN KEY (FuelTypeID) REFERENCES FuelTypes(FuelTypeID)


