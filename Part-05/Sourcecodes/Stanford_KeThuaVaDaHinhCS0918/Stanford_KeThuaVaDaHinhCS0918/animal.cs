using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_KeThuaVaDaHinhCS0918
{
 public  class animal
    {
        public int SoMat { get; set; }

        public int SoChan { get; set; }

        public string MauLong { get; set; }

        public virtual String TiengKeu()
        {
            return "";
        }

        public void InThongTin()
        {
            Console.WriteLine("So mat: " + SoMat);
            Console.WriteLine("So chan: " + SoChan);
            Console.WriteLine("Tieng keu: " + TiengKeu());
        }
    }
}
