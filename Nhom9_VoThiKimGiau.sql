create database THHQTCSDL_QLBS

use THHQTCSDL_QLBS

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    MaKH CHAR(5),
    TenKH NVARCHAR(50),
    DiaChi NVARCHAR(100),
    SDT VARCHAR(15),
    Email VARCHAR(50),
	CONSTRAINT PK_KhachHang PRIMARY KEY (MaKH)
)

-- Tạo bảng TacGia
CREATE TABLE TacGia (
    MaTG char(5),
    TenTG NVARCHAR(100),
	CONSTRAINT PK_TacGia PRIMARY KEY (MaTG)
)

-- Tạo bảng DanhMucSach
CREATE TABLE DanhMucSach (
    MaDanhMuc char(5),
    TenDanhMuc NVARCHAR(100),
	CONSTRAINT PK_DanhMucSach PRIMARY KEY (MaDanhMuc)
)

-- Tạo bảng Sach
CREATE TABLE Sach (
    MaSach CHAR(5),
    MaTG CHAR(5),
    MaDanhMuc CHAR(5),
    GiaBan DECIMAL(10,2),
    SLKho INT,
    TenSach NVARCHAR(200),
	CONSTRAINT PK_Sach PRIMARY KEY (MaSach)
)

-- Tạo bảng DonHang
CREATE TABLE DonHang (
    MaDH CHAR(5),
    MaKH CHAR(5),
    NgayDat DATE,
    TongTien DECIMAL(10,2),
	CONSTRAINT PK_DonHang PRIMARY KEY (MaDH)
)

-- Tạo bảng ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    MaCTDH CHAR(5),
	MaDH CHAR(5),
    MaSach CHAR(5),
    SoLuong INT,
    GiaBan DECIMAL(10,2),
	CONSTRAINT PK_ChiTietDonHang PRIMARY KEY (MaCTDH)
)

-- Khóa ngoại
alter table Sach
add constraint FK_Sach_TacGia foreign key (MaTG) references TacGia(MaTG),
constraint FK_Sach_DanhMucSach foreign key (MaDanhMuc) references DanhMucSach(MaDanhMuc)

alter table DonHang
add constraint FK_DonHang_KhachHang foreign key (MaKH) references KhachHang(MaKH)

alter table ChiTietDonHang
add constraint FK_ChiTietDonHang_Sach foreign key (MaSach) references Sach(MaSach),
constraint FK_ChiTietDonHang_DonHang foreign key (MaDH) references DonHang(MaDH)

-- Thêm dữ liệu vào bảng
insert into KhachHang values
('KH001', N'Nguyễn Văn Hòa', N'140 Tây Thạnh, Tân Phú, TPHCM', '0941824972', 'nguyenhoa@gmail.com'),
('KH002', N'Trần Hoàng Thịnh', N'121 Nguyễn Quý Anh, Tân Sơn Nhì, TPHCM', '0837528458', 'tranthinh@gmail.com'),
('KH003', N'Trần Thu Hằng', N'66 Đường số 11, Bình Hưng, Bình Chánh, TPHCM', '0736537149', 'thutran@gmail.com'),
('KH004', N'Võ Thùy Trang', N'986 Tạ Quang Bửu, Phường 6, Quận 8, TPHCM', '0283941023', 'trangvo@gmail.com'),
('KH005', N'Hồ Văn Trung', N'66/34 Phổ Quang, Phường 2, Tân Bình, TPHCM', '0637459206', 'trungho@gmail.com'),
('KH006', N'Nguyễn Thị Thùy My', N'7/6 Bùi Thị Xuân, Phường 2, Tân Bình, TPHCM', '0372857495', 'mynguyen@gmail.com')

insert into TacGia values
('TG001', N'Trương Học Vĩ'),
('TG002', N'Carol S. Dweck'),
('TG003', N'Thích Nhất Hạnh'),
('TG004', N'Phùng Quán'),
('TG005', N'Hae Min'),
('TG006', N'Koga Fumitake, Kishimi Ichiro'),
('TG007', N'John Perkins'),
('TG008', N'Cal Newport'),
('TG009', N'Nhiều Tác Giả'),
('TG010', N'Raymond Murphy')

insert into DanhMucSach values
('KNN', N'Kĩ năng sống'),
('VH', N'Văn học'),
('KT', N'Kinh tế'),
('NN', N'Ngoại ngữ')

insert into Sach values
('SH001', 'TG001', 'KNN', 92.400, 10, N'Ổn Định Hay Tự Do'),
('SH002', 'TG002', 'KNN', 183.650, 15, N'Tâm Lý Học Thành Công'),
('SH003', 'TG003', 'KNN', 74.000, 7, N'Không Diệt Không Sinh Đừng Sợ Hãi'),
('SH004', 'TG004', 'VH', 59.500, 20, N'Tuổi Thơ Dữ Dội - Tập 1'),
('SH005', 'TG005', 'VH', 104.300, 10, N'Yêu Những Điều Không Hoàn Hảo'),
('SH008', 'TG006', 'VH', 67.000, 5, N'Dám Bị Ghét'),
('SH006', 'TG007', 'KT', 143.000, 11, N'Lời Thú Tội Mới Của Một Sát Thủ Kinh Tế'),
('SH007', 'TG008', 'KT', 110.000, 17, N'Làm Ra Làm, Chơi Ra Chơi'),
('SH009', 'TG009', 'NN', 74.000, 25, N'i-Learn Smart Start Grade 5 Workbook'),
('SH010', 'TG010', 'NN', 163.800, 12, N'English Grammar in Use Book w Ans')

insert into DonHang values
('DH001', 'KH001', '2023-10-16', 92.400),
('DH002', 'KH002', '2023-11-25', 74.000),
('DH003', 'KH003', '2023-10-13', 143.000),
('DH004', 'KH004', '2023-11-23', 256.200),
('DH005', 'KH005', '2023-10-11', 67.000),
('DH006', 'KH006', '2023-10-10', 183.650),
('DH007', 'KH003', '2023-10-19', 59.500),
('DH008', 'KH005', '2023-11-29', 214.300)

insert into ChiTietDonHang values
('CT001', 'DH001', 'SH001', 1, 92.400),
('CT002', 'DH002', 'SH003', 1, 74.000),
('CT003', 'DH003', 'SH006', 2, 143.000),
('CT004', 'DH004', 'SH001', 1, 92.400),
('CT005', 'DH004', 'SH010', 2, 163.800),
('CT006', 'DH005', 'SH008', 3, 67.000),
('CT007', 'DH006', 'SH002', 2, 183.650),
('CT008', 'DH007', 'SH004', 1, 59.500),
('CT009', 'DH008', 'SH005', 1, 104.300),
('CT010', 'DH008', 'SH007', 1, 110.000)

/*2001210714 - Võ Thị Kim Giàu*/
/*Table TacGia, DanhMucSach, Sach*/

-- Các ràng buộc
alter table TacGia
add constraint UNI_TenTG unique (TenTG)

alter table DanhMucSach
add constraint UNI_TenDanhMuc unique (TenDanhMuc)

alter table Sach
add constraint CK_GiaBan check (GiaBan >= 0),
constraint UNI_TenSach unique (TenSach),
constraint CK_SLKho check (SLKho >= 0)

-- ==================================== Phân quyền ====================================
-- Tạo 2 nhóm quyền admin, customer
use THHQTCSDL_QLBS
exec sp_addrole 'Admin'

use THHQTCSDL_QLBS
exec sp_addrole 'Customer'

-- Cấp quyền cho mỗi nhóm
use THHQTCSDL_QLBS
grant control
to Admin

use THHQTCSDL_QLBS
grant select
to Customer

-- Tạo 1 admin, 1 customer mặc định

-- Tạo tài khoản login
use THHQTCSDL_QLBS
exec sp_addlogin 'admin', 'admin@' 

use THHQTCSDL_QLBS
exec sp_addlogin 'customer', 'customer123' 

-- Tạo tài khoản user
use THHQTCSDL_QLBS
exec sp_adduser 'admin', 'admin1' 

use THHQTCSDL_QLBS
exec sp_adduser 'customer', 'customer1' 

-- add user admin1 vào nhóm quyền Admin
use THHQTCSDL_QLBS
exec sp_addrolemember 'Admin', 'admin1'

-- add user admin1 vào nhóm quyền Customer
use THHQTCSDL_QLBS
exec sp_addrolemember 'Customer', 'customer1'

-- Để làm bên winform
create table PQ
(
	userid int,
	username char(50),
	pass char(50),
	typeofuser char(10),
	constraint PK_PQ primary key (userid)
)
insert into PQ(userid, username, pass, typeofuser) values
(7, 'admin1', 'admin@', 'Admin'),
(8, 'customer1', 'customer123', 'Customer')
-- ==================================== Stored procedure + Cursor ====================================
-- ========================== Hiện thông tin sách ==========================
GO
create proc show_TTSach
as
begin
	print N'Mã sách' + ' - ' + N'Tên sách' + ' - ' + N'Giá bán' + ' - ' + N'Số lượng kho'
	
	declare @mash char(5), @tensh nvarchar(200), @gia decimal(10, 2), @sl int
	declare mycursor cursor for select MaSach, TenSach, GiaBan, SLKho from Sach
	open mycursor

	fetch next from mycursor into @mash, @tensh, @gia, @sl
	while @@FETCH_STATUS = 0
	begin
		print @mash + ' - ' + @tensh + ' - ' + convert(varchar(15), @gia) + ' - ' + convert(varchar(5), @sl)
			
		fetch next from mycursor into @mash, @tensh, @gia, @sl
	end;

	close mycursor
	deallocate mycursor

	return;
end;
GO

-- Thực thi
exec dbo.show_TTSach

-- Xem kiểm tra kết quả
select * from Sach
-- ========================== Update số lượng kho cùng số lượng cho nhiều sách ==========================
GO
create proc update_SLKho @sl int
as
begin
	declare @mash char(5)
	declare mycursor cursor for select MaSach from Sach
	open mycursor

	fetch next from mycursor into @mash
	while @@FETCH_STATUS = 0
	begin
		update Sach
		set SLKho = SLKho + @sl
		where MaSach = @mash
			
		fetch next from mycursor into @mash
	end;

	close mycursor
	deallocate mycursor

	return;
end;
GO

-- Thực thi
exec dbo.update_SLKho 10

-- Xem kiểm tra kết quả
select * from Sach
-- ==================================== Function ====================================
-- ===================== Tổng số sách còn lại trong kho =====================
GO
create function sum_SachTrongKho ()
returns int
as
begin
	declare @sl int

	select @sl = sum(SLKho)
	from Sach

	return @sl;
end;
GO

-- Thực thi
declare @sl int
set @sl = dbo.sum_SachTrongKho()
select @sl as N'Tổng số sách còn trong kho'
-- Xem kiểm tra kết quả
select * from Sach
-- ===================== Bảng thông tin sách =====================
GO
create function show_TTSachDD ()
returns @dss table (TenDanhMuc nvarchar(100), TenTG nvarchar(100), TenSach nvarchar(200), GiaBan decimal(10, 2), SLKho int)
as
begin
	insert into @dss
		select TenDanhMuc, TenTG, TenSach, GiaBan, SLKho
		from (Sach join TacGia tg on Sach.MaTG = tg.MaTG)
		join DanhMucSach dm on Sach.MaDanhMuc = dm.MaDanhMuc

	return;
end;
GO

-- Thực thi
select * from dbo.show_TTSachDD()

-- Xem kiểm tra kết quả
select * from Sach
select * from DanhMucSach
select * from TacGia
-- =====================================================================================================
/* - Nguyễn Hữu Thông*/
/*Table ChiTietDonHang*/
alter table ChiTietDonHang
add constraint Check_GiaBan check (GiaBan >= 0),
constraint Check_SL check (SoLuong >= 0)

--Tính tổng tiền
declare TinhTongTien cursor for
select MaDH,SoLuong,GiaBan
from ChiTietDonHang

open TinhTongTien

declare @ma char(5), @sl int, @gia DECIMAL(10,2)
fetch next from TinhTongTien into @ma, @sl,@gia

while @@FETCH_STATUS = 0
begin
	update DonHang
	set TongTien = @sl * @gia
	where MaDH = @ma
	fetch next from TinhTongTien into @ma, @sl,@gia
end

close TinhTongTien
deallocate TinhTongTien

select * from DonHang

--Giảm 5% giá bán cho số lượng trên 2
declare GiamGia  cursor for
select MaDH,SoLuong,GiaBan
from ChiTietDonHang

open GiamGia

declare @ma char(5), @sl int, @gia DECIMAL(10,2) -- Tên biến giống
fetch next from GiamGia into @ma, @sl,@gia

while @@FETCH_STATUS = 0
begin
	update ChiTietDonHang
	set GiaBan = @gia * 0.95
	where MaDH = @ma and @sl >=2
	fetch next from GiamGia into @ma, @sl,@gia
end

close GiamGia
deallocate GiamGia

select * from ChiTietDonHang

--Tên sách trong đơn hàng 
go
create proc TSachMua
	@ma char(5)
as
begin
	select TenSach
	from Sach
	where MaSach in (select MaSach 
					from ChiTietDonHang
					where MaDH = @ma) 
end
go

exec TSachMua 'DH008'

--Giá bán sách
go
create proc GBSach
	@ma char(5)
as
begin
	select TenSach, CTDH.GiaBan
	from Sach, ChiTietDonHang CTDH
	where Sach.MaSach = CTDH.MaSach and CTDH.MaDH = @ma
end
go

exec GBSach 'DH008'

--Đếm số lượng sách bán
go
create function SLSachBan()
returns int 
as
begin
	declare @sl int
	select @sl = SUM(SoLuong)
	from ChiTietDonHang
	return @sl
end
go

select dbo.SLSachBan() as SoLuongSachBan

--Đếm chi tiết trong đơn 
go
create function SLCT
(
	@ma char(5)
)
returns int 
as
begin
	declare @sl int
	select @sl = SUM(SoLuong)
	from ChiTietDonHang
	where MaDH = @ma
	return @sl
end
go

select dbo.SLCT('DH008') as SoLuongCTDH

go
create function TKThang ()
returns table
as
	return (SELECT MONTH(NgayDat) AS Thang, SUM(TongTien) AS TongTienThang
	FROM DonHang
	GROUP BY MONTH(NgayDat))
go

select * from dbo.TKThang()

go
create function DTKH()
returns table
as
	return(
	SELECT MaKH, SUM(TongTien) AS DoanhThu
	FROM DonHang
	GROUP BY MaKH
	)
go

select * from dbo.DTKH()

--2001215672_Nguyễn Khánh Duy
----------------------------------------RÀNG BUỘC CHECK-DEFAULT-UNIQUE-------------------------------------------------
--Ràng buộc khi tên danh mục bỏ trống
ALTER TABLE DanhMucSach ADD CONSTRAINT DF_TENDANHMUC_DanhMucSach DEFAULT N'Vui Lòng Nhập Tên Danh Mục!' FOR TenDanhMuc
--Ràng buộc sdt duy nhất
ALTER TABLE KhachHang ADD CONSTRAINT UNIQ_SDT_KHACHHANG UNIQUE(SDT)
--trigger sau khi chèn (INSERT) hoặc cập nhật (UPDATE) vào ChiTietDonHang
-----------------------------------------------------TRIGGER------------------------------------------------------------
GO
CREATE TRIGGER Trig_TongTien_Update
ON ChiTietDonHang
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaDH CHAR(5);

    SELECT @MaDH = i.MaDH
    FROM inserted i;

    UPDATE DonHang
    SET TongTien = (
        SELECT SUM(GiaBan * SoLuong)
        FROM ChiTietDonHang
        WHERE MaDH = @MaDH
        GROUP BY MaDH -- Thêm GROUP BY ở đây để nhóm theo MaDH
    )
    WHERE MaDH = @MaDH;
END;
GO
-- Tạo trigger sau khi chèn (INSERT) hoặc cập nhật (UPDATE) vào ChiTietDonHang
CREATE TRIGGER Trig_GiamTonKho_Update
ON ChiTietDonHang
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaSach CHAR(5);

    SELECT @MaSach = i.MaSach
    FROM inserted i;

    UPDATE Sach
    SET SLKho = (
        SELECT SLKho - SUM(SoLuong)
        FROM ChiTietDonHang
        WHERE MaSach = @MaSach
        GROUP BY MaSach -- Thêm GROUP BY ở đây để nhóm theo MaSach
    )
    WHERE MaSach = @MaSach;
END;
GO
--------------------------------------------------------------------DÙNG TRONG WINFORM--------------------------------------------------------------
-------------PROCUDUCE
--1.PROCEDUCE LẤY THÔNG TIN SÁCH
Create Proc Inf_Book
AS
BEGIN
	SELECT MaSach,TenSach,GiaBan,SLKho FROM Sach Where SLKho >0
END
GO

EXEC Inf_Book
GO
--2.PROCUDUCE TÌM SÁCH THEO TÊN TÁC GIẢ
CREATE PROCEDURE TimSachTheoTenTacGia  @ten NVARCHAR(50) = NULL, @bien INT = 0
AS
BEGIN
    IF (@bien = 1)
    BEGIN
        -- Tìm theo tên sách
        SELECT MaSach,TenSach,GiaBan,SLKho FROM Sach
        WHERE 
            (@ten IS NULL OR TenSach LIKE '%' + @ten + '%')
    END
    ELSE
    BEGIN
        -- Tìm theo tác giả
        SELECT MaSach,TenSach,GiaBan,SLKho FROM Sach
        WHERE 
			Sach.MaTG IN (SELECT MaTG FROM TacGia WHERE @ten IS NULL OR TenTG LIKE '%' + @ten + '%')
            --(@ten IS NULL OR TacGia LIKE '%' + @ten + '%')
    END
END
GO
exec TimSachTheoTenTacGia N'Học', 1
GO
--3.PROCEDUCE THÊM ĐƠN HÀNG
Create Proc themDonHang @maDH char(5),@maKH char(5)
AS 
BEGIN
	INSERT INTO DonHang(MaDH,MaKH,NgayDat) VALUES (@maDH,@maKH,GETDATE())
END
GO
--4.PROCEDUCE THÊM CHI TIẾT ĐƠN HÀNG
CREATE PROCEDURE themChiTietDonHang @maCTDH CHAR(5), @maDH CHAR(5), @maSach CHAR(5), @soLuong INT,@giaBan DECIMAL(10,2)
AS 
BEGIN
    INSERT INTO ChiTietDonHang (MaCTDH, MaDH, MaSach, SoLuong, GiaBan) VALUES (@maCTDH, @maDH, @maSach, @soLuong, @giaBan)

    UPDATE DonHang
    SET TongTien = (SELECT ISNULL(SUM(SoLuong * GiaBan), 0) 
                   FROM ChiTietDonHang 
                   WHERE MaDH = @maDH)
    WHERE MaDH = @maDH
END
GO
--5.PROCEDUCE THÊM KHÁCH HÀNG
CREATE PROCEDURE ThemKhachHang @maKH CHAR(5),@tenKH NVARCHAR(50),@diaChi NVARCHAR(100),@sdt NVARCHAR(15),@email NVARCHAR(50)
AS 
BEGIN
    INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SDT, Email)
    VALUES (@maKH, @tenKH, @diaChi, @sdt, @email)
END
GO
--6.PROCEDUCE KIỂM TRA SỐ ĐIỆN THOẠI CÓ TỒN TẠI
Create Proc KiemTraSDT @sdt NVARCHAR(15)
AS
BEGIN
	SELECT COUNT(*) FROM KhachHang WHERE SDT=@sdt
END
GO
exec KiemTraSDT '0941824972'
GO
--7.PROCEDUCE LẤY MÃ KHÁCH HÀNG TỪ SỐ ĐIỆN THOẠI
Create Proc layMaTuSDT @sdt NVARCHAR(15)
AS
BEGIN
	Select MaKH From KhachHang Where SDT=@sdt
END
GO
--8.PROCEDUCE XUẤT HÓA ĐƠN
CREATE PROCEDURE LayThongTinDonHang
    @maDH CHAR(5)
AS
BEGIN
    SELECT
        CTDH.MaCTDH,
        DH.MaDH,
        S.TenSach,
        CTDH.SoLuong,
        CTDH.GiaBan,
        (CTDH.SoLuong * CTDH.GiaBan) AS ThanhTien,
        (SELECT TenKH FROM KhachHang WHERE MaKH = DH.MaKH) AS TenKH,
        DH.NgayDat,
        DH.TongTien
    FROM
        ChiTietDonHang CTDH,
        DonHang DH,
        Sach S
    WHERE
        CTDH.MaDH = DH.MaDH
        AND CTDH.MaSach = S.MaSach
        AND DH.MaDH = @maDH;
END;
GO
-------------------FUNCTION
--9.FUNCTION LẤY TỔNG TIỀN CỦA ĐƠN HÀNG X 
GO
CREATE FUNCTION dbo.LayTongTienDonHang(@maDH CHAR(5))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @tongTien DECIMAL(10, 2);
    SELECT @tongTien = TongTien
    FROM DonHang
    WHERE MaDH = @maDH;

    RETURN @tongTien;
END;
GO
--10.FUNCTION TÍNH TỔNG SỐ SÁCH TRONG ĐƠN HÀNG X
GO
CREATE FUNCTION dbo.LaySoLuongSachTrongDonHang(@maDH CHAR(5))
RETURNS INT
AS
BEGIN
    DECLARE @soLuong INT;
    SELECT @soLuong = SUM(SoLuong)
    FROM ChiTietDonHang
    WHERE MaDH = @maDH;

    RETURN @soLuong;
END;
GO
-----------------------CURSOR
--1.Cursor In thông tin khách hàng VIP hoặc Thường VIP nếu tổng đơn trên 300
DECLARE CurKhachHang CURSOR FOR
SELECT MaKH, TenKH
FROM KhachHang;

DECLARE @MaKH CHAR(5), @TenKH NVARCHAR(50);

OPEN CurKhachHang;

FETCH NEXT FROM CurKhachHang INTO @MaKH, @TenKH;

WHILE @@FETCH_STATUS = 0
BEGIN
    DECLARE @LoaiKhachHang NVARCHAR(10);

    -- Tính tổng đơn hàng của khách hàng
    DECLARE @TongDonHang DECIMAL(10, 2);
    SELECT @TongDonHang = ISNULL(SUM(TongTien), 0)
    FROM DonHang
    WHERE MaKH = @MaKH;

    SET @LoaiKhachHang = 
        CASE 
            WHEN @TongDonHang > 300 THEN N'VIP'
            ELSE N'Thường'
        END;

    -- In thông tin khách hàng
    PRINT 'Ma khach hang: ' + @MaKH + ', Ten khach hang: ' + @TenKH + ', Loai khach hang: ' + @LoaiKhachHang;

    FETCH NEXT FROM CurKhachHang INTO @MaKH, @TenKH;
END;

CLOSE CurKhachHang;
DEALLOCATE CurKhachHang;
--2. Cursor cho biết sách bán chạy và thường. Bán chạy khi sách đã bán trên 20
DECLARE CurSach CURSOR FOR
SELECT MaSach, TenSach
FROM Sach;

DECLARE @MaSach CHAR(5), @TenSach NVARCHAR(200);

OPEN CurSach;

FETCH NEXT FROM CurSach INTO @MaSach, @TenSach;

WHILE @@FETCH_STATUS = 0
BEGIN
    DECLARE @LoaiSach NVARCHAR(10);

    -- Tính tổng số lượng sách đã bán
    DECLARE @SoLuongBan INT;
    SELECT @SoLuongBan = ISNULL(SUM(SoLuong), 0)
    FROM ChiTietDonHang
    WHERE MaSach = @MaSach;

    -- Xác định loại sách
    SET @LoaiSach = 
        CASE 
            WHEN @SoLuongBan > 20 THEN N'Bán chạy'
            ELSE N'Thường'
        END;

    -- In thông tin sách
    PRINT 'Ma sach: ' + @MaSach + ', Ten sach: ' + @TenSach + ', Loai sach: ' + @LoaiSach;

    FETCH NEXT FROM CurSach INTO @MaSach, @TenSach;
END;

CLOSE CurSach;
DEALLOCATE CurSach;
