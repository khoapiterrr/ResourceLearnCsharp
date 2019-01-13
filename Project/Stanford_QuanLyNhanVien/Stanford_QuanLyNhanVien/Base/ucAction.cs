using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_QuanLyNhanVien.Base
{
    public partial class ucAction : UserControl
    {
        //Khai báo các sự kiện
        public event EventHandler NhanNutThem = null;
        public event EventHandler NhanNutSua = null;
        public event EventHandler NhanNutXoa = null;
        public event EventHandler NhanNutDong = null;

        public ucAction()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(NhanNutThem != null)
            {
                //Gọi sự kiện nhấn nút thêm mới
                NhanNutThem(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(NhanNutSua != null)
            {
                //Gọi sự kiện nhấn nút sửa
                NhanNutSua(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NhanNutXoa != null)
            {
                //Gọi sự kiện nhấn nút xóa
                NhanNutXoa(sender, e);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (NhanNutDong != null)
            {
                //Gọi sự kiện nhấn nút dóng
                NhanNutDong(sender, e);
            }
        }
    }
}
