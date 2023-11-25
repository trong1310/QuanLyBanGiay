CREATE DATABASE QLBanGiayTheThao_DuAn1
USE QLBanGiayTheThao_DuAn1
go
CREATE TABLE ChucVu
(
	idChucVu  uniqueidentifier primary key ,
	MaCV varchar(10) not null ,
	TenChucVu nvarchar(50) not null,
)
INSERT INTO ChucVu (idChucVu, MaCV, TenChucVu)
VALUES ('00000000-0000-0000-0000-000000000001', 'CV001', N'Quản lý'),
       ('00000000-0000-0000-0000-000000000002', 'CV002', N'Nhân viên')
     
go
CREATE TABLE CaLamViec
(
	idCaLamViec  uniqueidentifier primary key ,
	MaCa varchar(10) not null,
	ThoiGian datetime not null,
	TrangThai nvarchar(30) not null,
)
INSERT INTO CaLamViec (idCaLamViec, MaCa, ThoiGian, TrangThai)
VALUES ('00000000-0000-0000-0000-000000000001', 'CLV001', '2023-11-24 08:00:00', N'Đang làm việc'),
       ('00000000-0000-0000-0000-000000000002', 'CLV002', '2023-11-24 13:30:00', N'Đang làm việc'),
       ('00000000-0000-0000-0000-000000000003', 'CLV003', '2023-11-24 18:00:00',N'Đang làm việc')

CREATE TABLE NhanVien
(
	idNhanVien uniqueidentifier primary key,
	MaNV varchar(10) not null, 
	TenNhanVien nvarchar(50) not null,
	SoDienThoai varchar(15) not null,
	Email nvarchar(50) not null,
	GioiTinh varchar(10) not null,
	NgaySinh date not null,
	DiaChi nvarchar(250) not null,
	MatKhau nvarchar(30) not null,
	TrangThai nvarchar(30) not null,
	MaChucVu uniqueidentifier foreign key references ChucVu(idChucVu),
	MaCa uniqueidentifier foreign key references CaLamViec(idCaLamViec)
)
INSERT INTO NhanVien (idNhanVien, MaNV, TenNhanVien, SoDienThoai, Email, GioiTinh, NgaySinh, DiaChi, MatKhau, TrangThai, MaChucVu, MaCa)
VALUES ('00000000-0000-0000-0000-000000000001', 'admin', N'Nguyễn Văn A', '0901234567', 'nguyenvana@example.com', 'Nam', '1990-01-01', N'Hà Nội', '123', N'Đang làm việc', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001'),
       ('00000000-0000-0000-0000-000000000002', 'NV002', N'Nguyễn Thị B', '0909876543', 'nguyenthib@example.com', 'Nữ', '1995-02-15', N'Hồ Chí Minh', 'password', N'Đang làm việc', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002'),
       ('00000000-0000-0000-0000-000000000003', 'NV003', N'Trần Văn C', '0912345678', 'tranvanc@example.com', 'Nam', '1992-06-30', N'Đà Nẵng', 'password', N'Đang làm việc', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002');

CREATE TABLE SanPham
(
	idSanPham uniqueidentifier primary key,
	MaSP varchar(10) not null,
	TenSanPham nvarchar(250) not null,
	NgayNhap date not null,
	SoLuong int not null,
	TrangThai nvarchar(30) not null,
)
INSERT INTO SanPham (idSanPham, MaSP, TenSanPham, NgayNhap, SoLuong, TrangThai)
VALUES ('00000000-0000-0000-0000-000000000001', 'SP001', N'Sản phẩm 1', '2023-11-24', 10, N'Đang bán'),
       ('00000000-0000-0000-0000-000000000002', 'SP002', N'Sản phẩm 2', '2023-11-25', 5, N'Đang bán'),
       ('00000000-0000-0000-0000-000000000003', 'SP003', N'Sản phẩm 3', '2023-11-26', 8, N'Hết hàng');
CREATE TABLE MauSac
(
	idMauSac uniqueidentifier primary key,
	MaMau varchar(10) not null,
	TenMau nvarchar(50) not null,
	TrangThai nvarchar(30) not null
)
INSERT INTO MauSac (idMauSac, MaMau, TenMau, TrangThai)
VALUES ('00000000-0000-0000-0000-000000000001', 'M001', N'Màu đen', N'Đang sử dụng'),
       ('00000000-0000-0000-0000-000000000002', 'M002', N'Màu trắng', N'Đang sử dụng'),
       ('00000000-0000-0000-0000-000000000003', 'M003', N'Màu xanh', N'Ngừng sử dụng');
CREATE TABLE Size
(
	idSize uniqueidentifier primary key,
	MaSize varchar(10) not null,
	KichThuoc nvarchar(50) not null,
	TrangThai nvarchar(30) not null
)
INSERT INTO Size (idSize, MaSize, KichThuoc, TrangThai)
VALUES ('00000000-0000-0000-0000-000000000001', 'S001', N'Nhỏ', N'Đang sử dụng'),
       ('00000000-0000-0000-0000-000000000002', 'M001', N'Trung bình', N'Đang sử dụng'),
       ('00000000-0000-0000-0000-000000000003', 'L001', N'Lớn', N'Ngừng sử dụng');
CREATE TABLE ChatLieu
(
	idChatlieu uniqueidentifier primary key,
	MaChatLieu varchar(10) not null,
	LoaiChatLieu nvarchar(50) not null,
	TrangThai nvarchar(30) not null
)
INSERT INTO ChatLieu (idChatLieu, MaChatLieu, LoaiChatLieu, TrangThai)
VALUES ('00000000-0000-0000-0000-000000000001', 'CL001', N'Vải', N'Đang sử dụng'),
       ('00000000-0000-0000-0000-000000000002', 'CL002', N'Nhựa', N'Đang sử dụng'),
       ('00000000-0000-0000-0000-000000000003', 'CL003', N'Gỗ', N'Ngừng sử dụng');
CREATE TABLE ThuongHieu
(
	idThuongHieu uniqueidentifier primary key,
	MaTH varchar(10) not null,
	TenThuongHieu nvarchar(50) not null,
	TrangThai nvarchar(30) not null
)
INSERT INTO ThuongHieu (idThuongHieu, MaTH, TenThuongHieu, TrangThai)
VALUES ('00000000-0000-0000-0000-000000000001', 'TH001', N'Thương hiệu A', N'Đang hoạt động'),
       ('00000000-0000-0000-0000-000000000002', 'TH002', N'Thương hiệu B', N'Ngừng hoạt động'),
       ('00000000-0000-0000-0000-000000000003', 'TH003', N'Thương hiệu C', N'Đang hoạt động');
CREATE TABLE ChiTietSanPham
(
	idChiTietSp uniqueidentifier primary key,
	MASPCT varchar(10) not null ,
	Gia float not null,
	SoLuong int not null,
	MaSP uniqueidentifier foreign key references SanPham(idSanPham),
	MaMau uniqueidentifier foreign key references MauSac(idMauSac),
	MaSize uniqueidentifier foreign key references Size(idSize),
	MaChatLieu uniqueidentifier foreign key references ChatLieu(idChatLieu),
	MaTH uniqueidentifier foreign key references ThuongHieu(idThuongHieu)
); 
INSERT INTO ChiTietSanPham (idChiTietSp, MASPCT, Gia, SoLuong, MaSP, MaMau, MaSize, MaChatLieu, MaTH)
VALUES ('00000000-0000-0000-0000-000000000001', 'SP001', 10.99, 5, '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001'),
       ('00000000-0000-0000-0000-000000000002', 'SP002', 19.99, 3, '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002'),
       ('00000000-0000-0000-0000-000000000003', 'SP003', 29.99, 2, '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000003');
CREATE TABLE Voucher
(
	idVouCher uniqueidentifier primary key,
	MaVoucher varchar(10) not null,
	TenVoucher nvarchar(50) not null,
	MoTa nvarchar(250) not null,
	TrangThai varchar(30) not null,
	NgayBatDau date not null,
	NgayKetThuc date not null,

)
INSERT INTO Voucher (idVoucher, MaVoucher, TenVoucher, MoTa, TrangThai, NgayBatDau, NgayKetThuc)
VALUES ('00000000-0000-0000-0000-000000000001', 'VC001', N'Voucher A', N'Voucher giảm giá 10%', 'Hoạt động', '2023-01-01', '2023-12-31'),
       ('00000000-0000-0000-0000-000000000002', 'VC002', N'Voucher B', N'Voucher miễn phí vận chuyển', 'Hoạt động', '2023-06-01', '2023-06-30'),
       ('00000000-0000-0000-0000-000000000003', 'VC003', N'Voucher C', N'Voucher giảm 20% cho sản phẩm mới', 'Ngừng hoạt động', '2023-03-15', '2023-03-31');

CREATE TABLE KhachHang
(
	idKhachHang uniqueidentifier primary key,
	SDT varchar(10) not null,
	Diem float not null
)
INSERT INTO KhachHang (idKhachHang, SDT, Diem)
VALUES ('00000000-0000-0000-0000-000000000001', '0123456789', 1000),
       ('00000000-0000-0000-0000-000000000002', '0987654321', 500),
       ('00000000-0000-0000-0000-000000000003', '0369852147', 750.5);
CREATE TABLE RANKS
(
	RankID varchar(10) primary key ,
	DieuKien nvarchar(100) not null,
	MucUuDai varchar(100) not null,
	TrangThai nvarchar(30) not null,
	MoTa nvarchar(250) not null,
	MaKh uniqueidentifier foreign key references KhachHang(idKhachHang)
)
INSERT INTO RANKS (RankID, DieuKien, MucUuDai, TrangThai, MoTa, MaKh)
VALUES ('R001', N'Điểm tích lũy từ 1000 trở lên', 'Giảm giá 10% cho tất cả sản phẩm', N'Hoạt động', N'Rank A', '00000000-0000-0000-0000-000000000001'),
       ('R002', N'Điểm tích lũy từ 500 đến 999', 'Giảm giá 5% cho tất cả sản phẩm', N'Hoạt động', N'Rank B', '00000000-0000-0000-0000-000000000002'),
       ('R003', N'Điểm tích lũy dưới 500', 'Không có ưu đãi đặc biệt', N'Ngừng hoạt động', N'Rank C', '00000000-0000-0000-0000-000000000003');
create TABLE HoaDon
(
	idHoaDon uniqueidentifier primary key,
	MaHD varchar(10) not null,
	NgayTao date not null,
	TrangThai nvarchar(30) not null,
	TongTien float not null,
	TongTienSauVoucher float not null,
	MaSp uniqueidentifier foreign key references SanPham(idSanPham),
	MaVoucher uniqueidentifier foreign key references VouCher(idVouCher),
	MaNV uniqueidentifier foreign key references NhanVien(idNhanVien),
	MaKh uniqueidentifier foreign key references KhachHang(idKhachHang)
)
INSERT INTO HoaDon (idHoaDon, MaHD, NgayTao, TrangThai, TongTien, TongTienSauVoucher, MaSp, MaVoucher, MaNV, MaKh)
VALUES ('00000000-0000-0000-0000-000000000001', 'HD001', '2023-11-24', N'Đã thanh toán', 500000, 450000, '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001'),
       ('00000000-0000-0000-0000-000000000002', 'HD002', '2023-11-23', N'Đã thanh toán', 750000, 700000, '00000000-0000-0000-0000-000000000002', NULL, '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000002'),
       ('00000000-0000-0000-0000-000000000003', 'HD003', '2023-11-22', N'Chưa thanh toán', 1000000, 950000, '00000000-0000-0000-0000-000000000003', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000003');

CREATE TABLE HoaDonChiTiet
(
	idHoaDonCT uniqueidentifier primary key,
	MaHDCT varchar(10) not null,
	SoLuong int not null,
	DonGia float not null,
	GhiChu nvarchar(250) not null,
	MaHD uniqueidentifier foreign key references HoaDon(idHoaDon)
)
INSERT INTO HoaDonChiTiet (idHoaDonCT, MaHDCT, SoLuong, DonGia, GhiChu, MaHD)
VALUES ('00000000-0000-0000-0000-000000000001', 'HDCT001', 2, 100000, N'Ghi chú 1', '00000000-0000-0000-0000-000000000001'),
       ('00000000-0000-0000-0000-000000000002', 'HDCT002', 3, 150000, N'Ghi chú 2', '00000000-0000-0000-0000-000000000001'),
       ('00000000-0000-0000-0000-000000000003', 'HDCT003', 1, 50000, N'Ghi chú 3', '00000000-0000-0000-0000-000000000002');

CREATE TABLE Doi
(	
	idDoi uniqueidentifier primary key,
	MaDoi varchar(10) not null,
	TrangThai nvarchar(10) not null,
	NgayDoi date not null,
	LyDo nvarchar(250) not null,
	DoiSangSp nvarchar(100) not null,
	MaHDCT uniqueidentifier foreign key references HoaDonChiTiet(idHoaDonCT)
)

Create table Tra
(	
	idTra uniqueidentifier primary key,
	MaTra varchar(10) not null,
	TrangThai nvarchar(10) not null,
	NgayDoi date not null,
	LyDo nvarchar(250) not null,
	MaHDCT uniqueidentifier foreign key references HoaDonChiTiet(idHoaDonCT)
)

go
Create TABLE THONGKE
(
	idThongKe uniqueidentifier primary key,
	MaThongKe varchar(10) not null,
	NgayThongKe date not null,
	TongDoanhThu nvarchar(40) not null,
	SoLuong int not null,
	MaHD uniqueidentifier foreign key references HoaDon(idHoaDon),
	MaNv uniqueidentifier foreign key references NhanVien(idNhanVien)
)
	INSERT INTO Doi (idDoi, MaDoi, TrangThai, NgayDoi, LyDo, DoiSangSp, MaHDCT)
VALUES ('00000000-0000-0000-0000-000000000001', 'DOI001', N'Hoạt động', '2023-11-24', N'Lỗi sản phẩm', N'SP001', '00000000-0000-0000-0000-000000000001'),
       ('00000000-0000-0000-0000-000000000002', 'DOI002', N'Hoạt động', '2023-11-23', N'Sai size', N'SP002', '00000000-0000-0000-0000-000000000002');

INSERT INTO Tra (idTra, MaTra, TrangThai, NgayDoi, LyDo, MaHDCT)
VALUES ('00000000-0000-0000-0000-000000000003', 'TRA001', N'Hoạt động', '2023-11-22', N'Sản phẩm không đúng', '00000000-0000-0000-0000-000000000003');

INSERT INTO THONGKE (idThongKe, MaThongKe, NgayThongKe, TongDoanhThu, SoLuong, MaHD, MaNv)
VALUES ('00000000-0000-0000-0000-000000000004', 'TK001', '2023-11-21', N'5000000', 10, '00000000-0000-0000-0000-000000000001', '00000000-0000-0000-0000-000000000001'),
       ('00000000-0000-0000-0000-000000000005', 'TK002', '2023-11-20', N'7500000', 15, '00000000-0000-0000-0000-000000000002', '00000000-0000-0000-0000-000000000001');