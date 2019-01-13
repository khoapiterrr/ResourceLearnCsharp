using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_QuanLySinhVien
{
    public class Common
    {
        /// <summary>
        /// Khai báo chuỗi kết nối để làm việc với db trong SQL Server
        /// </summary>
<<<<<<< .mine
        private static string _ConnectString = @"Server=KHOAPITERRR_99\SQL_2012_EXPRESS; Database=sql_QuanLyNhanVien;Integrated Security = true;";
||||||| .r113
        private static string _ConnectString = @"Server=DANGBQ_INSPIRON\SQL2012; Database=CS091801CB;Integrated Security = true;";
=======
        private static string _ConnectString = @"Server=HAHAHA-PC\SQLEXPRESS2012; Database=CS091801CB;User ID=sa;Password =Sqlserver@2012";
>>>>>>> .r118

        public static string ConnectString
        {
            get { return _ConnectString; }
        }

    }
}
