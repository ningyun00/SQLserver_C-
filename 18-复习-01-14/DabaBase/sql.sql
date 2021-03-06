USE [master]
GO
/****** Object:  Database [BookManagement]    Script Date: 2022-01-18 16:04:43 ******/
CREATE DATABASE [BookManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookManagement', FILENAME = N'E:\S1\02-作业\03-SQL C#\02-C# 代码\18-复习-01-14\DabaBase\BookManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 4096KB )
 LOG ON 
( NAME = N'BookManagement_log', FILENAME = N'E:\S1\02-作业\03-SQL C#\02-C# 代码\18-复习-01-14\DabaBase\BookManagement_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 4096KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [BookManagement] SET  MULTI_USER 
GO
ALTER DATABASE [BookManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BookManagement', N'ON'
GO
ALTER DATABASE [BookManagement] SET QUERY_STORE = OFF
GO
USE [BookManagement]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2022-01-18 16:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Author] [nvarchar](200) NOT NULL,
	[PublishDate] [datetime] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Categoryid] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2022-01-18 16:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 2022-01-18 16:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DeId] [int] IDENTITY(1,1) NOT NULL,
	[DeName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffInfo]    Script Date: 2022-01-18 16:04:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffInfo](
	[StId] [int] IDENTITY(1,1) NOT NULL,
	[StNumber] [int] NOT NULL,
	[StName] [varchar](50) NOT NULL,
	[StSex] [char](2) NOT NULL,
	[DeId] [int] NOT NULL,
	[StTel] [varchar](50) NOT NULL,
	[StIdentityCard] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StaffInfo] PRIMARY KEY CLUSTERED 
(
	[StId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([id], [Title], [Author], [PublishDate], [UnitPrice], [Categoryid]) VALUES (1, N'精通C#编程', N'JACK jones&Boke', CAST(N'2011-10-01T00:00:00.000' AS DateTime), 109.0000, 1)
INSERT [dbo].[Books] ([id], [Title], [Author], [PublishDate], [UnitPrice], [Categoryid]) VALUES (2, N'C#高级编程', N'Louis Kobe', CAST(N'2010-09-10T00:00:00.000' AS DateTime), 32.0000, 1)
INSERT [dbo].[Books] ([id], [Title], [Author], [PublishDate], [UnitPrice], [Categoryid]) VALUES (3, N'Java开发案例', N'JAmes Gosling', CAST(N'2013-07-17T00:00:00.000' AS DateTime), 45.0000, 2)
INSERT [dbo].[Books] ([id], [Title], [Author], [PublishDate], [UnitPrice], [Categoryid]) VALUES (4, N'HTML标准', N'赵译', CAST(N'2011-10-04T00:00:00.000' AS DateTime), 56.0000, 3)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([id], [CategoryName]) VALUES (1, N'C#')
INSERT [dbo].[Categories] ([id], [CategoryName]) VALUES (2, N'JAVA')
INSERT [dbo].[Categories] ([id], [CategoryName]) VALUES (3, N'HTML')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DeId], [DeName]) VALUES (1, N'销售部')
INSERT [dbo].[Department] ([DeId], [DeName]) VALUES (2, N'财务部')
INSERT [dbo].[Department] ([DeId], [DeName]) VALUES (3, N'技术部')
INSERT [dbo].[Department] ([DeId], [DeName]) VALUES (4, N'人才部')
INSERT [dbo].[Department] ([DeId], [DeName]) VALUES (5, N'脑残部')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[StaffInfo] ON 

INSERT [dbo].[StaffInfo] ([StId], [StNumber], [StName], [StSex], [DeId], [StTel], [StIdentityCard]) VALUES (1, 256, N'王芳', N'女', 2, N'123456789', N'1234567898')
INSERT [dbo].[StaffInfo] ([StId], [StNumber], [StName], [StSex], [DeId], [StTel], [StIdentityCard]) VALUES (2, 276, N'咋哈是', N'男', 1, N'123456789', N'1234567898')
INSERT [dbo].[StaffInfo] ([StId], [StNumber], [StName], [StSex], [DeId], [StTel], [StIdentityCard]) VALUES (3, 286, N'三大芳', N'女', 2, N'123456789', N'1234567898')
INSERT [dbo].[StaffInfo] ([StId], [StNumber], [StName], [StSex], [DeId], [StTel], [StIdentityCard]) VALUES (4, 296, N'撒地方', N'男', 1, N'123456789', N'1234567898')
INSERT [dbo].[StaffInfo] ([StId], [StNumber], [StName], [StSex], [DeId], [StTel], [StIdentityCard]) VALUES (5, 306, N'按市场', N'男', 3, N'123456789', N'1234567898')
INSERT [dbo].[StaffInfo] ([StId], [StNumber], [StName], [StSex], [DeId], [StTel], [StIdentityCard]) VALUES (9, 310, N'撒阿文', N'女', 5, N'123456789', N'1234567898')
SET IDENTITY_INSERT [dbo].[StaffInfo] OFF
GO
USE [master]
GO
ALTER DATABASE [BookManagement] SET  READ_WRITE 
GO
