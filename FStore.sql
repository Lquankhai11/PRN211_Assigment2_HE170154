USE [master]
GO
/****** Object:  Database [FStore]    Script Date: 2/27/2024 11:52:45 PM ******/
CREATE DATABASE [FStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [FStore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FStore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FStore] SET  MULTI_USER 
GO
ALTER DATABASE [FStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FStore] SET QUERY_STORE = OFF
GO
USE [FStore]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2/27/2024 11:52:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2/27/2024 11:52:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NOT NULL,
	[ShippedDate] [datetime] NOT NULL,
	[Freight] [money] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 2/27/2024 11:52:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/27/2024 11:52:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'john.doe@example.com', N'ABC Corporation', N'New York', N'USA', N'password123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'alice.smith@example.com', N'XYZ Ltd', N'London', N'UK', N'p@ssw0rd')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'bob.jackson@example.com', N'123 Inc.', N'Los Angeles', N'USA', N'securepass')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'emma.wang@example.com', N'Smith & Co', N'Shanghai', N'China', N'qwerty123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'james.brown@example.com', N'Brown Enterprises', N'Toronto', N'Canada', N'brownpass')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (6, N'laura.adams@example.com', N'Adams Group', N'Sydney', N'Australia', N'adams123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (7, N'michael.nguyen@example.com', N'Nguyen Corporation', N'HCM city', N'Vietnam', N'nguyenpass')
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2024-02-27T00:00:00.000' AS DateTime), CAST(N'2024-03-05T00:00:00.000' AS DateTime), CAST(N'2024-03-03T00:00:00.000' AS DateTime), 10.5000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2024-02-28T00:00:00.000' AS DateTime), CAST(N'2024-03-06T00:00:00.000' AS DateTime), CAST(N'2024-03-04T00:00:00.000' AS DateTime), 8.7500)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 3, CAST(N'2024-03-01T00:00:00.000' AS DateTime), CAST(N'2024-03-07T00:00:00.000' AS DateTime), CAST(N'2024-03-05T00:00:00.000' AS DateTime), 12.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (4, 4, CAST(N'2024-03-02T00:00:00.000' AS DateTime), CAST(N'2024-03-08T00:00:00.000' AS DateTime), CAST(N'2024-03-06T00:00:00.000' AS DateTime), 9.2500)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (5, 5, CAST(N'2024-03-03T00:00:00.000' AS DateTime), CAST(N'2024-03-09T00:00:00.000' AS DateTime), CAST(N'2024-03-07T00:00:00.000' AS DateTime), 15.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (6, 6, CAST(N'2024-03-04T00:00:00.000' AS DateTime), CAST(N'2024-03-10T00:00:00.000' AS DateTime), CAST(N'2024-03-08T00:00:00.000' AS DateTime), 11.7500)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (7, 7, CAST(N'2024-03-05T00:00:00.000' AS DateTime), CAST(N'2024-03-11T00:00:00.000' AS DateTime), CAST(N'2024-03-09T00:00:00.000' AS DateTime), 13.5000)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 1, 20.9900, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 15.7500, 3, 0)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 3, 10.5000, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 4, 18.2500, 2, 0)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (3, 5, 22.0000, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (3, 6, 12.9900, 4, 0.15)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (4, 7, 16.5000, 3, 0.05)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'Product A', N'1 lb', 25.9900, 50)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 2, N'Product B', N'0.5 lb', 19.5000, 100)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 3, N'Product C', N'2 lb', 12.7500, 75)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 1, N'Product D', N'0.75 lb', 30.0000, 60)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 2, N'Product E', N'1.5 lb', 17.2500, 90)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (6, 3, N'Product F', N'1.25 lb', 9.9900, 120)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (7, 1, N'Product G', N'2.5 lb', 35.5000, 40)
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Member]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
USE [master]
GO
ALTER DATABASE [FStore] SET  READ_WRITE 
GO
