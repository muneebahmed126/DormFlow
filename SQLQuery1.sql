
CREATE DATABASE FormFlowSystemDB;
USE FormFlowSystemDB;
GO

CREATE TABLE AppUsers (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    CNIC NVARCHAR(20) NOT NULL,
    Role NVARCHAR(20) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL
);



ALTER TABLE AppUsers 
ADD CONSTRAINT UC_Password UNIQUE (Password);

INSERT INTO AppUsers (FullName, CNIC, Role, Username, Password)
VALUES ('Test Admin', '12345', 'Admin', 'admin', '123');

INSERT INTO AppUsers (FullName, CNIC, Role, Username, Password)
VALUES ('Test Admin', '123456', 'Admin', 'admin1', '1234');

INSERT INTO AppUsers (FullName, CNIC, Role, Username, Password)
VALUES ('Muneeb', '12', 'Admin', 'Muneeb', '8635');



CREATE TABLE Rooms (
    RoomNo INT PRIMARY KEY,
    RoomStatus NVARCHAR(20) NOT NULL, 
    Booked NVARCHAR(10) DEFAULT 'No'  
);

CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    CNIC NVARCHAR(20) UNIQUE NOT NULL,
    ContactNo NVARCHAR(20),
    RoomNo INT FOREIGN KEY REFERENCES Rooms(RoomNo),
    Status NVARCHAR(20) DEFAULT 'Living' -- 'Living' or 'Leaved'
);


CREATE TABLE Fees (
    FeeId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT FOREIGN KEY REFERENCES Students(StudentId),
    FeeMonth NVARCHAR(20),
    Amount INT,
    PaymentDate DATETIME DEFAULT GETDATE()
);


CREATE TABLE Employees (

    EmployeeId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    CNIC NVARCHAR(20) UNIQUE NOT NULL,
    MobileNo NVARCHAR(20),
    Email NVARCHAR(100),
    Designation NVARCHAR(50), -- e.g., 'Warden', 'Janitor'
    Status NVARCHAR(20) DEFAULT 'Working' -- 'Working' or 'Resigned'
);

CREATE TABLE RoomRequests (
    RequestId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT FOREIGN KEY REFERENCES Students(StudentId),
    PreferredRoomType NVARCHAR(50),
    RequestDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) DEFAULT 'Pending' -- 'Pending', 'Approved', 'Rejected'
);