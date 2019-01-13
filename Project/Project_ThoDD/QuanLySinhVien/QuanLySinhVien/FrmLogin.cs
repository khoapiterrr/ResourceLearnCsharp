using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
namespace QuanLySinhVien
{
    public partial class FrmLogin : Form
    {
        private LoginBusiness loginBusiness;
        private FrmMain parent;
        public FrmLogin(FrmMain frmParent)
        {
            InitializeComponent();
            loginBusiness = new LoginBusiness();
            parent = frmParent;
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (loginBusiness.KiemTraDangNhap(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                parent.KiemTraQuyenChucNang(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, liên hệ Sadmin để kiểm tra tài khoản");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
