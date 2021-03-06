USE [master]
GO
/****** Object:  Database [student]    Script Date: 2021-12-14 下午 01:56:22 ******/
CREATE DATABASE [student]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'student_mdf', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\09-作业-12-13\student\student_mdf.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 12288KB )
 LOG ON 
( NAME = N'student_log', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\09-作业-12-13\student\student_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 24576KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [student] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [student].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [student] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [student] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [student] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [student] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [student] SET ARITHABORT OFF 
GO
ALTER DATABASE [student] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [student] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [student] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [student] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [student] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [student] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [student] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [student] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [student] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [student] SET  DISABLE_BROKER 
GO
ALTER DATABASE [student] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [student] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [student] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [student] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [student] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [student] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [student] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [student] SET RECOVERY FULL 
GO
ALTER DATABASE [student] SET  MULTI_USER 
GO
ALTER DATABASE [student] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [student] SET DB_CHAINING OFF 
GO
ALTER DATABASE [student] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [student] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [student] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [student] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'student', N'ON'
GO
ALTER DATABASE [student] SET QUERY_STORE = OFF
GO
USE [student]
GO
/****** Object:  Table [dbo].[stuInfo]    Script Date: 2021-12-14 下午 01:56:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stuInfo](
	[stuNo] [varchar](10) NULL,
	[stuName] [varchar](10) NULL,
	[stuSex] [varchar](2) NULL,
	[stuAge] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[stuInfo] ([stuNo], [stuName], [stuSex], [stuAge]) VALUES (N'01', N'寜', N'男', 17)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'stuInfo', @level2type=N'COLUMN',@level2name=N'stuNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'stuInfo', @level2type=N'COLUMN',@level2name=N'stuName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别(男,女)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'stuInfo', @level2type=N'COLUMN',@level2name=N'stuSex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'年龄' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'stuInfo', @level2type=N'COLUMN',@level2name=N'stuAge'
GO
USE [master]
GO
ALTER DATABASE [student] SET  READ_WRITE 
GO
