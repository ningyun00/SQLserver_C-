USE [master]
GO
/****** Object:  Database [StudentManager]    Script Date: 2021-12-14 下午 01:57:24 ******/
CREATE DATABASE [StudentManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentManager', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\09-作业-12-13\student\StudentManager.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StudentManager_log', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\09-作业-12-13\student\StudentManager_log.ldf' , SIZE = 4224KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudentManager] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentManager].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [StudentManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentManager] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentManager] SET  MULTI_USER 
GO
ALTER DATABASE [StudentManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [StudentManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentManager', N'ON'
GO
ALTER DATABASE [StudentManager] SET QUERY_STORE = OFF
GO
USE [StudentManager]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2021-12-14 下午 01:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[height] [float] NULL,
	[sex] [varchar](2) NULL,
	[tream] [varchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (1, N'寜', 1.89, N'女', N's1')
INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (3, N'小草', 1.59, N'女', N's1')
INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (5, N'张妈', 1.6, N'女', N's2')
INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (6, N'赵哥', 1.71, N'男', N's2')
INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (7, N'小小', 1.88, N'男', N's1')
INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (8, N'张三丰', 1.57, N'男', N's2')
INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (9, N'张小三', 1.66, N'女', N's2')
INSERT [dbo].[Student] ([id], [name], [height], [sex], [tream]) VALUES (10, N'赵紫阳', 1.73, N'男', N's1')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
USE [master]
GO
ALTER DATABASE [StudentManager] SET  READ_WRITE 
GO
