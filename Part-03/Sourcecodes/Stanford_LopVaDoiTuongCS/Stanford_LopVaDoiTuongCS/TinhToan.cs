using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Stanford_LopVaDoiTuongCS
{
    class TinhToan
    {
        private const double PI = 3.14;

        /// <summary>
        /// Hàm có giá trị trả về và có tham số truyền vào
        /// </summary>
        /// <param name="banKinh"></param>
        /// <returns></returns>
        public double dienTichHT(double banKinh)
        {
            return PI * banKinh * banKinh;
        }

        /// <summary>
        /// Hàm không có giá trị trả về và không có tham số truyền vào
        /// </summary>
        public void inThongTin()
        {
            Debug.WriteLine("Hôm nay trời đẹp quá !");
        }

        /// <summary>
        /// Hàm không có giá trị trả về và có 1 tham số truyền vào
        /// </summary>
        /// <param name="n"></param>
        public void inThongTin(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Debug.WriteLine("I Love You " + i);
            }
        }

        /// <summary>
        /// Hàm có giá trị trả về và không có tham số truyền vào
        /// </summary>
        /// <returns></returns>
        public string layTenCongTy()
        {
            return "Stanford - Đào tạo và phát triển công nghệ";
        }

    }
}
