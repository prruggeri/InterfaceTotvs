CREATE TABLE [dbo].[TotvsTable]
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Contato ID] NVARCHAR(50) NULL, 
    [Cod] NVARCHAR(50) NULL, 
    [Loja] NVARCHAR(50) NULL, 
    [Nome] NVARCHAR(100) NULL, 
    [F ou J] NVARCHAR(50) NULL, 
    [CEP] NVARCHAR(50) NULL, 
    [Endereco] NVARCHAR(50) NULL, 
    [Bairro] NVARCHAR(50) NULL, 
    [Municipio] NVARCHAR(50) NULL, 
    [Estado] NVARCHAR(50) NULL, 
    [Pais] NVARCHAR(50) NULL, 
    [Telefone Fixo] NVARCHAR(50) NULL, 
    [Celular] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [CNPJ ou CPF] NVARCHAR(50) NULL, 
    [Nome Fantasia Empresa] NVARCHAR(100) NULL, 
    [Tipo] NVARCHAR(50) NULL, 
    [HomePage] NVARCHAR(50) NULL, 
    [Cliente] BIT NULL, 
    [Data Abertura ou Nascimento] DATE NULL
)
