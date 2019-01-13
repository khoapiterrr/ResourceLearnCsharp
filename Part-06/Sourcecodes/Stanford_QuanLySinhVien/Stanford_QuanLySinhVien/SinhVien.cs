using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Stanford_QuanLySinhVien
{
   public class SinhVien
    {
        /// <summary>
        /// Hàm khởi tạo không có đối số
        /// </summary>
        public SinhVien()
        {
            DiaChi = "Hà Nội";
        }

        /// <summary>
        /// Hàm khởi tạo có 1 tham số
        /// </summary>
        /// <param name="DiaChi"></param>
        public SinhVien(string DiaChi)
        {
            this.DiaChi = DiaChi;
        }

        /// <summary>
        /// Hàm khởi tạo có 5 tham số
        /// </summary>
        /// <param name="MaSV"></param>
        /// <param name="HoTen"></param>
        /// <param name="DienThoai"></param>
        /// <param name="Email"></param>
        /// <param name="DiaChi"></param>
        public SinhVien(string MaSV, string HoTen, string DienThoai, string Email, string DiaChi)
        {
            //Gán giá trị cho các thuộc tính
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.DienThoai = DienThoai;
            this.Email = Email;
            this.DiaChi = DiaChi;
        }
        private string _MaSV ="";
        public string MaSV
        {
            get { return _MaSV; }
            set {
               
                _MaSV = value;
                if (_MaSV.StartsWith("SF"))
                {
                    Debug.WriteLine("Là học viên của Stanford.com.vn");
                }
            }
        }

        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
    }
}
