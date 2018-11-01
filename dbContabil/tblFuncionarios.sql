CREATE TABLE [dbo].[tblFuncionarios]
(
	[Matricula] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Salario] DECIMAL(18, 2) NOT NULL, 
    [ValeTransporte] DECIMAL(18, 2) NOT NULL, 
    [Dependentes] INT NOT NULL
)
