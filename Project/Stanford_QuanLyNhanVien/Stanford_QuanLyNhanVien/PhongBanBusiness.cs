using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Stanford_QuanLyNhanVien
{
   public class PhongBanBusiness
    {
        public DataTable LayDanhSachPhongBan()
        {
            string strSQL = "Select MaPhong, TenPhong from PhongBan";

            return DataProvider.LayDanhSach(strSQL);
        }
    }
}
