USE [master]
GO
/****** Object:  Database [NegoShoeInventory]    Script Date: 4/14/2017 1:26:17 PM ******/
CREATE DATABASE [NegoShoeInventory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NegoShoeInventory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\NegoShoeInventory.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NegoShoeInventory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\NegoShoeInventory_log.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NegoShoeInventory] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NegoShoeInventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NegoShoeInventory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET ARITHABORT OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [NegoShoeInventory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NegoShoeInventory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NegoShoeInventory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NegoShoeInventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NegoShoeInventory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NegoShoeInventory] SET  MULTI_USER 
GO
ALTER DATABASE [NegoShoeInventory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NegoShoeInventory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NegoShoeInventory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NegoShoeInventory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [NegoShoeInventory]
GO
/****** Object:  Table [dbo].[ItemBrand]    Script Date: 4/14/2017 1:26:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemBrand](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 4/14/2017 1:26:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](150) NOT NULL,
	[Brand] [int] NOT NULL,
	[ProductType] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[TotalQuantity] [int] NOT NULL,
	[OfficeQuantity] [int] NOT NULL,
	[HouseQuantity] [int] NOT NULL,
	[Filename] [nvarchar](50) NULL,
	[ImageBase64] [nvarchar](max) NULL,
	[Remarks] [nvarchar](500) NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemType]    Script Date: 4/14/2017 1:26:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemType](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[ProductType] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ItemBrand] ON 

GO
INSERT [dbo].[ItemBrand] ([RecordID], [Brand]) VALUES (1, N'Jordan')
GO
INSERT [dbo].[ItemBrand] ([RecordID], [Brand]) VALUES (2, N'Mitchell & Ness')
GO
INSERT [dbo].[ItemBrand] ([RecordID], [Brand]) VALUES (3, N'Nike')
GO
INSERT [dbo].[ItemBrand] ([RecordID], [Brand]) VALUES (4, N'New Era')
GO
INSERT [dbo].[ItemBrand] ([RecordID], [Brand]) VALUES (5, N'Field Grade')
GO
INSERT [dbo].[ItemBrand] ([RecordID], [Brand]) VALUES (6, N'Adidas')
GO
SET IDENTITY_INSERT [dbo].[ItemBrand] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemType] ON 

GO
INSERT [dbo].[ItemType] ([RecordID], [ProductType]) VALUES (1, N'Cap')
GO
INSERT [dbo].[ItemType] ([RecordID], [ProductType]) VALUES (2, N'Shoe')
GO
INSERT [dbo].[ItemType] ([RecordID], [ProductType]) VALUES (3, N'Shirt')
GO
INSERT [dbo].[ItemType] ([RecordID], [ProductType]) VALUES (4, N'Short')
GO
INSERT [dbo].[ItemType] ([RecordID], [ProductType]) VALUES (5, N'Slides/Hydro')
GO
SET IDENTITY_INSERT [dbo].[ItemType] OFF
GO
USE [master]
GO
ALTER DATABASE [NegoShoeInventory] SET  READ_WRITE 
GO
