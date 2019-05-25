USE [master]
GO
/****** Object:  Database [ALFONSO_DB]    Script Date: 24/5/2019 21:22:22 ******/
CREATE DATABASE [ALFONSO_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ALFONSO_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ALFONSO_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ALFONSO_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ALFONSO_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ALFONSO_DB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ALFONSO_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ALFONSO_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ALFONSO_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ALFONSO_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ALFONSO_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ALFONSO_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ALFONSO_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ALFONSO_DB] SET  MULTI_USER 
GO
ALTER DATABASE [ALFONSO_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ALFONSO_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ALFONSO_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ALFONSO_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ALFONSO_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ALFONSO_DB] SET QUERY_STORE = OFF
GO
USE [ALFONSO_DB]
GO
/****** Object:  Table [dbo].[INGREDIENTES]    Script Date: 24/5/2019 21:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INGREDIENTES](
	[IdIngrediente] [int] IDENTITY(1,1) NOT NULL,
	[NombreIngrediente] [varchar](50) NOT NULL,
	[Stockingrediente] [decimal](12, 3) NOT NULL,
	[PrecioIngrediente] [decimal](12, 3) NOT NULL,
	[UnidadMedida] [int] NOT NULL,
	[MasterPack] [decimal](12, 3) NOT NULL,
	[FechaCreacion] [smalldatetime] NOT NULL,
	[UsuarioCreacion] [int] NOT NULL,
	[FechaModificacion] [smalldatetime] NOT NULL,
	[UsuarioModificacion] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIngrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UNIDADDEMEDIDA]    Script Date: 24/5/2019 21:22:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIDADDEMEDIDA](
	[IdUnidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcioncorta] [varchar](2) NOT NULL,
	[Descripcionlarga] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUnidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 24/5/2019 21:22:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[IdTipoUsuario] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[ApellidoUsuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DINGREDIENTES]    Script Date: 24/5/2019 21:22:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEw [dbo].[DINGREDIENTES] as
select  i.Idingrediente , i.NombreIngrediente, i.PrecioIngrediente, u.Descripcioncorta,i.MasterPack,us.Usuario, i.FechaCreacion ,us2.Usuario as UserMod, i.FechaModificacion from INGREDIENTES as i inner join UNIDADDEMEDIDA as u on u.IdUnidad =i.UnidadMedida inner join USUARIOS as us on  us.IdUsuario=i.UsuarioCreacion inner join usuarios as us2 on us2.IdUsuario=i.UsuarioModificacion where i.Estado=1
GO
/****** Object:  Table [dbo].[TIPOCOMIDA]    Script Date: 24/5/2019 21:22:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOCOMIDA](
	[IdTipoComida] [int] IDENTITY(1,1) NOT NULL,
	[NombreTipoComida] [varchar](50) NOT NULL,
	[FechaCreacion] [smalldatetime] NOT NULL,
	[UsuarioCreacion] [int] NOT NULL,
	[FechaModificacion] [smalldatetime] NOT NULL,
	[UsuarioModificacion] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoComida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DTIPOCOMIDAS]    Script Date: 24/5/2019 21:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEw [dbo].[DTIPOCOMIDAS] as
select  i.IdTipoComida , i.NombreTipoComida,  us.Usuario, i.FechaCreacion ,us2.Usuario as UserMod, i.FechaModificacion from TIPOCOMIDA as i  inner join USUARIOS as us on  us.IdUsuario=i.UsuarioCreacion inner join usuarios as us2 on us2.IdUsuario=i.UsuarioModificacion where i.Estado=1
GO
/****** Object:  Table [dbo].[COMIDAS]    Script Date: 24/5/2019 21:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMIDAS](
	[IdComida] [int] IDENTITY(1,1) NOT NULL,
	[NombreComida] [varchar](50) NOT NULL,
	[PrecioComida] [decimal](12, 3) NOT NULL,
	[FechaCreacion] [smalldatetime] NOT NULL,
	[UsuarioCreacion] [int] NOT NULL,
	[FechaModificacion] [smalldatetime] NOT NULL,
	[UsuarioModificacion] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[TC] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdComida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DCOMIDAS]    Script Date: 24/5/2019 21:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[DCOMIDAS] AS
select  i.IdComida , i.NombreComida, i.PrecioComida, TC.NombreTipoComida, us.Usuario, i.FechaCreacion ,us2.Usuario as UserMod, i.FechaModificacion from COMIDAS as i inner join TIPOCOMIDA as TC on i.IdComida=TC.IdTipoComida inner join USUARIOS as us on  us.IdUsuario=i.UsuarioCreacion inner join usuarios as us2 on us2.IdUsuario=i.UsuarioModificacion where i.Estado=1
GO
/****** Object:  Table [dbo].[INGREDIETESPORCOMIDAS]    Script Date: 24/5/2019 21:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INGREDIETESPORCOMIDAS](
	[IdComidas] [int] NOT NULL,
	[IdIngredientes] [int] NOT NULL,
	[Cantidad] [decimal](12, 3) NOT NULL,
	[FechaCreacion] [smalldatetime] NOT NULL,
	[UsuarioCreacion] [int] NOT NULL,
	[FechaModificacion] [smalldatetime] NOT NULL,
	[UsuarioModificacion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdComidas] ASC,
	[IdIngredientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPODEUSUARIO]    Script Date: 24/5/2019 21:22:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPODEUSUARIO](
	[IdTipoUsuario] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[COMIDAS] ON 

INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (1, N'PIZZA MUZZARELLA', CAST(175.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (2, N'PORCION PAPAS', CAST(86.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-22T00:00:00' AS SmallDateTime), 2, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (3, N'PIZZA JAMON Y MORON', CAST(222.000 AS Decimal(12, 3)), CAST(N'2019-02-05T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-22T00:00:00' AS SmallDateTime), 2, 1, 1)
SET IDENTITY_INSERT [dbo].[COMIDAS] OFF
SET IDENTITY_INSERT [dbo].[INGREDIENTES] ON 

INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, N'PAPA', CAST(0.000 AS Decimal(12, 3)), CAST(1.000 AS Decimal(12, 3)), 1, CAST(1.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 2, CAST(N'2019-05-21T00:00:00' AS SmallDateTime), 2, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (2, N'MASA', CAST(0.000 AS Decimal(12, 3)), CAST(223.000 AS Decimal(12, 3)), 1, CAST(22.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-20T00:00:00' AS SmallDateTime), 2, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (3, N'MUZZARELLA', CAST(0.000 AS Decimal(12, 3)), CAST(3500.000 AS Decimal(12, 3)), 2, CAST(26.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-18T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (4, N'SALSA', CAST(0.000 AS Decimal(12, 3)), CAST(500.000 AS Decimal(12, 3)), 3, CAST(8.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (5, N'ACEITUNA', CAST(0.000 AS Decimal(12, 3)), CAST(250.000 AS Decimal(12, 3)), 2, CAST(12.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 2, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (6, N'OREGANO', CAST(0.000 AS Decimal(12, 3)), CAST(22.000 AS Decimal(12, 3)), 1, CAST(22.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-22T00:00:00' AS SmallDateTime), 2, 1)
SET IDENTITY_INSERT [dbo].[INGREDIENTES] OFF
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 2, CAST(0.435 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 3, CAST(0.200 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 4, CAST(0.005 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 5, CAST(0.010 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 6, CAST(0.001 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (2, 1, CAST(0.460 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
SET IDENTITY_INSERT [dbo].[TIPOCOMIDA] ON 

INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, N'PIZZAS ESPECIALES', CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (2, N'EMPANADA', CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (3, N'HAMBURGUESA', CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[TIPOCOMIDA] OFF
INSERT [dbo].[TIPODEUSUARIO] ([IdTipoUsuario], [Descripcion], [Estado]) VALUES (1, N'ADMINISTRADOR', 1)
INSERT [dbo].[TIPODEUSUARIO] ([IdTipoUsuario], [Descripcion], [Estado]) VALUES (2, N'GERENTE', 1)
INSERT [dbo].[TIPODEUSUARIO] ([IdTipoUsuario], [Descripcion], [Estado]) VALUES (3, N'ATENCION PUBLICO', 1)
SET IDENTITY_INSERT [dbo].[UNIDADDEMEDIDA] ON 

INSERT [dbo].[UNIDADDEMEDIDA] ([IdUnidad], [Descripcioncorta], [Descripcionlarga], [Estado]) VALUES (1, N'UN', N'Unidad', 1)
INSERT [dbo].[UNIDADDEMEDIDA] ([IdUnidad], [Descripcioncorta], [Descripcionlarga], [Estado]) VALUES (2, N'GR', N'Gramo', 1)
INSERT [dbo].[UNIDADDEMEDIDA] ([IdUnidad], [Descripcioncorta], [Descripcionlarga], [Estado]) VALUES (3, N'CC', N'Centimetros Cubicos', 1)
SET IDENTITY_INSERT [dbo].[UNIDADDEMEDIDA] OFF
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 

INSERT [dbo].[USUARIOS] ([IdUsuario], [Usuario], [Pass], [IdTipoUsuario], [Estado], [NombreUsuario], [ApellidoUsuario]) VALUES (1, N'admin', N'admin', 1, 1, N'Leonardo', N'Alfonso')
INSERT [dbo].[USUARIOS] ([IdUsuario], [Usuario], [Pass], [IdTipoUsuario], [Estado], [NombreUsuario], [ApellidoUsuario]) VALUES (2, N'x', N'x', 1, 1, N'X', N'X')
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
ALTER TABLE [dbo].[COMIDAS]  WITH CHECK ADD FOREIGN KEY([UsuarioCreacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
GO
ALTER TABLE [dbo].[COMIDAS]  WITH CHECK ADD FOREIGN KEY([UsuarioModificacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
GO
ALTER TABLE [dbo].[COMIDAS]  WITH CHECK ADD  CONSTRAINT [FK_TCfr] FOREIGN KEY([TC])
REFERENCES [dbo].[TIPOCOMIDA] ([IdTipoComida])
GO
ALTER TABLE [dbo].[COMIDAS] CHECK CONSTRAINT [FK_TCfr]
GO
ALTER TABLE [dbo].[INGREDIENTES]  WITH CHECK ADD FOREIGN KEY([UsuarioCreacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
GO
ALTER TABLE [dbo].[INGREDIENTES]  WITH CHECK ADD FOREIGN KEY([UsuarioModificacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
GO
ALTER TABLE [dbo].[INGREDIENTES]  WITH CHECK ADD  CONSTRAINT [FK_Unidad] FOREIGN KEY([UnidadMedida])
REFERENCES [dbo].[UNIDADDEMEDIDA] ([IdUnidad])
GO
ALTER TABLE [dbo].[INGREDIENTES] CHECK CONSTRAINT [FK_Unidad]
GO
ALTER TABLE [dbo].[INGREDIETESPORCOMIDAS]  WITH CHECK ADD FOREIGN KEY([IdComidas])
REFERENCES [dbo].[COMIDAS] ([IdComida])
GO
ALTER TABLE [dbo].[INGREDIETESPORCOMIDAS]  WITH CHECK ADD FOREIGN KEY([IdIngredientes])
REFERENCES [dbo].[INGREDIENTES] ([IdIngrediente])
GO
ALTER TABLE [dbo].[INGREDIETESPORCOMIDAS]  WITH CHECK ADD FOREIGN KEY([UsuarioCreacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
GO
ALTER TABLE [dbo].[INGREDIETESPORCOMIDAS]  WITH CHECK ADD FOREIGN KEY([UsuarioModificacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD FOREIGN KEY([IdTipoUsuario])
REFERENCES [dbo].[TIPODEUSUARIO] ([IdTipoUsuario])
GO
ALTER TABLE [dbo].[COMIDAS]  WITH CHECK ADD CHECK  (([PrecioComida]>(0)))
GO
ALTER TABLE [dbo].[INGREDIENTES]  WITH CHECK ADD CHECK  (([PrecioIngrediente]>(0)))
GO
ALTER TABLE [dbo].[INGREDIETESPORCOMIDAS]  WITH CHECK ADD CHECK  (([Cantidad]>(0)))
GO
USE [master]
GO
ALTER DATABASE [ALFONSO_DB] SET  READ_WRITE 
GO
