using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_BaiTapWindows
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý nút đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //1. Khai báo biến
            string tenDangNhap = "", matKhau = "";

            //Lấy thông tin trên giao diện
            tenDangNhap = txtTenDangNhap.Text.Trim();
            matKhau = txtMatKhau.Text;

            //2. Kiểm tra dữ liệu nhập vào
            //Nếu không nhập tên đăng nhập
            if(tenDangNhap.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập tên đăng nhập");
                //Focus vào txtTenDangNhap
                txtTenDangNhap.Focus();

                //Thoát ra khỏi ct không thực hiện nữa
                return;
            }

            if (matKhau.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập mật khẩu đăng nhập");
                //Focus vào txtMatKhau
                txtMatKhau.Focus();

                //Thoát ra khỏi ct không thực hiện nữa
                return;
            }

            //Kiểm tra đúng tên đăng nhập và mật khẩu
            if(tenDangNhap.Equals("stanford") && matKhau.Equals("123"))
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Bạn vui lòng kiểm tra lại thông tin");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //Khai báo biến để chứa kết quả câu thông báo
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //Nếu nhấn ok thì đóng ứng dụng
            if(dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
