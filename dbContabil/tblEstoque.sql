CREATE TABLE [dbo].[tblEstoque]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdProduto] INT NOT NULL, 
    [TipoOperacao] NVARCHAR(10) NOT NULL, 
    [Quantidade] INT NOT NULL, 
    [ValorTotal] DECIMAL(18, 2) NOT NULL, 
    [Data] DATETIME NOT NULL,
	CONSTRAINT [FK_Produto] FOREIGN KEY (IdProduto) REFERENCES [tblProdutos](Id)
)
