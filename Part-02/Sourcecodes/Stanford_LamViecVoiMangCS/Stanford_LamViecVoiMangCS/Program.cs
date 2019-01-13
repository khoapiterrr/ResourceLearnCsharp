using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_LamViecVoiMangCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Ví dụ 1: Khai báo 1 mảng số nguyên gồm 3 phần tử
            //Khai báo mảng
            int[] a = new int[3];

            //Gán giá trị
            a[0] = 2;
            a[1] = 3;
            a[2] = 6;

            
            //In phần tử thứ 2
            Console.WriteLine("Gia tri cua phan tu thu 2 la: " + a[1]);

            //In tất cả các phần tử
            Console.WriteLine("Cac phan tu cua mang la: ");

            for (int i = 0; i < a.Length; i++) 
            {
                Console.WriteLine(a[i]);
            }
            //Ví dụ 2: Khai báo 1 mảng số thực gồm n phần tử với n nhập từ bàn phím sau đó in thông tin ra màn hình
            //Khai báo biến
            int n = 0;

            Console.Write("Nhap mang gom n phan tu voi n = ");
            n = int.Parse(Console.ReadLine());

            //Khai báo 1 mảng kiểu số thực
            float[] a1 = new float[n];

            Console.WriteLine("Nhap cac phan tu cua mang:");
            for(int i = 0; i< n; i++)
            {
                //Nhập cho phần tử thứ i
                Console.Write("a1[" + i + "] = ");
                a1[i] = float.Parse(Console.ReadLine());
            }

            //in kết quả
            Console.WriteLine("Cac phan tu cua mang la: ");
            for(int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + "\t");
            }
            */

            //Khai báo 1 mảng 2 chiều số nguyên gồm 3 dòng và 2 cột
            /*
             * a00      a01
             * a10      a11
             * a20      a21
             **/
            //Khai báo biến
            int[,] a2 = new int[3, 2];

            //Gán các giá trị cho dòng 1
            a2[0, 0] = 2;
            a2[0, 1] = 3;

            //Dòng 2
            a2[1, 0] = 5;
            a2[1, 1] = 6;

            //Dòng 3
            a2[2, 0] = 8;
            a2[2, 1] = 9;

            //In các phần tử ra
            Console.WriteLine("Cac phan tu cua mang 2 chieu la: ");
            for(int i = 0; i< a2.GetLength(0); i++)
            {
                for(int j = 0; j< a2.GetLength(1); j++)
                {
                    Console.Write(a2[i, j] + "\t");
                }
                //Hết cột mới xuống dòng
                Console.WriteLine("");
            }
            //Ví dụ 4: Khai báo 1 mảng số thực gồm m dòng và n cột nhập từ phím sau đó nhập các phần tử từ bàn phím rồi in ra màn hình.

            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo 1 danh sách để chứa tên sinh viên của lớp
           /* List<string> lstDanhSachLop = new List<string>();

            //Thêm sinh viên vào danh sách
            lstDanhSachLop.Add("Phú");
            lstDanhSachLop.Add("Đạt");
            lstDanhSachLop.Add("Phong");
            lstDanhSachLop.Add("Việt Anh");
            lstDanhSachLop.Add("Giáp");
            lstDanhSachLop.Add("Tới");
            lstDanhSachLop.Add("Khoa");
            lstDanhSachLop.Add("Thao");

            //Console.Write("Nhập sinh viên mới: ");
           // lstDanhSachLop.Add(Console.ReadLine());

            //In danh sách ra
            Console.WriteLine("Danh sach lop:");
            foreach(string sv in lstDanhSachLop)
            {
                Console.WriteLine(sv);
            }

            //Khai báo 1 danh sách ArrayList
            ArrayList arrThongTin = new ArrayList();
            //List<object> lstTT = new List<object>();

            //Thêm đối tượng vào danh sách
            arrThongTin.Add("Stanford - Dạy lập trình");
            arrThongTin.Add(10);
            arrThongTin.Add("stanford.com.vn");
            arrThongTin.Add(DateTime.Now);

            //In thông tin
            Console.WriteLine("Danh sach cac thong tin cua arraylist:");
            foreach(object o in arrThongTin)
            {
                Console.WriteLine(o);
            }
            */
            //Sử dụng các hàm với chuỗi
            string thongTinA = "Stanford", thongTinB = "Stanford";

            int idx = thongTinA.CompareTo(thongTinB);
            Console.WriteLine("Ket qua so sanh: " + idx);

            //Khai báo 1 định dạng
            string ngayThang = string.Format("Hom nay, ngay {0} thang {1} nam {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Console.WriteLine(ngayThang);

            //Cộng thêm giá trị
            thongTinA += " - Day kinh nghiem lap trinh";

            Console.WriteLine("Chu thuong: " + thongTinA.ToLower());
            Console.WriteLine("Chu hoa: " + thongTinA.ToUpper());

            //Tìm vị trí của t đầu tiên
            int idx1 = thongTinA.IndexOf('t');

            Console.WriteLine("Vi tri dau cua ki tu t la: " + idx1);

            //Vị trí cuối cùng
            int ldx = thongTinA.LastIndexOf('t');

            Console.WriteLine("Vi tri cuoi cua ki tu t la: " + ldx);

            //Khai báo 1 chuỗi mới
            string strGiaTri = "50;60;80;30";

            //Chia chuỗi về mảng bằng cách chặt theo từng dấu ;
            string[] arr = strGiaTri.Split(';');

            Console.WriteLine("Cac phan tu cua mang lay duoc tu chuoi la: ");
            foreach(string giaTri in arr)
            {
                Console.WriteLine(giaTri);
            }

            Console.WriteLine("Thay thế: " + thongTinA.Replace('t', 'T'));

            //Lấy từ viết tắt
            string strTenVietTat = thongTinA.Substring(0, 8);
            Console.WriteLine("Ten viet tat: " + strTenVietTat);
            Console.ReadKey();
        }
    }
}
