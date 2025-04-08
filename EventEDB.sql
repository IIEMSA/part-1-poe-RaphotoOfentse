-- Step 1: Create the database
CREATE DATABASE EventEDB;
GO

-- Step 2: Use the new database
USE EventEDB;
GO

-- Step 3: Create the Venue table
CREATE TABLE Venue (
    VenueID INT PRIMARY KEY IDENTITY(1,1), -- Auto-incrementing ID
    VenueName NVARCHAR(100) NOT NULL,
    Location NVARCHAR(200) NOT NULL,
    Capacity INT NOT NULL,
    ImageURL NVARCHAR(MAX) NULL
);

--Insert table data
INSERT INTO Venue (VenueName, Location, Capacity, ImageURL)
VALUES('Shepstone Gardens', 'Johanesburg', 250, 'https://www.google.co.za/url?sa=i&url=https%3A%2F%2Fwww.wheresmywedding.co.za%2Fblog%2Fgauteng-wedding-venue-shepstone-gardens&psig=AOvVaw2xP2ebCMHCcsQHAb_c6dL3&ust=1744201582266000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCOjrgbW3yIwDFQAAAAAdAAAAABAP')

SELECT * FROM Venue

DROP TABLE IF EXISTS Event;


CREATE TABLE Event (
    EventID INT PRIMARY KEY IDENTITY(1,1),
    EventName NVARCHAR(100) NOT NULL,
    Date DATETIME NOT NULL,
    Description NVARCHAR(MAX),
    ImageURL NVARCHAR(MAX)
);

INSERT INTO Event (EventName, Date, Description, ImageURL)
VALUES ('Balcony Mix Africa', '2025-02-26 13:09','Vibrant Music Festival', 'https://www.google.co.za/imgres?q=balcony%20mix&imgurl=https%3A%2F%2Fhowler-production.s3.eu-west-1.amazonaws.com%2Fuploads%2Forganiser%2Forganiser_logo%2F10196%2FLogos_The_Balcony_Mix_Africa_colored_black.png&imgrefurl=https%3A%2F%2Fbalconymix.howler.co.za%2F&docid=g50b8UVOygQWJM&tbnid=r58c0_ojQBoIdM&vet=12ahUKEwjjtMnd48iMAxV1Z0EAHY_MIOAQM3oECBYQAA..i&w=4500&h=4501&hcb=2&ved=2ahUKEwjjtMnd48iMAxV1Z0EAHY_MIOAQM3oECBYQAA')

SELECT * FROM Event

CREATE TABLE Booking (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    BookingDate DATETIME NOT NULL,
    CustomerName NVARCHAR(100) NOT NULL,
    CustomerEmail NVARCHAR(100) NOT NULL,
	EventName NVARCHAR(100) NOT NULL,
    NumberOfGuests INT NOT NULL
);

INSERT INTO Booking (BookingDate, CustomerName, CustomerEmail, EventName, NumberOfGuests)
VALUES ('2025-02-01 14:30', 'Lily', 'lilybloom@gmail.com','Balcony', 20)

SELECT * FROM Booking
