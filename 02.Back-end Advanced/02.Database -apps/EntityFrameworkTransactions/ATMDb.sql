CREATE DATABASE ATMdb;

GO

CREATE TABLE CardAccounts
(
Id int IDENTITY(1,1) PRIMARY KEY,
CardNumber char(10) NOT NULL,
CardPIN char(4),
CardCash money 
)

GO

CREATE TABLE TransactionHistory 
(
Id int IDENTITY(1,1) PRIMARY KEY,
CardNumber char(10) NOT NULL,
TransactionDate datetime,
Amount money
)

