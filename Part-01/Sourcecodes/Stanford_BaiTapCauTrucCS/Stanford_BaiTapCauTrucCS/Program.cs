using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_BaiTapCauTrucCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Bai 1
            //− Tuổi của một người − Số lượng cây trong thành phố
            Int16 tuoiNguoi = 25;
            Int32 soLuongCay = 10000;
            //− Độ dài cạnh một tam giác − Khoảng cách giữa các hành tinh
            float doDaiCanh = 2.56f;
            double khoangCach = 213456545.57567f;
            //− Một chữ số − Nghiệm x của phương trình bậc 1
            char chuSo = '9';
            float x = 12.56f;
            //− Một chữ cái − Biệt thức Δ của phương trình bậc 2
            char chuCai = 'S';
            float delta = 10.5457f;
            Console.WriteLine("Tuoi cua nguoi la: " + tuoiNguoi);
            Console.WriteLine("So luong cay la: " + soLuongCay);
            Console.WriteLine("Chu so la: " + chuSo);
            Console.WriteLine("Nghiem cua phuong trinh:{0}", delta.ToString("F2"));

            //Bai tap 2
            //Khai báo biến
            float soThuc = 0;
            Int16 soNguyen = 0;
            Int64 soNguyenDai = 0;
            char kiTu;

            //Yêu cầu người dùng nhập thông tin từ bàn phím
            Console.Write("Nhap so thuc la: ");
            //Lấy thông tin từ màn hình người dùng nhập vào sau đó gán cho biến
            soThuc = float.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen la: ");
            soNguyen = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nhap so nguyen dai la: ");
            soNguyenDai = Convert.ToInt64(Console.ReadLine());

            //Lấy 1 kí tự
            Console.Write("Nhap 1 ki tu: ");
            kiTu = Console.ReadLine().ToArray()[0];

            //In thông tin ra màn hình
            //Hiển thị tiếng việt có dấu
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Số thực: " + soThuc);
            Console.WriteLine("Số nguyên: " + soNguyen);
            Console.WriteLine("Số nguyên dài: " + soNguyenDai.ToString("###,###"));
            Console.WriteLine("Kí tự là: " + kiTu);

            //Bài 4
            Console.WriteLine("Ki tu {0} co ma ascii la: {1}", kiTu, (int)kiTu);
            

            //Bài 5
            //Khai báo biến
            float soThuc1 = 0, soThuc2 = 0;

            Console.Write("Nhap so thuc 1 = ");
            soThuc1 = float.Parse(Console.ReadLine());

            Console.Write("Nhap so thuc 2 = ");
            soThuc2 = float.Parse(Console.ReadLine());

            //In ra
            Console.WriteLine("So thuc 1 = {0} \t So thuc 2 = {1}", soThuc1.ToString("###.00"), soThuc2.ToString("###.00"));

            //Bài tập 6
            //Khai báo biến
            double cau6a = 0, cau6b = 0;
            cau6a = Math.Sqrt(3 + Math.Sqrt(3 + Math.Sqrt(3)));
            cau6b = 1 / (2.0 + 1 / (2.0 + 1 / 2.0));

            Console.WriteLine("Ket qua cau 6a la: {0}", cau6a.ToString("F2"));
            Console.WriteLine("Ket qua cau 6b la: {0}", cau6b.ToString("F2"));

            //Bài tập 7
            //Khai báo biến
            double a = 0, b = 0, c = 0, cau7a = 0, cau7b = 0, cau7c = 0, cau7d = 0;

            Console.Write("Nhap vao so a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap vao so b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap vao so c = ");
            c = Convert.ToDouble(Console.ReadLine());

            //Tính toán
            cau7a = Math.Pow(a, 2) - 2 * b + (a * b) / c;
            cau7b = ((b * b) - 4 * a * c) / (2 * a);
            cau7c = 3 * a - Math.Pow(b, 3) - 2 * Math.Sqrt(c);
            cau7d = Math.Sqrt((a * a) / b - (4 * a) / (b * c) + 1);

            //In kết quả ra màn hình
            Console.WriteLine("Ket qua cau 7a la: {0}", cau7a.ToString("F2"));
            Console.WriteLine("Ket qua cau 7b la: {0}", cau7b.ToString("F2"));
            Console.WriteLine("Ket qua cau 7c la: {0}", cau7c.ToString("F2"));
            Console.WriteLine("Ket qua cau 7d la: {0}", cau7d.ToString("F2"));

            //Bài tập 9
            //Khai báo biến
            double trungBinhCong = 0, trungBinhNhan = 0;

            trungBinhCong = (a + b + c) / 3;
            trungBinhNhan = Math.Pow((a * b * c), 1 / 3.0);

            Console.WriteLine("Trung binh cong la: " + trungBinhCong);
            Console.WriteLine("Trung binh nhan la: " + trungBinhNhan);
            */

            //Bài 13: Nhập vào 4 chữ số. In ra tổng của 4 chữ số này và chữ số hàng chục, hàng đơn vị của tổng(ví dụ 4 chữ số 3, 1, 8, 5 có tổng là 17 và chữ số hàng chục là 1 và hàng
            //đơn vị là 7, cần in ra 17, 1, 7)
            //Khai báo biến
            int soThu1 = 0, soThu2 = 0, soThu3 = 0, soThu4 = 0, hangChuc = 0, donVi = 0, tong = 0;

            //Nhập thông tin
            Console.Write("Nhap so thu nhat = ");
            soThu1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai = ");
            soThu2 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu ba = ");
            soThu3 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu tu = ");
            soThu4 = int.Parse(Console.ReadLine());
            //Tính toán
            tong = soThu1 + soThu2 + soThu3 + soThu4;

            hangChuc = tong / 10;
            donVi = tong % 10;

            //In kết quả
            Console.WriteLine("Tong 4 chu so la: " + tong);
            Console.WriteLine("Hang chuc la: " + hangChuc);
            Console.WriteLine("Hang don vi la: " + donVi);

            //Giữ màn hình đến khi nhấn phím bất kỳ tiếp theo
            Console.ReadKey();
        }
    }
}
