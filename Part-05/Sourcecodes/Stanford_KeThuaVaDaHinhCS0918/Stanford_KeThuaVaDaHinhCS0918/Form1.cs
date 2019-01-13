using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stanford_KeThuaVaDaHinhCS0918
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Khai báo đối tượng mèo Tom
            Cat tom = new Cat();

            //Gán giá trị cho các thuộc tính
            tom.SoMat = 2;
            tom.SoChan = 4;
            tom.MauLong = "Màu xám";

            //Khai báo 1 đối tượng chó John
            Dog john = new Dog();

            //Gán giá trị
            john.SoMat = 2;
            john.SoChan = 4;
            john.MauLong = "Màu đen";

            //Gọi in thông tin của 2 loài
            Console.WriteLine("Thong tin cua meo Tom la:");
            tom.InThongTin();
            tom.TiengKeu();

            Console.WriteLine("Thong tin cua cho John la:");
            john.InThongTin();

            //Sử dụng tính diện tích hình tròn, hình chữ nhật
            HinhTron ht = new HinhTron(3);

            ht.InThongTin();

            HinhChuNhat hcn = new HinhChuNhat();
            hcn.ChieuDai = 4;
            hcn.ChieuRong = 3;
            hcn.InThongTin();

           
        }
    }
}
