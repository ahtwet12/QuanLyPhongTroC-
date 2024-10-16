USE [master]
GO
/****** Object:  Database [QLPhongTro]    Script Date: 13/10/2024 22:05:53 ******/
CREATE DATABASE [QLPhongTro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLPhongTro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLPhongTro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLPhongTro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLPhongTro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLPhongTro] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLPhongTro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLPhongTro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLPhongTro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLPhongTro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLPhongTro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLPhongTro] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLPhongTro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLPhongTro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLPhongTro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLPhongTro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLPhongTro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLPhongTro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLPhongTro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLPhongTro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLPhongTro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLPhongTro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLPhongTro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLPhongTro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLPhongTro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLPhongTro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLPhongTro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLPhongTro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLPhongTro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLPhongTro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLPhongTro] SET  MULTI_USER 
GO
ALTER DATABASE [QLPhongTro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLPhongTro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLPhongTro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLPhongTro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLPhongTro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLPhongTro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLPhongTro] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLPhongTro] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLPhongTro]
GO
/****** Object:  Table [dbo].[tblCauHinh]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCauHinh](
	[TenPhongTro] [nvarchar](250) NULL,
	[ChuPhongTro] [nvarchar](50) NOT NULL,
	[DiaChiPhongTro] [nvarchar](250) NOT NULL,
	[SoDienThoai] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDichVu]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDichVu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDichVu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDienNuoc]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDienNuoc](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDThuePhong] [bigint] NULL,
	[IDLoaiDichVu] [int] NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[ChiSoCu] [int] NULL,
	[ChiSoMoi] [int] NULL,
	[DonGia] [float] NULL,
	[DaThanhToan] [tinyint] NULL,
 CONSTRAINT [PK_tblDienNuoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DienThoai] [varchar](10) NULL,
	[CMND] [varchar](12) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[HoKhauTT] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiPhong]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_tblLoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[IDLoaiPhong] [int] NULL,
	[TrangThai] [tinyint] NULL,
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuanLy]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuanLy](
	[TaiKhoan] [varchar](20) NOT NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_tblQuanLy] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThuePhong]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThuePhong](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDKhachHang] [int] NULL,
	[IDPhong] [int] NULL,
	[GiaPhong] [float] NULL,
	[TienDatCoc] [float] NULL,
	[NgayThue] [date] NULL,
	[NgayTraPhong] [date] NULL,
	[DaThanhToan] [tinyint] NULL,
 CONSTRAINT [PK_tblThuePhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblDienNuoc] ADD  CONSTRAINT [DF_tblDienNuoc_TrangThai]  DEFAULT ((0)) FOR [DaThanhToan]
GO
ALTER TABLE [dbo].[tblDienNuoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDienNuoc_tblDichVu] FOREIGN KEY([IDLoaiDichVu])
REFERENCES [dbo].[tblDichVu] ([ID])
GO
ALTER TABLE [dbo].[tblDienNuoc] CHECK CONSTRAINT [FK_tblDienNuoc_tblDichVu]
GO
ALTER TABLE [dbo].[tblDienNuoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDienNuoc_tblThuePhong] FOREIGN KEY([IDThuePhong])
REFERENCES [dbo].[tblThuePhong] ([ID])
GO
ALTER TABLE [dbo].[tblDienNuoc] CHECK CONSTRAINT [FK_tblDienNuoc_tblThuePhong]
GO
ALTER TABLE [dbo].[tblPhong]  WITH CHECK ADD  CONSTRAINT [FK_tblPhong_tblLoaiPhong] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[tblLoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[tblPhong] CHECK CONSTRAINT [FK_tblPhong_tblLoaiPhong]
GO
ALTER TABLE [dbo].[tblThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_tblThuePhong_tblKhachHang] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[tblKhachHang] ([ID])
GO
ALTER TABLE [dbo].[tblThuePhong] CHECK CONSTRAINT [FK_tblThuePhong_tblKhachHang]
GO
ALTER TABLE [dbo].[tblThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_tblThuePhong_tblPhong] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[tblPhong] ([ID])
GO
ALTER TABLE [dbo].[tblThuePhong] CHECK CONSTRAINT [FK_tblThuePhong_tblPhong]
GO
/****** Object:  StoredProcedure [dbo].[capNhatLoaiPhong]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[capNhatLoaiPhong]
	@idLoaiPhong int,
	@tenLoaiPhong nvarchar(50),
	@donGia int
as
begin
	update tblLoaiPhong
	set TenLoaiPhong = @tenLoaiPhong,
		DonGia = @donGia
	where ID = @idLoaiPhong;

	if @@ROWCOUNT > 0 return 1;
	else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[loaiDsLoaiPhong]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loaiDsLoaiPhong]
as
begin
	select * from tblLoaiPhong;
end
GO
/****** Object:  StoredProcedure [dbo].[themLoaiPhong]    Script Date: 13/10/2024 22:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themLoaiPhong]
	@tenLoaiPhong nvarchar(50),
	@donGia int
as
begin
	insert into tblLoaiPhong values(@tenLoaiPhong,@donGia);
	if @@ROWCOUNT > 0 return 1
	else return 0;
end
GO
USE [master]
GO
ALTER DATABASE [QLPhongTro] SET  READ_WRITE 
GO
