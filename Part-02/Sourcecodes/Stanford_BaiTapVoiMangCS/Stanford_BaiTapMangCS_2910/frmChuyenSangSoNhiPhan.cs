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
    public partial class frmChuyenSangSoNhiPhan : Form
    {
        public frmChuyenSangSoNhiPhan()
        {
            InitializeComponent();
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string strSoThapPhan = "", soNhiPhan = "";
            int soThapPhan = 0, soDu = 0;

            //Khai báo 1 danh sách để chứa số dư
            List<string> lstBit = new List<string>();

            //Lấy thông tin trên giao diện
            strSoThapPhan = txtSoThapPhan.Text;

            //Chuyển đổi sang dạng số
            try
            {
                soThapPhan = int.Parse(txtSoThapPhan.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình chuyển đổi. Chi tiết: " + ex.Message);
                txtSoThapPhan.Focus();
                return;
            }
           
            //Xử lý đưa về dạng số nhị phân
            //Thực hiện vòng lặp đến khi nào soThapPhan = 0
            //Mỗi lần sẽ lưu số dư vào list
            while(soThapPhan > 0)
            {
                soDu = soThapPhan % 2;
                soThapPhan = soThapPhan / 2;
                //Thêm vào danh sách
                lstBit.Add("" + soDu);
            }

            //Duyệt theo chiều ngược lại
            for(int i = lstBit.Count - 1; i >=0; i--)
            {
                soNhiPhan += lstBit[i];
            }

            //Hiển thị lên giao diện
            txtSoNhiPhan.Text = soNhiPhan;
        }
    }
}
