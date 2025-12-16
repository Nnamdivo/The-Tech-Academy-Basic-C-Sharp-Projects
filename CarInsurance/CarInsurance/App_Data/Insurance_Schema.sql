-- SQL Schema for Insurance.mdf
-- This is the SQL query that should be executed in the T-SQL screen

CREATE TABLE [dbo].[Insurees] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [FirstName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [EmailAddress] NVARCHAR(100) NOT NULL,
    [DateOfBirth] DATETIME NOT NULL,
    [CarYear] INT NOT NULL,
    [CarMake] NVARCHAR(50) NOT NULL,
    [CarModel] NVARCHAR(50) NOT NULL,
    [DUI] BIT NOT NULL DEFAULT 0,
    [SpeedingTickets] INT NOT NULL DEFAULT 0,
    [CoverageType] NVARCHAR(50) NOT NULL,
    [Quote] DECIMAL(18,2) NOT NULL
);

