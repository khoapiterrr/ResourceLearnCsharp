using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Stanford_KeThuaVaDaHinhCS
{
   public class HinhTron: Hinh
    {
        public double BanKinh { get; set; }

        public override double DienTich()
        {
            return (Math.PI * BanKinh * BanKinh);
        }

        public override void InThongTin()
        {
            Debug.WriteLine("Diện tích hình tròn là: " + DienTich());
        }
    }
}
