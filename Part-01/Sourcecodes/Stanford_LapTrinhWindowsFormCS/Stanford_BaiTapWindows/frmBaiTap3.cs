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
    public partial class frmBaiTap3 : Form
    {
        public frmBaiTap3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý chương trình đăng ký kết bạn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //Xóa thông báo của lần chạy trước đi
            errThongBao.Clear();
            //Khai báo biến
            string hoTen = "", gioiTinh = "", trangThai = "", ketQua = "";
            UInt16 tuoi = 0;

            //Lấy thông tin trên giao diện
            hoTen = txtHoTen.Text;
            gioiTinh = cboGioiTinh.Text;
            trangThai = cboTrangThai.Text;
            
            if(!UInt16.TryParse(txtTuoi.Text, out tuoi))
            {
                //Đưa ra thông báo
                errThongBao.SetError(txtTuoi, "Bạn cần phải nhập tuổi kiểu số");
                txtTuoi.Focus();
                return;
            }

            if(tuoi < 19)
            {
                ketQua = "Không được phép tham gia";
            }
            else
            {
                if(trangThai == "Chưa có gia đình" || trangThai == "Ly hôn")
                {
                    if(gioiTinh == "Nam" && tuoi >= 22)
                    {
                        ketQua = "Được phép tham gia";
                    }
                    else
                    {
                        if (gioiTinh == "Nữ" && tuoi >= 19)
                        {
                            ketQua = "Được phép tham gia";
                        }
                        else
                        {
                            ketQua = "Không được phép tham gia";
                        }
                    }
                }
                else
                {
                    ketQua = "Không được phép tham gia";
                }
            }

            //Hiển thị kết quả
            txtKetQua.Text = ketQua;

        }

        private void frmBaiTap3_Load(object sender, EventArgs e)
        {
            txtHoTen.Focus();
        }
    }
}
