using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_KeThuaVaDaHinhCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Khai báo 1 đối tượng thuộc lớp Cat
            Cat tom = new Cat();

            //Gán giá trị
            tom.SoMat = 2;
            tom.SoChan = 4;
            tom.MauLong = "Màu xám";

            //In thông tin
            string strThongTin = "Thông tin mèo Tom: ";
            strThongTin += "Màu lông: " + tom.MauLong + "\n";
            strThongTin += "Số mắt: " + tom.SoMat + "\n";
            strThongTin += "Số chân: " + tom.SoChan + "\n";
            strThongTin += "Tiếng kêu: " + tom.TiengKeu() + "\n";

            //Khai báo 1 đối tượng Dog
            Dog john = new Dog();

            //Gán thông tin cho thuộc tính
            john.SoMat = 2;
            john.SoChan = 4;
            john.MauLong = "Màu đen";

            //In thông tin
            strThongTin += "Thông tin chó John: ";
            strThongTin += "Màu lông: " + john.MauLong + "\n";
            strThongTin += "Số mắt: " + john.SoMat + "\n";
            strThongTin += "Số chân: " + john.SoChan + "\n";
            strThongTin += "Tiếng kêu: " + john.TiengKeu() + "\n";

            //MessageBox.Show(strThongTin);

            //Khai báo 1 đối tượng thuộc lớp HCN
            HinhChuNhat hcn = new HinhChuNhat();

            hcn.ChieuDai = 5;
            hcn.ChieuRong = 3;

            hcn.InThongTin();

            //Khai báo đối tượng HT
            HinhTron ht = new HinhTron();
            ht.BanKinh = 3;

            ht.InThongTin();
        }
    }
}
