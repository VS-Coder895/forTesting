


-- ================================================
-- Table: Customers
-- ================================================
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(100),
    Email VARCHAR(100),
    DLN VARCHAR(30) NOT NULL UNIQUE,
    Address VARCHAR(200)
);
INSERT INTO Customers (Name, PhoneNumber, Email, DLN, Address) VALUES
('Ali Hassan', '777111222', 'ali@example.com', 'DLN001', 'Sana''a, Yemen'),
('Fatima Saleh', '777333444', 'fatima@example.com', 'DLN002', 'Aden, Yemen'),
('Mohammed Nasser', '777555666', 'mohammed@example.com', 'DLN003', 'Taiz, Yemen');
