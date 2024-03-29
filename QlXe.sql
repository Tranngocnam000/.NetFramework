USE [master]
GO
/****** Object:  Database [QlXe]    Script Date: 06/01/2022 14:20:49 ******/
CREATE DATABASE [QlXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QlXe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QlXe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QlXe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QlXe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QlXe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QlXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QlXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QlXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QlXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QlXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QlXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QlXe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QlXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QlXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QlXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QlXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QlXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QlXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QlXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QlXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QlXe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QlXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QlXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QlXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QlXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QlXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QlXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QlXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QlXe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QlXe] SET  MULTI_USER 
GO
ALTER DATABASE [QlXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QlXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QlXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QlXe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QlXe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QlXe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QlXe] SET QUERY_STORE = OFF
GO
USE [QlXe]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 06/01/2022 14:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](100) NULL,
	[password] [nvarchar](100) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoDich]    Script Date: 06/01/2022 14:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
	[MaGD] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[MaXe] [int] NOT NULL,
	[NgayBatDauThue] [date] NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [PK_GiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/01/2022 14:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[SoCMND] [nvarchar](50) NULL,
	[BangLaiXe] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 06/01/2022 14:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 06/01/2022 14:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [int] IDENTITY(1,1) NOT NULL,
	[TenXe] [nvarchar](50) NULL,
	[BienSo] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[GiaThue] [int] NULL,
	[MaLoai] [int] NOT NULL,
	[SoGhe] [int] NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([id], [username], [password]) VALUES (1, N'nam', N'123')
INSERT [dbo].[Admin] ([id], [username], [password]) VALUES (2, N'an', N'123')
INSERT [dbo].[Admin] ([id], [username], [password]) VALUES (3, N'huy', N'123')
INSERT [dbo].[Admin] ([id], [username], [password]) VALUES (4, N'long', N'123')
INSERT [dbo].[Admin] ([id], [username], [password]) VALUES (5, N'minh', N'123')
INSERT [dbo].[Admin] ([id], [username], [password]) VALUES (6, N'Nam', N'123')
INSERT [dbo].[Admin] ([id], [username], [password]) VALUES (7, N'an', N'123')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[GiaoDich] ON 

INSERT [dbo].[GiaoDich] ([MaGD], [MaKhachHang], [MaXe], [NgayBatDauThue], [NgayTra]) VALUES (1, 1, 1, CAST(N'2021-12-10' AS Date), CAST(N'2021-12-20' AS Date))
INSERT [dbo].[GiaoDich] ([MaGD], [MaKhachHang], [MaXe], [NgayBatDauThue], [NgayTra]) VALUES (2, 2, 4, CAST(N'2021-10-25' AS Date), CAST(N'2021-11-02' AS Date))
INSERT [dbo].[GiaoDich] ([MaGD], [MaKhachHang], [MaXe], [NgayBatDauThue], [NgayTra]) VALUES (3, 2, 4, CAST(N'2022-10-10' AS Date), CAST(N'2022-11-11' AS Date))
INSERT [dbo].[GiaoDich] ([MaGD], [MaKhachHang], [MaXe], [NgayBatDauThue], [NgayTra]) VALUES (5, 5, 4, CAST(N'2022-01-14' AS Date), CAST(N'2022-01-26' AS Date))
INSERT [dbo].[GiaoDich] ([MaGD], [MaKhachHang], [MaXe], [NgayBatDauThue], [NgayTra]) VALUES (11, 3, 7, CAST(N'2022-04-01' AS Date), CAST(N'2022-06-01' AS Date))
INSERT [dbo].[GiaoDich] ([MaGD], [MaKhachHang], [MaXe], [NgayBatDauThue], [NgayTra]) VALUES (12, 22, 8, CAST(N'2022-01-04' AS Date), CAST(N'2022-01-30' AS Date))
SET IDENTITY_INSERT [dbo].[GiaoDich] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (1, N'Phan Văn Anh Quốc', N'Quảng Trị', N'01679543215', N'148774541', N'123456789123')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (2, N'Lê An Khanh', N'Hue', N'0212547845', N'213545612', N'235454894564')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (3, N'Hoàng Lan', N'Đà Nẵng', N'02147585478', N'235464878', N'546135497865')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (4, N'Văn Hậu', N'Quảng Bình', N'0125478451', N'456879856', N'135468745648')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (5, N'Trần Ngọc An', N'Huế', N'147568521', N'546132548', N'561235487945')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (6, N'Trần Hoàng Lan', N'Hà Nội', N'0987546542', N'541234654', N'564265479845')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (7, N'Lý Hoàng An', N'HCM', N'0657415486', N'465124568', N'561235487978')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (8, N'Văn Hòa', N'Huế', N'03654852145', N'123456898', N'545612354879')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (9, N'Trần Long', N'Quảng Trị', N'01354587954', N'456789746', N'546878487546')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (10, N'Tran Binh An', N'Da Nang', N'1111111122 ', N'111111111', N'111111111111')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (11, N'Tran Long', N'Hue', N'0123547458', N'197554714', N'213555778441')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (12, N'Le An', N'aa', N'456', N'23', N'15')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (14, N'Nam', N'12', N'12', N'12', N'12')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (15, N'nam', N'12', N'12', N'12', N'12')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (16, N'Nam', N'12', N'12', N'12', N'12')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (17, N'Phuong', N'123', N'123', N'123', N'123')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (18, N'Ha', N'12', N'12', N'12', N'12')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (19, N'ga', N'12', N'12', N'12', N'12')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (20, N'ha', N'12', N'12', N'12', N'12')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (21, N'Phan Quang', N'Long An', N'0154257458', N'198445871', N'124566685133')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [SoDienThoai], [SoCMND], [BangLaiXe]) VALUES (22, N'Phan Long', N'Long An', N'0125474147', N'198554741', N'125415557481')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (1, N'Toyota')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (2, N'KIA')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (3, N'Ford')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (4, N'Huyndai')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (5, N'Chevrolet')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (6, N'Honda')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (7, N'Suzuki')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (8, N'Nissan')
SET IDENTITY_INSERT [dbo].[Loai] OFF
GO
SET IDENTITY_INSERT [dbo].[Xe] ON 

INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (1, N'Hiace', N'74E1 01238', N'Mới', 500000, 1, 12)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (2, N'Fortuner', N'74E1 012345', N'Mới', 500000, 1, 8)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (4, N'Avanza', N'74E1 012345', N'Mới', 500000, 1, 4)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (5, N'Colorado', N'75E2 012345', N'Mới', 400000, 5, 4)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (6, N'GT-R', N'12A1 012354', N'Cũ', 400000, 8, 4)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (7, N'Pathfinder', N'14A1 054321', N'Mới', 500000, 8, 4)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (8, N'Civic', N'74E1 026124', N'Mới', 200000, 6, 12)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [BienSo], [TinhTrang], [GiaThue], [MaLoai], [SoGhe]) VALUES (9, N'Camry', N'74E1 012345', N'Mới', 9900000, 1, 16)
SET IDENTITY_INSERT [dbo].[Xe] OFF
GO
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDich_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[GiaoDich] CHECK CONSTRAINT [FK_GiaoDich_KhachHang]
GO
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDich_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[GiaoDich] CHECK CONSTRAINT [FK_GiaoDich_Xe]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_Loai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_Loai]
GO
USE [master]
GO
ALTER DATABASE [QlXe] SET  READ_WRITE 
GO
