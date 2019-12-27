

CREATE DATABASE QuanLyKhachSan
go
USE QuanLyKhachSan
go

 CREATE TABLE ThongTinTaiKhoan
 (
	ID INT PRIMARY KEY,
	[Tên đăng nhập] NVARCHAR(MAX),
	[Mật khẩu] NVARCHAR(MAX),
	[Họ và tên] NVARCHAR(MAX),
	[Địa chỉ] NVARCHAR(MAX),
	[Số điện thoại] NVARCHAR(MAX),
 )

 CREATE TABLE ThongTinKhachSan
 (
	ID INT PRIMARY KEY,
	[Tên khách sạn] NVARCHAR(MAX),
	[Địa chỉ khách sạn] NVARCHAR(MAX),
	[Số điện thoại khách sạn] NVARCHAR(MAX),
	[ID chủ khách sạn] INT, 
	Email nvarchar(MAX)
 )

 CREATE TABLE LoaiPhong
 (
	ID INT PRIMARY KEY,
	[Tên loại phòng] NVARCHAR(MAX),
	[Số lượng người ở] INT,
	[Giá phòng] INT,
	[ID khách sạn] INT 
 )

 CREATE TABLE Tang
 (
	ID INT PRIMARY KEY,
	[Tên tầng] NVARCHAR(MAX),
	[ID khách sạn] INT 
 )

 CREATE TABLE Phong
 (
	 ID INT PRIMARY KEY,
	 [Tên Phòng] NVARCHAR(MAX),
	 [Trạng thái] NVARCHAR(MAX),
	 [ID khách sạn]INT ,
	 [ID loại phòng] INT ,
	 [ID tầng] INT 
	 	
 )

 CREATE TABLE LoaiDichVu
 (
	ID INT PRIMARY KEY,
	[Tên dịch vụ] NVARCHAR(MAX),
	[Giá dịch vụ] INT,
	[Group dịch vụ] NVARCHAR(MAX)
 )

 
 CREATE TABLE KhachHang
 (
	ID INT primary key,
	[Họ tên] NVARCHAR(MAX),
	CMND NVARCHAR(MAX) ,
	[Số điện thoại] NVARCHAR(MAX)
 )

 CREATE TABLE Bill
 (
	[ID phòng] int,
	[Tên dịch vụ] NVARCHAR(MAX),
	[Số lượng] int,
	[Đơn giá] int,
	[Thành tiền] int
 )
 ALTER TABLE Phong ADD [ID khách hàng] INT
 ALTER TABLE Phong ADD [Thời gian đến] SMALLDATETIME
 ALTER TABLE Phong ADD [Thời gian đi] SMALLDATETIME
 ALTER TABLE Phong ADD [Tổng tiền] INT
 ALTER TABLE Phong ADD [Số tiền đặt cọc] INT

 INSERT INTO LoaiPhong VALUES ('1',N'Phòng đơn','1','70000','1')
 INSERT INTO LoaiPhong VALUES ('2',N'Phòng đôi 1 giường','2','70000','1')
 INSERT INTO LoaiPhong VALUES ('3',N'Phòng đôi 2 giường','2','70000','1') 
 INSERT INTO LoaiPhong VALUES ('4',N'Phòng Vip','2','70000','1')

