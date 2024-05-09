
INSERT KHOA(MaKhoa,TenKhoa,SoCBGV) VALUES 
	('7480201',N'Công nghệ thông tin',100),
	('7480202',N'An toàn thông tin',100)

Insert LOP(MaLop,TenLop,MaKhoa) Values
	('D21CQCN01',N'An toàn thông tin','7480201'),
	('D21CQCN02',N'An toàn thông tin','7480201'),
	('D21CQCN03',N'An toàn thông tin','7480201'),
	('D21CQCN04',N'An toàn thông tin','7480201'),
	('D21CQCN05',N'An toàn thông tin','7480201'),
	('D21CQCN06',N'An toàn thông tin','7480201'),
	('D21CQCN07',N'An toàn thông tin','7480201'),
	('D21CQCN08',N'An toàn thông tin','7480201'),
	('D21CQCN09',N'An toàn thông tin','7480201'),
	('D21CQCN10',N'An toàn thông tin','7480201')


INSERT SINHVIEN(Masv,HoTen,NgaySinh,GioiTinh,NienKhoa,MaLop) VALUES
	('B21DCCN442',N'Trần Văn Huy','2003-04-22',1,'2021','D21CQCN10'),
	('B21DCCN443',N'Trần Xuân Huy','2003-03-12',1,'2021','D21CQCN10'),
	('B21DCCN123',N'Đinh Trần Đức','2003-12-25',1,'2021','D21CQCN09'),
	('B21DCCN444',N'Bùi Xuân Huy','2003-11-14',1,'2021','D21CQCN10'),
	('B21DCCN321',N'Đinh Thùy Linh','2003-05-08',0,'2021','D21CQCN08'),
	('B21DCCN420',N'Tống Văn Hùng','2003-04-04',1,'2021','D21CQCN10'),
	('B21DCCN112',N'Lê Tiến Đạt','2003-06-22',1,'2021','D21CQCN07'),
	('B21DCCN100',N'Nguyễn Tấn Dũng','2003-09-02',1,'2021','D21CQCN07')

INSERT MONHOC(MaMH,TenMH,TinChi,SoTiet)VALUES
	('BAS1153',N'Lịch sử Đảng cộng sản Việt Nam',2,30),
	('BAS1160',N'Tiếng Anh (Course 3 Plus)',2,30),
	('INT1313',N'Cơ sở dữ liệu',3,45),
	('INT13162',N'Lập trình với Python',3,45),
	('INT1319',N'Hệ điều hành',3,45),
	('INT1332',N'Lập trình hướng đối tượng',3,45),
	('INT1336',N'Mạng máy tính',3,45),
	('ELE1319',N'Lý thuyết thông tin',3,45),
	('INT1306',N'Cấu trúc dữ liệu và giải thuật',3,45),
	('INT13145',N'Kiến trúc máy tính',3,45)


Insert KETQUA(MaMH,Masv,TenMH,DiemThi) Values
	('BAS1160','B21DCCN442',N'Tiếng Anh (Course 3 Plus)',8.4),
	('INT1313','B21DCCN442',N'Cơ sở dữ liệu',7.9),
	('INT1313','B21DCCN443',N'Cơ sở dữ liệu',8.6),
	('INT1313','B21DCCN100',N'Cơ sở dữ liệu',6.5),
	('INT1306','B21DCCN321',N'Cấu trúc dữ liệu và giải thuật',7.4),
	('INT1306','B21DCCN123',N'Cấu trúc dữ liệu và giải thuật',9.3),
	('BAS1160','B21DCCN420',N'Tiếng Anh (Course 3 Plus)',5.6),
	('BAS1160','B21DCCN444',N'Tiếng Anh (Course 3 Plus)',7.4),
	('INT13162','B21DCCN112',N'Lập trình với Python',3.9)




	