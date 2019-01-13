using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Stanford_QuanLySinhVien
{
    /// <summary>
    /// Xử lý nghiệp vụ với các đối tượng sinh viên
    /// </summary>
    public class SinhVienBusiness
    {
        //Khai báo 1 danh sách để chứa thông tin
        private List<SinhVien> lstSinhVien = new List<SinhVien>();

        /// <summary>
        /// Hàm lấy danh sách sinh viên
        /// </summary>
        /// <returns></returns>
        public DataTable layDanhSach()
        {
            //Khai báo 1 công việc hay câu lệnh SQL
            string strSQL = "select SinhVien.*,Khoa.TENKHOA from SinhVien left join  Khoa on SinhVien.MAKHOA = Khoa.MAKHOA";

            return DataProvider.LayDanhSach(strSQL);
        }

        public DataTable TimKiem(string pTen)
        {
            //Khai báo 1 công việc hay câu lệnh SQL
            string strSQL = "select SinhVien.*,Khoa.TENKHOA from SinhVien left join  Khoa on SinhVien.MAKHOA = Khoa.MAKHOA where TenSinhVien like N'%" + pTen + "%'";

            return DataProvider.LayDanhSach(strSQL);
        }

        /// <summary>
        /// Hàm lấy thông tin chi tiết của sinh viên theo mã
        /// </summary>
        /// <param name="maSV"></param>
        /// <returns></returns>
        public DataTable layChiTietSinhVienTheoMa(string maSV)
        {
            //Khai báo 1 công việc hay câu lệnh SQL
            string strSQL = "Select MaSinhVien, HoTen, DienThoai, Email, DiaChi from SinhVien where MaSV = '" + maSV + "'";

            return DataProvider.LayDanhSach(strSQL);
        }
        /// <summary>
        /// Hàm thêm mới 1 sinh viên vào trong danh sách
        /// </summary>
        /// <param name="objSV"></param>
        /// <returns></returns>
        public bool themMoiSinhVien(SinhVien objSV)
        {
            //Khai báo câu lệnh insert
            string strInsert = "Insert into SinhVien(MaSV, HoTen, DienThoai, Email, DiaChi) values(@MaSV, @HoTen, @DienThoai, @Email, @DiaChi)";

            //Khai báo tham số và gán giá trị cho các tham số
            SqlParameter[] pars = new SqlParameter[5];

            //Phần tử 1
            pars[0] = new SqlParameter("@MaSV", SqlDbType.Char, 5);
            pars[0].Value = objSV.MaSV;

            pars[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
            pars[1].Value = objSV.HoTen;

            pars[2] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
            pars[2].Value = objSV.DienThoai;

            pars[3] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            pars[3].Value = objSV.Email;

            pars[4] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 150);
            pars[4].Value = objSV.DiaChi;

            return DataProvider.ThucHien(strInsert, pars);
        }

        /// <summary>
        /// Hàm cập nhật thông tin sinh viên vào db
        /// </summary>
        /// <param name="objSV"></param>
        /// <returns></returns>
        public bool capNhat(SinhVien objSV)
        {
            //Khai báo câu lệnh update
            string strUpdate = "Update SinhVien set HoTen=@HoTen, DienThoai=@DienThoai, Email = @Email, DiaChi = @DiaChi where MaSV = @MaSV";

            //Khai báo tham số và gán giá trị cho các tham số
            SqlParameter[] pars = new SqlParameter[5];

            //Phần tử 1
            pars[0] = new SqlParameter("@MaSV", SqlDbType.Char, 5);
            pars[0].Value = objSV.MaSV;

            pars[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
            pars[1].Value = objSV.HoTen;

            pars[2] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
            pars[2].Value = objSV.DienThoai;

            pars[3] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            pars[3].Value = objSV.Email;

            pars[4] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 150);
            pars[4].Value = objSV.DiaChi;

            return DataProvider.ThucHien(strUpdate, pars);
        }

        /// <summary>
        /// Xóa sinh viên theo mã sinh viên
        /// </summary>
        /// <param name="maSV">Mã sinh vien</param>
        /// <returns>True: Nếu xóa thành công, False: Nếu xóa thất bại</returns>
        public bool XoaSinhVien(string maSV)
        {
            string strDelete = "Delete from SinhVien where MaSV = @MaSV";
            //Khai báo tham số và gán giá trị cho các tham số
            SqlParameter[] pars = new SqlParameter[1];

            //Phần tử 1
            pars[0] = new SqlParameter("@MaSV", SqlDbType.Char, 5);
            pars[0].Value = maSV;

            return DataProvider.ThucHien(strDelete, pars);
        }

    }
}
