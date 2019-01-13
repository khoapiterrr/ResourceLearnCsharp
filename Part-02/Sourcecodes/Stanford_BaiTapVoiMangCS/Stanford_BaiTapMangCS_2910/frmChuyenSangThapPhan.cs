using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_BaiTapMangCS_2910
{
    public partial class frmChuyenSangThapPhan : Form
    {
        public frmChuyenSangThapPhan()
        {
            InitializeComponent();
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string strSoNhiPhan = "";
            int soThapPhan = 0;

            //Lấy giá trị
            strSoNhiPhan = txtSoNhiPhan.Text;

            //Chuyển từ chuỗi về mảng kí tự
            char[] arr = strSoNhiPhan.ToArray();

            //Chuyển về số thập phân
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == '1')
                {
                    soThapPhan += (int)Math.Pow(2, arr.Length - 1 - i);//2^n-1
                }
            }

            //Hiển thị kết quả
            txtSoThapPhan.Text = soThapPhan.ToString();
        }
    }
}
