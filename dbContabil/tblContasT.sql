CREATE TABLE [dbo].[tblContasT]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] NVARCHAR(30) NOT NULL, 
    [TipoConta] NCHAR(20) NOT NULL, 
    [Saldo] DECIMAL(18, 2) NOT NULL
)
