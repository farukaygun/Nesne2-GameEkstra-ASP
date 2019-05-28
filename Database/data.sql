CREATE DATABASE GameEkstraDatabase
GO

USE GameEkstraDatabase     
GO

CREATE TABLE tblUser
(
    TCNO INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(25),
    password PASSWORD,
    name NVARCHAR(25),
    surname NVARCHAR(25),
    mail NVARCHAR(50),
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

CREATE TABLE UserBuyProduct
(
    TCNO INT FOREIGN KEY REFERENCES tblUser(TCNO),
    ID INT FOREIGN KEY REFERENCES tblProduct(ID),
    adet INT
)