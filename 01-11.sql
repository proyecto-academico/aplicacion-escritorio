USE [master]
GO
/****** Object:  Database [proyecto_academico]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[clase]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[division]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[division_de_alumnos]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[evaluaciones]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[faltas]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[materia]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[notas]    Script Date: 01/11/2023 21:38:27 ******/
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
/****** Object:  Table [dbo].[persona]    Script Date: 01/11/2023 21:38:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[DNI] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Contrasena] [varchar](50) NULL,
	[Nivel] [int] NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (1, 1, N'1', N'26911147', CAST(N'2023-03-22' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (2, 1, N'5', N'36073248', CAST(N'2023-03-22' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (3, 1, N'14', N'330617946', CAST(N'2023-03-15' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (4, 1, N'4', N'40321542', CAST(N'2023-03-16' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (5, 1, N'7', N'26911147', CAST(N'2023-03-22' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (6, 1, N'12', N'40321542', CAST(N'2023-03-30' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (7, 1, N'7', N'44879840', CAST(N'2023-03-29' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (8, 5, N'8', N'44879840', CAST(N'2023-04-03' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (9, 5, N'3', N'45843469', CAST(N'2023-03-06' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (10, 5, N'10', N'26911147', CAST(N'2023-03-13' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (11, 5, N'11', N'45843469', CAST(N'2023-03-08' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (12, 5, N'5', N'30617946', CAST(N'2023-03-15' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (13, 5, N'13', N'46570763', CAST(N'2023-03-17' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (14, 5, N'14', N'36073248', CAST(N'2023-03-21' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (15, 2, N'12', N'60824508', CAST(N'2023-03-06' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (16, 2, N'5', N'81669035', CAST(N'2023-03-12' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (17, 2, N'11', N'66671306', CAST(N'2023-03-10' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (18, 2, N'7', N'81233569', CAST(N'2023-03-08' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (19, 2, N'3', N'71589467', CAST(N'2023-03-14' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (20, 2, N'10', N'80910575', CAST(N'2023-03-03' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (21, 2, N'13', N'46570763', CAST(N'2023-03-15' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (22, 7, N'14', N'36073248', CAST(N'2023-03-06' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (23, 7, N'1', N'81669035', CAST(N'2023-03-09' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (24, 7, N'3', N'70477729', CAST(N'2023-03-02' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (25, 7, N'8', N'80910575', CAST(N'2023-03-14' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (26, 7, N'10', N'40321542', CAST(N'2023-03-06' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (27, 7, N'5', N'30617946', CAST(N'2023-03-08' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (28, 7, N'6', N'40321542', CAST(N'2023-03-09' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (29, 7, N'12', N'71589467', CAST(N'2023-03-13' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (30, 4, N'9', N'26911147', CAST(N'2023-03-14' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (31, 4, N'13', N'70477729', CAST(N'2023-03-03' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (32, 4, N'5', N'36073248', CAST(N'2023-03-14' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (33, 4, N'1', N'46570763', CAST(N'2023-03-07' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (34, 4, N'11', N'66671306', CAST(N'2023-03-16' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (35, 4, N'4', N'81233569', CAST(N'2023-03-08' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (36, 4, N'10', N'40321542', CAST(N'2023-03-15' AS Date), NULL)
INSERT [dbo].[clase] ([Clase_ID], [Division_ID], [Materia_ID], [Profesor_ID], [Fecha_Comienzo], [Fecha_Final]) VALUES (37, 5, N'30', N'60824508', CAST(N'2022-03-22' AS Date), CAST(N'2022-11-22' AS Date))
GO
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (1, 1, 1, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (2, 1, 2, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (3, 1, 3, N'noche')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (4, 1, 4, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (5, 2, 1, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (6, 2, 2, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (7, 2, 3, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (8, 2, 4, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (9, 3, 1, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (10, 3, 2, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (11, 3, 3, N'noche')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (12, 3, 4, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (13, 4, 1, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (14, 4, 2, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (15, 4, 3, N'noche')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (16, 4, 4, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (17, 5, 1, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (18, 5, 2, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (19, 5, 3, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (20, 5, 4, N'noche')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (21, 6, 1, N'tarde')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (22, 6, 2, N'maniana')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (23, 6, 3, N'noche')
INSERT [dbo].[division] ([Division_ID], [Anio_Escolar], [Division_Escolar], [Turno]) VALUES (24, 6, 4, N'maniana')
GO
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (1, 36595167, 1, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (2, 93752192, 1, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (3, 54070271, 5, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (4, 55719308, 5, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (5, 36595178, 1, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (6, 1176488, 1, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (7, 3868668, 2, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (8, 6046189, 3, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (9, 8306524, 4, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (10, 11763489, 2, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (11, 11794349, 2, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (12, 19198515, 2, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (13, 27066540, 3, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (14, 28787007, 3, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (15, 30728792, 3, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (16, 8837419, 5, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (17, 9972472, 6, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (18, 10710361, 7, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (19, 11763488, 8, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (20, 15253985, 9, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (21, 20982264, 10, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (22, 34768096, 4, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (23, 45396209, 4, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (24, 48192861, 4, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (25, 25032594, 11, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (26, 30318061, 12, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (27, 37418882, 13, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (28, 38703622, 14, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (29, 48397598, 15, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (30, 60136659, 16, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (31, 61923966, 17, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (32, 84217460, 18, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (33, 51886426, 5, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (34, 53796361, 6, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (35, 61561229, 6, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (36, 54616843, 6, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (37, 64419692, 7, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (38, 69058336, 7, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (39, 73789450, 7, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (40, 76103238, 8, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (41, 78721686, 8, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (42, 81222167, 8, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (43, 81853671, 9, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (44, 83852143, 9, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (45, 84649838, 19, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (46, 86684260, 20, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (47, 89354103, 21, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (48, 89374374, 22, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (49, 90211974, 23, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (50, 91245394, 24, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (51, 92767317, 1, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (52, 92789405, 2, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (53, 94260639, 3, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (54, 94452392, 4, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (55, 95820922, 5, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (56, 96747752, 6, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (57, 96779259, 7, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (58, 98181845, 8, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (59, 99652265, 9, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (60, 99899305, 10, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (61, 99999999, 11, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (62, 1176488, 5, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (63, 3868668, 6, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (64, 6046189, 7, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (65, 8306524, 8, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (66, 92767317, 5, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (67, 94260639, 6, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (68, 92789405, 7, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (69, 94452392, 8, 2023)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (70, 54070271, 1, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (71, 55719308, 2, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (72, 51886426, 3, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (73, 53796361, 4, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (74, 61561229, 1, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (75, 54616843, 2, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (76, 64419692, 3, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (77, 73789450, 4, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (78, 76103238, 1, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (79, 78721686, 2, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (80, 81222167, 3, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (81, 1176488, 4, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (82, 3868668, 1, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (83, 6046189, 2, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (84, 8306524, 3, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (85, 92767317, 4, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (86, 94260639, 1, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (87, 92789405, 2, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (88, 94452392, 3, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (89, 69058336, 4, 2022)
INSERT [dbo].[division_de_alumnos] ([DivisionDA_ID], [DNI_Alumno], [Division_ID], [Anio_Calendario]) VALUES (90, 81853671, 5, 2022)
GO
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (1, 4, CAST(N'2023-07-14' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (2, 6, CAST(N'2023-06-21' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (3, 1, CAST(N'2023-08-14' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (4, 2, CAST(N'2023-10-19' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (5, 3, CAST(N'2023-05-13' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (6, 4, CAST(N'2023-04-18' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (7, 5, CAST(N'2023-12-07' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (8, 6, CAST(N'2023-11-06' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (9, 7, CAST(N'2023-10-03' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (10, 8, CAST(N'2023-09-14' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (11, 9, CAST(N'2023-04-19' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (12, 10, CAST(N'2023-06-13' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (13, 11, CAST(N'2023-08-18' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (14, 12, CAST(N'2023-11-07' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (15, 13, CAST(N'2023-12-06' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (16, 14, CAST(N'2023-10-23' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (17, 1, CAST(N'2023-10-11' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (18, 2, CAST(N'2023-10-12' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (19, 3, CAST(N'2023-10-13' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (20, 4, CAST(N'2023-10-14' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (21, 5, CAST(N'2023-10-15' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (22, 6, CAST(N'2023-10-16' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (23, 7, CAST(N'2023-10-17' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (24, 8, CAST(N'2023-10-18' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (25, 9, CAST(N'2023-10-19' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (26, 10, CAST(N'2023-10-20' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (27, 11, CAST(N'2023-10-21' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (28, 12, CAST(N'2023-10-22' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (29, 13, CAST(N'2023-10-23' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (30, 14, CAST(N'2023-10-24' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (31, 15, CAST(N'2023-10-25' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (32, 16, CAST(N'2023-10-26' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (33, 17, CAST(N'2023-10-27' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (34, 18, CAST(N'2023-10-28' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (35, 19, CAST(N'2023-10-29' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (36, 20, CAST(N'2023-10-30' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (37, 21, CAST(N'2023-10-31' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (38, 22, CAST(N'2023-11-01' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (39, 23, CAST(N'2023-11-02' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (40, 24, CAST(N'2023-11-03' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (41, 25, CAST(N'2023-11-04' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (42, 26, CAST(N'2023-11-05' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (43, 27, CAST(N'2023-11-06' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (44, 28, CAST(N'2023-11-07' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (45, 29, CAST(N'2023-11-08' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (46, 30, CAST(N'2023-11-09' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (47, 31, CAST(N'2023-11-10' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (48, 32, CAST(N'2023-11-11' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (49, 33, CAST(N'2023-11-12' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (50, 34, CAST(N'2023-11-13' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (51, 35, CAST(N'2023-11-14' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (52, 36, CAST(N'2023-11-15' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (53, 1, CAST(N'2023-11-16' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (54, 2, CAST(N'2023-11-17' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (55, 3, CAST(N'2023-11-18' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (56, 4, CAST(N'2023-11-19' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (57, 5, CAST(N'2023-11-20' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (58, 6, CAST(N'2023-11-21' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (59, 7, CAST(N'2023-11-22' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (60, 8, CAST(N'2023-11-23' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (61, 9, CAST(N'2023-11-24' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (62, 10, CAST(N'2023-11-25' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (63, 11, CAST(N'2023-11-26' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (64, 12, CAST(N'2023-11-27' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (65, 13, CAST(N'2023-11-28' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (66, 14, CAST(N'2023-11-29' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (67, 15, CAST(N'2023-11-30' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (68, 16, CAST(N'2023-12-01' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (69, 17, CAST(N'2023-12-02' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (70, 18, CAST(N'2023-12-03' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (71, 19, CAST(N'2023-12-04' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (72, 20, CAST(N'2023-12-05' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (73, 21, CAST(N'2023-12-06' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (74, 22, CAST(N'2023-12-07' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (75, 23, CAST(N'2023-12-08' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (76, 24, CAST(N'2023-12-09' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (77, 25, CAST(N'2023-12-10' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (78, 26, CAST(N'2023-12-11' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (79, 27, CAST(N'2023-12-12' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (80, 28, CAST(N'2023-12-13' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (81, 29, CAST(N'2023-12-14' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (82, 30, CAST(N'2023-12-15' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (83, 31, CAST(N'2023-12-16' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (84, 32, CAST(N'2023-12-17' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (85, 33, CAST(N'2023-12-18' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (86, 34, CAST(N'2023-12-19' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (87, 35, CAST(N'2023-12-20' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (88, 36, CAST(N'2023-12-21' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (89, 1, CAST(N'2023-12-22' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (90, 2, CAST(N'2023-12-23' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (91, 3, CAST(N'2023-12-24' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (92, 4, CAST(N'2023-12-25' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (93, 5, CAST(N'2023-12-26' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (94, 6, CAST(N'2023-12-27' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (95, 7, CAST(N'2023-12-28' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (96, 8, CAST(N'2023-12-29' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (97, 9, CAST(N'2023-12-30' AS Date), N'multiplechoice')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (98, 10, CAST(N'2023-12-31' AS Date), N'examen oral')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (99, 11, CAST(N'2024-01-01' AS Date), N'examen escrito')
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (100, 12, CAST(N'2024-01-02' AS Date), N'multiplechoice')
GO
INSERT [dbo].[evaluaciones] ([Evaluacion_ID], [Clase_ID], [Fecha], [Detalles]) VALUES (101, 37, CAST(N'2022-04-22' AS Date), N'multiplechoice')
GO
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (1, 36595167, CAST(N'2023-05-19' AS Date), CAST(0.5 AS Decimal(10, 1)), 2)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (2, 54070271, CAST(N'2023-06-15' AS Date), CAST(1.0 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (3, 95820922, CAST(N'2023-07-02' AS Date), CAST(1.0 AS Decimal(10, 1)), 2)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (4, 94260639, CAST(N'2023-03-22' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (5, 89374374, CAST(N'2023-03-28' AS Date), CAST(1.0 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (6, 86684260, CAST(N'2023-08-18' AS Date), CAST(0.5 AS Decimal(10, 1)), 2)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (7, 81853671, CAST(N'2023-09-09' AS Date), CAST(1.0 AS Decimal(10, 1)), 2)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (8, 81222167, CAST(N'2023-10-09' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (9, 11794349, CAST(N'2023-10-05' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (10, 15253985, CAST(N'2023-10-06' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (11, 19198515, CAST(N'2023-10-07' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (12, 20982264, CAST(N'2023-10-08' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (13, 25032594, CAST(N'2023-10-09' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (14, 27066540, CAST(N'2023-10-10' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (15, 28787007, CAST(N'2023-10-11' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (16, 30318061, CAST(N'2023-10-12' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (17, 30728792, CAST(N'2023-10-13' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (18, 34768096, CAST(N'2023-10-14' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (19, 36595167, CAST(N'2023-10-15' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (20, 36595178, CAST(N'2023-10-16' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (21, 37418882, CAST(N'2023-10-17' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (22, 38703622, CAST(N'2023-10-18' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (23, 45396209, CAST(N'2023-10-19' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (24, 48192861, CAST(N'2023-10-20' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (25, 48397598, CAST(N'2023-10-21' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (26, 51886426, CAST(N'2023-10-22' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (27, 53796361, CAST(N'2023-10-23' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (28, 54070271, CAST(N'2023-10-24' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (29, 54616843, CAST(N'2023-10-25' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (30, 55719308, CAST(N'2023-10-26' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (31, 60136659, CAST(N'2023-10-27' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (32, 61561229, CAST(N'2023-10-28' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (33, 61923966, CAST(N'2023-10-29' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (34, 64419692, CAST(N'2023-10-30' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (35, 69058336, CAST(N'2023-10-31' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (36, 73789450, CAST(N'2023-11-01' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (37, 76103238, CAST(N'2023-11-02' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (38, 78721686, CAST(N'2023-11-03' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (39, 81222167, CAST(N'2023-11-04' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (40, 81853671, CAST(N'2023-11-05' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (41, 83852143, CAST(N'2023-11-06' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (42, 84217460, CAST(N'2023-11-07' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (43, 84649838, CAST(N'2023-11-08' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (44, 86684260, CAST(N'2023-11-09' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (45, 89354103, CAST(N'2023-11-10' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (46, 89374374, CAST(N'2023-11-11' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (47, 90211974, CAST(N'2023-11-12' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (48, 91245394, CAST(N'2023-11-13' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (49, 92767317, CAST(N'2023-11-14' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (50, 92789405, CAST(N'2023-11-15' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (51, 93752192, CAST(N'2023-11-16' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (52, 94260639, CAST(N'2023-11-17' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (53, 94452392, CAST(N'2023-11-18' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (54, 95820922, CAST(N'2023-11-19' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (55, 96747752, CAST(N'2023-11-20' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (56, 96779259, CAST(N'2023-11-21' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (57, 98181845, CAST(N'2023-11-22' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (58, 99652265, CAST(N'2023-11-23' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (59, 99899305, CAST(N'2023-11-24' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (60, 301465, CAST(N'2023-11-25' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (61, 3868669, CAST(N'2023-11-26' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (62, 6046190, CAST(N'2023-11-27' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (63, 8306525, CAST(N'2023-11-28' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (64, 8837420, CAST(N'2023-11-29' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (65, 9972473, CAST(N'2023-11-30' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (66, 10710362, CAST(N'2023-12-01' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (67, 11763490, CAST(N'2023-12-02' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (68, 11794350, CAST(N'2023-12-03' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (69, 15253986, CAST(N'2023-12-04' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (70, 19198516, CAST(N'2023-12-05' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (71, 20982265, CAST(N'2023-12-06' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (72, 25032595, CAST(N'2023-12-07' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (73, 27066541, CAST(N'2023-12-08' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (74, 28787008, CAST(N'2023-12-09' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (75, 30318062, CAST(N'2023-12-10' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (76, 30728793, CAST(N'2023-12-11' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (77, 34768097, CAST(N'2023-12-12' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (78, 36595168, CAST(N'2023-12-13' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (79, 36595179, CAST(N'2023-12-14' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (80, 37418883, CAST(N'2023-12-15' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (81, 38703623, CAST(N'2023-12-16' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (82, 45396210, CAST(N'2023-12-17' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (83, 48192862, CAST(N'2023-12-18' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (84, 48397599, CAST(N'2023-12-19' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (85, 51886427, CAST(N'2023-12-20' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (86, 53796362, CAST(N'2023-12-21' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (87, 54070272, CAST(N'2023-12-22' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (88, 54616844, CAST(N'2023-12-23' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (89, 55719309, CAST(N'2023-12-24' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (90, 60136660, CAST(N'2023-12-25' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (91, 61561230, CAST(N'2023-12-26' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (92, 61923967, CAST(N'2023-12-27' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (93, 64419693, CAST(N'2023-12-28' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (94, 69058337, CAST(N'2023-12-29' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (95, 73789451, CAST(N'2023-12-30' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (96, 76103239, CAST(N'2023-12-31' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (97, 78721687, CAST(N'2024-01-01' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (98, 81222168, CAST(N'2024-01-02' AS Date), CAST(0.5 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (99, 81853672, CAST(N'2024-01-03' AS Date), CAST(1.0 AS Decimal(10, 1)), 0)
INSERT [dbo].[faltas] ([Falta_ID], [DNI_Alumno], [Fecha], [Tipo], [jutificada]) VALUES (100, 83852144, CAST(N'2024-01-04' AS Date), CAST(0.5 AS Decimal(10, 1)), 1)
GO
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (1, N'matematica', 1, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (2, N'lengua y literatura', 1, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (3, N'biologia', 1, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (4, N'ingles', 1, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (5, N'educacion fisica', 1, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (6, N'educacion ciudadana', 1, 3)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (7, N'taller', 1, 3)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (8, N'biologia', 2, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (9, N'ingles', 2, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (10, N'matematicas', 2, 1)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (11, N'educacion fisica', 2, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (12, N'lengua y literatura', 2, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (13, N'taller', 2, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (14, N'educacion ciudadana', 2, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (15, N'matematica', 3, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (16, N'lengua y literatura', 3, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (17, N'quimica', 3, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (18, N'educacion fisica', 3, 1)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (19, N'ingles', 3, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (20, N'taller 1', 3, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (21, N'taller 2', 3, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (22, N'matematica', 4, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (23, N'literatura', 4, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (24, N'historia', 4, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (25, N'educacion fisica', 4, 1)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (26, N'ingles', 4, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (27, N'laboratorio algoritmos', 4, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (28, N'organizacion computadoras', 4, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (29, N'logica computacional', 4, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (30, N'matematica', 5, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (31, N'literatura', 5, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (32, N'historia', 5, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (33, N'educacion fisica', 5, 1)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (34, N'ingles', 5, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (35, N'redes', 5, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (36, N'adm. y gestion de datos', 5, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (37, N'analisis de sistemas', 5, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (38, N'matematica', 6, 4)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (39, N'ciencia y tecnologia', 6, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (40, N'ciudadania y trabajo', 6, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (41, N'educacion fisica', 6, 1)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (42, N'ingles', 6, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (43, N'adm. de sistemas y redes', 6, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (44, N'gestion de procesos prod.', 6, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (45, N'desarrollo de sistemas', 6, 2)
INSERT [dbo].[materia] ([Materia_ID], [Nombre], [Anio_escolar], [Horas_Semanales]) VALUES (46, N'programacion sobre redes', 6, 2)
GO
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (1, CAST(7.00 AS Decimal(10, 2)), 54070271, 1)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (2, CAST(4.00 AS Decimal(10, 2)), 55719308, 2)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (3, CAST(9.00 AS Decimal(10, 2)), 48192861, 3)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (4, CAST(6.00 AS Decimal(10, 2)), 48397598, 4)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (5, CAST(4.00 AS Decimal(10, 2)), 51886426, 5)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (6, CAST(2.00 AS Decimal(10, 2)), 53796361, 6)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (7, CAST(10.00 AS Decimal(10, 2)), 54616843, 7)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (8, CAST(1.00 AS Decimal(10, 2)), 60136659, 8)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (9, CAST(6.00 AS Decimal(10, 2)), 69058336, 9)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (10, CAST(1.00 AS Decimal(10, 2)), 301464, 10)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (11, CAST(2.00 AS Decimal(10, 2)), 301464, 11)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (12, CAST(3.00 AS Decimal(10, 2)), 1176488, 12)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (13, CAST(4.00 AS Decimal(10, 2)), 3868668, 13)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (14, CAST(5.00 AS Decimal(10, 2)), 6046189, 14)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (15, CAST(6.00 AS Decimal(10, 2)), 8306524, 15)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (16, CAST(7.00 AS Decimal(10, 2)), 8837419, 16)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (17, CAST(8.00 AS Decimal(10, 2)), 9972472, 17)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (18, CAST(9.00 AS Decimal(10, 2)), 10710361, 18)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (19, CAST(10.00 AS Decimal(10, 2)), 11763488, 19)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (20, CAST(1.00 AS Decimal(10, 2)), 11763489, 20)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (21, CAST(2.00 AS Decimal(10, 2)), 11794349, 21)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (22, CAST(3.00 AS Decimal(10, 2)), 12345678, 22)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (23, CAST(4.00 AS Decimal(10, 2)), 15253985, 23)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (24, CAST(5.00 AS Decimal(10, 2)), 19198515, 24)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (25, CAST(6.00 AS Decimal(10, 2)), 20982264, 25)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (26, CAST(7.00 AS Decimal(10, 2)), 25032594, 26)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (27, CAST(8.00 AS Decimal(10, 2)), 27066540, 27)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (28, CAST(9.00 AS Decimal(10, 2)), 28787007, 28)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (29, CAST(10.00 AS Decimal(10, 2)), 30318061, 29)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (30, CAST(1.00 AS Decimal(10, 2)), 30728792, 30)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (31, CAST(2.00 AS Decimal(10, 2)), 34768096, 31)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (32, CAST(3.00 AS Decimal(10, 2)), 36595167, 32)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (33, CAST(4.00 AS Decimal(10, 2)), 36595178, 33)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (34, CAST(5.00 AS Decimal(10, 2)), 37418882, 34)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (35, CAST(6.00 AS Decimal(10, 2)), 38703622, 35)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (36, CAST(7.00 AS Decimal(10, 2)), 45396209, 36)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (37, CAST(8.00 AS Decimal(10, 2)), 48192861, 37)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (38, CAST(9.00 AS Decimal(10, 2)), 48397598, 38)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (39, CAST(10.00 AS Decimal(10, 2)), 51886426, 39)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (40, CAST(1.00 AS Decimal(10, 2)), 53796361, 40)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (41, CAST(2.00 AS Decimal(10, 2)), 54070271, 41)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (42, CAST(3.00 AS Decimal(10, 2)), 54616843, 42)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (43, CAST(4.00 AS Decimal(10, 2)), 55719308, 43)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (44, CAST(5.00 AS Decimal(10, 2)), 60136659, 44)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (45, CAST(6.00 AS Decimal(10, 2)), 61561229, 45)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (46, CAST(7.00 AS Decimal(10, 2)), 61923966, 46)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (47, CAST(8.00 AS Decimal(10, 2)), 64419692, 47)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (48, CAST(9.00 AS Decimal(10, 2)), 69058336, 48)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (49, CAST(10.00 AS Decimal(10, 2)), 73789450, 49)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (50, CAST(1.00 AS Decimal(10, 2)), 76103238, 50)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (51, CAST(2.00 AS Decimal(10, 2)), 78721686, 51)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (52, CAST(3.00 AS Decimal(10, 2)), 81222167, 52)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (53, CAST(4.00 AS Decimal(10, 2)), 81853671, 53)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (54, CAST(5.00 AS Decimal(10, 2)), 83852143, 54)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (55, CAST(6.00 AS Decimal(10, 2)), 84217460, 55)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (56, CAST(7.00 AS Decimal(10, 2)), 84649838, 56)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (57, CAST(8.00 AS Decimal(10, 2)), 86684260, 57)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (58, CAST(9.00 AS Decimal(10, 2)), 89354103, 58)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (59, CAST(10.00 AS Decimal(10, 2)), 89374374, 59)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (60, CAST(1.00 AS Decimal(10, 2)), 90211974, 60)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (61, CAST(2.00 AS Decimal(10, 2)), 91245394, 61)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (62, CAST(3.00 AS Decimal(10, 2)), 92767317, 62)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (63, CAST(4.00 AS Decimal(10, 2)), 92789405, 63)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (64, CAST(5.00 AS Decimal(10, 2)), 93752192, 64)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (65, CAST(6.00 AS Decimal(10, 2)), 94260639, 65)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (66, CAST(7.00 AS Decimal(10, 2)), 94452392, 66)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (67, CAST(8.00 AS Decimal(10, 2)), 95820922, 67)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (68, CAST(9.00 AS Decimal(10, 2)), 96747752, 68)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (69, CAST(10.00 AS Decimal(10, 2)), 96779259, 69)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (70, CAST(1.00 AS Decimal(10, 2)), 98181845, 70)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (71, CAST(2.00 AS Decimal(10, 2)), 99652265, 71)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (72, CAST(3.00 AS Decimal(10, 2)), 99899305, 72)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (73, CAST(4.00 AS Decimal(10, 2)), 99999999, 73)
INSERT [dbo].[notas] ([Notas_ID], [Nota], [DNI_Alumno], [Evaluacion_ID]) VALUES (74, CAST(6.00 AS Decimal(10, 2)), 81853671, 101)
GO
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (0, N'123', N'123', N'@com', NULL, 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (1, N'12345', N'12345', N'@.com', NULL, 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (7, N'123', N'123', N'', NULL, 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (9, N'123', N'123', N'@', NULL, 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (301464, N'tomas', N'mari', N'tomasmari@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (1176488, N'felicita', N'aguirre', N'felicitaaguirre@gmail.com', NULL, 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (3868668, N'silvia', N'galan', N'silviagalan@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (6046189, N'jennifer ', N'prada', N'jenniferprada@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (8306524, N'kevin ', N'corral', N'kevincorral@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (8837419, N'nora', N'campo', N'noracampo@gmai.com', N'1234', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (9972472, N'nicoleta ', N'rosales', N'nicoletarosales@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (10710361, N'miquel ', N'murcia', N'miquelmurcia@gmail.com', N'1234', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (11763488, N'felicita', N'aguirre', N'felicitaaguirre@gmail.com', NULL, 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (11763489, N'felicita', N'aguirre', N'felicitaaguirre@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (11794349, N'yanira', N'aguilar', N'yaniraaguilar@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (12345678, N'1', N'1', N'@gmail.com', NULL, 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (15253985, N'eduard ', N' romera', N'eduardromera@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (19198515, N'Miguela', N'Felicidad Sancho', N'miguelaFelicidadSancho@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (20982264, N'carlos', N'garreno', N'carlosgarreno@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (25032594, N'gisela', N'soria', N'giselasoria@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (26888080, N'Estrella Rogelio', N'Pardo', N'estrellaRogelioPardo@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 1)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (26911147, N'nilo wilmar', N'simon', N'niloWilmarSimon@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (27066540, N'narciso', N'segui', N'narcisosegui@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (28787007, N'saray', N'collado', N'saraycollado@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (30318061, N'joan', N'valencia', N'joanvalencia@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (30617946, N'maria', N'cruz', N'mariaCruz66@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (30728792, N'Felisa', N'Rosalva Duarte', N'felisaRosalvaDuarte@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (32395268, N'reghr', N'dsjhsdh', N'@micaela.com', NULL, 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (34768096, N'isidora', N'lloret', N'isidoralloret@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (36073248, N'moreno', N'panfilo', N'morenoPanfilo22@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (36165581, N'Alejo Fabian', N'Nieto', N'alejoFabianNieto@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 1)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (36595167, N'eloy', N'rodriguez', N'eloyrodriguez@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (36595178, N'jose', N'martin', N'josemartin@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (37418882, N'aritz ', N'gisbert', N'artizgisbert@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (38703622, N'ines', N'aroca', N'inesaroca@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (40321542, N'cloe', N'ciro', N'cloeCiro54@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (44879840, N'ruben dario', N'olmo', N'rubenDarioOlmo@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (45396209, N'Cruz', N' Albina Clemente', N'cruzAlbinaClemente@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (45843469, N'nelson', N'carmen', N'nelsonCarmen66@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (46283697, N'Jose Angel Luis Angel', N'Quijada', N'joseAngelLuisAngelQuijada@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 1)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (46570763, N'rosendo ciro', N'arenas', N'rosendoCiroArenas@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (47181893, N'Osvaldo Filomena', N'Ruiz', N'osvaldoFilomenaRuiz@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 1)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (48192861, N'Javiera', N'Silvino Olmo', N'javieraSilvinoOlmo@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (48397598, N'imane ', N' vazquez', N'imanevazquez@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (51886426, N'Amado', N'Felipa Valencia', N'amadoFelipaValencia@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (53796361, N'Leopoldo', N'Mireya Francisco', N'leopoldoMireyaFrancisco@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (54070271, N'marina', N'jurado', N'marinajurado@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (54616843, N'laila', N'gilbert', N'lailagilbert@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (55719308, N'daniela', N'martorell', N'danielamartorell@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (60136659, N'erica ', N'ramirez', N'ericaramirez@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (60824508, N'emilio maximiano', N'del olmo', N'emilioMaximianoDelOlmo@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (61561229, N'Matias', N'Gaspar Esparza', N'matiasGasparEsparza@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (61923966, N'julian', N'lafuente', N'julianlafuente@gmail.com', N'1234', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (64419692, N'Geraldo', N'Ignacia Espinosa', N'geraldoIgnaciaEspinosa@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (66671306, N'jessica', N'patricia', N'jessicaPatricia22@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (67854464, N'felicita', N'aguirre', N'felicitaaguirre@gmail.com', NULL, 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (68626809, N'Aranzazu Encarnita', N'Araujo', N'aránzazuEncarnitaAraujo@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 1)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (69058336, N'moussa', N'nieto', N'moussanieto@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (70477729, N'mariana', N'abigail', N'marianaAbigail42@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (71589467, N'agapito benjamin', N'rivas', N'agapitoBenjaminRivas@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (73789450, N'Luis', N'Pio Casales', N'luisPioCasales@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (76103238, N'aquilino', N'ocaña', N'aquilinoocaña@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (78721686, N'june', N'alonso', N'junealonso@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (80910575, N'aureliano', N'norberto', N'aurelianoNorberto44@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (81222167, N'Victoriano', N' Melania Gonzales', N'victorianoMelaniaGonzales@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (81233569, N'azahara ', N'dionisia', N'azaharaDionisia@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (81669035, N'modesto', N'gertrudis', N'modestoGertrudis11@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 2)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (81853671, N'enrique', N'marquez', N'enriquemarquez@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (83852143, N'Marina', N'Filemon Chaves', N'marinaFilemonChaves@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (84217460, N'María Guadalupe', N'Inmaculada Aguado', N'mariaGuadalupeInmaculadaAguado@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (84649838, N'Urbana', N'Caridad Morales', N'urbanaCaridadMorales@gmal.com', N'1234', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (86684260, N'abril', N'mateu', N'abrilmateu@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (89354103, N'Bernardo', N'Jessenia Asturias', N'bernardoJesseniaAsturias@gmail.com', N'1234', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (89374374, N'montse ', N'mendoza', N'montsemendoza@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (90211974, N'claudia ', N'granado', N'claudiagranado@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (91245394, N'lorena', N'maldonado', N'lorenamaldonado@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (92767317, N'mariam', N'yuste', N'mariamyuste@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (92789405, N'valeria', N'nuñez', N'valerianuñez@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (93752192, N'felix', N'araujo', N'felixaraujo@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (94260639, N'Leyre', N'Anunciacion Otero', N'leyreAnunciacionOtero@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (94452392, NULL, NULL, NULL, N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (95820922, N'Xiomara', N'Rosalinda Castellano', N'xiomaraRosalindaCastellano@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (96747752, N'sabela', N'trigo', N'sabelatrigo@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (96779259, N'Saul', N'Feliciano Borja', N'saulFelicianoBorja@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (98181845, N'cecilia', N'ordoñez', N'ceciliaordoñez@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (99652265, N'Ainara', N'Fabricio Alonso', N'ainaraFabricioAlonso@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (99899305, N'Marcelino', N'Rayen Miranda', N'marcelinoRayenMiranda@gmail.com', N'*A4B6157319038724E3560894F7F932C8886EBFCF', 3)
INSERT [dbo].[persona] ([DNI], [Nombre], [Apellido], [Mail], [Contrasena], [Nivel]) VALUES (99999999, N'Ramon', N'Copernico', N'lokiju@gmail.com', NULL, 3)
GO
USE [master]
GO
ALTER DATABASE [proyecto_academico] SET  READ_WRITE 
GO
