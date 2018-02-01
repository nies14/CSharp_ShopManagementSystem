CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(20) NULL, 
    [User_Name] NCHAR(10) NULL, 
    [Age] TINYINT NULL, 
    [Mobile] NCHAR(11) NULL, 
    [Address] NCHAR(100) NULL, 
    [Gender] NCHAR(5) NULL, 
    [Password] NCHAR(20) NULL
)
