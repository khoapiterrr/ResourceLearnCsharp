--Tập lệnh cơ bản để truy vấn lấy thông tin từ các bảng
--Lấy tất cả các thông tin trong bảng bao gồm các cột, các dòng
Select * from SinhVien;
--Lấy tất cả các thông tin trong bảng bao gồm các dòng và các cột cần lấy
Select MaSV, HoTen, DiaChi from SinhVien;

--Sử dụng mệnh đề (từ khóa) Where để lọc lấy thông tin cần thiết
--Sử dụng từ khóa Like với những cột có kiểu chuỗi để lấy ra 1 tập dữ liệu thỏa mãn
--Nếu ghi N'%Hà Nội' thì chỉ lấy những thông có kết thúc bằng từ Hà Nội
--Nếu ghi N'Hà Nội%' thì chỉ lấy những thông tin bắt đầu bằng từ Hà Nội
--Nếu ghi N'%Hà Nội%' thì lấy những thông tin chứa từ Hà Nội
--Sử dụng kí tự N để làm việc với unicode
Select * from SinhVien where DiaChi like N'%Hà Nội%'

--Lấy thông tin dựa vào toán tử =, !=, <, <=, >, >=
Select * from SinhVien where MaSV = 'SF001';

--Lấy thông tin theo 1 tập dữ liệu
Select * from SinhVien where MaSV IN ('SF001', 'SF006');
--Lấy tất cả thông tin thuộc khoa Công nghệ thông tin
Select * from SinhVien where ChuyenKhoaId='CNTT';

--Tập lệnh theo tác với dữ liệu
--Thêm mới thông tin dạng đầy đủ
Insert into SinhVien values('SF007',N'Trần Quốc Toản',0,'06/05/1990','0988333568','quoctoan@stanford.com.vn',N'Hải Dương');
--Thêm mới thông tin dạng khai báo những cột cần thêm
Insert into SinhVien(MaSV, HoTen, DiaChi) values('SF008',N'Nguyễn Thành Công',N'Nam Định');

--Tập lệnh về cập nhật thông tin sửa đổi
Update SinhVien SET HoTen=N'Trần Quốc Toản', DiaChi=N'Hải Dương' where MaSV= 'SF007';

--Câu lệnh xóa thông tin
--Xóa tất cả thông tin trong bảng
Delete from SinhVien;

--Xóa tất cả thông tin thỏa mãn điều kiện
Delete from SinhVien Where MaSV='SF008';