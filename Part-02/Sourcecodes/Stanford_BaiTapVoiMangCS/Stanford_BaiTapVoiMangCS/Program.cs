using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_BaiTapVoiMangCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1 :
            // Nhập vào dãy n số thực. Tính tổng dãy, trung bình dãy, tổng các số âm, 
            //dương và tổng các số ở vị trí chẵn, vị trí lẻ trong dãy

            //BaiTap1();

            // Bài 2
            // Tìm và chỉ ra vị trí xuất hiện đầu tiên của phần tử x trong dãy.
            //BaiTap2();

            // Bài 3
            //Nhập vào dãy n số. Hãy in ra số lớn nhất, bé nhất của dãy
            //BaiTap3();

            // Bài 4
            // Nhập vào dãy số. In ra dãy đã được sắp xếp tăng dần, giảm dần.
            //BaiTap4();

            // Bài 5
            //Viết chương trình nhập vào 1 mảng gồm N phần tử, với N được nhập từ bàn phím.
            //Tách mảng đã cho thành 2 mảng, 1 mảng chứa các số âm, 1 mảng chứa các số dương.
            // BaiTap5();

            // Bài 8
            // Hãy nhập một xâu kí tự. In ra màn hình đảo ngược của xâu đó.
            BaiTap8();

        }

        private static void BaiTap1()
        {
            int n;
            double[] arrSoThuc;
            NhapSoThuc(out n, out arrSoThuc);

            // Khai báo các biến đầu ra
            double tongDaySo = 0;
            double tongTrungBinhDay = 0;
            double tongCacSoAm = 0;
            double tongCacSoDuong = 0;
            double tongCacSoOViTriChan = 0;
            double tongCacSoOViTriLe = 0;

            // Thực hiện nghiệp vụ
            for (int i = 0; i < arrSoThuc.Length; i++)
            {
                tongDaySo = +arrSoThuc[i];

                tongCacSoAm += (arrSoThuc[i] < 0) ? arrSoThuc[i] : 0;

                if (arrSoThuc[i] > 0)
                    tongCacSoDuong = +arrSoThuc[i];

                if (i % 2 == 0)
                    tongCacSoOViTriChan = +arrSoThuc[i];
                else
                    tongCacSoOViTriLe = +arrSoThuc[i];
            }

            tongTrungBinhDay = tongDaySo / n;

            // Hiển thị kết quả
            Console.Write("Hien thi ket qua");
            Console.WriteLine(string.Empty);
            Console.Write("tongDaySo = {0}", tongDaySo);
            Console.WriteLine(string.Empty);
            Console.Write("tongTrungBinhDay = {0}", tongTrungBinhDay);
            Console.WriteLine(string.Empty);
            Console.Write("tongCacSoAm = {0}", tongCacSoAm);
            Console.WriteLine(string.Empty);
            Console.Write("tongCacSoDuong = {0}", tongCacSoDuong);
            Console.WriteLine(string.Empty);
            Console.Write("tongCacSoOViTriChan = {0}", tongCacSoOViTriChan);
            Console.WriteLine(string.Empty);
            Console.Write("tongCacSoOViTriLe = {0}", tongCacSoOViTriLe);

            Console.ReadLine();
        }

        // Tìm và chỉ ra vị trí xuất hiện đầu tiên của phần tử x trong dãy.
        private static void BaiTap2()
        {
            int n;
            double[] arrSoThuc;
            NhapSoThuc(out n, out arrSoThuc);


            // Khai phần tử x
            Console.Write("Nhap phan tu can tim kiem x:=");
            double x = double.Parse(Console.ReadLine());

            int vitri = -1;
            // Thực hiện nghiệp vụ
            for (int i = 0; i < arrSoThuc.Length; i++)
            {
                if (arrSoThuc[i] == x)
                {
                    vitri = i;
                    break;
                }
            }

            if (vitri != -1)
                Console.Write("Vi tri cua phan tu x can tim la  = {0}", vitri);
            else
                Console.Write("Khong tim thay phan tu x trong mang");

            Console.ReadLine();
        }

        //Nhập vào dãy n số. Hãy in ra số lớn nhất, bé nhất của dãy
        private static void BaiTap3()
        {
            int n;
            double[] arrSoThuc;
            NhapSoThuc(out n, out arrSoThuc);


            // khai báo 2 biến Max, Min
            double soLonNhat = arrSoThuc[0];
            double soNhoNhat = arrSoThuc[0];

            // Thực hiện nghiệp vụ
            for (int i = 1; i < arrSoThuc.Length; i++)
            {
                // Số nhỏ nhất
                if (soNhoNhat > arrSoThuc[i])
                {
                    soNhoNhat = arrSoThuc[i];
                }

                // Số lớn nhất
                if (soLonNhat < arrSoThuc[i])
                {
                    soLonNhat = arrSoThuc[i];
                }
            }

            // Hiển thị kết quả
            Console.Write("Hien thi ket qua");
            Console.WriteLine(string.Empty);
            Console.Write("soLonNhat = {0}", soLonNhat);
            Console.WriteLine(string.Empty);
            Console.Write("soNhoNhat = {0}", soNhoNhat);
            Console.WriteLine(string.Empty);

            Console.ReadLine();
        }

        //Nhập vào dãy số. In ra dãy đã được sắp xếp tăng dần, giảm dần.
        //Nhập vào dãy n số. Hãy in ra số lớn nhất, bé nhất của dãy
        private static void BaiTap4()
        {
            int n;
            double[] arrSoThuc;
            NhapSoThuc(out n, out arrSoThuc);

            // Xắp xếp tăng dần 

            for (int i = 0; i < arrSoThuc.Length - 1; i++)
            {
                // Mỗi vòng lặp sẽ tìm được phần tử lớn nhất chuyển về đầu dãy
                for (int j = i + 1; j < arrSoThuc.Length; j++)
                {
                    if (arrSoThuc[i] > arrSoThuc[j])
                    {
                        HoanDoi(arrSoThuc, i, j);
                    }
                }
            }

            // Hiển thị mảng xắp xếp tăng dần
            HienThiMang(arrSoThuc);


            // Xắp xếp giam dan
            for (int i = 0; i < arrSoThuc.Length - 1; i++)
            {
                // Mỗi vòng lặp sẽ tìm được phần tử lớn nhất chuyển về đầu dãy
                for (int j = i + 1; j < arrSoThuc.Length; j++)
                {
                    if (arrSoThuc[i] < arrSoThuc[j])
                    {
                        HoanDoi(arrSoThuc, i, j);
                    }
                }
            }

            // Hiển thị mảng xắp xếp giam dần
            HienThiMang(arrSoThuc);

            Console.ReadLine();
        }

        private static void HienThiMang(double[] arrSoThuc)
        {
            Console.Write("A :=[");
            for (int i = 0; i < arrSoThuc.Length; i++)
            {
                Console.Write("{0}  ", arrSoThuc[i]);
            }
            Console.WriteLine("]");
            //Console.Write("A :=[{0}]", string.Join("    ",arrSoThuc));
        }

        private static void HienThiMangDaonguoc(double[] arrSoThuc)
        {
            Console.Write("A :=[");
            for (int i = arrSoThuc.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}  ", arrSoThuc[i]);
            }
            Console.WriteLine("]");
        }

        private static void HoanDoi(double[] arrSoThuc, int i, int j)
        {
            double temp = arrSoThuc[j];
            arrSoThuc[j] = arrSoThuc[i];
            arrSoThuc[i] = temp;
        }

        private static void NhapSoThuc(out int n, out double[] arrSoThuc)
        {
            // số phần tử mảng
            Console.Write("Nhap so phan tu cua mang :=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Empty);

            //Nhập n số thực
            Console.Write("Nhap so lieu cho mang");
            Console.WriteLine(string.Empty);
            arrSoThuc = new double[n];
            for (int i = 0; i < arrSoThuc.Length; i++)
            {
                Console.Write("arrSoThuc[{0}]:= ", i);
                arrSoThuc[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(string.Empty);
            }
        }

        // Tách mảng đã cho thành 2 mảng, 1 mảng chứa các số âm, 1 mảng chứa các số dương.
        private static void BaiTap5()
        {
            int n;
            double[] arrSoThuc;
            NhapSoThuc(out n, out arrSoThuc);


            // Khai phần tử x
            List<double> listSoAm = new List<double>();
            List<double> listSoDuong = new List<double>();


            int vitri = -1;
            // Thực hiện nghiệp vụ
            for (int i = 0; i < arrSoThuc.Length; i++)
            {
                // Thêm phần tử số âm vào List số Âm
                if (arrSoThuc[i] < 0)
                    listSoAm.Add(arrSoThuc[i]);

                // Thêm phần tử số dương vào List số dương
                if (arrSoThuc[i] > 0)
                    listSoDuong.Add(arrSoThuc[i]);
            }

            // Hiển thị kết quả
            Console.Write("Hien thi mang so am");
            HienThiMang(listSoAm.ToArray());

            Console.Write("Hien thi mang so duong");
            HienThiMang(listSoDuong.ToArray());

            Console.ReadLine();
        }

        // Hãy nhập một xâu kí tự. In ra màn hình đảo ngược của xâu đó.
        private static void BaiTap8()
        {
            int n;
            double[] arrSoThuc;
            NhapSoThuc(out n, out arrSoThuc);


            Console.Write("Hien thi mang truoc dao nguoc");
            HienThiMang(arrSoThuc);

            Console.WriteLine(string.Empty);
            Console.Write("Hien thi mang dao nguoc");
            HienThiMangDaonguoc(arrSoThuc);

            Console.ReadLine();
        }
    }
}
