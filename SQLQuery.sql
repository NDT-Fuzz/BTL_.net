
CREATE DATABASE QuanLiBanHang;

USE QuanLiBanHang;

Create Table HeThong(
	TenTN		char(20) NOT NULL,
	SDT			char(10) NOT NULL,
	MATKHAU		char(10) NOT NULL
);

CREATE TABLE NhaCungCap  (
	Ncc_ID				int NOT NULL PRIMARY KEY,
	TenNcc				nvarchar(50) NOT NULL,
	DiaChi				nvarchar(50) NOT NULL,
	SoDT				char(10) NOT NULL CHECK(sodt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);


CREATE TABLE HoaDonNhap (
	Hdn_ID				int NOT NULL  PRIMARY KEY,
	NgayNhapHang		date NOT NULL,
	NguoiNhap			nvarchar(50),
	TrangThai			nvarchar(30) NOT NULL,
	TongTien			float NOT NULL,
	Ncc_ID				int NOT NULL,
	FOREIGN KEY(Ncc_ID) REFERENCES NhaCungCap(Ncc_ID)
);


CREATE TABLE DMSanPham  (
	Dm_ID				int NOT NULL PRIMARY KEY ,
	TenDm				nvarchar(50) NOT NULL,
	HinhAnhSanPham		varchar(200) NOT NULL
);


CREATE TABLE SanPham  (
	SP_ID				int NOT NULL PRIMARY KEY,
	TenSanPham			nvarchar(50)  NOT NULL,
	GiaNhap				float NOT NULL,
	GiaBan				float not null,
	HinhAnh				varchar(200) NOT NULL,
	MoTa				nvarchar(1000)  NOT NULL,
	SoLuong				int NOT NULL,
	Dm_ID				int NOT NULL, 
	FOREIGN KEY(Dm_ID) REFERENCES DMSanPham(Dm_ID)   
); 


CREATE TABLE ChiTietDonNhapHang (
	CTDonNhap_ID		int NOT NULL PRIMARY KEY,  
	SoLuong				int NOT NULL,
	ThanhTien			float not null,
	GhiChu				nvarchar(100),
	Hdn_ID				int NOT NULL, 
	SP_ID				int NOT NULL, 
	FOREIGN KEY(Hdn_ID) REFERENCES HoaDonNhap(Hdn_ID), 
	FOREIGN KEY(SP_ID) REFERENCES SanPham (SP_ID)  
);


CREATE TABLE VaiTro (
	VaiTro_ID			int NOT NULL PRIMARY KEY,
	TenVaiTro			nvarchar(50) NOT NULL,
	Email				varchar(50) NOT NULL,
	MatKhau				varchar(50) NOT NULL,
	QuyenTruyCap		int not null ,
);


CREATE TABLE NhanVien (
	NhanVien_ID				int NOT NULL  PRIMARY KEY,
	TenNhanVien				nvarchar(50) NOT NULL,
	SoDT					char(10) NOT NULL check(sodt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	DiaChi					nvarchar(50) ,
	Email					varchar(50) NOT NULL,
	VaiTro_ID				int NOT NULL, 
	FOREIGN KEY(VaiTro_ID)  REFERENCES VaiTro(VaiTro_ID)   
);


CREATE TABLE KhachHang (
	KhachHang_ID		int NOT NULL  PRIMARY KEY,
	TenKhachHang		nvarchar(50) NOT NULL,
	SoDT				char(10) NOT NULL check(sodt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	DiaChi				nvarchar(50),
	Email				varchar(50) NOT NULL
);



CREATE TABLE HoaDonBan (
	HoaDonBan_ID			int NOT NULL  PRIMARY KEY,
	NgayBan					date NOT NULL,
	TrangThai				nvarchar(30) NOT NULL,
	PhuongThucThanhToan		nvarchar(50) NOT NULL,
	TongTien				float not null,
	KhachHang_ID			int NOT NULL, 
	NhanVien_ID				int NOT NULL, 
	FOREIGN KEY(KhachHang_ID) REFERENCES KhachHang(KhachHang_ID),
	FOREIGN KEY(NhanVien_ID) REFERENCES nhanvien(NhanVien_ID)   
);


CREATE TABLE ChiTietDonBan (
	CTDonBan_ID	int NOT NULL PRIMARY KEY,  
	SoLuong				int NOT NULL,
	GiamGia				float NOT NULL,
	ThanhTien			float not null,
	GhiChu				nvarchar(100) ,
	HoaDonBan_ID		int NOT NULL, 
	SP_ID	 			int NOT NULL,  
	FOREIGN KEY(HoaDonBan_ID) REFERENCES HoaDonBan(HoaDonBan_ID),  
	FOREIGN KEY(SP_ID) REFERENCES SanPham(SP_ID),  
	
);

INSERT INTO HeThong (TenTN		, SDT			,MATKHAU)
VALUES		    	('admin'	, '0123456789'	,'admin' ) ; 

INSERT INTO NhaCungCap(Ncc_ID	, TenNcc, DiaChi        , SoDT)
VALUES					(1		, 'ncc1', 'Ha Noi'		, '0123456789' ),
						(2		, 'ncc2', 'Hoa Binh'	, '0123456788' ),
						(3		, 'ncc3', 'Nam Dinh'	, '0123456787' ),
						(4		, 'ncc4', 'Ha Nam'		, '0123456786' ),
						(5		, 'ncc5', 'Thai Binh'	, '0123456785' );

INSERT INTO HoaDonNhap(Hdn_ID	, NgayNhapHang  , NguoiNhap	        , TrangThai		, TongTien	, Ncc_ID)
VALUES					(1		, '2021-11-02'	, 'Nguyen Van A'	, 'Thanh cong'	, 400000	, 2	),		
						(2		, '2021-10-03'	, 'Nguyen Van B'	, 'That bai'	, 535000	, 1	),
						(3		, '2021-05-15'	, 'Nguyen Thi C'	, 'Thanh cong'	, 300000	, 2	),	
						(4		, '2021-05-17'	, 'Nguyen Van D'	, 'Thanh cong'	, 600000	, 3	),	
						(5		, '2021-11-20'	, 'Nguyen Thi D'	, 'That bai'	, 510000	, 4	);	

INSERT INTO DmSanPham	(Dm_ID	, TenDm			, HinhAnhSanPham)
VALUES					(1		, 'dienthoai'	, 'https://img.icons8.com/clouds/2x/multiple-smartphones.png'),
						(2		, 'laptop'		, 'https://img.icons8.com/clouds/2x/laptop.png');

INSERT INTO SanPham (SP_ID	, TenSanPham					, GiaNhap ,GiaBan, HinhAnh, MoTa, SoLuong, Dm_ID)
VALUES				(1		,'iPhone 13 Pro max'			, 25000	  ,32000 , 'https://cdn.tgdd.vn/Products/Images/42/213033/iphone-12-pro-max-195420-015412-400x400.png',  N'iPhone 13 Pro Max sở hữu diện mạo mới mới với khung viền được vát thẳng và mạnh mẽ như trên iPad Pro 2020, chấm dứt hơn 6 năm với kiểu thiết kế bo cong trên iPhone 6 được ra mắt lần đầu tiên vào năm 2014.\r\nMàn hình\r\nCông nghệ màn hình	OLED\r\nĐộ phân giải	1284 x 2778 Pixels\r\nMàn hình rộng	6.7\"\r\nMặt kính cảm ứng	Kính cường lực Ceramic Shield\r\nCamera sau\r\nĐộ phân giải	3 camera 12 MP\r\nĐèn Flash	Đèn LED kép\r\nCamera trước\r\nĐộ phân giải	12 MP\r\nHệ điều hành & CPU\r\nHệ điều hành	iOS 14\r\nChip xử lý (CPU)	Apple A14 Bionic 6 nhân\r\nTốc độ CPU	2 nhân 3.1 GHz & 4 nhân 1.8 GHz\r\nChip đồ họa (GPU)	Apple GPU 6 nhân\r\nBộ nhớ & Lưu trữ\r\nRAM	6 GB\r\nBộ nhớ trong	128 GB\r\nBộ nhớ còn lại (khả dụng)	Khoảng 113 GB\r\nThiết kế & Trọng lượng\r\nThiết kế	Nguyên khối\r\nChất liệu	Khung thép không gỉ & Mặt lưng kính cường lực\r\nKích thước	Dài 160.8 mm - Ngang 78.1 mm - Dày 7.4 mm\r\nTrọng lượng	228 g\r\nPin & Sạc\r\nDung lượng pin	3687 mAh\r\nLoại pin	Li-Ion', 2, 1),
					(2		,'Acer Aspire 3 A315 56 36YS'	, 17000	  , 21000,'https://cdn.tgdd.vn/Products/Images/44/224583/acer-aspire-3-a315-56-i3-nxhs5sv008-8-1-224583-600x600.jpg', N'Laptop Acer Aspire 3 A315 56 36YS i3 (NX.HS5SV.008) là chiếc máy có thiết kế gọn nhẹ, hướng tới người dùng văn phòng cần một sản phẩm ổn định đáp ứng được nhu cầu công việc và học tập cơ bản với mức giá thành rẻ.\r\nCPU:	Intel Core i3 Ice Lake, 1005G1, 1.20 GHz\r\nRAM:	8 GB, DDR4 (On board 4GB +1 khe 4GB), 2400 MHz\r\nỔ cứng:	SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA\r\nMàn hình:	15.6 inch, Full HD (1920 x 1080)\r\nCard màn hình:	Card đồ họa tích hợp, Intel UHD Graphics\r\nCổng kết nối:	2 x USB 2.0, USB 3.1, HDMI, LAN (RJ45)\r\nHệ điều hành:	Windows 10 Home SL\r\nThiết kế:	Vỏ nhựa, PIN liền\r\nKích thước:	Dày 19.9 mm, 1.7 kg', 1, 2),
					(3		,'Lenovo IdeaPad S145 15IIL i3', 15000	  , 18500, 'https://cdn.tgdd.vn/Products/Images/44/216292/lenovo-ideapad-s145-81w8001xvn-a4-216292-600x600.jpg', N'Laptop Lenovo IdeaPad S145 15IIL i3 (81W8001XVN) thuộc phân khúc laptop học tập văn phòng cơ bản với mức giá tốt. Máy có cấu hình ổn, đủ chạy các ứng dụng văn phòng phổ biến, điểm nổi bật của Lenovo IdeaPad S145 là ổ cứng SSD siêu nhanh, thiết kế mỏng gọn, tinh tế.\r\nCPU:	Intel Core i3 Ice Lake, 1005G1, 1.20 GHz\r\nRAM:	4 GB, DDR4 (On board +1 khe), 2666 MHz\r\nỔ cứng:	SSD 256GB NVMe PCIe, Hỗ trợ khe cắm HDD SATA\r\nMàn hình:	15.6 inch, Full HD (1920 x 1080)\r\nCard màn hình:	Card đồ họa tích hợp, Intel UHD Graphics\r\nCổng kết nối:	2 x USB 3.0, HDMI, USB 2.0\r\nHệ điều hành:	Windows 10 Home SL\r\nThiết kế:	Vỏ nhựa, PIN liền\r\nKích thước:	Dày 17.9 mm, 1.79kg' , 3, 2),
					(4		,'Xiaomi Redmi 9', 7000, 9500, 'https://cdn.tgdd.vn/Products/Images/42/217308/TimerThumb/xiaomi-redmi-9-(34).jpg', N'Nhanh như một cơn gió, sức hot của Redmi Note 9 Pro chưa có dấu hiệu hạ nhiệt thì Xiaomi Redmi 9 vừa bất ngờ ra mắt sớm. Thiết bị mang một thiết kế mới, thời trang và nhỏ gọn, phần cứng được nâng cấp cùng thời lượng pin ấn tượng, đặc biệt đi kèm một mức giá bán không thể nào hấp dẫn hơn.\r\nMàn hình:	IPS LCD, 6.53\", Full HD+\r\nHệ điều hành:	Android 10\r\nCamera sau:	Chính 13 MP & Phụ 8 MP, 5 MP, 2 MP\r\nCamera trước:	8 MP\r\nCPU:	MediaTek Helio G80 8 nhân\r\nRAM:	4 GB\r\nBộ nhớ trong:	64 GB\r\nThẻ nhớ:	MicroSD, hỗ trợ tối đa 512 GB\r\nThẻ SIM:\r\n2 Nano SIM, Hỗ trợ 4G\r\nHOTSIM VNMB Siêu sim (5GB/ngày)\r\nDung lượng pin:	5020 mAh, có sạc nhanh', 1, 1);

INSERT INTO ChiTietDonNhapHang 	(CTDonNhap_ID, SoLuong	, ThanhTien	,	GhiChu				, Hdn_ID,SP_ID				)
VALUES							(1			 , 10		, 250000	, N'Nhập khẩu trực tiếp', 1		,1),
								(2			 , 5		, 35000		, N'Nhập khẩu gián tiếp', 2		,4),
								(3			 , 10		, 150000	, N'Nhập khẩu gián tiếp', 1		,3),
								(4			 , 20		, 500000	, N'Nhập khẩu trực tiếp', 2		,1),
								(5			 , 30		, 510000	, N'Nhập khẩu trực tiếp', 5		,2);
INSERT INTO VaiTro 	(VaiTro_ID	, TenVaiTro			    , Email					, MatKhau		, QuyenTruyCap)
VALUES				(1			, N'Thư ký'				, 'thuky@tgdd.vn'		, '4869'	,  0),
					(2			, N'Quản lý'			, 'quanly@tgdd.vn'		, '4868'	,  1),
					(3			, N'Tư vấn viên'		, 'tuvanvien@tgdd.vn'	, '4867'	,  0),
					(4			, N'Nhân viên bán hàng'	, 'nvbh@tgdd.vn'		, '4866'	,  0),
					(5			, N'Kỹ thuật viên'		, 'kythuat@tgdd.vn'		, '4865'	,  1);

INSERT INTO NhanVien (NhanVien_ID, TenNhanVien			    , SoDT			,DiaChi			, Email						, VaiTro_ID)
VALUES				(1			 , N'Nguyễn Hữu Hoàng Anh'	, '0125684572'	,'Ninh Binh'	,'hoanganh@gmail.com'		, 2),
					(2			 , N'Hoàng Long'			, '0125684573'	,'Thai Binh'	,'hoanglong@gmail.com'		, 1),
					(3			 , N'Đặng Thị Ánh Tuyết'	, '0125684574'	,'Ha Noi'		,'anhtuyet@gmail.com'		, 1),
					(4			 , N'Nguyễn Minh Vũ'		, '0125684575'	,'Ha Nam'		,'minhvu@gmail.com'			, 3),
					(5			 , N'Nguyễn Đức Trường'		, '0125684576'	,'Nam Dinh'		,'ductruong@gmail.com'		, 5);

INSERT INTO KhachHang(KhachHang_ID	,TenKhachHang	,	SoDT		,DiaChi		,Email)
VALUES				 (1				, N'Quang Đức'	, '0247856251'	,'Ha Noi'	,'qd@gmail.com'),
					 (2				, N'Tuấn Việt'	, '0247856252'	,'Hoa Binh' ,'viet@gmail.com'),
					 (3				, N'Đức Khải'	, '0247856253'	,'Bac Ninh' ,'khai@gmail.com'),
					 (4				, N'Quách Yến'	, '0247856254'	,'Ha Noi'	,'yen@gmail.com'),
					 (5				, N'Thu Hằng'	, '0247856255'	,'Ha Noi'	,'hang@gmail.com');


INSERT INTO HoaDonBan 	(HoaDonBan_ID	,	NgayBan		,	TrangThai		, PhuongThucThanhToan,TongTien	,KhachHang_ID,NhanVien_ID)
VALUES					(1				, '2021-01-15'	, N'Đã thu tiền'	, N'Tiền mặt'		 , 64000	, 1			, 3),
						(2				, '2021-02-01'	, N'Đã thu tiền'	, N'Tiền mặt'		 , 15000	, 2			, 4),
						(3				, '2021-04-11'	, N'Đã thu tiền'	, N'Thẻ ATM'		 , 42000	, 1			, 3),
						(4				, '2021-03-22'	, N'Đã thu tiền'	, N'Ví điện tử MOMO' , 30000	, 5			, 4),
						(5				, '2021-04-20'	, N'Đã thu tiền'	, N'Thẻ ATM'		 , 63000	, 3			, 4);

INSERT INTO ChiTietDonBan 	(CTDonBan_ID ,SoLuong	,GiamGia	,ThanhTien	,GhiChu					,HoaDonBan_ID	,SP_ID)
VALUES						(1			 , 2		, 0			, 64000		, N'Không khuyến mại'	, 1				, 1),
							(2			 , 2		, 0			, 42000		, N'Không khuyến mại'	, 3				, 2),
							(3			 , 2		, 7000		, 30000		, N'Đã khuyến mại'		, 4				, 3),
							(4			 , 2		, 4000		, 15000		, N'Đã khuyến mại'		, 2				, 4);

SELECT * FROM NhaCungCap;
SELECT * FROM ChiTietDonBan;
SELECT * FROM HoaDonBan;
	
SELECT * FROM NhanVien;
SELECT * FROM VaiTro;
SELECT * FROM ChiTietDonNhapHang;
SELECT * FROM SanPham;
SELECT * FROM DMSanPham;
SELECT * FROM HoaDonNhap;
Create table banhang1 (
NgayBan		date,
SoHoaDon	int,
DoanhThu	int,
GiaGoc		int
);
Insert Into banhang1
	Select NgayBan, HoaDonBan.HoaDonBan_ID, SUM(GiaBan)as DoanhThu,SUM(GiaNhap) as GiaGoc
	From HoaDonBan,SanPham,ChiTietDonBan
	Where HoaDonBan.HoaDonBan_ID=ChiTietDonBan.HoaDonBan_ID And ChiTietDonBan.SP_ID=SanPham.SP_ID
	Group by NgayBan, HoaDonBan.HoaDonBan_ID;

select * from banhang1;

Create table BanHang (
NgayBan		date,
SoHoaDon	int,
DoanhThu	int,
LoiNhuan		int
);
Insert Into BanHang
	Select NgayBan,SoHoaDon, DoanhThu,(DoanhThu-GiaGoc) as LoiNhuan
	From banhang1
	Group by NgayBan,SoHoaDon, DoanhThu,GiaGoc;

select * from BanHang;

Select * from SanPham ; 
Select * from BanHang