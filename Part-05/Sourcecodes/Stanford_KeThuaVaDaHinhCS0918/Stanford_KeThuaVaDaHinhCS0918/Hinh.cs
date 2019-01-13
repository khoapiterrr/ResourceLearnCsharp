using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_KeThuaVaDaHinhCS0918
{
    public abstract class Hinh
    {
        public abstract double DienTich();

        public virtual void InThongTin()
        {
            Console.WriteLine("Dien tich cua hinh la: " + DienTich());
        }
    }
}
