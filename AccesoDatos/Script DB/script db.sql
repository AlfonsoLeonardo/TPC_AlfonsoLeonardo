use master
go
create database PIZZERIA_DB
go


USE PIZZERIA_DB
GO

/****** Object:  Table [dbo].[PERSONAJES]    Script Date: 6/4/2019 11:08:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[INGREDIENTES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[StockIngrediente] [money] Null,
	[MasterPack] [money] Null,
	[Precio] [money] NULL,
	[PrecioPorUnidad] [money] null, 
 CONSTRAINT [PK_INGREDIENTES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

