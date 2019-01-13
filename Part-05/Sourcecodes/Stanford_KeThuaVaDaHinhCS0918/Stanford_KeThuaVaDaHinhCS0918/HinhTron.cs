using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_KeThuaVaDaHinhCS0918
{
    public class HinhTron:Hinh
    {
        private double banKinh;

        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public override double DienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
    }
}
