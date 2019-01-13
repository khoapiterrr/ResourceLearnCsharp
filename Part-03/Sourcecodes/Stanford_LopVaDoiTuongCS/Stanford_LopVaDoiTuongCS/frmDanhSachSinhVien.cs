using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_LopVaDoiTuongCS
{
    public partial class frmDanhSachSinhVien : Form
    {
        public frmDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Gọi hàm hiển thị danh sách ở đây
            HienThiDanhSachSinhVien();
        }

        private void HienThiDanhSachSinhVien()
        {
            gridSinhVien.DataSource = null;
            gridSinhVien.DataSource = DataProvider.SinhVienBus.layDanhSach();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //Khai báo 1 đối tượng
            frmSinhVienAdd frmThemMoi = new frmSinhVienAdd();

            //Hiển thị form
            frmThemMoi.ShowDialog();

            // Load lại danh sách sinh viên
            HienThiDanhSachSinhVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Khai báo 1 đối tượng sửa
            frmSinhVienAdd frmSuaSinhVien = new frmSinhVienAdd();

            string maSinhVien = gridSinhVien.CurrentRow.Cells[0].Value.ToString();

            //Hiển thị form
            frmSuaSinhVien.MaSinhVien = maSinhVien;
            frmSuaSinhVien.ShowDialog();

            // Load lại danh sách sinh viên phía dưới sau sửa để nhìn kết quả thay đổi
            HienThiDanhSachSinhVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSinhVien = gridSinhVien.CurrentRow.Cells[0].Value.ToString();

            DataProvider.SinhVienBus.XoaSinhVien(maSinhVien);

            // Load lại danh sách sinh viên phía dưới sau xóa để nhìn kết quả thay đổi
            HienThiDanhSachSinhVien();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gridSinhVien.DataSource = null;
            gridSinhVien.DataSource = DataProvider.SinhVienBus.TimKiemSinhVien(txtHoTen.Text);
        }
    }
}
