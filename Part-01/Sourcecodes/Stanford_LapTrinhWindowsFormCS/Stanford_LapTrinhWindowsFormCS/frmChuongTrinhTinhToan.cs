using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_LapTrinhWindowsFormCS
{
    public partial class frmChuongTrinhTinhToan : Form
    {
        public frmChuongTrinhTinhToan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý công việc khi người dùng nhấn nút thực hiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            //Viết code ở trong đây
            //Khai báo biến
            string strSoa = "", strSob = "", phepTinh = "";
            double soa = 0, sob = 0, ketQua = 0;

            //Lấy thông tin người dùng nhập trên các textbox, combobox
            strSoa = txtSoa.Text;
            strSob = txtSob.Text;
            phepTinh = cboPhepTinh.Text;

            //Chuyển thông tin về dạng số
            soa = double.Parse(strSoa);
            sob = double.Parse(strSob);

            //Xử lý công việc
            switch(phepTinh)
            {
                case "Cộng": ketQua = soa + sob;
                    break;
                case "Trừ": ketQua = soa - sob;
                    break;
                case "Nhân": ketQua = soa * sob;
                    break;
                case "Chia":

                    if(sob == 0)
                    {
                        //Đưa ra thông báo
                        MessageBox.Show("Bạn cần nhập số b khác 0", "Thông báo");
                        //Di chuyển hay focus con chuột vào textbox b
                        txtSob.Focus();
                        return;//Thoát ra, không thực hiện công việc tiếp theo nữa
                    }
                    ketQua = soa / sob;
                    break;
            }

            //Hiển thị kết quả
            txtKetQua.Text = ketQua.ToString();
        }

        /// <summary>
        /// Xử lý nút đóng ứng dụng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDong_Click(object sender, EventArgs e)
        {
            //Khai báo biến để chứa kết quả thông báo người dùng chọn
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Nếu người dùng chọn yes
            if(dr == DialogResult.Yes)
            {
                //Tắt ứng dụng
                Application.Exit();
            }
        }
    }
}
