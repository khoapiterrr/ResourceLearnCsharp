using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_QuanLyNhanVien
{
    public partial class frmCuaSoChinh : Form
    {
        /// <summary>
        /// Khai báo 1 thuộc tính để lưu thông tin đăng nhập
        /// </summary>
        public static string TenDangNhap { get; set; }

        public frmCuaSoChinh()
        {
            InitializeComponent();
        }

        private void menuItemNhanVien_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien frmNhanVien = new frmDanhSachNhanVien();

            frmNhanVien.MdiParent = this;

            frmNhanVien.Show();
        }

        private void frmCuaSoChinh_Load(object sender, EventArgs e)
        {
            //Gọi hàm hiển thị và kiểm tra đăng nhập
            //KiemTraDangNhap();
        }

        private void KiemTraDangNhap()
        {
            //Lúc đầu chưa đăng nhập sẽ ẩn chức năng đi
            HienThiChucNang(false);

            frmDangNhap frmLogin = new frmDangNhap();

            frmLogin.ShowDialog();

            //Kiểm tra quyền
            HienThiChucNang(frmLogin.TrangThaiDangNhap);
        }
        private void HienThiChucNang(bool isHienThi)
        {
            menuNghiepVu.Enabled = isHienThi;
            menuBaoCao.Enabled = isHienThi;
            menuItemNguoiDung.Visible = isHienThi;
           
            if(isHienThi)
            {
                menuItemDangNhap.Visible = false;
                menuItemDangXuat.Visible = true;
            }
            else
            {
                menuItemDangNhap.Visible = true;
                menuItemDangXuat.Visible = false;
            }
        }

        private void menuItemDangNhap_Click(object sender, EventArgs e)
        {
            //Gọi hàm hiển thị và kiểm tra đăng nhập
            KiemTraDangNhap();
        }

        private void menuItemDangXuat_Click(object sender, EventArgs e)
        {
            //Gọi hàm hiển thị và kiểm tra đăng nhập
            KiemTraDangNhap();
        }

        private void menuItemKhachHang_Click(object sender, EventArgs e)
        {
            frmDanhSachKhachHang frmKhachHang = new frmDanhSachKhachHang();
            frmKhachHang.Show();
        }

        private void menuItemNguoiDung_Click(object sender, EventArgs e)
        {
            frmDanhSachNguoiDung frmNguoiDung = new frmDanhSachNguoiDung();
            frmNguoiDung.Show();
        }
    }
}
