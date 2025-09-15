
use Car_Rental_DB

-- ================================================
-- Table: EnginTypes
-- ================================================
CREATE TABLE EnginTypes (
    EnginTypeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);
INSERT INTO EnginTypes (Name) VALUES
('V4'),
('V6'),
('Electric Motor');
