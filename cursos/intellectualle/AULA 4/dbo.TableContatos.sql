﻿CREATE TABLE [dbo].[Table]
(
	[Codigo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Telefone] NVARCHAR(15) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL
)
