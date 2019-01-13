using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Stanford_QuanLyNhanVien
{
    public class NhanVienBusiness
    {
        public DataTable LayDanhSachNhanVien()
        {
            string strSQL = "Select MaNV, HoTen, DienThoai, Email, DiaChi from NhanVien";

            return DataProvider.LayDanhSach(strSQL);
        }

        public DataTable TimKiemNhanVien(string tuKhoa, string maPhong)
        {
            string strSQL = "Select MaNV, HoTen, DienThoai, Email, DiaChi from NhanVien where 1 = 1";

            //Nếu từ khóa có thông tin
            if(!string.IsNullOrEmpty(tuKhoa))
            {
                strSQL += string.Format("AND (MaNV = '{0}' OR HoTen like N'%{0}%')", tuKhoa);
            }

            //Nếu có thông tin phòng chọn
            if(!string.IsNullOrEmpty(maPhong))
            {
                strSQL += string.Format(" AND MaPhong = '{0}'", maPhong);
            }

            return DataProvider.LayDanhSach(strSQL);
        }

        public DataTable ChiTietNhanVienTheoMa(string maNV)
        {
            string strSQL = "Select MaNV, HoTen,GioiTinh,NgaySinh, DienThoai, Email, DiaChi,MaPhong from NhanVien where MaNV= '" + maNV + "'";

            return DataProvider.LayDanhSach(strSQL);
        }

        public bool ThemMoi(NhanVien objNhanVien)
        {
            string strInsert = "Insert into NhanVien(MaNV, HoTen, GioiTinh, NgaySinh, DienThoai, Email, DiaChi, MaPhong) values(@MaNV, @HoTen, @GioiTinh, @NgaySinh, @DienThoai, @Email, @DiaChi, @MaPhong);";

            //Khai báo 1 mảng tham số
            SqlParameter[] pars = new SqlParameter[8];

            //Khởi tạo tham số thứ 1
            pars[0] = new SqlParameter("@MaNV", SqlDbType.VarChar, 10);
            pars[0].Value = objNhanVien.MaNV;

            pars[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
            pars[1].Value = objNhanVien.HoTen;

            pars[2] = new SqlParameter("@GioiTinh", SqlDbType.TinyInt);
            pars[2].Value = objNhanVien.GioiTinh;

            pars[3] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            pars[3].Value = objNhanVien.NgaySinh;

            pars[4] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
            pars[4].Value = objNhanVien.DienThoai;

            pars[5] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            pars[5].Value = objNhanVien.Email;

            pars[6] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 150);
            pars[6].Value = objNhanVien.DiaChi;

            pars[7] = new SqlParameter("@MaPhong", SqlDbType.VarChar, 10);
            pars[7].Value = objNhanVien.MaPhong;

            return DataProvider.ThucHienCongViec(strInsert, pars);
        }

        public bool CapNhat(NhanVien objNhanVien)
        {
            string strUpdate = "Update NhanVien set HoTen=@HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DienThoai = @DienThoai, Email = @Email, DiaChi = @DiaChi, MaPhong=@MaPhong where MaNV = @MaNV";

            //Khai báo 1 mảng tham số
            SqlParameter[] pars = new SqlParameter[8];

            //Khởi tạo tham số thứ 1
            pars[0] = new SqlParameter("@MaNV", SqlDbType.VarChar, 10);
            pars[0].Value = objNhanVien.MaNV;

            pars[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
            pars[1].Value = objNhanVien.HoTen;

            pars[2] = new SqlParameter("@GioiTinh", SqlDbType.TinyInt);
            pars[2].Value = objNhanVien.GioiTinh;

            pars[3] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            pars[3].Value = objNhanVien.NgaySinh;

            pars[4] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
            pars[4].Value = objNhanVien.DienThoai;

            pars[5] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            pars[5].Value = objNhanVien.Email;

            pars[6] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 150);
            pars[6].Value = objNhanVien.DiaChi;

            pars[7] = new SqlParameter("@MaPhong", SqlDbType.VarChar, 10);
            pars[7].Value = objNhanVien.MaPhong;

            return DataProvider.ThucHienCongViec(strUpdate, pars);
        }

        public bool Xoa(string maNV)
        {
            string strDelete = "Delete from NhanVien where MaNV = @MaNV";
            //Khai báo 1 mảng tham số
            SqlParameter[] pars = new SqlParameter[1];

            //Khởi tạo tham số thứ 1
            pars[0] = new SqlParameter("@MaNV", SqlDbType.VarChar, 10);
            pars[0].Value = maNV;

            return DataProvider.ThucHienCongViec(strDelete, pars);
        }
    }
}
