USE [master]
GO
/****** Object:  Database [ALFONSO_DB]    Script Date: 7/5/2019 21:49:07 ******/
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
/****** Object:  Table [dbo].[COMIDAS]    Script Date: 7/5/2019 21:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMIDAS](
	[IdComida] [int] IDENTITY(1,1) NOT NULL,
	[NombreComida] [varchar](50) NOT NULL,
	[PrecioComida] [decimal](12, 3) NOT NULL CHECK (PrecioComida>0),
	[FechaCreacion] [smalldatetime] NOT NULL,
	[UsuarioCreacion] [int] NOT NULL,
	[FechaModificacion] [smalldatetime] NOT NULL,
	[UsuarioModificacion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdComida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INGREDIENTES]    Script Date: 7/5/2019 21:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INGREDIENTES](
	[IdIngrediente] [int] IDENTITY(1,1) NOT NULL,
	[NombreIngrediente] [varchar](50) NOT NULL,
	[Stockingrediente] [decimal](12, 3) NOT NULL,
	[PrecioIngrediente] [decimal](12, 3) NOT NULL CHECK (PrecioIngrediente>0),
	[UnidadMedida] [int] NOT NULL,
	[MasterPack] [decimal](12, 3) NOT NULL,
	[FechaCreacion] [smalldatetime] NOT NULL,
	[UsuarioCreacion] [int] NOT NULL,
	[FechaModificacion] [smalldatetime] NOT NULL,
	[UsuarioModificacion] [int] NOT NULL,
	
PRIMARY KEY CLUSTERED 
(
	[IdIngrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INGREDIETESPORCOMIDAS]    Script Date: 7/5/2019 21:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INGREDIETESPORCOMIDAS](
	[IdComidas] [int] NOT NULL,
	[IdIngredientes] [int] NOT NULL,
	[Cantidad] [decimal](12, 3) NOT NULL CHECK (Cantidad>0),
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
/****** Object:  Table [dbo].[TIPODEUSUARIO]    Script Date: 7/5/2019 21:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPODEUSUARIO](
	[IdTipoUsuario] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UNIDADDEMEDIDA]    Script Date: 7/5/2019 21:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIDADDEMEDIDA](
	[IdUnidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcioncorta] [varchar](2) NOT NULL,
	[Descripcionlarga] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUnidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 7/5/2019 21:49:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[IdTipoUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[COMIDAS] ON 

INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, N'Pizza Mussa', CAST(175.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (2, N'Porcion Papas', CAST(85.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (3, N'jamon y morron', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-02-05T00:00:00' AS SmallDateTime), 1, CAST(N'2019-02-05T00:00:00' AS SmallDateTime), 1)
SET IDENTITY_INSERT [dbo].[COMIDAS] OFF
SET IDENTITY_INSERT [dbo].[INGREDIENTES] ON 

INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [UnidadMedida]) VALUES (1, N'Papa', CAST(0.000 AS Decimal(12, 3)), CAST(1500.000 AS Decimal(12, 3)), CAST(15.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 2)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [UnidadMedida]) VALUES (2, N'Masa', CAST(0.000 AS Decimal(12, 3)), CAST(17.000 AS Decimal(12, 3)), CAST(0.435 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 2)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [UnidadMedida]) VALUES (3, N'Muzzarella', CAST(0.000 AS Decimal(12, 3)), CAST(3500.000 AS Decimal(12, 3)), CAST(25.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 2)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [UnidadMedida]) VALUES (4, N'Salsa', CAST(0.000 AS Decimal(12, 3)), CAST(500.000 AS Decimal(12, 3)), CAST(8.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 3)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [UnidadMedida]) VALUES (5, N'Aceituna', CAST(0.000 AS Decimal(12, 3)), CAST(250.000 AS Decimal(12, 3)), CAST(12.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 2)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [UnidadMedida]) VALUES (6, N'Oregano', CAST(0.000 AS Decimal(12, 3)), CAST(100.000 AS Decimal(12, 3)), CAST(500.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 2)
SET IDENTITY_INSERT [dbo].[INGREDIENTES] OFF
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 2, CAST(0.435 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 3, CAST(0.200 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 4, CAST(0.005 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 5, CAST(0.010 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, 6, CAST(0.001 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (2, 1, CAST(0.460 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[TIPODEUSUARIO] ([IdTipoUsuario], [Descripcion]) VALUES (1, N'ADMINISTRADOR')
INSERT [dbo].[TIPODEUSUARIO] ([IdTipoUsuario], [Descripcion]) VALUES (2, N'GERENTE')
INSERT [dbo].[TIPODEUSUARIO] ([IdTipoUsuario], [Descripcion]) VALUES (3, N'ATENCION PUBLICO')
SET IDENTITY_INSERT [dbo].[UNIDADDEMEDIDA] ON 

INSERT [dbo].[UNIDADDEMEDIDA] ([IdUnidad], [Descripcioncorta], [Descripcionlarga]) VALUES (1, N'UN', N'Unidad')
INSERT [dbo].[UNIDADDEMEDIDA] ([IdUnidad], [Descripcioncorta], [Descripcionlarga]) VALUES (2, N'GR', N'Gramo')
INSERT [dbo].[UNIDADDEMEDIDA] ([IdUnidad], [Descripcioncorta], [Descripcionlarga]) VALUES (3, N'CC', N'Centimetros Cubicos')
SET IDENTITY_INSERT [dbo].[UNIDADDEMEDIDA] OFF
SET IDENTITY_INSERT [dbo].[USUARIOS] ON 

INSERT [dbo].[USUARIOS] ([IdUsuario], [Usuario], [Pass], [IdTipoUsuario]) VALUES (1, N'admin', N'admin', 1)
SET IDENTITY_INSERT [dbo].[USUARIOS] OFF
ALTER TABLE [dbo].[COMIDAS]  WITH CHECK ADD FOREIGN KEY([UsuarioCreacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
GO
ALTER TABLE [dbo].[COMIDAS]  WITH CHECK ADD FOREIGN KEY([UsuarioModificacion])
REFERENCES [dbo].[USUARIOS] ([IdUsuario])
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
USE [master]
GO
ALTER DATABASE [ALFONSO_DB] SET  READ_WRITE 
GO
