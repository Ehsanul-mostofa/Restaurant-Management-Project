USE [master]
GO
/****** Object:  Database [restaurent]    Script Date: 4/1/2021 7:56:59 PM ******/
CREATE DATABASE [restaurent]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'restaurent', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\restaurent.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'restaurent_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\restaurent_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [restaurent] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [restaurent].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [restaurent] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [restaurent] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [restaurent] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [restaurent] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [restaurent] SET ARITHABORT OFF 
GO
ALTER DATABASE [restaurent] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [restaurent] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [restaurent] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [restaurent] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [restaurent] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [restaurent] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [restaurent] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [restaurent] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [restaurent] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [restaurent] SET  DISABLE_BROKER 
GO
ALTER DATABASE [restaurent] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [restaurent] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [restaurent] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [restaurent] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [restaurent] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [restaurent] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [restaurent] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [restaurent] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [restaurent] SET  MULTI_USER 
GO
ALTER DATABASE [restaurent] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [restaurent] SET DB_CHAINING OFF 
GO
ALTER DATABASE [restaurent] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [restaurent] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [restaurent] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [restaurent] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [restaurent] SET QUERY_STORE = OFF
GO
USE [restaurent]
GO
/****** Object:  Table [dbo].[billings]    Script Date: 4/1/2021 7:57:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[billings](
	[sl] [int] NOT NULL,
	[item] [varchar](50) NULL,
	[qty] [int] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_billings] PRIMARY KEY CLUSTERED 
(
	[sl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/1/2021 7:57:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [varchar](20) NOT NULL,
	[name] [varchar](30) NULL,
	[address] [varchar](50) NULL,
	[department] [varchar](20) NULL,
	[salary] [float] NULL,
	[hiredate] [date] NULL,
	[contact] [numeric](18, 0) NULL,
	[password] [varchar](20) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 4/1/2021 7:57:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[id] [varchar](20) NOT NULL,
	[name] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchase]    Script Date: 4/1/2021 7:57:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchase](
	[id] [varchar](50) NOT NULL,
	[name] [varchar](50) NULL,
	[quantity] [varchar](30) NULL,
	[purchasedate] [date] NULL,
	[expiredate] [date] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_purchase] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 4/1/2021 7:57:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[amount] [float] NULL,
	[ondate] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utility]    Script Date: 4/1/2021 7:57:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utility](
	[month] [date] NULL,
	[gasbill] [float] NULL,
	[electricitybill] [float] NULL,
	[waterbill] [float] NULL,
	[others] [float] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([id], [name], [address], [department], [salary], [hiredate], [contact], [password]) VALUES (N'e-01', N'nila', N'kumarkhali', N'admin', 55000, CAST(N'2020-01-01' AS Date), CAST(12345678 AS Numeric(18, 0)), N'123')
INSERT [dbo].[Employee] ([id], [name], [address], [department], [salary], [hiredate], [contact], [password]) VALUES (N'e-02', N'asif', N'dhaka', N'manager', 40000, CAST(N'2020-01-01' AS Date), CAST(45678 AS Numeric(18, 0)), N'123')
INSERT [dbo].[Employee] ([id], [name], [address], [department], [salary], [hiredate], [contact], [password]) VALUES (N'e-03', N'sohan', N'comilla', N'admin', 45000, CAST(N'2020-05-01' AS Date), CAST(45678 AS Numeric(18, 0)), N'123')
INSERT [dbo].[Employee] ([id], [name], [address], [department], [salary], [hiredate], [contact], [password]) VALUES (N'e-04', N'nilam', N'dhaka', N'manager', 50000, CAST(N'2021-01-02' AS Date), CAST(12345 AS Numeric(18, 0)), N'123')
INSERT [dbo].[Employee] ([id], [name], [address], [department], [salary], [hiredate], [contact], [password]) VALUES (N'e-05', N'shehnaz', N'narayanganj', N'manager', 30000, CAST(N'2021-01-03' AS Date), CAST(12345 AS Numeric(18, 0)), N'123')
GO
INSERT [dbo].[Item] ([id], [name], [type], [price]) VALUES (N'i-01', N'bbq cheese burger', N'large', 280)
INSERT [dbo].[Item] ([id], [name], [type], [price]) VALUES (N'i-02', N'cheese burger', N'medium', 220)
INSERT [dbo].[Item] ([id], [name], [type], [price]) VALUES (N'i-09', N'double cheese burger', N'large', 220)
INSERT [dbo].[Item] ([id], [name], [type], [price]) VALUES (N'i-10', N'oven baked pasta', N'medium bowl size', 350)
INSERT [dbo].[Item] ([id], [name], [type], [price]) VALUES (N'i-11', N'french fry', N'large', 120)
GO
INSERT [dbo].[purchase] ([id], [name], [quantity], [purchasedate], [expiredate], [price]) VALUES (N'r-01', N'sauce', N'500mL', CAST(N'2020-01-12' AS Date), CAST(N'2021-12-12' AS Date), 280)
INSERT [dbo].[purchase] ([id], [name], [quantity], [purchasedate], [expiredate], [price]) VALUES (N'r-02', N'bun', N'500', CAST(N'2020-12-12' AS Date), CAST(N'2021-10-12' AS Date), 2000)
INSERT [dbo].[purchase] ([id], [name], [quantity], [purchasedate], [expiredate], [price]) VALUES (N'r-03', N'chicken', N'5kg', CAST(N'2020-12-12' AS Date), CAST(N'2021-10-12' AS Date), 850)
INSERT [dbo].[purchase] ([id], [name], [quantity], [purchasedate], [expiredate], [price]) VALUES (N'r-04', N'beef', N'5kg', CAST(N'2020-12-12' AS Date), CAST(N'2021-10-12' AS Date), 3000)
INSERT [dbo].[purchase] ([id], [name], [quantity], [purchasedate], [expiredate], [price]) VALUES (N'r-05', N'rice', N'5kg', CAST(N'2020-01-12' AS Date), CAST(N'2021-05-12' AS Date), 500)
INSERT [dbo].[purchase] ([id], [name], [quantity], [purchasedate], [expiredate], [price]) VALUES (N'r-06', N'coke', N'10 litre', CAST(N'2021-01-02' AS Date), CAST(N'2021-05-02' AS Date), 1200)
INSERT [dbo].[purchase] ([id], [name], [quantity], [purchasedate], [expiredate], [price]) VALUES (N'r-07', N'vegetables', N'10kg', CAST(N'2021-01-02' AS Date), CAST(N'2021-02-02' AS Date), 500)
GO
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (1000, CAST(N'2021-01-02' AS Date))
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (520, CAST(N'2021-01-02' AS Date))
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (500, CAST(N'2021-02-02' AS Date))
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (960, CAST(N'2021-01-03' AS Date))
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (520, CAST(N'2021-01-03' AS Date))
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (680, CAST(N'2021-01-03' AS Date))
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (1360, CAST(N'2021-01-04' AS Date))
INSERT [dbo].[sales] ([amount], [ondate]) VALUES (780, CAST(N'2021-01-03' AS Date))
GO
INSERT [dbo].[utility] ([month], [gasbill], [electricitybill], [waterbill], [others]) VALUES (CAST(N'2021-01-02' AS Date), 400, 1000, 500, 500)
GO
USE [master]
GO
ALTER DATABASE [restaurent] SET  READ_WRITE 
GO
