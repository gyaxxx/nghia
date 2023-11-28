CREATE DATABASE DBQuanLiKTX
USE DBQuanLiKTX

CREATE TABLE Nha (
    Manha NVARCHAR(5) NOT NULL PRIMARY KEY,
    Tennha VARCHAR(255)
);

CREATE TABLE Phong (
    MaPhong NVARCHAR(5) NOT NULL PRIMARY KEY,
    Tenphong VARCHAR(255),
    Manha NVARCHAR(5) NOT NULL,
    Loaiphong VARCHAR(255),
    Songuoitoida INT,
    Songuoidango INT,
    Tienthue DECIMAL(18, 2),
    Ghichu TEXT,
    FOREIGN KEY (Manha) REFERENCES Nha(Manha)
);

CREATE TABLE ThietBiPhong (
    MaPhong NVARCHAR(5) NOT NULL,
    Mathietbi NVARCHAR(5) NOT NULL PRIMARY KEY,
    soluong INT,
    Tinhtrang VARCHAR(255),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

CREATE TABLE Khoa (
    Makhoa NVARCHAR(5) NOT NULL PRIMARY KEY,
    Tenkhoa VARCHAR(255)
);

CREATE TABLE Lop (
    Malop NVARCHAR(5) NOT NULL PRIMARY KEY,
    TenLop VARCHAR(255),
    Makhoa NVARCHAR(5) NOT NULL,
    FOREIGN KEY (Makhoa) REFERENCES Khoa(Makhoa)
);

CREATE TABLE Que (
    Maque NVARCHAR(5) NOT NULL PRIMARY KEY,
    Tenque VARCHAR(255)
);

CREATE TABLE SinhVien (
    Masinhvien NVARCHAR(5) NOT NULL PRIMARY KEY,
    Tensinhvien VARCHAR(255),
    Ngaysinh DATE,
    Gioitinh VARCHAR(10),
    Maque NVARCHAR(5) NOT NULL,
    Makhoa NVARCHAR(5) NOT NULL,
    Malop NVARCHAR(5) NOT NULL,
    FOREIGN KEY (Maque) REFERENCES Que(Maque),
    FOREIGN KEY (Makhoa) REFERENCES Khoa(Makhoa),
    FOREIGN KEY (Malop) REFERENCES Lop(Malop)
);



CREATE TABLE Thietbi (
    Mathietbi NVARCHAR(5) NOT NULL PRIMARY KEY,
    Tenthietbi VARCHAR(255),
    Giatri DECIMAL(18, 2)
);

CREATE TABLE Thuephong (
    Masothue NVARCHAR(5) NOT NULL PRIMARY KEY,
    Masv NVARCHAR(5) NOT NULL,
    Maphong NVARCHAR(5) NOT NULL,
    NgayBdau DATE,
    Ngaykt DATE,
    Ghichu TEXT,
    FOREIGN KEY (Masv) REFERENCES SinhVien(Masinhvien),
    FOREIGN KEY (Maphong) REFERENCES Phong(MaPhong)
);

CREATE TABLE Traphong (
    Masothue NVARCHAR(5) NOT NULL,
    Ngaytra DATE,
    Tienvipham DECIMAL(18, 2),
    PRIMARY KEY (Masothue, Ngaytra),
    FOREIGN KEY (Masothue) REFERENCES Thuephong(Masothue)
);

CREATE TABLE ThutienPhong (
    Maphong NVARCHAR(5) NOT NULL,
    Thang INT,
    Nam INT,
    Tiennha DECIMAL(18, 2),
    Tiendien DECIMAL(18, 2),
    Tiennuoc DECIMAL(18, 2),
    Tienvesinh DECIMAL(18, 2),
    Tienphat DECIMAL(18, 2),
    Ngayhethan DATE,
    Ngaydong DATE,
    PRIMARY KEY (Maphong, Thang, Nam),
    FOREIGN KEY (Maphong) REFERENCES Phong(MaPhong)
);

INSERT INTO Nha (Manha, Tennha)
VALUES 
    ('NH001', 'Nhà A'),
    ('NH002', 'Nhà B'),
    ('NH003', 'Nhà C');

INSERT INTO Phong (MaPhong, Tenphong, Manha, Loaiphong, Songuoitoida, Songuoidango, Tienthue, Ghichu)
VALUES 
    ('P001', 'Phòng 101', 'NH001', '8 sinh viên / phòng', 8, 8, 5000000.00, ''),
    ('P002', 'Phòng 102', 'NH001', '8 sinh viên / phòng', 8, 8, 5000000.00, ''),
    ('P003', 'Phòng 201', 'NH002', '6 sinh viên / phòng', 6, 6, 7000000.00, ''),
    ('P004', 'Phòng 202', 'NH002', '6 sinh viên / phòng', 6, 6, 7000000.00, ''),
    ('P005', 'Phòng 301', 'NH003', '8 sinh viên / phòng', 8, 8, 8000000.00, '');

INSERT INTO ThietBiPhong (MaPhong, Mathietbi, soluong, Tinhtrang)
VALUES 
    ('P001', 'TB001', 5, 'Đang sử dụng'),
    ('P001', 'TB002', 3, 'Hỏng'),
    ('P002', 'TB003', 2, 'Đang sử dụng'),
    ('P003', 'TB004', 4, 'Đang sử dụng'),
    ('P004', 'TB005', 1, 'Hỏng');
INSERT INTO Khoa(MaKhoa,TenKhoa)
VALUES 
    ('IT', N'Công Nghệ Thông Tin'),
    ('FCE', N'Công Trình'),
	('IME', N'Cơ Khí'),
	('EE', N'Kinh Tế - Quản Trị');
INSERT INTO Que(Maque,Tenque)
VALUES 
    ('17', N'Thái Bính'),
    ('29', N'Hà Nội'),
	('16', N'Hải Phòng'),
	('37', N'Nghệ An'),
	('14', N'Quảng Ninh');
INSERT INTO Lop(Makhoa,Malop)
VALUES 
    ('IT', N'CNTT1'),
    ('IT', N'CNTT2'),
	('FCE', N'CT1'),
	('FCE', N'CT2'),
	('IME', N'CK1'),
	('IME', N'CK2'),
	('EE', N'KTQT1'),
	('EE', N'KTQT2');
ALTER TABLE SinhVien
ALTER COLUMN Gioitinh nvarchar(10)
ALTER TABLE SinhVien
ALTER COLUMN Tensinhvien nvarchar(100)
ALTER TABLE Phong
ALTER COLUMN Loaiphong nvarchar(10)