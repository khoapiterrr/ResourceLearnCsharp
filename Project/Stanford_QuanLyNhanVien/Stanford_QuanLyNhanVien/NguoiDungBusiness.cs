using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Stanford_QuanLyNhanVien
{
   public class NguoiDungBusiness
    {
        /// <summary>
        /// Hàm kiểm tra đăng nhập hệ thống
        /// </summary>
        /// <param name="tenDangNhap"></param>
        /// <returns></returns>
        public DataTable KiemTraDangNhap(string tenDangNhap)
        {
            string strSQL = string.Format("Select Id, TenDangNhap, MatKhau from NguoiDung where TenDangNhap = '{0}'", tenDangNhap);

            return DataProvider.LayDanhSach(strSQL);
        }
    }
}
