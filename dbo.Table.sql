CREATE TABLE [dbo].[Employee] (
    [Id]        INT         NOT NULL,
    [Name]      NCHAR (20)  NULL,
    [User Name] NCHAR (10)  NULL,
    [Age]       TINYINT     NULL,
    [Mobile]    NCHAR (11)  NULL,
    [Gender]    NCHAR (7)   NULL,
    [Address]   NCHAR (100) NULL,
    [Password]  NCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

