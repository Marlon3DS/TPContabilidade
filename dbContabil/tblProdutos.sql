CREATE TABLE [dbo].[tblProdutos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [ValorUnitario] DECIMAL(18, 2) NOT NULL
)
