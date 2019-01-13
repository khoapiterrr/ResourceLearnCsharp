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
    public partial class frmNhanVienAdd : Form
    {
        //Khai báo 1 thuộc tính để có thể truyền thông tin từ giao diện danh sách lên frmNhanVienAdd
        private string _MaNhanVien = "";
        public string MaNhanVien
        {
            get
            {
                return _MaNhanVien;
            }
            set
            {
                _MaNhanVien = value;
            }
        }

        public frmNhanVienAdd()
        {
            InitializeComponent();
        }

        private void frmNhanVienAdd_Load(object sender, EventArgs e)
        {
            //Gọi hàm hiển thị danh sách phòng
            DanhSachPhongBan();

            //Nếu mã nhân viên khác rỗng
            if(!string.IsNullOrEmpty(MaNhanVien))
            {
                this.Text = "Sửa thông tin nhân viên";

                //Hiển thị thông tin chi tiết của nhân viên
                HienThiChiTietNhanVien();
            } 
            else
            {
                this.Text = "Thêm mới thông tin nhân viên";
            }
        }

        private void DanhSachPhongBan()
        {
            //KHai báo 1 biến
            PhongBanBusiness service = new PhongBanBusiness();

            DataTable dtPhong = service.LayDanhSachPhongBan();

            cboPhongBan.ValueMember = "MaPhong";
            cboPhongBan.DisplayMember = "TenPhong";
            cboPhongBan.DataSource = dtPhong;
        }


        /// <summary>
        /// Hàm hiển thị chi tiết thông tin nhân viên
        /// </summary>
        private void HienThiChiTietNhanVien()
        {
            //Lấy thông tin chi tiết của nhân viên
            NhanVienBusiness service = new NhanVienBusiness();
            DataTable dtNhanVien = service.ChiTietNhanVienTheoMa(MaNhanVien);

            //Nếu nhân viên tồn tại
            if (dtNhanVien != null && dtNhanVien.Rows.Count > 0)
            {
                txtMaNV.Text = MaNhanVien;
                txtHoTen.Text = "" + dtNhanVien.Rows[0]["HoTen"];
                cboGioiTinh.SelectedIndex = int.Parse("0" + dtNhanVien.Rows[0]["GioiTinh"]);
                txtDienThoai.Text = "" + dtNhanVien.Rows[0]["DienThoai"];
                txtEmail.Text = "" + dtNhanVien.Rows[0]["Email"];
                txtDiaChi.Text = "" + dtNhanVien.Rows[0]["DiaChi"];

                //Hiển thị phòng của nhân viên
                cboPhongBan.SelectedValue = "" + dtNhanVien.Rows[0]["MaPhong"];

                //Hiển thị ngày sinh lên giao diện
                DateTime ngaySinh = DateTime.Now;

                //Thử chuyển thông tin về dạng ngày tháng nếu đúng thì gán cho biến
                DateTime.TryParse("" + dtNhanVien.Rows[0]["NgaySinh"], out ngaySinh);

                dtpNgaySinh.Value = ngaySinh;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //Khai báo và khởi tạo 1 đối tượng
            NhanVien objNhanVien = new NhanVien();

            //Lấy thông tin trên giao diện và gán cho thuộc tính của đối tượng
            objNhanVien.MaNV = txtMaNV.Text;
            objNhanVien.HoTen = txtHoTen.Text;
            objNhanVien.GioiTinh = cboGioiTinh.SelectedIndex;
            objNhanVien.NgaySinh = dtpNgaySinh.Value;
            objNhanVien.DienThoai = txtDienThoai.Text;
            objNhanVien.Email = txtEmail.Text;
            objNhanVien.DiaChi = txtDiaChi.Text;

            //Lấy mã phòng người dùng chọn
            objNhanVien.MaPhong = "" + cboPhongBan.SelectedValue;
            
            //Gọi hàm thêm mới
            bool ketQua = false;

            //Nếu có mã nhân viên
            if (!string.IsNullOrEmpty(MaNhanVien))
            {
                //Trường hợp sửa thông tin nhân viên
                objNhanVien.MaNV = MaNhanVien;
               ketQua = DataProvider.nhanVienBus.CapNhat(objNhanVien);
            }
            else
            {
               ketQua = DataProvider.nhanVienBus.ThemMoi(objNhanVien);
            }

            //Nếu thực hiện thành công
            if(ketQua)
            {
                MessageBox.Show("Cập nhật nhân viên thành công");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //Đóng cửa sổ hiện thời
            this.Close();
        }
    }
}
