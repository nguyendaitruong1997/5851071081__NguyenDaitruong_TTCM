create database QuanLyKhachSan_Se
go
use QuanLyKhachSan_Se
go
create table LoaiKhachHang(
	QuocTich nvarchar(10),
	GhiChu   nvarchar(50),
	primary key(QuocTich)
)
go
create table KhachHang(
	MaKhachHang nvarchar(10),
	QuocTich	nvarchar(10),
	TenKhachHang nvarchar(20),
	CMND varchar(10),
	GioiTinh nvarchar,
	DiaChi nvarchar(50),
	SDT varchar(11),
	foreign key (QuocTich) references LoaiKhachhang(QuocTich),
	primary key (MaKhachHang)
)
go
create table LoaiPhong(
	MaLoaiPhong nvarchar(10),
	TenLoaiPhong nvarchar(50),
	DonGia int,
	SoNguoiChuan int,
	SoNguoiToiDa int,
	TiLeTang float,
	primary key(MaLoaiPhong)
)
create table TinhTrangPhong(
	MaTinhTrang varchar(50),
	TenTinhTrang nvarchar(50),
	primary key(MaTinhTrang)
)
go
go
create table Phong(
	MaPhong nvarchar(10),
	MaloaiPhong nvarchar(10),
	MaTinhTrang varchar(50),
	GhiChu nvarchar(50),
	foreign key (MaLoaiPhong) references LoaiPhong(MaLoaiPhong),
	foreign key (MaTinhTrang) references TinhTrangPhong(MaTinhTrang),
	primary key (MaPhong)
)
create table NhanVien(
	MaNhanVien varchar(10),
	TenNhanVien nvarchar(50),
	GioiTinh	nvarchar(10),
	QueQuan		nvarchar(50),
	NgaySinh	nvarchar(50),
	primary key(MaNhanVien),
)
go
create table PhieuThuePhong(
	MaPhieuThue varchar(10),
	MaNhanVien varchar(10),
	MaKhachHang nvarchar(10),
	foreign key (MaKhachHang) references KhachHang(MaKhachHang),
	foreign key (MaNhanVien) references NhanVien(MaNhanVien),
	primary key(MaPhieuThue)
)
go
create table ChinhSachTraPhong(
	MaChinhSach varchar(10),
	ThoiGianQuyDinh datetime,
	PhuThu int,
	primary key(MaChinhSach	)
)
go

create table PhieuNhanPhong(
	
	MaNhanPhong varchar(10),
	MaKhachHang nvarchar(10),
	MaPhieuThue varchar(10),
	foreign key (MaKhachHang) references KhachHang(MaKhachHang),
	foreign key (MaPhieuThue) references PhieuThuePhong(MaPhieuThue),

	primary key(MaNhanPhong)
)
go
create table HoaDon(
	MaHoaDon varchar(10),
	MaNhanVien varchar(10),
	MaKhachHang nvarchar(10),
	MaNhanPhong varchar(10),
	TongTien int,
	NgayLap datetime,
	foreign key (MaKhachHang) references KhachHang(MaKhachHang),
	foreign key (MaNhanVien) references NhanVien(MaNhanVien),
	foreign key (MaNhanPhong) references PhieuNhanPhong(MaNhanPhong),
	primary key(MaHoaDon)
)
go
create table CT_HoaDon(
	MaHoaDon varchar(10),
	MaPhong nvarchar(10),
	MaChinhSach varchar(10),
	HinhThucThanhToan nvarchar(20),
	SoNgay int,
	TienPhong int,
	PhuThu int,
	ThanhTien int,
	foreign key (MaHoaDon) references HoaDon(MaHoaDon),
	foreign key (MaPhong) references Phong(MaPhong),
	foreign key (MaChinhSach) references ChinhSachTraPhong(MaChinhSach),
	primary key(MaHoaDon,MaPhong,MaChinhSach),
)
go
create table CT_PhieuNhan(

	MaNhanPhong varchar(10),
	MaPhong nvarchar(10),
	MaKhachHang nvarchar(10),
	NgayTraDuKien datetime,
	NgayTraThucTe date,
	foreign key (MaNhanPhong) references PhieuNhanPhong(MaNhanPhong),
	foreign key (MaPhong) references Phong(MaPhong),
	foreign key (MaKhachHang) references KhachHang(MaKhachHang),
	primary key(MaNhanPhong,MaPhong,MaKhachHang)
)
go
Create table CT_PhieuThue(
	MaPhieuThue varchar(10),
	MaPhong		nvarchar(10),
	NgayDangKiPhong	datetime,
	NgayNhanPhong	datetime,
	foreign key (MaPhieuThue) references PhieuThuePhong(MaPhieuThue),
	foreign key (MaPhong) references Phong(MaPhong),
)
create table TaiKhoan(
	TenDangNhap varchar(20),
	MatKhau		varchar(20),
	Quyen int,
	primary key(TenDangNhap)
)


