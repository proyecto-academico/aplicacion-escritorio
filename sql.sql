USE [master]
GO
/****** Object:  Database [proyecto_academico]    Script Date: 24/5/2023 20:19:17 ******/
CREATE DATABASE [proyecto_academico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyecto_academico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\proyecto_academico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyecto_academico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\proyecto_academico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [proyecto_academico] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyecto_academico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyecto_academico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyecto_academico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyecto_academico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyecto_academico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyecto_academico] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyecto_academico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyecto_academico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyecto_academico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyecto_academico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyecto_academico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyecto_academico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyecto_academico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyecto_academico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyecto_academico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyecto_academico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyecto_academico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyecto_academico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyecto_academico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyecto_academico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyecto_academico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyecto_academico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyecto_academico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyecto_academico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [proyecto_academico] SET  MULTI_USER 
GO
ALTER DATABASE [proyecto_academico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyecto_academico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyecto_academico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyecto_academico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyecto_academico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proyecto_academico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [proyecto_academico] SET QUERY_STORE = OFF
GO
USE [proyecto_academico]
GO
/****** Object:  Table [dbo].[administracion]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administracion](
	[DNI_Admin] [numeric](8, 0) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Contrasena] [varchar](50) NULL,
 CONSTRAINT [PK_administracion] PRIMARY KEY CLUSTERED 
(
	[DNI_Admin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[alumno]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumno](
	[DNI_Alumno] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Mail] [varchar](100) NULL,
	[Contrasena] [varchar](50) NULL,
 CONSTRAINT [PK_alumno] PRIMARY KEY CLUSTERED 
(
	[DNI_Alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clase]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clase](
	[Clase_ID] [int] NOT NULL,
	[Division_ID] [int] NOT NULL,
	[Materia_ID] [varchar](50) NOT NULL,
	[Profesor_ID] [varchar](50) NOT NULL,
	[Fecha_Comienzo] [date] NOT NULL,
	[Fecha_Final] [date] NULL,
 CONSTRAINT [PK_clase] PRIMARY KEY CLUSTERED 
(
	[Clase_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[division]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[division](
	[Division_ID] [int] NOT NULL,
	[Anio_Escolar] [int] NOT NULL,
	[Division_Escolar] [int] NOT NULL,
	[Turno] [varchar](50) NOT NULL,
 CONSTRAINT [PK_division] PRIMARY KEY CLUSTERED 
(
	[Division_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[division_de_alumnos]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[division_de_alumnos](
	[DivisionDA_ID] [int] NOT NULL,
	[DNI_Alumno] [int] NOT NULL,
	[Division_ID] [int] NOT NULL,
	[Anio_Calendario] [int] NOT NULL,
 CONSTRAINT [PK_division_de_alumnos] PRIMARY KEY CLUSTERED 
(
	[DivisionDA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[evaluaciones]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[evaluaciones](
	[Evaluacion_ID] [int] NOT NULL,
	[Clase_ID] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Detalles] [varchar](50) NOT NULL,
 CONSTRAINT [PK_evaluaciones] PRIMARY KEY CLUSTERED 
(
	[Evaluacion_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[faltas]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[faltas](
	[Falta_ID] [int] NOT NULL,
	[DNI_Alumno] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Tipo] [decimal](10, 1) NOT NULL,
	[jutificada] [tinyint] NOT NULL,
 CONSTRAINT [PK_faltas] PRIMARY KEY CLUSTERED 
(
	[Falta_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materia]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materia](
	[Materia_ID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Anio_escolar] [int] NOT NULL,
	[Horas_Semanales] [int] NOT NULL,
 CONSTRAINT [PK_materia] PRIMARY KEY CLUSTERED 
(
	[Materia_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notas]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notas](
	[Notas_ID] [int] NOT NULL,
	[Nota] [decimal](10, 2) NOT NULL,
	[DNI_Alumno] [int] NOT NULL,
	[Evaluacion_ID] [int] NOT NULL,
 CONSTRAINT [PK_notas] PRIMARY KEY CLUSTERED 
(
	[Notas_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesor]    Script Date: 24/5/2023 20:19:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesor](
	[DNI_Profesor] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Contrasena] [varchar](50) NULL,
 CONSTRAINT [PK_profesor] PRIMARY KEY CLUSTERED 
(
	[DNI_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [proyecto_academico] SET  READ_WRITE 
GO