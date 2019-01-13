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
    public partial class frmBaiTap6 : Form
    {
        public frmBaiTap6()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string ketQua = "";

            int giaTri = 0, kieu = 0;

            //Lấy thông tin từ trên giao diện
            giaTri = int.Parse(txtGiaTri.Text);

            //Lấy chỉ số hay vị trí của thông tin đấy trên danh sách, bắt đầu từ 0
            kieu = cboKieu.SelectedIndex;

            //Sử dụng vòng lặp
            int i = 0;
            while(i <= giaTri)
            {
                if(kieu == 0 && i % 2== 0)
                {
                    ketQua += i + "-";
                }
                else
                {
                    if (kieu == 1 && i % 2 != 0)
                    {
                        ketQua += i + "-";
                    }
                }
                i++;
            }

            //Loại bỏ kí tự - ở cuối chuỗi
            ketQua = ketQua.Substring(0, ketQua.Length - 1);

            //Hiển thị kết quả
            txtKetQua.Text = ketQua;
        }

        private void frmBaiTap6_Load(object sender, EventArgs e)
        {
            //Khai báo 1 danh sách
            string[] arr = new string[] { "C#", "Java", "PHP", "Swift" };

            foreach(string value in arr)
            {
                MessageBox.Show(value);
            }
        }
    }
}
