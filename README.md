# DAEA-Practica4
Practica4 - C624 Mariam Dalia Apaza Santillana

# Video Demostracion
[![](https://i.ibb.co/zb07M6G/video.png)](https://www.hippovideo.io/video/play/71_Wc7LfxCIzsXb6q96V2R3yFPIXJoZHjyPYqvxVuwY?utm_source=hv-campaigns&hreferer=private&hvre=false&_=1638436325432&%20Watch%20Video)

# Modelo Entidad Relacion
![](https://i.ibb.co/TYKgB0p/database-model.png)

# Base de Datos (Script)
####Javascript　

```Script.sql
USE [master]
GO
/****** Object:  Database [practica4]    Script Date: 2/12/2021 03:57:17 ******/
CREATE DATABASE [practica4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'practica4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\practica4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'practica4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\practica4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [practica4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [practica4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [practica4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [practica4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [practica4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [practica4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [practica4] SET ARITHABORT OFF 
GO
ALTER DATABASE [practica4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [practica4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [practica4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [practica4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [practica4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [practica4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [practica4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [practica4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [practica4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [practica4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [practica4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [practica4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [practica4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [practica4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [practica4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [practica4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [practica4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [practica4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [practica4] SET  MULTI_USER 
GO
ALTER DATABASE [practica4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [practica4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [practica4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [practica4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [practica4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [practica4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [practica4] SET QUERY_STORE = OFF
GO
USE [practica4]
GO
/****** Object:  Table [dbo].[autor]    Script Date: 2/12/2021 03:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autor](
	[IdAutor] [int] NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Nacionalidad] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libro]    Script Date: 2/12/2021 03:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libro](
	[IdLibro] [int] NOT NULL,
	[IdAutor] [int] NULL,
	[Codigo] [int] NULL,
	[Titulo] [varchar](100) NULL,
	[ISBN] [varchar](30) NULL,
	[Editorial] [varchar](60) NULL,
	[NumPags] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prestamos]    Script Date: 2/12/2021 03:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prestamos](
	[IdPrestamo] [int] NOT NULL,
	[IdLibro] [int] NULL,
	[IdUsuario] [int] NULL,
	[FecPrestamo] [datetime] NULL,
	[FecDevolucion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 2/12/2021 03:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[IdUsuario] [int] NOT NULL,
	[NumUsuario] [int] NULL,
	[NIF] [varchar](20) NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](255) NULL,
	[Telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[autor] ([IdAutor], [Nombre], [Nacionalidad]) VALUES (1, N'Mario Vargas Llosa', N'Peruana')
INSERT [dbo].[autor] ([IdAutor], [Nombre], [Nacionalidad]) VALUES (2, N'Gabriel García Márquez', N'Colombiana')
INSERT [dbo].[autor] ([IdAutor], [Nombre], [Nacionalidad]) VALUES (3, N'Pablo Neruda', N'Chilena')
GO
INSERT [dbo].[libro] ([IdLibro], [IdAutor], [Codigo], [Titulo], [ISBN], [Editorial], [NumPags]) VALUES (1, 1, 100001, N'Conversación en La Catedral', N'9780060732806', N'Alfaguara', 736)
INSERT [dbo].[libro] ([IdLibro], [IdAutor], [Codigo], [Titulo], [ISBN], [Editorial], [NumPags]) VALUES (2, 1, 100002, N'PANTALEON Y LAS VISITADORAS', N'9788420432793', N'Alfaguara', 344)
INSERT [dbo].[libro] ([IdLibro], [IdAutor], [Codigo], [Titulo], [ISBN], [Editorial], [NumPags]) VALUES (3, 2, 1003, N'Cien años de soledad', N'9788497592208', N'DEBOLSILLO', 496)
INSERT [dbo].[libro] ([IdLibro], [IdAutor], [Codigo], [Titulo], [ISBN], [Editorial], [NumPags]) VALUES (4, 2, 1004, N'El amor en los tiempos del cólera', N'9788497592451', N'DEBOLSILLO', 496)
INSERT [dbo].[libro] ([IdLibro], [IdAutor], [Codigo], [Titulo], [ISBN], [Editorial], [NumPags]) VALUES (5, 3, 1005, N'Cien sonetos de amor', N'9788432237812', N'DEBOLSILLO', 144)
INSERT [dbo].[libro] ([IdLibro], [IdAutor], [Codigo], [Titulo], [ISBN], [Editorial], [NumPags]) VALUES (6, 3, 1006, N'Residencia en la tierra', N'9788437607078', N'DEBOLSILLO', 384)
GO
INSERT [dbo].[prestamos] ([IdPrestamo], [IdLibro], [IdUsuario], [FecPrestamo], [FecDevolucion]) VALUES (1466, 4, 1, CAST(N'2021-12-02T00:00:00.000' AS DateTime), CAST(N'2021-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[prestamos] ([IdPrestamo], [IdLibro], [IdUsuario], [FecPrestamo], [FecDevolucion]) VALUES (1502, 1, 1, CAST(N'2021-12-02T00:00:00.000' AS DateTime), CAST(N'2022-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[prestamos] ([IdPrestamo], [IdLibro], [IdUsuario], [FecPrestamo], [FecDevolucion]) VALUES (1605, 1, 1, CAST(N'2021-12-02T00:00:00.000' AS DateTime), CAST(N'2021-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[prestamos] ([IdPrestamo], [IdLibro], [IdUsuario], [FecPrestamo], [FecDevolucion]) VALUES (1910, 3, 1, CAST(N'2021-12-02T00:00:00.000' AS DateTime), CAST(N'2021-12-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[usuario] ([IdUsuario], [NumUsuario], [NIF], [Nombre], [Direccion], [Telefono]) VALUES (1, 1001, N'25458956', N'Mariam Apaza', N'Av Peru 215', N'948526102')
GO
ALTER TABLE [dbo].[libro]  WITH CHECK ADD  CONSTRAINT [fk_autor] FOREIGN KEY([IdAutor])
REFERENCES [dbo].[autor] ([IdAutor])
GO
ALTER TABLE [dbo].[libro] CHECK CONSTRAINT [fk_autor]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [fk_libro] FOREIGN KEY([IdLibro])
REFERENCES [dbo].[libro] ([IdLibro])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [fk_libro]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [fk_usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [fk_usuario]
GO
USE [master]
GO
ALTER DATABASE [practica4] SET  READ_WRITE 
GO


```
