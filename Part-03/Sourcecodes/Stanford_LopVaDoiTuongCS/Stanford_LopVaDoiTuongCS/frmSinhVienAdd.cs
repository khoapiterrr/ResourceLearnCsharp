using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_LopVaDoiTuongCS
{
    public partial class frmSinhVienAdd : Form
    {
        // Trường khóa dùng để xác định việc sửa xóa sinh viên trên form
        private string _MaSinhVien;
        public string MaSinhVien
        {
            get { return _MaSinhVien; }
            set { _MaSinhVien = value; }
        }

        public frmSinhVienAdd()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Khai báo một đối tương sinh viên
            SinhVien sv = new SinhVien();
            string a = MaSinhVien;
            // Gán giá trị người dùng nhập cho sinh viên
            sv.MaSV = txtMaSV.Text.Trim();
            sv.HoTen = txtHoTen.Text.Trim();
            sv.DiaChi = txtDiaChi.Text.Trim();
            sv.DienThoai = txtDienThoai.Text.Trim();
            sv.Email = txtEmail.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.GioiTinh = cboGioiTinh.SelectedIndex;

            // Thực hiện nghiệp vụ thêm mới
            if (string.IsNullOrEmpty(MaSinhVien))
            {
                DataProvider.SinhVienBus.themMoiSinhVien(sv);
            }
            else // Có mã sinh viên thì thực hiện việc cập nhật
            {
                DataProvider.SinhVienBus.CapNhatSinhVien(sv);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //Đóng cửa sổ hiện thời
            this.Close();
        }

        private void frmSinhVienAdd_Load(object sender, EventArgs e)
        {

            // Nếu MaSinhVien khác null thì đây là form sửa
            if (!string.IsNullOrEmpty(MaSinhVien))
            {
                // Gọi tới hàm tìm kiếm sinh viên theo mã
                SinhVien sv = DataProvider.SinhVienBus.TimKiemSinhVienTheoMa(MaSinhVien);

                if (sv != null)
                {
                    txtMaSV.Text = sv.MaSV;
                    txtMaSV.Enabled = false;
                    txtHoTen.Text = sv.HoTen;
                    txtDiaChi.Text = sv.DiaChi;
                    txtDienThoai.Text = sv.DienThoai;
                    txtEmail.Text = sv.Email;
                    cboGioiTinh.SelectedIndex = sv.GioiTinh;
                    dtpNgaySinh.Value = sv.NgaySinh;
                }
            }
        }
    }
}
