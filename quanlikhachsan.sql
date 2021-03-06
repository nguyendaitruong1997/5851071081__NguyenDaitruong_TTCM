USE [master]
GO
/****** Object:  Database [QuanLyKhachSan_Update]    Script Date: 7/18/2020 3:45:29 PM ******/
CREATE DATABASE [QuanLyKhachSan_Update]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhachSan_Update', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhachSan_Update.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKhachSan_Update_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyKhachSan_Update_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhachSan_Update].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET QUERY_STORE = OFF
GO
USE [QuanLyKhachSan_Update]
GO
/****** Object:  Table [dbo].[CT_PhieuThue]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuThue](
	[SoPhieuThue] [int] NOT NULL,
	[MaPhieuThue] [varchar](10) NULL,
	[MaPhong] [nvarchar](10) NULL,
	[NgayDangKiPhong] [datetime] NULL,
	[NgayNhanPhong] [datetime] NULL,
	[DonGia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachDichVu]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachDichVu](
	[MaDanhSach] [nvarchar](50) NOT NULL,
	[SoPhieuThue] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DV]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DV](
	[MaDV] [nvarchar](50) NOT NULL,
	[MaLoaiDV] [nvarchar](50) NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[MaDanhSach] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] NOT NULL,
	[MaNhanVien] [varchar](10) NULL,
	[MaKhachHang] [nvarchar](10) NULL,
	[MaPhieuThue] [varchar](10) NULL,
	[SoNgay] [int] NULL,
	[TongTien] [int] NULL,
	[NgayLap] [datetime] NULL,
	[TongTienDV] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](10) NOT NULL,
	[QuocTich] [nvarchar](10) NULL,
	[TenKhachHang] [nvarchar](20) NULL,
	[CMND] [varchar](10) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDV]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDV](
	[MaLoaiDV] [nvarchar](50) NOT NULL,
	[TenLoaiDV] [nvarchar](50) NULL,
	[DonGia] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[QuocTich] [nvarchar](10) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[QuocTich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [nvarchar](10) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoNguoiChuan] [int] NULL,
	[SoNguoiToiDa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[NgaySinh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThuePhong]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuePhong](
	[MaPhieuThue] [varchar](10) NOT NULL,
	[MaNhanVien] [varchar](10) NULL,
	[MaKhachHang] [nvarchar](10) NULL,
	[SoNguoi] [int] NULL,
	[KhachNuocNgoai] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](10) NOT NULL,
	[MaloaiPhong] [nvarchar](10) NULL,
	[MaTinhTrang] [varchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [int] NULL,
	[Gmail] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhTrangPhong]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangPhong](
	[MaTinhTrang] [varchar](50) NOT NULL,
	[TenTinhTrang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_PhieuThue]  WITH CHECK ADD FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PhieuThuePhong] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[CT_PhieuThue]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DanhSachDichVu]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachDichVu_CT_PhieuThue] FOREIGN KEY([SoPhieuThue])
REFERENCES [dbo].[CT_PhieuThue] ([SoPhieuThue])
GO
ALTER TABLE [dbo].[DanhSachDichVu] CHECK CONSTRAINT [FK_DanhSachDichVu_CT_PhieuThue]
GO
ALTER TABLE [dbo].[DV]  WITH CHECK ADD  CONSTRAINT [FK_DV_DanhSachDichVu1] FOREIGN KEY([MaDanhSach])
REFERENCES [dbo].[DanhSachDichVu] ([MaDanhSach])
GO
ALTER TABLE [dbo].[DV] CHECK CONSTRAINT [FK_DV_DanhSachDichVu1]
GO
ALTER TABLE [dbo].[DV]  WITH CHECK ADD  CONSTRAINT [FK_DV_LoaiDV] FOREIGN KEY([MaLoaiDV])
REFERENCES [dbo].[LoaiDV] ([MaLoaiDV])
GO
ALTER TABLE [dbo].[DV] CHECK CONSTRAINT [FK_DV_LoaiDV]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PhieuThuePhong] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([QuocTich])
REFERENCES [dbo].[LoaiKhachHang] ([QuocTich])
GO
ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuThuePhong]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([MaloaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([MaTinhTrang])
REFERENCES [dbo].[TinhTrangPhong] ([MaTinhTrang])
GO
/****** Object:  StoredProcedure [dbo].[checkPhieuThueChuaThanhToan]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkPhieuThueChuaThanhToan]
	as begin
	select c.MaPhieuThue  from CT_PhieuThue c where c.MaPhieuThue not in
	(
	select a.MaPhieuThue 
	from HoaDon a, CT_PhieuThue b
	where  b.MaPhieuThue = a.MaPhieuThue
	)
	end
GO
/****** Object:  StoredProcedure [dbo].[checkPhieuThueDV]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkPhieuThueDV]
as
begin

	select a.SoPhieuThue from  CT_PhieuThue  a where a.MaPhieuThue not in
	(
		select b.MaPhieuThue from HoaDon b, CT_PhieuThue c
		where b.MaPhieuThue=c.MaPhieuThue
	
	)
	end
GO
/****** Object:  StoredProcedure [dbo].[checkPhieuThueDV1]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkPhieuThueDV1]
as
begin

	select a.SoPhieuThue from  CT_PhieuThue  a where a.MaPhieuThue not in
	(
		select b.MaPhieuThue from HoaDon b, CT_PhieuThue c
		where b.MaPhieuThue=c.MaPhieuThue
	
	)
	and a.SoPhieuThue not in(select g.SoPhieuThue from DanhSachDichVu g)
	end
GO
/****** Object:  StoredProcedure [dbo].[delete_PhieuDk]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[delete_PhieuDk](

	@sophieuthue int,
	@maphieuthue varchar(10)
)
as begin
delete CT_PhieuThue where  SoPhieuThue=@sophieuthue


delete PhieuThuePhong where MaPhieuThue=@maphieuthue

end
GO
/****** Object:  StoredProcedure [dbo].[deleteDanhSach]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteDanhSach](

	@MaDanhSach nvarchar(50)
)
as begin
delete  DanhSachDichVu where MaDanhSach=@MaDanhSach
end
GO
/****** Object:  StoredProcedure [dbo].[deleteHoaDon]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteHoaDon](
	@MaHoaDon int
)
as begin 
delete HoaDon where MaHoaDon=@MaHoaDon
end
GO
/****** Object:  StoredProcedure [dbo].[deletePhong]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletePhong](
	@MaPhong nvarchar(10)
	
)

as begin
delete Phong where MaPhong=@MaPhong
end
GO
/****** Object:  StoredProcedure [dbo].[deleteTT]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteTT]
@MaTinhTrang varchar(50)
as begin
delete from TinhTrangPhong where MaTinhTrang=@MaTinhTrang
end
GO
/****** Object:  StoredProcedure [dbo].[delleteTaiKhoan]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delleteTaiKhoan]
@TenDangNhap varchar(20)
as begin
delete from TaiKhoan where TenDangNhap=@TenDangNhap
end
GO
/****** Object:  StoredProcedure [dbo].[doimk]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[doimk](
	@TenDangNhap varchar(20),
	@MatKhau nvarchar(50)
)
as
begin
	update TaiKhoan set MatKhau=@MatKhau where TenDangNhap=@TenDangNhap

end
GO
/****** Object:  StoredProcedure [dbo].[insert_CtPhieuThue]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_CtPhieuThue](
	@SoPhieuThue int,
	@MaPhieuThue varchar(10),
	@MaPhong		nvarchar(10),
	@NgayDangKiPhong	datetime,
	@NgayNhanPhong	datetime

)
as begin
insert into CT_PhieuThue values(@SoPhieuThue ,
	@MaPhieuThue ,
	@MaPhong		,
	@NgayDangKiPhong	,
	@NgayNhanPhong	)
end
GO
/****** Object:  StoredProcedure [dbo].[insert_PhieuThue]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_PhieuThue](
	@PhieuThue varchar(10),
	@MaNhanVien varchar(10),
	@MaKhachHang nvarchar(10),
	@SoNguoi int,
	@KhachNuocNgoai varchar(5)
)
as begin 
insert into PhieuThuePhong values(
	@PhieuThue ,
	@MaNhanVien ,
	@MaKhachHang ,
	@SoNguoi ,
	@KhachNuocNgoai )
end
GO
/****** Object:  StoredProcedure [dbo].[insertCt_phieuNhan]    Script Date: 7/18/2020 3:45:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertCt_phieuNhan](
	@SoPhieuNhan int,
	@MaNhanPhong varchar(10),
	@MaPhong nvarchar(10),
	@MaKhachHang nvarchar(10),
	@NgayNhanPhong datetime,
	@NgayTra dateTime
)
as
begin
	insert into CT_PhieuNhan values(@SoPhieuNhan ,
	@MaNhanPhong ,
	@MaPhong ,
	@MaKhachHang ,
	@NgayNhanPhong ,
	@NgayTra )
end
GO
/****** Object:  StoredProcedure [dbo].[insertCT_PHieuThue]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertCT_PHieuThue](
		@SoPhieuThue int,
		@MaPhieuThue varchar(10),
		@MaPhong nvarchar(10),
		@NgayDangKi datetime,
		@NgayNhanPhong datetime,
		@DonGia int
	
	
	)
	as begin
	insert into CT_PhieuThue values(@SoPhieuThue ,
		@MaPhieuThue ,
		@MaPhong ,
		@NgayDangKi ,
		@NgayNhanPhong ,
		@DonGia
		)
	end
GO
/****** Object:  StoredProcedure [dbo].[insertCT_PHieuThue_DV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertCT_PHieuThue_DV](
		@SoPhieuThue int,
		@MaPhieuThue varchar(10),
		@MaPhong nvarchar(10),
		@NgayDangKi datetime,
		@NgayNhanPhong datetime,
		@DonGia int,
		@MaDanhSach nvarchar(50)
	
	)
	as begin
	insert into CT_PhieuThue values(@SoPhieuThue ,
		@MaPhieuThue ,
		@MaPhong ,
		@NgayDangKi ,
		@NgayNhanPhong ,
		@DonGia,
		@MaDanhSach)
	end
GO
/****** Object:  StoredProcedure [dbo].[insertPhieuNhan]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertPhieuNhan](
	@MaNhanPhong varchar(10),
	@MaKhachHang nvarchar(10),
	@MaPhieuThue varchar(10)

)
as
begin
	insert into PhieuNhanPhong values(@MaNhanPhong,@MaKhachHang,@MaPhieuThue)
end
GO
/****** Object:  StoredProcedure [dbo].[insertt]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertt]
@TenDangNhap varchar(20),
@MatKhau varchar(100),
@Quyen int,
@gmail nvarchar(100)
as begin
insert into TaiKhoan values(@TenDangNhap,@MatKhau,@Quyen,@gmail)

end
GO
/****** Object:  StoredProcedure [dbo].[insertThemHoaDon]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertThemHoaDon](
	@MaHoaDon int ,
	@MaNhanVien varchar(10),
	@MaKhachHang nvarchar(10),
	@MaPhieuThue varchar(10),
	@TongTien int
	)
	as begin insert into HoaDon values(
	@MaHoaDon ,
	@MaNhanVien ,
	@MaKhachHang,
	@MaPhieuThue ,
	@TongTien ,
	GETDATE()
	)
	end
GO
/****** Object:  StoredProcedure [dbo].[insertTT]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertTT]
@MaTinhTrang varchar(50),
@TenTinhTrang nvarchar(50)
as begin
insert into TinhTrangPhong values(@MaTinhTrang,@TenTinhTrang)

end
GO
/****** Object:  StoredProcedure [dbo].[lichsukhach]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[lichsukhach]
as
begin

select a.MaHoaDon,b.MaPhieuThue,d.TenKhachHang,d.CMND,c.NgayNhanPhong,a.NgayLap from HoaDon a,PhieuThuePhong b,CT_PhieuThue c ,KhachHang d where  a.MaPhieuThue=c.MaPhieuThue and b.MaKhachHang=d.MaKhachHang and 
b.MaPhieuThue=c.MaPhieuThue
end
GO
/****** Object:  StoredProcedure [dbo].[reportHoaDonChuan]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reportHoaDonChuan](@maHD int)
as begin
	select *
	from CT_PhieuThue, HoaDon, PhieuThuePhong
	where CT_PhieuThue.MaPhieuThue = HoaDon.MaPhieuThue and PhieuThuePhong.MaPhieuThue = CT_PhieuThue.MaPhieuThue
	and HoaDon.MaHoaDon = @maHD
end
GO
/****** Object:  StoredProcedure [dbo].[seaching]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching] 
	@valuaToFind nvarchar(50)
as
begin
select hd.MaHoaDon, nv.TenNhanVien, kh.TenKhachHang, ct.MaPhieuThue, ct.DonGia, hd.SoNgay, hd.TongTien, hd.NgayLap 
from HoaDon hd, CT_PhieuThue ct, NhanVien nv, KhachHang kh
where ConCat( hd.MaHoaDon, nv.TenNhanVien, kh.TenKhachHang, ct.MaPhieuThue, ct.DonGia, hd.SoNgay, hd.TongTien, hd.NgayLap ) like  '%' + @valuaToFind + '%' and  hd.MaPhieuThue = ct.MaPhieuThue and hd.MaNhanVien = nv.MaNhanVien and
hd.MaKhachHang = kh.MaKhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[seaching_HoaDon]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching_HoaDon]
	@valuaToFind nvarchar(50)
as
begin
select * 
from HoaDon c
where ConCat( c.MaHoaDon,c.MaKhachHang,c.MaNhanVien,c.MaPhieuThue,c.NgayLap,c.SoNgay,c.TongTien ) like  '%' + @valuaToFind + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[seaching_kh]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching_kh](
@valuaToFind nvarchar(50)

)
as
begin 
select *from KhachHang c where 
ConCat( c.MaKhachHang,c.TenKhachHang,c.CMND,c.DiaChi,c.SDT,c.QuocTich,c.GioiTinh )like  '%' + @valuaToFind + '%'

end
GO
/****** Object:  StoredProcedure [dbo].[seaching_loaiPhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching_loaiPhong](
@valuaToFind nvarchar(50)

)
as
begin 
select *from LoaiPhong c where 
ConCat( c.DonGia,c.MaLoaiPhong,c.SoNguoiChuan,c.SoNguoiToiDa,c.TenLoaiPhong )like  '%' + @valuaToFind + '%'

end
GO
/****** Object:  StoredProcedure [dbo].[seaching_nv]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching_nv](
@valuaToFind nvarchar(50)

)
as
begin 
select *from NhanVien c where 
ConCat( c.GioiTinh,c.MaNhanVien,c.NgaySinh,c.QueQuan,c.TenNhanVien )like  '%' + @valuaToFind + '%'

end
GO
/****** Object:  StoredProcedure [dbo].[seaching_PhieuDK]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching_PhieuDK](
@valuaToFind nvarchar(50)

)
as
begin 
select *from CT_PhieuThue c where 
ConCat( c.SoPhieuThue,c.MaPhieuThue,c.MaPhong,c.NgayDangKiPhong,c.NgayNhanPhong,c.DonGia )like  '%' + @valuaToFind + '%'

end
GO
/****** Object:  StoredProcedure [dbo].[seaching_PhieuThuePhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seaching_PhieuThuePhong]
	@valuaToFind nvarchar(50)
as
begin
select * 
from PhieuThuePhong c
where ConCat( c.KhachNuocNgoai,c.MaKhachHang,c.MaNhanVien,c.MaPhieuThue,c.SoNguoi ) like  '%' + @valuaToFind + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[Seaching_Phong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Seaching_Phong]
(
		@valuaToFind nvarchar(50)
	)

as begin
	select Phong.MaPhong,LoaiPhong.TenLoaiPhong,TinhTrangPhong.MaTinhTrang,TinhTrangPhong.TenTinhTrang
	from Phong,TinhTrangPhong,LoaiPhong Where CONCAT( Phong.MaPhong,LoaiPhong.TenLoaiPhong,TinhTrangPhong.MaTinhTrang,TinhTrangPhong.TenTinhTrang) like  '%' + @valuaToFind + '%'and
	phong.MaTinhTrang=TinhTrangPhong.MaTinhTrang and Phong.MaloaiPhong=LoaiPhong.MaLoaiPhong
	end
GO
/****** Object:  StoredProcedure [dbo].[Seaching_QuocTich]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[Seaching_QuocTich]
(
		@valuaToFind nvarchar(50)
	)

as begin
	select * from LoaiKhachHang where CONCAT( LoaiKhachHang.QuocTich,LoaiKhachHang.QuocTich) like  '%' + @valuaToFind + '%'
	end
GO
/****** Object:  StoredProcedure [dbo].[sechingDs]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sechingDs]
@valuaToFind nvarchar(50)
as begin
select * from DanhSachDichVu a where
 ConCat(a.MaDanhSach,a.SoPhieuThue) like  '%' + @valuaToFind + '%' 
end
GO
/****** Object:  StoredProcedure [dbo].[sechingDV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sechingDV]
@valuaToFind nvarchar(50)
as begin
select DV.MaDV,LoaiDV.TenLoaiDV,Dv.MaDanhSach from LoaiDV, DV where DV.MaLoaiDV=LoaiDV.MaLoaiDV
and ConCat(DV.MaDV,LoaiDV.TenLoaiDV,Dv.MaDanhSach ) like  '%' + @valuaToFind + '%' 
end
GO
/****** Object:  StoredProcedure [dbo].[selectcthd]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectcthd] 
as
select hd.MaHoaDon, nv.TenNhanVien, kh.TenKhachHang, ct.MaPhieuThue, ct.DonGia, hd.SoNgay,hd.TongTienDV, hd.TongTien, hd.NgayLap 
from HoaDon hd, CT_PhieuThue ct, NhanVien nv, KhachHang kh
where hd.MaPhieuThue = ct.MaPhieuThue and hd.MaNhanVien = nv.MaNhanVien and
hd.MaKhachHang = kh.MaKhachHang
GO
/****** Object:  StoredProcedure [dbo].[selectCTPhieuThue]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectCTPhieuThue]
as begin
select * from CT_PhieuThue 
end
GO
/****** Object:  StoredProcedure [dbo].[selectDoanhThu]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectDoanhThu]
	@Thang int
	as begin
	select d.MaLoaiPhong,sum(a.TongTien) as 'DoanhThu'  from HoaDon a, CT_PhieuThue b, Phong c,LoaiPhong d where  a.MaPhieuThue =b.MaPhieuThue and b.MaPhong=c.MaPhong
	and d.MaLoaiPhong=c.MaloaiPhong and  MONTH(a.NgayLap)=@Thang and  YEAR(a.NgayLap)=YEAR(GETDATE())
	group by c.MaPhong,d.MaLoaiPhong
	end
GO
/****** Object:  StoredProcedure [dbo].[selectDS]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectDS]
	as
	begin

	select a.MaDanhSach from DanhSachDichVu a, CT_PhieuThue b,PhieuThuePhong c
	where a.SoPhieuThue=b.SoPhieuThue and b.MaPhieuThue=c.MaPhieuThue and c.MaPhieuThue not in
	(  select e.MaPhieuThue from HoaDon e )

	end
GO
/****** Object:  StoredProcedure [dbo].[selectDV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectDV]
as begin
select DV.MaDV,LoaiDV.TenLoaiDV,Dv.MaDanhSach from LoaiDV, DV where DV.MaLoaiDV=LoaiDV.MaLoaiDV
end
GO
/****** Object:  StoredProcedure [dbo].[SelectHD]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectHD]
as begin


select hd.MaHoaDon, nv.TenNhanVien, kh.TenKhachHang, ct.MaPhieuThue, ct.DonGia, hd.SoNgay, sum(cast (LDV.DonGia as int)) as 'TongTienDV', hd.TongTien, hd.NgayLap 
from HoaDon hd, CT_PhieuThue ct, NhanVien nv, KhachHang kh,DanhSachDichVu ds,DV dv, LoaiDV LDV
where hd.MaPhieuThue = ct.MaPhieuThue and hd.MaNhanVien = nv.MaNhanVien and ct.SoPhieuThue=ds.SoPhieuThue and dv.MaDanhSach=ds.MaDanhSach
and dv.MaLoaiDV= LDV.MaLoaiDV and
hd.MaKhachHang = kh.MaKhachHang 
group by hd.MaHoaDon, nv.TenNhanVien,kh.TenKhachHang,ct.MaPhieuThue,hd.SoNgay,hd.TongTien,hd.NgayLap,ct.DonGia
end
GO
/****** Object:  StoredProcedure [dbo].[selectHd1]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectHd1]
as
begin


select hd.MaHoaDon, nv.TenNhanVien, kh.TenKhachHang, ct.MaPhieuThue, ct.DonGia, hd.SoNgay,hd.TongTienDV, hd.TongTien, hd.NgayLap 
from HoaDon hd, CT_PhieuThue ct, NhanVien nv, KhachHang kh
where hd.MaPhieuThue = ct.MaPhieuThue and hd.MaNhanVien = nv.MaNhanVien and
hd.MaKhachHang = kh.MaKhachHang 
end
GO
/****** Object:  StoredProcedure [dbo].[selectPhieuDangKi]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectPhieuDangKi](@machitiet int)
as begin
	select * from LoaiKhachHang s, KhachHang a,PhieuThuePhong b,CT_PhieuThue c 
	Where a.MaKhachHang=b.MaKhachHang and b.MaPhieuThue=c.MaPhieuThue and a.QuocTich=s.QuocTich
	and c.SoPhieuThue = @machitiet
end
GO
/****** Object:  StoredProcedure [dbo].[SlectPhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SlectPhong]
as begin
	select Phong.MaPhong,LoaiPhong.TenLoaiPhong,TinhTrangPhong.MaTinhTrang,TinhTrangPhong.TenTinhTrang
	from Phong,TinhTrangPhong,LoaiPhong Where
	phong.MaTinhTrang=TinhTrangPhong.MaTinhTrang and Phong.MaloaiPhong=LoaiPhong.MaLoaiPhong
	end
GO
/****** Object:  StoredProcedure [dbo].[suahd]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suahd] (@mahd int, @manv nvarchar (10), @makh nvarchar (10), @maphieuthue nvarchar (10), @songay int,@tienphong int ,@ngaylap datetime,

	@TienDV nvarchar(50))
as
begin
update HoaDon set MaNhanVien=@manv,MaKhachHang=@makh,MaPhieuThue=@maphieuthue,SoNgay=@songay,TongTien=@tienphong,NgayLap=@ngaylap,TongTienDV=@TienDV where MaHoaDon=@mahd
end
GO
/****** Object:  StoredProcedure [dbo].[suakhachhang]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suakhachhang] 
@MaKhachHang nvarchar(10),
@QuocTich	nvarchar(10),
@TenKhachHang nvarchar(20),
@CMND varchar(10),
@GioiTinh nvarchar(10),
@DiaChi nvarchar(50),
@SDT varchar(11)
as begin
update  KhachHang set QuocTich=@QuocTich,TenKhachHang=@TenKhachHang,CMND=@CMND,GioiTinh=@GioiTinh,DiaChi=@DiaChi,SDT=@SDT where MaKhachHang=@MaKhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiKhachHang]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SuaLoaiKhachHang]
(
	@QuocTich nvarchar(10),
	@GhiChu nvarchar(10)
)
	as begin
	insert into LoaiKhachHang values (@QuocTich,@GhiChu)
	end
GO
/****** Object:  StoredProcedure [dbo].[suaLoaiPhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaLoaiPhong]
	@MaLoaiPhong nvarchar(10),
@TenLoaiPhong nvarchar(50),
@DonGia int,
@SoNguoiChuan int,
@SoNguoiToiDa int,
@TiLeTang float

	as begin
	update  LoaiPhong set TenLoaiPhong= @TenLoaiPhong ,DonGia= @DonGia ,SoNguoiChuan= @SoNguoiChuan ,SoNguoiToiDa= @SoNguoiToiDa ,TiLeTang=@TiLeTang where MaLoaiPhong=@MaLoaiPhong
	end
GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiPhongaaaaaa]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaLoaiPhongaaaaaa](
	@MaLoaiPhong nvarchar(10),
	@TenLoaiPhong nvarchar(50),
	@DonGia int ,
	@SoNguoiChuan int,
	@SoNguoiToiDa int
)
as begin
update LoaiPhong set TenLoaiPhong=@TenLoaiPhong,DonGia=@DonGia,SoNguoiChuan=@SoNguoiChuan,SoNguoiToiDa=@SoNguoiToiDa
where	MaLoaiPhong=@MaLoaiPhong

	end
GO
/****** Object:  StoredProcedure [dbo].[suanhanvien]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suanhanvien] 
@MaNhanVien varchar(10),
@TenNhanVien nvarchar(50),
@GioiTinh	nvarchar(10),
@QueQuan		nvarchar(50),
@NgaySinh	nvarchar(50)
as begin
update  NhanVien set TenNhanVien=@TenNhanVien,GioiTinh=@GioiTinh,QueQuan=@QueQuan,NgaySinh=@NgaySinh where MaNhanVien=@MaNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[them_DV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_DV]
(
	 @MaDV nvarchar(50),
	@MaLoaiDV nvarchar(50),
	@TenDV nvarchar(50),
	@MaDanhSach nvarchar(50)
)
as
begin
		insert into DV values (@MaDV,@MaLoaiDV,@TenDV,@MaDanhSach)

end
GO
/****** Object:  StoredProcedure [dbo].[themdanhsachDV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themdanhsachDV]
 (@MaDanhSach nvarchar(50),
 @SoPhieuTheu int)
as begin

insert into DanhSachDichVu values(@MaDanhSach,@SoPhieuTheu)
end
GO
/****** Object:  StoredProcedure [dbo].[themhd]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themhd] (@mahd int, @manv nvarchar (10), @makh nvarchar (10), @maphieuthue nvarchar (10), @songay int,@tienDichVu nvarchar(50),@tienphong int ,@ngaylap datetime)
as
insert into HoaDon values (@mahd, @manv, @makh, @maphieuthue, @songay, @tienphong, @ngaylap,@tienDichVu)
GO
/****** Object:  StoredProcedure [dbo].[themhd1]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[themhd1] (@mahd int, @manv nvarchar (10), @makh nvarchar (10), @maphieuthue nvarchar (10), @songay int,@tienDichVu nvarchar(50),@tienphong int ,@ngaylap datetime)
as
insert into HoaDon values (@mahd, @manv, @makh, @maphieuthue, @songay, @tienphong, @ngaylap,@tienDichVu)
GO
/****** Object:  StoredProcedure [dbo].[themkhachhangs]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themkhachhangs]
@MaKhachHang nvarchar(10),
@QuocTich	nvarchar(10),
@TenKhachHang nvarchar(20),
@CMND varchar(10),
@GioiTinh nvarchar(10),
@DiaChi nvarchar(50),
@SDT varchar(11)
as begin
insert into KhachHang values(@MaKhachHang,@QuocTich,@TenKhachHang,@CMND,@GioiTinh,@DiaChi,@SDT)
end
GO
/****** Object:  StoredProcedure [dbo].[themLoaiDV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themLoaiDV]
 @MaLoaiDV nvarchar(100),
 @TenLoaiDV nvarchar(100),
 @dongia nvarchar(50)
 as
 begin 
 insert into LoaiDV values(@MaLoaiDV,@TenLoaiDV,@dongia)
 end
GO
/****** Object:  StoredProcedure [dbo].[themLoaiKhachHang]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themLoaiKhachHang]
(
	@QuocTich nvarchar(10),
	@GhiChu nvarchar(10)
)

	as begin
	insert into LoaiKhachHang values (@QuocTich,@GhiChu)
	end
GO
/****** Object:  StoredProcedure [dbo].[themLoaiPhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themLoaiPhong] 
@MaLoaiPhong nvarchar(10),
@TenLoaiPhong nvarchar(50),
@DonGia int,
@SoNguoiChuan int,
@SoNguoiToiDa int,
@TiLeTang float
as begin
insert into LoaiPhong values(@MaLoaiPhong ,@TenLoaiPhong ,@DonGia ,@SoNguoiChuan ,@SoNguoiToiDa ,@TiLeTang )
end
GO
/****** Object:  StoredProcedure [dbo].[ThemLoaiPhongaaaaaa]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemLoaiPhongaaaaaa](
	@MaLoaiPhong nvarchar(10),
	@TenLoaiPhong nvarchar(50),
	@DonGia int ,
	@SoNguoiChuan int,
	@SoNguoiToiDa int
)
as begin
insert into LoaiPhong values(
	@MaLoaiPhong ,
	@TenLoaiPhong ,
	@DonGia ,
	@SoNguoiChuan,
	@SoNguoiToiDa)
	end
GO
/****** Object:  StoredProcedure [dbo].[themnhanvien]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themnhanvien] 
@MaNhanVien varchar(10),
@TenNhanVien nvarchar(50),
@GioiTinh	nvarchar(10),
@QueQuan		nvarchar(50),
@NgaySinh	nvarchar(50)
as begin
insert into NhanVien values(@MaNhanVien,@TenNhanVien,@GioiTinh,@QueQuan,@NgaySinh)
end
select * from NhanVien
GO
/****** Object:  StoredProcedure [dbo].[ThemphieuDangKi]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemphieuDangKi](
	@MaChiTietPhieuThue int ,
	@MaPhieuThue varchar(10),
	@MaNhanVien varchar(10),
	@MaKhachHang nvarchar(10),
	@MaPhong nvarchar(10),
	@NgayDangKiPhong	datetime,
	@NgayNhanPhong	datetime
)
as begin
	insert into PhieuThuePhong values(@MaPhieuThue,@MaNhanVien,@MaKhachHang)
	insert into CT_PhieuThue values(@MaChiTietPhieuThue,@MaPhieuThue,@MaPhong,@NgayDangKiPhong,@NgayNhanPhong)
end
GO
/****** Object:  StoredProcedure [dbo].[ThemphieuDk]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemphieuDk](
	@MaPhieuThue varchar(10),
	@MaNhanVien varchar(10),
	@MaKhachHang nvarchar(10),
	@MaPhong nvarchar(10),
	@NgayDangKiPhong	datetime,
	@NgayNhanPhong	datetime
)
as begin
	insert into PhieuThuePhong values(@MaPhieuThue,@MaNhanVien,@MaKhachHang)
	insert into CT_PhieuThue values(@MaPhieuThue,@MaPhong,@NgayDangKiPhong,@NgayNhanPhong)
end
GO
/****** Object:  StoredProcedure [dbo].[themPhieuThueedm]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themPhieuThueedm](
	@MaPhieuThue varchar(10),
	@MaNhanVien Varchar(10),
	@MaKhachHang nvarchar(10),
	@SoNguoi int,
	@KhachNuocNgoai varchar(5)
	
	)

	as begin 
	insert into PhieuThuePhong values(
	@MaPhieuThue ,
	@MaNhanVien ,
	@MaKhachHang ,
	@SoNguoi ,
	@KhachNuocNgoai 
	)
	end
GO
/****** Object:  StoredProcedure [dbo].[themPhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themPhong]
(
	@MaPhong nvarchar(10),
	@MaloaiPhong nvarchar(10),
	@MaTinhTrang varchar(50),
	@GhiChu nvarchar(50)
)

	as begin
	insert into Phong values (@MaPhong,@MaloaiPhong,@MaTinhTrang,@GhiChu)
	end
GO
/****** Object:  StoredProcedure [dbo].[TienDV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TienDV](
	@maDS nvarchar(50)
	)
as begin
select sum(cast (c.DonGia as float)) from DanhSachDichVu a, DV b , LoaiDV c where a.MaDanhSach=b.MaDanhSach and b.MaLoaiDV=c.MaLoaiDV 
and a.MaDanhSach=@maDS
group by b.MaDanhSach
end
GO
/****** Object:  StoredProcedure [dbo].[update_CTPhieuThue]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_CTPhieuThue](
	@SoPhieuThue int,
	@MaPhieuThue varchar(10),
	@MaPhong		nvarchar(10),
	@NgayDangKiPhong	datetime,
	@NgayNhanPhong	datetime
)
as
begin
update CT_PhieuThue set MaPhieuThue=@MaPhieuThue,MaPhong=@MaPhong,NgayDangKiPhong=@NgayDangKiPhong,NgayNhanPhong=@NgayNhanPhong

where SoPhieuThue=@SoPhieuThue
end
GO
/****** Object:  StoredProcedure [dbo].[update_danhsachDV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_danhsachDV]
 (@MaDanhSach nvarchar(50),
 @SoPhieuTheu int)
as begin

update DanhSachDichVu set SoPhieuThue=@SoPhieuTheu where MaDanhSach=@MaDanhSach
end
GO
/****** Object:  StoredProcedure [dbo].[update_mk]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_mk](
	
	@TenDangNhap varchar(20),
	@MatKhau nvarchar(50)

	)
	as
	begin
	update TaiKhoan set MatKhau=@MatKhau where TenDangNhap=@TenDangNhap
	end
GO
/****** Object:  StoredProcedure [dbo].[update_Nguoidung]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_Nguoidung]
@TenDangNhap varchar(20),
@MatKhau varchar(100),
@Quyen int,
@gmail nvarchar(100)
as begin
update TaiKhoan set  MatKhau=@MatKhau,Quyen=@Quyen,Gmail=@gmail where TenDangNhap=@TenDangNhap

end
GO
/****** Object:  StoredProcedure [dbo].[update_PhieuThue]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_PhieuThue](
	@MaPhieuThue varchar(10),
	@MaNhanVien varchar(10),
	@MaKhachHang nvarchar(10),
	@SoNguoi int,
	@NguoiNuocNgoai varchar(5)
)
as
begin

update PhieuThuePhong set MaNhanVien=@MaNhanVien,MaKhachHang=@MaKhachHang,
	SoNguoi=@SoNguoi,
	KhachNuocNgoai=@NguoiNuocNgoai
	where MaPhieuThue=@MaPhieuThue
end
GO
/****** Object:  StoredProcedure [dbo].[update_Phong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_Phong](
 @maphong nvarchar(50),
 @matinhtrang nvarchar(50),
 @ghichu nvarchar(50)
)
as begin
update Phong set MaTinhTrang=@matinhtrang,GhiChu=@ghichu where MaPhong=@maphong
end
GO
/****** Object:  StoredProcedure [dbo].[update_TinhTrangPhongCuaPhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_TinhTrangPhongCuaPhong](
	@MaPhong Nvarchar(10),
	@tinhtrangphong nvarchar(10),
	@ghichu nvarchar(50)


)
as begin
update Phong set MaTinhTrang=@tinhtrangphong,GhiChu=@ghichu where MaPhong=@MaPhong
end
GO
/****** Object:  StoredProcedure [dbo].[updateCtPhieuNhan]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateCtPhieuNhan](
	@SoPhieuNhan int,
	@MaNhanPhong varchar(10),
	@MaPhong nvarchar(10),
	@MaKhachHang nvarchar(10),
	@NgayNhanPhong datetime,
	@NgayTra dateTime

)
as begin
update  CT_PhieuNhan set @MaNhanPhong=@MaNhanPhong,
MaPhong=@MaPhong,MaKhachHang=@MaKhachHang,NgayNhanPhong=@NgayNhanPhong,NgayTra=@NgayTra
where SoPhieuNhan=@SoPhieuNhan


end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePhieuNhan]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePhieuNhan](
	@MaNhanPhong varchar(10),
	@MaKhachHang nvarchar(10),
	@MaPhieuThue varchar(10)

)
as
begin
	update PhieuNhanPhong set MaKhachHang=@MaKhachHang,MaPhieuThue=@MaPhieuThue where MaNhanPhong=@MaNhanPhong
end
GO
/****** Object:  StoredProcedure [dbo].[updatePhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[updatePhong]
(
	@MaPhong nvarchar(10),
	@MaloaiPhong nvarchar(10),
	@MaTinhTrang varchar(50),
	@GhiChu nvarchar(50)
)

	as begin
	update  Phong set MaLoaiPhong=@MaloaiPhong,MaTinhTrang=@MaTinhTrang,GhiChu=@GhiChu  Where MaPhong=@MaPhong
	end
GO
/****** Object:  StoredProcedure [dbo].[UpdateThemPhieuDangKi]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateThemPhieuDangKi](
	
	@MaChiTietPhieuThue int,
	@MaPhieuThue varchar(10),
	@MaPhong nvarchar(10),
	@NgayDangKiPhong	datetime,
	@NgayNhanPhong	datetime
)
as begin
	update  CT_PhieuThue set MaPhieuThue=@MaPhieuThue ,MaPhong=@MaPhong,NgayDangKiPhong=@NgayDangKiPHong ,
	NgayNhanPhong=@NgayNhanPhong where MaChiTietPhieuThue=@MaChiTietPhieuThue
	
end
GO
/****** Object:  StoredProcedure [dbo].[updateTT]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateTT]
@MaTinhTrang varchar(50),
@TenTinhTrang nvarchar(50)
as begin
update TinhTrangPhong set TenTinhTrang=@TenTinhTrang where MaTinhTrang=@MaTinhTrang
end
GO
/****** Object:  StoredProcedure [dbo].[xoaDV]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaDV]
	@MaDV nvarchar(50)
	as begin
	delete DV where MaDV=@MaDV
	end
GO
/****** Object:  StoredProcedure [dbo].[xoakhachhang]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoakhachhang] 
@MaKhachHang nvarchar(10)
as begin
delete  from KhachHang where MaKhachHang=@MaKhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[XoaLoaiKhachHang]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[XoaLoaiKhachHang](
	@QuocTich nvarchar(10)	
)
as begin
	delete from LoaiKhachHang Where QuocTich=@QuocTich
end
GO
/****** Object:  StoredProcedure [dbo].[xoaLoaiPhong]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaLoaiPhong]
@MaLoaiPhong nvarchar(10)
as begin
delete  from LoaiPhong where MaLoaiPhong=@MaLoaiPhong
end
GO
/****** Object:  StoredProcedure [dbo].[xoanhanvienn]    Script Date: 7/18/2020 3:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoanhanvienn]
@MaNhanVien varchar(10)
as begin
delete  from NhanVien where MaNhanVien=@MaNhanVien
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhachSan_Update] SET  READ_WRITE 
GO
