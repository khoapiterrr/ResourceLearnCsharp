using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using DALLayer;

namespace BusinessLayer
{
    public class LoginBusiness
    {

        /// <summary>
        /// Hàm kiểm tra đăng nhập
        /// </summary>
        /// <param name="username">Tài khoản của người dùng</param>
        /// <param name="password">Mật khẩu người dùng</param>
        /// <returns>Nếu tồn tại tài khoản tra về true, ngược lại trả về false</returns>
        public bool KiemTraDangNhap(string username, string password)
        {
            bool isSuccess = false;

            //Câu lệnh truy vấn thông tin người dùng
            string strSQL = "Select * from NguoiDung where username = '" + username + "' and password = '" + password + "' and Lock = 1";

            DataTable result = DataProvider.LayDanhSach(strSQL);

            if (result != null && result.Rows.Count == 1)
            {
                isSuccess = true;
            }

            return isSuccess;
        }
    }
}
