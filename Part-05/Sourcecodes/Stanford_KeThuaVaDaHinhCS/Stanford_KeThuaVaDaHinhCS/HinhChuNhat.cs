using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Stanford_KeThuaVaDaHinhCS
{
  public  class HinhChuNhat: Hinh
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public override double DienTich()
        {
            return (ChieuDai * ChieuRong);
        }

        public override void InThongTin()
        {
            Debug.WriteLine("Diện tích Hình chữ nhật là: " + DienTich());
        }

    }
}
