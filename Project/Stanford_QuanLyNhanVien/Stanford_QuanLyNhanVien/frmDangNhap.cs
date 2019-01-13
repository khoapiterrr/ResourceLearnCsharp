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
    public partial class frmDangNhap : Form
    {
        /// <summary>
        /// Khai báo thuộc tính để biết đăng nhập thành công thì trả về true
        /// Thất bại trả về false
        /// </summary>
        public bool TrangThaiDangNhap { get; set; }

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Khai báo biến và lấy thông tin
            string tenDangNhap = "", matKhau = "";

            //Lấy thông tin từ giao diện
            tenDangNhap = txtTenDangNhap.Text.Trim();
            matKhau = txtMatKhau.Text;

            //Khai báo đối tượng
            NguoiDungBusiness service = new NguoiDungBusiness();

            DataTable dtNguoiDung = service.KiemTraDangNhap(tenDangNhap);

            if(dtNguoiDung.Rows.Count > 0)
            {
                //Lấy mật khẩu trong db
                string matKhauDb = "" + dtNguoiDung.Rows[0]["MatKhau"];

                //Nếu đúng mật khẩu
                if(matKhau.Equals(matKhauDb))
                {
                    //Gán thông tin
                    TrangThaiDangNhap = true;
                    frmCuaSoChinh.TenDangNhap = tenDangNhap;
                    //Đóng cửa sổ đăng nhập
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu đăng nhập không đúng", "Thông báo");
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại. Bạn vui lòng kiểm tra lại", "Thông báo");
                txtTenDangNhap.Focus();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
