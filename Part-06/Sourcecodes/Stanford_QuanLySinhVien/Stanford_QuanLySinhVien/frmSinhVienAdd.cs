using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_QuanLySinhVien
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

        /// <summary>
        /// Xử lý thêm mới, sửa thông tin sinh viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Khai báo một đối tương sinh viên
            SinhVien sv = new SinhVien();

            // Gán giá trị người dùng nhập cho sinh viên
            sv.MaSV = txtMaSV.Text.Trim();
            sv.HoTen = txtHoTen.Text.Trim();
            sv.DiaChi = txtDiaChi.Text.Trim();
            sv.DienThoai = txtDienThoai.Text.Trim();
            sv.Email = txtEmail.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.GioiTinh = cboGioiTinh.SelectedIndex;

            //Khai báo đối tượng
            SinhVienBusiness sinhVienBusiness = new SinhVienBusiness();

            // Thực hiện nghiệp vụ thêm mới
            bool ketQua = false;
            if (string.IsNullOrEmpty(MaSinhVien))
            {
                ketQua = sinhVienBusiness.themMoiSinhVien(sv);
            }
            else // Có mã sinh viên thì thực hiện việc cập nhật
            {
                ketQua = sinhVienBusiness.capNhat(sv);
            }

            if(ketQua)
            {
                MessageBox.Show("Cập nhật thông tin sinh viên thành công");
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
                SinhVienBusiness sinhVienBusiness = new SinhVienBusiness();
                DataTable dtSV = sinhVienBusiness.layChiTietSinhVienTheoMa(MaSinhVien);

                if (dtSV.Rows.Count > 0)
                {
                    txtMaSV.Text = MaSinhVien;
                    txtMaSV.Enabled = false;
                    txtHoTen.Text = "" + dtSV.Rows[0]["HoTen"];
                    txtDiaChi.Text = "" + dtSV.Rows[0]["DiaChi"];
                    txtDienThoai.Text = "" + dtSV.Rows[0]["DienThoai"];
                    txtEmail.Text = "" + dtSV.Rows[0]["Email"];
                   // cboGioiTinh.SelectedIndex = sv.GioiTinh;
                    //dtpNgaySinh.Value = sv.NgaySinh;
                }
            }
        }
    }
}
