USE [master]
GO
/****** Object:  Database [Employee]    Script Date: 2022-01-19 11:12:51 ******/
CREATE DATABASE [Employee]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Employee', FILENAME = N'E:\S1\02-作业\03-SQL C#\02-C# 代码\19-S1学考试-01-19\DataBase\Employee.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 4096KB )
 LOG ON 
( NAME = N'Employee_log', FILENAME = N'E:\S1\02-作业\03-SQL C#\02-C# 代码\19-S1学考试-01-19\DataBase\Employee_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 4096KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Employee] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Employee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Employee] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Employee] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Employee] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Employee] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Employee] SET ARITHABORT OFF 
GO
ALTER DATABASE [Employee] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Employee] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Employee] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Employee] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Employee] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Employee] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Employee] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Employee] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Employee] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Employee] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Employee] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Employee] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Employee] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Employee] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Employee] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Employee] SET RECOVERY FULL 
GO
ALTER DATABASE [Employee] SET  MULTI_USER 
GO
ALTER DATABASE [Employee] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Employee] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Employee] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Employee] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Employee] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Employee] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Employee', N'ON'
GO
ALTER DATABASE [Employee] SET QUERY_STORE = OFF
GO
USE [Employee]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2022-01-19 11:12:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
	[JoinDate] [datetime] NOT NULL,
	[RostRankid] [int] NOT NULL,
	[BirthDay] [datetime] NOT NULL,
	[NativePlace] [nvarchar](200) NULL,
	[Sex] [nvarchar](2) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostRank]    Script Date: 2022-01-19 11:12:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostRank](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PostRankName] [nvarchar](20) NULL,
 CONSTRAINT [PK_PostRank] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([id], [EmployeeName], [Position], [JoinDate], [RostRankid], [BirthDay], [NativePlace], [Sex]) VALUES (1, N'寜', N'不知道', CAST(N'2022-01-19T00:00:00.000' AS DateTime), 2, CAST(N'2004-01-30T00:00:00.000' AS DateTime), N'中国', N'男')
INSERT [dbo].[Employees] ([id], [EmployeeName], [Position], [JoinDate], [RostRankid], [BirthDay], [NativePlace], [Sex]) VALUES (2, N'撒娇', N'不顺德', CAST(N'2021-01-19T00:00:00.000' AS DateTime), 3, CAST(N'2003-01-30T00:00:00.000' AS DateTime), N'中国', N'女')
INSERT [dbo].[Employees] ([id], [EmployeeName], [Position], [JoinDate], [RostRankid], [BirthDay], [NativePlace], [Sex]) VALUES (3, N'埃美柯', N'不啊', CAST(N'2020-01-19T00:00:00.000' AS DateTime), 1, CAST(N'2002-01-30T00:00:00.000' AS DateTime), N'中国', N'男')
INSERT [dbo].[Employees] ([id], [EmployeeName], [Position], [JoinDate], [RostRankid], [BirthDay], [NativePlace], [Sex]) VALUES (4, N'柯', N'啊', CAST(N'2019-01-19T00:00:00.000' AS DateTime), 1, CAST(N'2002-01-30T00:00:00.000' AS DateTime), N'中国', N'男')
INSERT [dbo].[Employees] ([id], [EmployeeName], [Position], [JoinDate], [RostRankid], [BirthDay], [NativePlace], [Sex]) VALUES (5, N'安定', N'阿斯顿', CAST(N'2004-06-24T00:00:00.000' AS DateTime), 5, CAST(N'2022-01-19T11:04:31.000' AS DateTime), N'阿萨', N'女')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[PostRank] ON 

INSERT [dbo].[PostRank] ([id], [PostRankName]) VALUES (1, N'一级岗')
INSERT [dbo].[PostRank] ([id], [PostRankName]) VALUES (2, N'二级岗')
INSERT [dbo].[PostRank] ([id], [PostRankName]) VALUES (3, N'三级岗')
INSERT [dbo].[PostRank] ([id], [PostRankName]) VALUES (4, N'四级岗')
INSERT [dbo].[PostRank] ([id], [PostRankName]) VALUES (5, N'五级岗')
INSERT [dbo].[PostRank] ([id], [PostRankName]) VALUES (6, N'六级岗')
SET IDENTITY_INSERT [dbo].[PostRank] OFF
GO
USE [master]
GO
ALTER DATABASE [Employee] SET  READ_WRITE 
GO
