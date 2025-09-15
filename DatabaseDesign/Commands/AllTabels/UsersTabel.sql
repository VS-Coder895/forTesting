

CREATE DATABASE Car_Rental_DB

-- ================================================
-- Table: Users
-- ================================================
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    UserName VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20)
);
INSERT INTO Users (UserName, Password, Role) VALUES
('admin', 'admin123', 'Admin'),
('john_doe', 'pass123', 'Staff'),
('sara_smith', 'sara123', 'Staff');
