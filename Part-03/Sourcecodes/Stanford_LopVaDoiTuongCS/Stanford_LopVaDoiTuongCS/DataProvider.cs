using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_LopVaDoiTuongCS
{
  public  class DataProvider
    {
        /// <summary>
        /// Khai báo 1 thuộc tính dạng static để có thể gọi đến thuộc tính của lớp SinhVienBusiness giúp truy xuất và sử dụng các hàm trong lớp đó ở nhiều nơi
        /// </summary>
        private static IHanhDong _sinhVienBus = new SinhVienBusiness();
        public static IHanhDong SinhVienBus
        {
            get { return _sinhVienBus; }
        }
    }
}
