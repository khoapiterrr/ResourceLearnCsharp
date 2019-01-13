using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Kiểm tra quyền chức năng mức 0
        /// </summary>
        /// <param name="hasPermission"></param>
        public void KiemTraQuyenChucNang(bool hasPermission)
        {
            
            loginToolStripMenuItem.Enabled = !hasPermission;
            logoutToolStripMenuItem.Enabled = hasPermission;
            businessToolStripMenuItem.Enabled = hasPermission;
            reportToolStripMenuItem.Enabled = hasPermission;
            helpToolStripMenuItem.Enabled = hasPermission;
        }
        private void checkLogin()
        {
            // Mặc định ban đầu chưa đăng nhập thì không có quyền
            KiemTraQuyenChucNang(false);


            // Load form đăng nhập
            FrmLogin frm = new FrmLogin(this);
            frm.MdiParent = this;
            frm.Show();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
