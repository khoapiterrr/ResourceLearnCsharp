using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_QuanLyNhanVien
{
   public class NhanVien
    {
        public NhanVien()
        {
            DiaChi = "Hà Nội";
        }

        public NhanVien(string MaNV, string HoTen, string DienThoai, string Email, string DiaChi)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.DienThoai = DienThoai;
            this.Email = Email;
            this.DiaChi = DiaChi;
        }

        public string MaNV { get; set; }

        public string HoTen { get; set; }

        public int GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public string DienThoai { get; set; }

        public string Email { get; set; }

        public string DiaChi { get; set; }

        public string MaPhong { get; set; }
    }
}
