CREATE DATABASE GameEkstraDatabase
GO

USE GameEkstraDatabase     
GO

CREATE TABLE tblUser
(
    name NVARCHAR(25),
    surname NVARCHAR(25),
    TCNO INT PRIMARY KEY IDENTITY(1,1),
    mail NVARCHAR(50),
    password PASSWORD,
    phone INT,
    address TEXT,
)

CREATE TABLE tblProduct
(
    ID INT PRIMARY KEY,
    name NVARCHAR(25),
    price MONEY,
    image IMAGE
)