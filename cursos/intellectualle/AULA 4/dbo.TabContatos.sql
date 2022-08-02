CREATE TABLE [dbo].[Table]
(
    [Nome] NVARCHAR(50) NOT NULL, 
    [Telefone] NVARCHAR(15) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Codigo] INT NOT NULL IDENTITY, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Codigo])
)
