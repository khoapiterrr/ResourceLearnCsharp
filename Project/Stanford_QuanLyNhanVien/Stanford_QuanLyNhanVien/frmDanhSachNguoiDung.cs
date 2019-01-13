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
    public partial class frmDanhSachNguoiDung : Form
    {
        public frmDanhSachNguoiDung()
        {
            InitializeComponent();
        }

        private void frmDanhSachNguoiDung_Load(object sender, EventArgs e)
        {
            ucAction1.NhanNutThem += UcAction1_NhanNutThem;
        }

        private void UcAction1_NhanNutThem(object sender, EventArgs e)
        {
            frmNguoiDungAdd frmThem = new frmNguoiDungAdd();
            frmThem.Show();
        }
    }
}
