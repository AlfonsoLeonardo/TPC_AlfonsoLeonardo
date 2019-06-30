USE [master]
GO
/****** Object:  Database [ALFONSO_DB]    Script Date: 21/6/2019 18:59:34 ******/
CREATE DATABASE [ALFONSO_DB]
 CONTAINMENT = NONElk
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
/****** Object:  Table [dbo].[INGREDIENTES]    Script Date: 21/6/2019 18:59:35 ******/
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
/****** Object:  Table [dbo].[UNIDADDEMEDIDA]    Script Date: 21/6/2019 18:59:35 ******/
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
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 21/6/2019 18:59:35 ******/
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
/****** Object:  View [dbo].[DINGREDIENTES]    Script Date: 21/6/2019 18:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEw [dbo].[DINGREDIENTES] as
select  i.Idingrediente , i.NombreIngrediente, i.PrecioIngrediente, u.Descripcioncorta,i.MasterPack,us.Usuario, i.FechaCreacion ,us2.Usuario as UserMod, i.FechaModificacion from INGREDIENTES as i inner join UNIDADDEMEDIDA as u on u.IdUnidad =i.UnidadMedida inner join USUARIOS as us on  us.IdUsuario=i.UsuarioCreacion inner join usuarios as us2 on us2.IdUsuario=i.UsuarioModificacion where i.Estado=1
GO
/****** Object:  Table [dbo].[TIPOCOMIDA]    Script Date: 21/6/2019 18:59:35 ******/
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
/****** Object:  View [dbo].[DTIPOCOMIDAS]    Script Date: 21/6/2019 18:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEw [dbo].[DTIPOCOMIDAS] as
select  i.IdTipoComida , i.NombreTipoComida,  us.Usuario, i.FechaCreacion ,us2.Usuario as UserMod, i.FechaModificacion from TIPOCOMIDA as i  inner join USUARIOS as us on  us.IdUsuario=i.UsuarioCreacion inner join usuarios as us2 on us2.IdUsuario=i.UsuarioModificacion where i.Estado=1
GO
/****** Object:  Table [dbo].[COMIDAS]    Script Date: 21/6/2019 18:59:35 ******/
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
/****** Object:  View [dbo].[DCOMIDAS]    Script Date: 21/6/2019 18:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DCOMIDAS]
AS
SELECT        i.IdComida, i.NombreComida, i.PrecioComida, TC.NombreTipoComida, us.Usuario, i.FechaCreacion, us2.Usuario AS UserMod, i.FechaModificacion
FROM            dbo.COMIDAS AS i INNER JOIN
                         dbo.TIPOCOMIDA AS TC ON i.TC = TC.IdTipoComida INNER JOIN
                         dbo.USUARIOS AS us ON us.IdUsuario = i.UsuarioCreacion INNER JOIN
                         dbo.USUARIOS AS us2 ON us2.IdUsuario = i.UsuarioModificacion
WHERE        (i.Estado = 1)
GO
/****** Object:  Table [dbo].[INGREDIETESPORCOMIDAS]    Script Date: 21/6/2019 18:59:35 ******/
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
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdComidas] ASC,
	[IdIngredientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPODEUSUARIO]    Script Date: 21/6/2019 18:59:35 ******/
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

INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (1, N'MUZZARELLA', CAST(175.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (2, N'PORCION PAPAS', CAST(85.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-22T00:00:00' AS SmallDateTime), 2, 1, 11)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (3, N'JAMON Y MORON', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-02-05T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-22T00:00:00' AS SmallDateTime), 2, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (18, N'CARNE', CAST(30.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 2)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (19, N'POLLO', CAST(30.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 2)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (20, N'CHOCLO', CAST(30.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 2)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (21, N'CAPRESE', CAST(30.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 2)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (22, N'ROQUEFORT', CAST(30.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 2)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (23, N'JAMON Y QUESO', CAST(30.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 2)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (24, N'CEBOLLA Y QUESO', CAST(30.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 2)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (25, N'ALBAHACA', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (26, N'ANCHOAS', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (27, N'CALABRESA', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (28, N'CAPRESSE', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (29, N'CHOCLO.', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (30, N'FUGAZZA', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (31, N'FUGAZZETA', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (32, N'HUEVO', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (33, N'HUEVO CON JAMON', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (34, N'JAMON', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (35, N'NAPOLITANA', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (36, N'NAPO CON JAMON', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (37, N'PRIMAVERA', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (38, N'PROVOLONE', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (39, N'QUESO AZUL', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (40, N'SALCHICHA', CAST(220.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 1)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (41, N'ANANA', CAST(240.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 6)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (42, N'PALMITOS', CAST(240.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 6)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (43, N'PAPA Y HVO FRITO', CAST(240.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 6)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (44, N'A CABALLO', CAST(240.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 6)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (45, N'SUPER FUGAZZETA', CAST(240.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 6)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (46, N'PIZZA AZUL', CAST(240.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 6)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (47, N'MI PRIMAVERA', CAST(240.000 AS Decimal(12, 3)), CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1, 6)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (48, N'MILA SIMPLE', CAST(140.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 10)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (49, N'MILA S.COMPLETA', CAST(150.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 10)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (50, N'MILA COMPLETA', CAST(180.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 10)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (51, N'NAPO C/FRITAS', CAST(200.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 10)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (52, N'MILA C/FRITAS', CAST(180.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 10)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (53, N'M+CABALLO+FRITA', CAST(200.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 10)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (54, N'COMBO 1', CAST(145.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 8)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (55, N'COMBO 2', CAST(175.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 8)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (56, N'COMBO 3', CAST(165.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 8)
INSERT [dbo].[COMIDAS] ([IdComida], [NombreComida], [PrecioComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado], [TC]) VALUES (57, N'COMBO 4', CAST(195.000 AS Decimal(12, 3)), CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-21T00:00:00' AS SmallDateTime), 1, 1, 8)
SET IDENTITY_INSERT [dbo].[COMIDAS] OFF
SET IDENTITY_INSERT [dbo].[INGREDIENTES] ON 

INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, N'PAPA', CAST(0.000 AS Decimal(12, 3)), CAST(1.000 AS Decimal(12, 3)), 1, CAST(1.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 2, CAST(N'2019-05-21T00:00:00' AS SmallDateTime), 2, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (2, N'MASA', CAST(0.000 AS Decimal(12, 3)), CAST(223.000 AS Decimal(12, 3)), 1, CAST(22.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-20T00:00:00' AS SmallDateTime), 2, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (3, N'MUZZARELLA', CAST(0.000 AS Decimal(12, 3)), CAST(3500.000 AS Decimal(12, 3)), 2, CAST(26.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-18T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (4, N'SALSA', CAST(0.000 AS Decimal(12, 3)), CAST(500.000 AS Decimal(12, 3)), 3, CAST(8.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (5, N'ACEITUNA', CAST(0.000 AS Decimal(12, 3)), CAST(250.000 AS Decimal(12, 3)), 2, CAST(12.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 2, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (6, N'OREGANO', CAST(0.000 AS Decimal(12, 3)), CAST(22.000 AS Decimal(12, 3)), 1, CAST(22.000 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-22T00:00:00' AS SmallDateTime), 2, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (37, N'PEPA', CAST(0.000 AS Decimal(12, 3)), CAST(44.000 AS Decimal(12, 3)), 1, CAST(33.000 AS Decimal(12, 3)), CAST(N'2019-05-26T00:00:00' AS SmallDateTime), 2, CAST(N'2019-05-26T00:00:00' AS SmallDateTime), 2, 1)
INSERT [dbo].[INGREDIENTES] ([IdIngrediente], [NombreIngrediente], [Stockingrediente], [PrecioIngrediente], [UnidadMedida], [MasterPack], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1037, N'GARGARA', CAST(555.000 AS Decimal(12, 3)), CAST(555.000 AS Decimal(12, 3)), 1, CAST(555.000 AS Decimal(12, 3)), CAST(N'2019-06-16T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-16T00:00:00' AS SmallDateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[INGREDIENTES] OFF
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, 2, CAST(0.435 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, 3, CAST(0.200 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, 4, CAST(0.005 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, 5, CAST(0.010 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, 6, CAST(0.001 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[INGREDIETESPORCOMIDAS] ([IdComidas], [IdIngredientes], [Cantidad], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (2, 1, CAST(0.460 AS Decimal(12, 3)), CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, CAST(N'2018-03-03T00:00:00' AS SmallDateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[TIPOCOMIDA] ON 

INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (1, N'PIZZAS ESPECIALES', CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (2, N'EMPANADAS', CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (3, N'HAMBURGUESA', CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, CAST(N'2019-05-24T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (6, N'PIZZAS SUPER ESPECIALES', CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (8, N'COMBOS', CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (9, N'PROMOS', CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (10, N'MILANESAS', CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-17T00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[TIPOCOMIDA] ([IdTipoComida], [NombreTipoComida], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion], [Estado]) VALUES (11, N'PAPAS', CAST(N'2019-06-20T00:00:00' AS SmallDateTime), 1, CAST(N'2019-06-20T00:00:00' AS SmallDateTime), 1, 1)
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
/****** Object:  StoredProcedure [dbo].[AgregarComida]    Script Date: 21/6/2019 18:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarComida]
@NombreComida varchar (50),
@PrecioComida decimal(12,3),
@FechaCreacion smalldatetime, 
@UsuarioCreacion int,
@FechaModificacion smalldatetime, 
@UsuarioModificacion int, 
@Estado bit,
@TC int
as
insert into 
COMIDAS(NombreComida, PrecioComida, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Estado, TC) 
values (@NombreComida, @PrecioComida, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Estado, @TC)
GO
/****** Object:  StoredProcedure [dbo].[AgregarIngrediente]    Script Date: 21/6/2019 18:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarIngrediente]
@NombreIngrediente varchar (50),
@StockIngrediente decimal(12,3),
@UnidadMedida int,
@MasterPack decimal(12,3),
@PrecioIngrediente decimal(12,3),
@FechaCreacion smalldatetime, 
@UsuarioCreacion int,
@FechaModificacion smalldatetime, 
@UsuarioModificacion int, 
@Estado bit
as
insert into 
INGREDIENTES (NombreIngrediente, StockIngrediente, UnidadMedida, MasterPack, PrecioIngrediente, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Estado) 
values (@NombreIngrediente, @StockIngrediente, @UnidadMedida, @MasterPack, @PrecioIngrediente, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Estado)
GO
/****** Object:  StoredProcedure [dbo].[AgregarIngredientePorComida]    Script Date: 21/6/2019 18:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarIngredientePorComida]
@IdComidas int,
@IdIngredientes int,
@Cantidad decimal(12,3),
@FechaCreacion smalldatetime, 
@UsuarioCreacion int,
@FechaModificacion smalldatetime, 
@UsuarioModificacion int, 
@Estado bit
as
insert into 
INGREDIETESPORCOMIDAS(IdComidas, IdIngredientes,Cantidad, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Estado) 
values (@IdComidas, @IdIngredientes,@Cantidad, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Estado)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "i"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TC"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "us"
            Begin Extent = 
               Top = 6
               Left = 275
               Bottom = 136
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "us2"
            Begin Extent = 
               Top = 138
               Left = 275
               Bottom = 268
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCOMIDAS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DCOMIDAS'
GO
USE [master]
GO
ALTER DATABASE [ALFONSO_DB] SET  READ_WRITE 
GO