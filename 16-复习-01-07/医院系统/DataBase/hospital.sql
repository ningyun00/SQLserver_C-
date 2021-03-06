USE [master]
GO
/****** Object:  Database [hospital]    Script Date: 2022-01-09 01:34:08 ******/
CREATE DATABASE [hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hospital', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\16-复习-01-07\医院系统\DataBase\hospital.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 4096KB )
 LOG ON 
( NAME = N'hospital_log', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\16-复习-01-07\医院系统\DataBase\hospital_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 4096KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [hospital] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [hospital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hospital] SET RECOVERY FULL 
GO
ALTER DATABASE [hospital] SET  MULTI_USER 
GO
ALTER DATABASE [hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [hospital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [hospital] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'hospital', N'ON'
GO
ALTER DATABASE [hospital] SET QUERY_STORE = OFF
GO
USE [hospital]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 2022-01-09 01:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctorID] [int] IDENTITY(1,1) NOT NULL,
	[doctorName] [varchar](50) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 2022-01-09 01:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[pID] [int] IDENTITY(1,1) NOT NULL,
	[pName] [varchar](50) NULL,
	[pAge] [varchar](50) NULL,
	[pSex] [varchar](50) NULL,
	[pExplain] [varchar](50) NULL,
	[doctorID] [int] NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[pID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([doctorID], [doctorName]) VALUES (1, N'张三')
INSERT [dbo].[Doctor] ([doctorID], [doctorName]) VALUES (2, N'李四')
INSERT [dbo].[Doctor] ([doctorID], [doctorName]) VALUES (3, N'王五')
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([pID], [pName], [pAge], [pSex], [pExplain], [doctorID]) VALUES (10, N'小徐', N'13', N'女', N'无', 1)
INSERT [dbo].[patient] ([pID], [pName], [pAge], [pSex], [pExplain], [doctorID]) VALUES (11, N'寜', N'16', N'女', N'无', 1)
INSERT [dbo].[patient] ([pID], [pName], [pAge], [pSex], [pExplain], [doctorID]) VALUES (12, N'小白', N'19', N'女', N'无', 1)
INSERT [dbo].[patient] ([pID], [pName], [pAge], [pSex], [pExplain], [doctorID]) VALUES (13, N'大白', N'13', N'女', N'无', 1)
SET IDENTITY_INSERT [dbo].[patient] OFF
GO
USE [master]
GO
ALTER DATABASE [hospital] SET  READ_WRITE 
GO
