using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Stanford_KeThuaVaDaHinhCS
{
    public abstract class Hinh
    {
        public abstract double DienTich();

        public virtual void InThongTin()
        {
            Debug.WriteLine("Diện tích của hình là: " + DienTich());
        }
    }
}
