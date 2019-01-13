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
    public partial class frmDanhSachNhanVien : Form
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void frmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            //Gọi hàm hiển thị danh sách phòng ban
            DanhSachPhongBan();

            //Gọi hàm hiển thị danh sách
            HienThiDanhSachNhanVien();
        }

        private void HienThiDanhSachNhanVien()
        {
            //Khai báo 1 đối tượng để truy xuất các hàm trong NhanVienBusiness
            NhanVienBusiness service = new NhanVienBusiness();

            //Khai báo biến
            string tuKhoa = "", maPhong = "";

            //Lấy thông tin người dùng chọn
            tuKhoa = txtTuKhoa.Text.Trim();
            maPhong = "" + cboPhongBan.SelectedValue;
            //Lấy danh sách
            DataTable dtNhanVien = service.TimKiemNhanVien(tuKhoa, maPhong);

            //Hiển thị lên giao diện danh sách gridview
            gridNhanVien.DataSource = dtNhanVien;
        }

        private void DanhSachPhongBan()
        {
            //KHai báo 1 biến
            PhongBanBusiness service = new PhongBanBusiness();

            DataTable dtPhong = service.LayDanhSachPhongBan();

            //Chèn thêm 1 dòng vào danh sách ở vị trí đầu
            DataRow root = dtPhong.NewRow();
            root[0] = "";
            root[1] = "---Tất cả---";

            dtPhong.Rows.InsertAt(root, 0);

            cboPhongBan.ValueMember = "MaPhong";
            cboPhongBan.DisplayMember = "TenPhong";
            cboPhongBan.DataSource = dtPhong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Khai báo 1 đối tượng thuộc lớp frmNhanVienAdd
            frmNhanVienAdd frmThem = new frmNhanVienAdd();

            //Hiển thị giao diện
            frmThem.ShowDialog();

            //Reload lại danh sách
            HienThiDanhSachNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Khai báo 1 biến dạng chuỗi để chứa mã nhân viên chọn trên danh sách
            string maNV = "";

            //Lấy mã dòng chọn trên gridview
            maNV = "" + gridNhanVien.CurrentRow.Cells[0].Value;

            //Khai báo 1 đối tượng để hiển thị giao diện sửa nhân viên
            frmNhanVienAdd frmSua = new frmNhanVienAdd();

            //Gán mã nhân viên mang lên giao diện sửa nhân viên
            frmSua.MaNhanVien = maNV;

            frmSua.ShowDialog();

            //Reload lại danh sách
            HienThiDanhSachNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Khai báo biến để lấy mã nhân viên
            string maNV = "";

            //Lấy thông tin từ giao diện dòng được chọn trên gridview
            maNV = "" + gridNhanVien.CurrentRow.Cells[0].Value;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                //Xóa thông tin
                bool ketQua = false;

                //Khai báo biến
                NhanVienBusiness service = new NhanVienBusiness();

                //Thực hiện xóa
                ketQua = service.Xoa(maNV);

                //Hiển thị lại danh sách nhân viên để ko còn nhân đã xóa trên danh sách
                if(ketQua)
                {
                    HienThiDanhSachNhanVien();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
        }

    }
}
