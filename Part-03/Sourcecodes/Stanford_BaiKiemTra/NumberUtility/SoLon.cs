using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberUtility
{
    public class SoLon
    {
        public string ChuoiDauVaoA { get; set; }
        public string ChuoiDauVaoB { get; set; }

        public SoLon() { }

        public SoLon(string pChuoiDauVaoA, string pChuoiDauVaoB)
        {
            ChuoiDauVaoA = pChuoiDauVaoA;
            ChuoiDauVaoB = pChuoiDauVaoB;
        }


        /// <summary>
        /// Hàm công hai số lớn không tham số
        /// </summary>
        /// <returns></returns>
        public string TongHaiSoLon()
        {
            int chenhLech, soDu = 0;
            string KetQua = string.Empty;
            chenhLech = Math.Abs(ChuoiDauVaoA.Length - ChuoiDauVaoB.Length);


            //tìm độ dài số có độ dài nhỏ nhất và gán ký tự 0 vào trc dãy nhỏ làm cân bằng dãy số
            CanBang(chenhLech);

            // Thuật toán chính của bạn Dat
            for (int i = (ChuoiDauVaoA.Length - 1); i >= -1; i--)
            {
                if (i >= 0)
                {

                    //cộng 2 số 
                    int temp = (ChuoiDauVaoA[i] - '0') + (ChuoiDauVaoB[i] - '0');

                    //dãy kq = dãy cũ 
                    KetQua = ("" + (temp % 10 + soDu)) + KetQua;

                    //Lấy dư
                    soDu = temp / 10;
                }
                else
                {
                    KetQua = "" + soDu + KetQua;
                }

            }

            if (KetQua[0] == '0')
            {
                KetQua = KetQua.Substring(1);
            }


            return KetQua;
        }

        public string TongHaiSoLon(string pChuoiDauVaoA, string pChuoiDauVaoB)
        {
            string KetQua = string.Empty;


            int maxLength = pChuoiDauVaoA.Length > pChuoiDauVaoB.Length ? pChuoiDauVaoA.Length : pChuoiDauVaoB.Length;

            int m = pChuoiDauVaoA.Length - 1;
            int n = pChuoiDauVaoB.Length - 1;

            // lưu lại nhớ của phép cộng
            int nho = 0;

            // tổng từng bước
            int tong = 0;

            // THuật toán chính
            for (int i = (maxLength - 1); i >= -1; i--)
            {
                int a = 0;
                int b = 0;
                if (m >= 0)
                {
                    // lấy số bằng cách trử các ký tự ASCII
                    a = pChuoiDauVaoA[m] - '0';
                }

                if (n >= 0)
                {
                    b = pChuoiDauVaoB[n] - '0';
                }

                tong = a + b + nho;
                KetQua = tong % 10 + KetQua;
                nho = tong / 10;


                m--;
                n--;
            }

            if (nho > 0) KetQua = nho + KetQua;

            if (KetQua[0] == '0')
            {
                KetQua = KetQua.Substring(1);
            }

            return KetQua;
        }

        private void CanBang(int chenhLech)
        {
            if (ChuoiDauVaoA.Length < ChuoiDauVaoB.Length)
            {
                for (int i = 0; i < chenhLech; i++)
                {
                    ChuoiDauVaoA = "0" + ChuoiDauVaoA;
                }
            }
            else
            {
                for (int i = 0; i < chenhLech; i++)
                {
                    ChuoiDauVaoB = "0" + ChuoiDauVaoB;
                }
            }
        }
    }
}
