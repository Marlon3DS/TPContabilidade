CREATE TABLE [dbo].[tblLivroDiario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Data] DATETIME NOT NULL, 
    [Local] VARCHAR(50) NOT NULL, 
    [Destino] INT NOT NULL, 
    [Origem] INT NOT NULL, 
    [Historico] VARCHAR(MAX) NOT NULL, 
    [Valor] DECIMAL NOT NULL, 
    CONSTRAINT [FK_Destino] FOREIGN KEY (Destino) REFERENCES [tblContasT](Id), 
	CONSTRAINT [FK_Origem] FOREIGN KEY (Origem) REFERENCES [tblContasT](Id), 
)
