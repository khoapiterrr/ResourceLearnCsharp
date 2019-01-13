using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NumberUtility;

namespace Stanford_BaiKiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //// Khởi tạo theo hàm khởi tạo có tham số
            //SoLon solon = new SoLon(txbInput1.Text, txbInput2.Text);

            //// Gọi phương thức tính tổng không tham số
            //txbOutput.Text = solon.TongHaiSoLon();

            // Khởi tạo theo hàm khởi tạo không tham số
            SoLon solon = new SoLon();

            // Gọi phương thức tính tổng hai tham số
            txbOutput.Text = solon.TongHaiSoLon(txbInput1.Text, txbInput2.Text);
        }
    }
}
