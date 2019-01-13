using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALLayer
{
    public class Common
    {
        /// <summary>
        /// Khai báo chuỗi kết nối để làm việc với db trong SQL Server
        /// </summary>
        private static string _ConnectString = @"Server=HAHAHA-PC\SQLEXPRESS2012; Database=ProjectQLSV;User ID=sa;Password =Sqlserver@2012";

        public static string ConnectString
        {
            get { return _ConnectString; }
        }
    }
}
