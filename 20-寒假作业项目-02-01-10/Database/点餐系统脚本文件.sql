USE [master]
GO
/****** Object:  Database [点餐系统]    Script Date: 2022-02-11 14:11:58 ******/
CREATE DATABASE [点餐系统]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'点餐系统', FILENAME = N'E:\S1\02-作业\03-SQL C#\02-C# 代码\20-寒假作业项目-02-01-10\Database\点餐系统.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 4096KB )
 LOG ON 
( NAME = N'点餐系统_log', FILENAME = N'E:\S1\02-作业\03-SQL C#\02-C# 代码\20-寒假作业项目-02-01-10\Database\点餐系统_log.ldf' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 4096KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [点餐系统] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [点餐系统].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [点餐系统] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [点餐系统] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [点餐系统] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [点餐系统] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [点餐系统] SET ARITHABORT OFF 
GO
ALTER DATABASE [点餐系统] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [点餐系统] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [点餐系统] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [点餐系统] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [点餐系统] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [点餐系统] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [点餐系统] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [点餐系统] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [点餐系统] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [点餐系统] SET  DISABLE_BROKER 
GO
ALTER DATABASE [点餐系统] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [点餐系统] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [点餐系统] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [点餐系统] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [点餐系统] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [点餐系统] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [点餐系统] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [点餐系统] SET RECOVERY FULL 
GO
ALTER DATABASE [点餐系统] SET  MULTI_USER 
GO
ALTER DATABASE [点餐系统] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [点餐系统] SET DB_CHAINING OFF 
GO
ALTER DATABASE [点餐系统] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [点餐系统] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [点餐系统] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [点餐系统] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'点餐系统', N'ON'
GO
ALTER DATABASE [点餐系统] SET QUERY_STORE = OFF
GO
USE [点餐系统]
GO
/****** Object:  Table [dbo].[Adm_07]    Script Date: 2022-02-11 14:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adm_07](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[AdmName] [varchar](50) NOT NULL,
	[AdmPwd] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Adm_07] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EverySingle02]    Script Date: 2022-02-11 14:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EverySingle02](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[Vegetables] [varchar](50) NOT NULL,
	[DishesType] [int] NOT NULL,
	[OriginalCost] [float] NULL,
	[Discount] [float] NULL,
	[Remark] [varchar](200) NULL,
 CONSTRAINT [PK_EverySingle02] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderList05]    Script Date: 2022-02-11 14:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderList05](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[OrderListNO] [int] NOT NULL,
 CONSTRAINT [PK_OrderList05] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderTable04]    Script Date: 2022-02-11 14:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTable04](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[TableNumber] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[Vegetables] [varchar](500) NOT NULL,
	[DealWith] [float] NOT NULL,
	[Payment] [float] NOT NULL,
	[Change] [float] NOT NULL,
	[Remark] [varchar](50) NULL,
 CONSTRAINT [PK_OrderTable04] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table01]    Script Date: 2022-02-11 14:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table01](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[TableNumber] [int] NOT NULL,
	[TableType] [varchar](2) NOT NULL,
	[Remark] [varchar](200) NULL,
 CONSTRAINT [PK_Table01] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_06]    Script Date: 2022-02-11 14:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_06](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserPwd] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User_06] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VegetableDishes03]    Script Date: 2022-02-11 14:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VegetableDishes03](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[DishesType] [varchar](50) NOT NULL,
	[Remark] [varchar](200) NULL,
 CONSTRAINT [PK_VegetableDishes03] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Adm_07] ON 

INSERT [dbo].[Adm_07] ([NO], [AdmName], [AdmPwd]) VALUES (1, N'xiao', N'123456')
SET IDENTITY_INSERT [dbo].[Adm_07] OFF
GO
SET IDENTITY_INSERT [dbo].[EverySingle02] ON 

INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (1, N'清炒白菜', 1, 10, 9, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (2, N'酱油白菜', 1, 9, 8, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (3, N'水煮白菜', 1, 5, 4, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (4, N'白菜', 1, 2, 1, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (5, N'韩国泡菜', 2, 10, 9, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (6, N'面酱黄瓜', 2, 10, 9, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (7, N'酱萝卜', 2, 12, 11, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (8, N'心太软', 2, 12, 12, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (9, N'拌丝瓜尖', 2, 12, 12, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (10, N'剁椒皮蛋', 2, 16, 16, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (11, N'泡椒木耳', 2, 16, 16, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (12, N'大丰收', 2, 16, 16, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (13, N'五香牛肉', 2, 38, 38, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (14, N'白切羊肉', 2, 58, 52.2, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (15, N'澳洲龙虾', 3, 128.9, 128.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (16, N'草虾', 3, 109.9, 109.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (17, N'对虾', 3, 129.9, 129.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (18, N'河虾', 3, 129.9, 129.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (19, N'桂鱼', 3, 29.9, 29.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (20, N'青蟹', 3, 29.9, 26.91, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (21, N'石斑', 3, 229.9, 229.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (22, N'大菱平', 3, 229.9, 229.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (23, N'大黄鱼', 3, 229.9, 229.9, N'时价')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (26, N'一品海皇羹', 4, 58, 58, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (27, N'西湖牛肉羹', 4, 28, 28, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (28, N'酸辣羹', 4, 22, 22, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (29, N'芥菜白玉羹', 4, 18, 18, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (30, N'三丝银鱼羹', 4, 38, 38, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (31, N'剁椒威蹄', 5, 68, 68, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (32, N'五福临门', 5, 68, 68, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (33, N'梅菜扣肉', 5, 58, 58, N'')
INSERT [dbo].[EverySingle02] ([NO], [Vegetables], [DishesType], [OriginalCost], [Discount], [Remark]) VALUES (34, N'五谷丰登', 5, 32, 32, N'')
SET IDENTITY_INSERT [dbo].[EverySingle02] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderList05] ON 

INSERT [dbo].[OrderList05] ([NO], [OrderListNO]) VALUES (1, 3)
SET IDENTITY_INSERT [dbo].[OrderList05] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderTable04] ON 

INSERT [dbo].[OrderTable04] ([NO], [TableNumber], [OrderNumber], [StartTime], [EndTime], [Vegetables], [DealWith], [Payment], [Change], [Remark]) VALUES (1, 30, 100, CAST(N'2022-02-08T10:03:04.000' AS DateTime), CAST(N'2022-02-08T10:03:30.000' AS DateTime), N'清炒白菜。酱萝卜。面酱黄瓜。大菱平。', 270.9, 300, 29.1, N'')
INSERT [dbo].[OrderTable04] ([NO], [TableNumber], [OrderNumber], [StartTime], [EndTime], [Vegetables], [DealWith], [Payment], [Change], [Remark]) VALUES (2, 1, 101, CAST(N'2022-02-10T14:05:28.000' AS DateTime), CAST(N'2022-02-10T14:05:49.000' AS DateTime), N'清炒白菜  五福临门  ', 77, 100, 23, N'')
INSERT [dbo].[OrderTable04] ([NO], [TableNumber], [OrderNumber], [StartTime], [EndTime], [Vegetables], [DealWith], [Payment], [Change], [Remark]) VALUES (3, 2, 102, CAST(N'2022-02-10T14:10:31.000' AS DateTime), CAST(N'2022-02-10T14:10:43.000' AS DateTime), N'清炒白菜  韩国泡菜  拌丝瓜尖  ', 42, 50, 8, N'')
INSERT [dbo].[OrderTable04] ([NO], [TableNumber], [OrderNumber], [StartTime], [EndTime], [Vegetables], [DealWith], [Payment], [Change], [Remark]) VALUES (4, 3, 103, CAST(N'2022-02-10T14:18:33.000' AS DateTime), CAST(N'2022-02-10T14:18:51.000' AS DateTime), N'清炒白菜  一品海皇羹  五福临门  ', 135, 150, 15, N'')
INSERT [dbo].[OrderTable04] ([NO], [TableNumber], [OrderNumber], [StartTime], [EndTime], [Vegetables], [DealWith], [Payment], [Change], [Remark]) VALUES (5, 2, 104, CAST(N'2022-02-10T14:40:35.000' AS DateTime), CAST(N'2022-02-10T14:40:50.000' AS DateTime), N'清炒白菜  酱萝卜  拌丝瓜尖  ', 40, 50, 10, N'')
INSERT [dbo].[OrderTable04] ([NO], [TableNumber], [OrderNumber], [StartTime], [EndTime], [Vegetables], [DealWith], [Payment], [Change], [Remark]) VALUES (6, 3, 105, CAST(N'2022-02-10T14:43:29.000' AS DateTime), CAST(N'2022-02-10T14:43:47.000' AS DateTime), N'清炒白菜  五香牛肉  五福临门  ', 131, 140, 9, N'')
INSERT [dbo].[OrderTable04] ([NO], [TableNumber], [OrderNumber], [StartTime], [EndTime], [Vegetables], [DealWith], [Payment], [Change], [Remark]) VALUES (7, 3, 3, CAST(N'2022-02-10T15:40:19.000' AS DateTime), CAST(N'2022-02-10T15:40:40.000' AS DateTime), N'酱油白菜  面酱黄瓜  ', 29, 30, 1, N'')
SET IDENTITY_INSERT [dbo].[OrderTable04] OFF
GO
SET IDENTITY_INSERT [dbo].[Table01] ON 

INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (1, 1, N'有', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (2, 2, N'有', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (3, 3, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (4, 4, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (5, 5, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (6, 6, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (7, 7, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (8, 8, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (9, 9, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (10, 10, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (11, 11, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (12, 12, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (13, 13, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (14, 14, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (15, 15, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (16, 16, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (17, 17, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (18, 18, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (19, 19, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (20, 20, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (21, 21, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (22, 22, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (23, 23, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (24, 24, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (25, 25, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (26, 26, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (27, 27, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (28, 28, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (29, 29, N'无', N'')
INSERT [dbo].[Table01] ([NO], [TableNumber], [TableType], [Remark]) VALUES (30, 30, N'无', N'')
SET IDENTITY_INSERT [dbo].[Table01] OFF
GO
SET IDENTITY_INSERT [dbo].[User_06] ON 

INSERT [dbo].[User_06] ([NO], [UserName], [UserPwd]) VALUES (1, N'ning', N'123456')
INSERT [dbo].[User_06] ([NO], [UserName], [UserPwd]) VALUES (2, N'asd', N'1234567')
SET IDENTITY_INSERT [dbo].[User_06] OFF
GO
SET IDENTITY_INSERT [dbo].[VegetableDishes03] ON 

INSERT [dbo].[VegetableDishes03] ([NO], [DishesType], [Remark]) VALUES (1, N'炒菜', N'')
INSERT [dbo].[VegetableDishes03] ([NO], [DishesType], [Remark]) VALUES (2, N'凉菜', N'')
INSERT [dbo].[VegetableDishes03] ([NO], [DishesType], [Remark]) VALUES (3, N'海鲜', N'')
INSERT [dbo].[VegetableDishes03] ([NO], [DishesType], [Remark]) VALUES (4, N'汤类', N'')
INSERT [dbo].[VegetableDishes03] ([NO], [DishesType], [Remark]) VALUES (5, N'清蒸', N'')
SET IDENTITY_INSERT [dbo].[VegetableDishes03] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'素菜' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EverySingle02', @level2type=N'COLUMN',@level2name=N'Vegetables'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'荤菜' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EverySingle02', @level2type=N'COLUMN',@level2name=N'OriginalCost'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EverySingle02', @level2type=N'COLUMN',@level2name=N'Discount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EverySingle02', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OrderTable04', @level2type=N'COLUMN',@level2name=N'OrderNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开始时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OrderTable04', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OrderTable04', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'素菜' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OrderTable04', @level2type=N'COLUMN',@level2name=N'Vegetables'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'桌号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Table01', @level2type=N'COLUMN',@level2name=N'TableNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Table01', @level2type=N'COLUMN',@level2name=N'Remark'
GO
USE [master]
GO
ALTER DATABASE [点餐系统] SET  READ_WRITE 
GO
