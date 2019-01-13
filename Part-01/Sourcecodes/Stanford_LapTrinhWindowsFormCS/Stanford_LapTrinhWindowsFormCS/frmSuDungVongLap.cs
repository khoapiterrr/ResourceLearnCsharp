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
    public partial class frmSuDungVongLap : Form
    {
        public frmSuDungVongLap()
        {
            InitializeComponent();
        }

        private void rbtnWhile_CheckedChanged(object sender, EventArgs e)
        {
            if(!rbtnWhile.Checked)
            {
                return;
            }
            //Xóa dữ liệu listbox trước đó
            lbThongTin.Items.Clear();

            //Khai báo biến
            int i = 1;
            while(i <= 10)
            {
                //Thêm vào 1 thông tin để hiển thị trên listbox
                lbThongTin.Items.Add("Vòng lặp while tiếp tục thực hiện khi điều kiện còn đúng " + i);
                //Tăng i lên 1 đơn vị
                i++;
            }
        }

        private void rbtnDoWhile_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtnDoWhile.Checked)
            {
                return;
            }
            //Xóa dữ liệu listbox trước đó
            lbThongTin.Items.Clear();

            //Khai báo biến
            int i = 1;
            do
            {
                //Công việc thực hiện
                // lbThongTin.Items.Add("Vòng lặp do while, thực hiện trước sau đó mới kiểm tra, nếu đúng thì tiếp tục thực hiện, sai sẽ dừng lại " + i);
                lbThongTin.Items.Add("I Love You " + i);
                i++;
            }
            while (i <= 20);
        }

        private void rbtnFor_CheckedChanged(object sender, EventArgs e)
        {
            //Xóa thông tin trước đó đi nếu có
            lbThongTin.Items.Clear();

            //Hiển thị các số lên giao diện
            for(int i = 80; i<= 100; i+=2)
            {
                //Thêm thông tin lên listbox
                lbThongTin.Items.Add(i);
            }
        }
    }
}
