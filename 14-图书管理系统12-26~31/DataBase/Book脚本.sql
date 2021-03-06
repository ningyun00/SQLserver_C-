USE [master]
GO
/****** Object:  Database [Book]    Script Date: 2021-12-29 下午 09:31:16 ******/
CREATE DATABASE [Book]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Book', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\14-图书管理系统12-26~31\DataBase\Book.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 4096KB )
 LOG ON 
( NAME = N'Book_log', FILENAME = N'E:\02-作业\03-SQL C#\02-C# 代码\14-图书管理系统12-26~31\DataBase\Book_log.ldf' , SIZE = 5120KB , MAXSIZE = 2048GB , FILEGROWTH = 4096KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Book] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Book].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Book] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Book] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Book] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Book] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Book] SET ARITHABORT OFF 
GO
ALTER DATABASE [Book] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Book] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Book] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Book] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Book] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Book] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Book] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Book] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Book] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Book] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Book] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Book] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Book] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Book] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Book] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Book] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Book] SET RECOVERY FULL 
GO
ALTER DATABASE [Book] SET  MULTI_USER 
GO
ALTER DATABASE [Book] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Book] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Book] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Book] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Book] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Book] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Book', N'ON'
GO
ALTER DATABASE [Book] SET QUERY_STORE = OFF
GO
USE [Book]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 2021-12-29 下午 09:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[AID] [int] IDENTITY(1,1) NOT NULL,
	[Aname] [varchar](50) NULL,
	[Apwd] [varchar](50) NULL,
	[Akeys] [varchar](12) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[AID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookManage]    Script Date: 2021-12-29 下午 09:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookManage](
	[Bid] [int] IDENTITY(1,1) NOT NULL,
	[Bname] [varchar](50) NULL,
	[Bauthor] [varchar](50) NULL,
	[Bpress] [varchar](50) NULL,
	[BtypeID] [int] NOT NULL,
	[Binventory] [int] NOT NULL,
 CONSTRAINT [PK_BookManage] PRIMARY KEY CLUSTERED 
(
	[Bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BooksBorrow]    Script Date: 2021-12-29 下午 09:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BooksBorrow](
	[Bid] [int] IDENTITY(1,1) NOT NULL,
	[BbookName] [varchar](50) NULL,
	[Bname] [varchar](50) NULL,
	[Bsex] [varchar](4) NULL,
	[Bage] [int] NULL,
	[Bphone] [int] NULL,
	[Baddress] [varchar](100) NULL,
	[Btime] [varchar](50) NOT NULL,
	[BreturnTime] [varchar](50) NULL,
	[Bremarks] [varchar](500) NULL,
 CONSTRAINT [PK_BooksBorrow] PRIMARY KEY CLUSTERED 
(
	[Bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 2021-12-29 下午 09:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[Cid] [int] IDENTITY(1,1) NOT NULL,
	[BtypeID] [int] NOT NULL,
	[Ctype] [varchar](50) NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[Cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MyBookrack]    Script Date: 2021-12-29 下午 09:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyBookrack](
	[Mid] [int] IDENTITY(1,1) NOT NULL,
	[Mname] [varchar](50) NULL,
	[Mauthor] [varchar](50) NULL,
 CONSTRAINT [PK_MyBookrack] PRIMARY KEY CLUSTERED 
(
	[Mid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MyBookshelfKeeper]    Script Date: 2021-12-29 下午 09:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyBookshelfKeeper](
	[GID] [int] IDENTITY(1,1) NOT NULL,
	[Gname] [varchar](50) NULL,
	[Gauthor] [varchar](50) NULL,
 CONSTRAINT [PK_MyBookshelfKeeper] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2021-12-29 下午 09:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[Uname] [varchar](50) NULL,
	[Upwd] [varchar](50) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([AID], [Aname], [Apwd], [Akeys]) VALUES (1, N'ning', N'1111', N'AAAAAAAAAAAA')
INSERT [dbo].[Administrator] ([AID], [Aname], [Apwd], [Akeys]) VALUES (2, N'yun', N'111111', N'QWERTYUIOPAS')
INSERT [dbo].[Administrator] ([AID], [Aname], [Apwd], [Akeys]) VALUES (3, N'ying', N'1111', N'AAAAAAAAAAAA')
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[BookManage] ON 

INSERT [dbo].[BookManage] ([Bid], [Bname], [Bauthor], [Bpress], [BtypeID], [Binventory]) VALUES (1, N'幻灵梦寜', N'寜', N'起点', 1, 10)
INSERT [dbo].[BookManage] ([Bid], [Bname], [Bauthor], [Bpress], [BtypeID], [Binventory]) VALUES (2, N'一梦天下', N'寜', N'起点', 1, 11)
INSERT [dbo].[BookManage] ([Bid], [Bname], [Bauthor], [Bpress], [BtypeID], [Binventory]) VALUES (3, N'小熊', N'寜', N'起点', 1, 1)
INSERT [dbo].[BookManage] ([Bid], [Bname], [Bauthor], [Bpress], [BtypeID], [Binventory]) VALUES (4, N'小七', N'寜', N'起点', 5, 1)
INSERT [dbo].[BookManage] ([Bid], [Bname], [Bauthor], [Bpress], [BtypeID], [Binventory]) VALUES (7, N'辟邪剑谱', N'金老', N'宏兴', 1, 1)
SET IDENTITY_INSERT [dbo].[BookManage] OFF
GO
SET IDENTITY_INSERT [dbo].[BooksBorrow] ON 

INSERT [dbo].[BooksBorrow] ([Bid], [BbookName], [Bname], [Bsex], [Bage], [Bphone], [Baddress], [Btime], [BreturnTime], [Bremarks]) VALUES (1, N'幻灵梦寜', N'寜', N'女', 15, 110119120, N'银河系，太阳系，地月系，地球，亚洲，中国，湖南，长沙', N'12 27 2021 12:47AM', N'2021-12-27 上午 11:51:34', N'图书已归还')
INSERT [dbo].[BooksBorrow] ([Bid], [BbookName], [Bname], [Bsex], [Bage], [Bphone], [Baddress], [Btime], [BreturnTime], [Bremarks]) VALUES (3, N'三国演义', N'寜', N'女', 12, 110119120, N'不知道', N'2021-12-27 上午 10:06:05', N'2021-12-27 上午 11:34:42', N'图书已归还')
INSERT [dbo].[BooksBorrow] ([Bid], [BbookName], [Bname], [Bsex], [Bage], [Bphone], [Baddress], [Btime], [BreturnTime], [Bremarks]) VALUES (4, N'三国演义', N'云', N'女', 11, 123456, N'阿斯蒂芬干哈', N'2021-12-27 上午 10:08:27', N'2021-12-27 上午 11:32:55', N'图书已归还')
INSERT [dbo].[BooksBorrow] ([Bid], [BbookName], [Bname], [Bsex], [Bage], [Bphone], [Baddress], [Btime], [BreturnTime], [Bremarks]) VALUES (5, N'大王饶命', N'寜', N'女', 18, 123456, N'未知', N'2021-12-27 上午 10:15:57', N'2021-12-27 上午 11:51:34', N'图书已归还')
SET IDENTITY_INSERT [dbo].[BooksBorrow] OFF
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([Cid], [BtypeID], [Ctype]) VALUES (1, 1, N'玄幻类')
INSERT [dbo].[Class] ([Cid], [BtypeID], [Ctype]) VALUES (2, 2, N'学习类')
INSERT [dbo].[Class] ([Cid], [BtypeID], [Ctype]) VALUES (3, 3, N'烹饪类')
INSERT [dbo].[Class] ([Cid], [BtypeID], [Ctype]) VALUES (4, 4, N'科幻类')
INSERT [dbo].[Class] ([Cid], [BtypeID], [Ctype]) VALUES (5, 5, N'热血类')
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[MyBookrack] ON 

INSERT [dbo].[MyBookrack] ([Mid], [Mname], [Mauthor]) VALUES (2, N'小七', N'寜')
INSERT [dbo].[MyBookrack] ([Mid], [Mname], [Mauthor]) VALUES (3, N'幻灵梦寜', N'寜')
INSERT [dbo].[MyBookrack] ([Mid], [Mname], [Mauthor]) VALUES (4, N'幻灵梦寜', N'寜')
SET IDENTITY_INSERT [dbo].[MyBookrack] OFF
GO
SET IDENTITY_INSERT [dbo].[MyBookshelfKeeper] ON 

INSERT [dbo].[MyBookshelfKeeper] ([GID], [Gname], [Gauthor]) VALUES (14, N'幻灵梦寜', N'寜')
INSERT [dbo].[MyBookshelfKeeper] ([GID], [Gname], [Gauthor]) VALUES (15, N'小七', N'寜')
SET IDENTITY_INSERT [dbo].[MyBookshelfKeeper] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UID], [Uname], [Upwd]) VALUES (1, N'ning', N'1111')
INSERT [dbo].[User] ([UID], [Uname], [Upwd]) VALUES (2, N'ying', N'111111')
INSERT [dbo].[User] ([UID], [Uname], [Upwd]) VALUES (3, N'yun', N'111111')
INSERT [dbo].[User] ([UID], [Uname], [Upwd]) VALUES (5, N'A12345', N'12345')
INSERT [dbo].[User] ([UID], [Uname], [Upwd]) VALUES (6, N'A', N'123')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Class] FOREIGN KEY([Cid])
REFERENCES [dbo].[Class] ([Cid])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Class]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrator', @level2type=N'COLUMN',@level2name=N'AID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrator', @level2type=N'COLUMN',@level2name=N'Aname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrator', @level2type=N'COLUMN',@level2name=N'Apwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员密钥' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Administrator', @level2type=N'COLUMN',@level2name=N'Akeys'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookManage', @level2type=N'COLUMN',@level2name=N'Bid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookManage', @level2type=N'COLUMN',@level2name=N'Bname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookManage', @level2type=N'COLUMN',@level2name=N'Bauthor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版社' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookManage', @level2type=N'COLUMN',@level2name=N'Bpress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookManage', @level2type=N'COLUMN',@level2name=N'BtypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书库存' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookManage', @level2type=N'COLUMN',@level2name=N'Binventory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Bid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'BbookName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借阅人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Bname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Bsex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'年龄' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Bage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Bphone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'家庭住址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Baddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借阅时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Btime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'归还时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'BreturnTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BooksBorrow', @level2type=N'COLUMN',@level2name=N'Bremarks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'UID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'普通用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'Uname'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'普通密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User', @level2type=N'COLUMN',@level2name=N'Upwd'
GO
USE [master]
GO
ALTER DATABASE [Book] SET  READ_WRITE 
GO
