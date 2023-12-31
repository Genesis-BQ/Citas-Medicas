USE [master]
GO
/****** Object:  Database [Proyec1]    Script Date: 21/09/2023 18:14:26 ******/
CREATE DATABASE [Proyec1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyec1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proyec1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyec1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proyec1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Proyec1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyec1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyec1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyec1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyec1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyec1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyec1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyec1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyec1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyec1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyec1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyec1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyec1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyec1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyec1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyec1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyec1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Proyec1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyec1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyec1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyec1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyec1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyec1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyec1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyec1] SET RECOVERY FULL 
GO
ALTER DATABASE [Proyec1] SET  MULTI_USER 
GO
ALTER DATABASE [Proyec1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyec1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyec1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyec1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyec1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proyec1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proyec1', N'ON'
GO
ALTER DATABASE [Proyec1] SET QUERY_STORE = OFF
GO
USE [Proyec1]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 21/09/2023 18:14:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[Cedula] [int] NOT NULL,
	[Establecimineto de Salud] [varchar](50) NOT NULL,
	[Servicio] [varchar](50) NOT NULL,
	[Especialidad] [varchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Hora] [time](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inicio]    Script Date: 21/09/2023 18:14:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inicio](
	[Cedula] [int] NOT NULL,
	[Ultima Conexion] [datetime] NOT NULL,
 CONSTRAINT [PK_Inicio] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 21/09/2023 18:14:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Cedula] [int] NOT NULL,
	[Contraseña] [varchar](12) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/09/2023 18:14:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Citas] ([Cedula], [Establecimineto de Salud], [Servicio], [Especialidad], [Fecha], [Hora]) VALUES (118190050, N'Ebais1', N'Medicina', N'MedicinaGeneral', CAST(N'2023-09-20' AS Date), CAST(N'08:00:00' AS Time))
INSERT [dbo].[Citas] ([Cedula], [Establecimineto de Salud], [Servicio], [Especialidad], [Fecha], [Hora]) VALUES (118190050, N'Ebais1', N'Medicina', N'Ortodolongia', CAST(N'2023-09-20' AS Date), CAST(N'08:30:00' AS Time))
GO
INSERT [dbo].[Inicio] ([Cedula], [Ultima Conexion]) VALUES (109050728, CAST(N'2023-09-19T21:03:34.047' AS DateTime))
INSERT [dbo].[Inicio] ([Cedula], [Ultima Conexion]) VALUES (118190050, CAST(N'2023-09-21T13:11:20.863' AS DateTime))
GO
INSERT [dbo].[Login] ([Cedula], [Contraseña]) VALUES (119030682, N'123')
INSERT [dbo].[Login] ([Cedula], [Contraseña]) VALUES (109050728, N'123')
INSERT [dbo].[Login] ([Cedula], [Contraseña]) VALUES (118190050, N'123')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido1], [Apellido2], [Telefono], [Email], [Contraseña]) VALUES (109050728, N'Jana Orit', N'Quirós', N'Bagnarello', N'89201824', N'jana@hotmail.com', N'123')
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido1], [Apellido2], [Telefono], [Email], [Contraseña]) VALUES (118190050, N'Genesis Dehora', N'Barahona', N'Quiros', N'88490797', N'devo@gmail.com', N'123')
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido1], [Apellido2], [Telefono], [Email], [Contraseña]) VALUES (119030682, N'Samuel', N'Barahona', N'Quirós', N'61450715', N'sb@gmail.com', N'123')
GO
/****** Object:  Trigger [dbo].[RegistroUsuario]    Script Date: 21/09/2023 18:14:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Génesis Barahona>
-- Create date: <17/sep/2023>
-- Description:	<Ingresar datos de login>
-- =============================================
CREATE TRIGGER [dbo].[RegistroUsuario]
   ON  [dbo].[Usuarios]
   AFTER INSERT
AS
BEGIN
    DECLARE @Cedula int
    DECLARE @Contraseña VARCHAR(25)

    SELECT @Cedula = Cedula, @Contraseña = Contraseña
    FROM inserted

    INSERT INTO Login(Cedula, Contraseña)
    VALUES (@Cedula, @Contraseña)

END
GO
ALTER TABLE [dbo].[Usuarios] ENABLE TRIGGER [RegistroUsuario]
GO
USE [master]
GO
ALTER DATABASE [Proyec1] SET  READ_WRITE 
GO
