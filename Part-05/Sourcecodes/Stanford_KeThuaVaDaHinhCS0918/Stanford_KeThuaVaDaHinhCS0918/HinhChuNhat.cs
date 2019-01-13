using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_KeThuaVaDaHinhCS0918
{
  public class HinhChuNhat: Hinh
    {
        public double ChieuDai { get; set; }

        public double ChieuRong { get; set; }

        public override double DienTich()
        {
            return ChieuDai * ChieuRong;
        }
    }
}
