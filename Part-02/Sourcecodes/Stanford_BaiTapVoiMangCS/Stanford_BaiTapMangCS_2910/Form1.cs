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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Viết những công việc cần xử lý khi form hiển thị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Gán giá trị
            txtDaySo.Text = "50,40,80,100,10,30,20,60,70,90";
        }

        //Khai báo 1 biến mảng toàn cục
        string[] arr = new string[10];

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string daySo = "";
            int giaTriLonNhat = 0, giaTriNhoNhat = 0, soLan = 0;
            Int64 tongBinhPhuong = 0;

            int soCanTim = 0;

            //Lấy thông tin từ trên giao diện
            daySo = txtDaySo.Text;

            if(!int.TryParse(txtSoCanTim.Text, out soCanTim))
            {
                MessageBox.Show("Bạn cần phải nhập số cần tìm kiểu số");
                txtSoCanTim.Focus();
                return;
            }

            //Chuyển chuỗi về mảng
            arr = daySo.Split(',');

            //Tìm max, min
            giaTriLonNhat = int.Parse(arr[0]);
            giaTriNhoNhat = int.Parse(arr[0]);
            for(int i = 0; i < arr.Length; i++)
            {
                //Gán lại giá trị lớn nhất
                if(int.Parse(arr[i]) > giaTriLonNhat)
                {
                    //Gán lại giá trị lớn nhất
                    giaTriLonNhat = int.Parse(arr[i]);
                }

                //Gán lại giá trị nhỏ nhất
                if (int.Parse(arr[i]) < giaTriLonNhat)
                {
                    //Gán lại giá trị lớn nhất
                    giaTriNhoNhat = int.Parse(arr[i]);
                }
                //Tính tổng bình phương
                tongBinhPhuong += int.Parse(arr[i]) * int.Parse(arr[i]);

                //Tìm số trong dãy
                if(int.Parse(arr[i]) == soCanTim)
                {
                    soLan++;
                }
            }

            #region  Xử lý sắp xếp
            string temp = "";
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(rbtnTangDan.Checked)
                    {
                        //Nếu thỏa mãn điều kiện thì hoán đổi
                        if(int.Parse(arr[j]) < int.Parse(arr[i]))
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                    else
                    {
                        if (rbtnGiamDan.Checked)
                        {
                            if (int.Parse(arr[j]) > int.Parse(arr[i]))
                            {
                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }
                        }
                    }
                }
            }

            #endregion Kết thúc xử lý sắp xếp

            //Hiển thị lên giao diện
            lbDaySo.Items.Clear();
            for (int i = 0; i< arr.Length; i++)
            {
                //Thêm vào listbox
                lbDaySo.Items.Add(arr[i]);
            }

            //Hiển thị kết quả
            lblMax.Text = giaTriLonNhat.ToString();
            lblMin.Text = giaTriNhoNhat.ToString();
            lblSoLan.Text = soLan.ToString();
            lblTongBinhPhuong.Text = tongBinhPhuong.ToString();

        }

        private void rbtnTangDan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnGiamDan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
