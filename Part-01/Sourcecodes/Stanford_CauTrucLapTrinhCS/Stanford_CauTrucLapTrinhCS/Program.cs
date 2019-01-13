using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_CauTrucLapTrinhCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Viết code ở đây để có thể chạy được

            //In thông tin ra màn hình
            Console.WriteLine("Chao mung cac ban den voi C# !");

            //Khai báo biến để chứa tuổi sinh viên
            Int16 tuoiSV = 20;

            //In thông tin ra
            Console.WriteLine("Tuoi cua sinh vien la: " + tuoiSV);

            //Gán giá trị mới
            tuoiSV = 22;

            //In giá trị mới
            Console.WriteLine("Tuoi cua sinh vien moi la: " + tuoiSV);

            //Khai báo 1 tên biến để chứa tên của công ty
            String strTenCongTy = "Stanford - Dao tao va phat trien cong nghe";

            //In thông tin
            Console.WriteLine("Ten cong ty la: " + strTenCongTy + ", tuoi: " + tuoiSV);

            //Ví dụ 2: Nhập số 2 từ bàn phím sau đó tính tổng hai số này.
            //Khai báo biến
            /*int soa = 0, sob = 0, tong = 0;

            //Đưa thông báo để người dùng nhập thông tin
            Console.Write("Nhap so a = ");

            //Lấy thông tin và chuyển về dạng số
            soa = Convert.ToInt16(Console.ReadLine());

            //Đưa thông báo để người dùng nhập thông tin
            Console.Write("Nhap so b = ");

            //Lấy thông tin và chuyển về dạng số
            sob = Convert.ToInt16(Console.ReadLine());

            //Thực hiện tính tổng
            tong = soa + sob;

            //Hiển thị kết quả
            Console.WriteLine("Tong hai so la: " + tong);*/

            //Ví dụ 3: Nhập chiều cao của Đạt và Phong sau đó kiểm tra xem hai bạn có bằng nhau không ?
            //Khai báo biến
            double chieuCaoDat = 0, chieuCaoPhong = 0;

            //Đưa thông báo
            Console.Write("Nhap chieu cao cua Dat: ");

            chieuCaoDat = Convert.ToDouble(Console.ReadLine());

            //Đưa thông báo
            Console.Write("Nhap chieu cao cua Phong: ");

            chieuCaoPhong = Convert.ToDouble(Console.ReadLine());
            //Nếu chiều cao của 2 bạn bằng nhau
            if(chieuCaoDat == chieuCaoPhong)
            {
                Console.WriteLine("Chieu cao cua Dat va Phong bang nhau");
            }
            else
            {
                if(chieuCaoDat > chieuCaoPhong)
                {
                    Console.WriteLine("Chieu cao cua Dat cao hon Phong");
                }
                else
                {
                    Console.WriteLine("Chieu cao cua Phong cao hon Dat");
                }
            }

            //Lấy căn bậc hai
            double t = Math.Sqrt(9);//3

            //Lấy hàm số mũ
            t = Math.Pow(2, 3);//8
            //Sử dụng các hàm số học trong lớp Math

        }
    }
}
