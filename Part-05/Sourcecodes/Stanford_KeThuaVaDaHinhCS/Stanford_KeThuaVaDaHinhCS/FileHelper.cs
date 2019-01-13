using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Khai báo thư viện để làm việc với file
using System.IO;

namespace Stanford_KeThuaVaDaHinhCS
{
   public class FileHelper
    {
        /// <summary>
        /// Đọc dữ liệu từ file
        /// </summary>
        /// <param name="duongDan">Đường dẫn file</param>
        /// <returns>Nội dung file đọc được</returns>
        public static string DocDuLieuTuFile(string duongDan)
        {
            string noiDung = "";

            //Khai báo 1 đối tượng để chứa luồng dữ liệu lấy được từ file
            FileStream fileStream = new FileStream(duongDan, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //Khai báo 1 luồng để đọc dữ liệu từ file
            StreamReader streamReader = new StreamReader(fileStream);

            //Duyệt để đọc từng dòng
            string dong = "";
            while(streamReader.Peek() >= 0)
             {
                dong = streamReader.ReadLine();
                noiDung += dong + "\n";
            }
            //Đóng luồng
            fileStream.Close();
            streamReader.Close();
            return noiDung;
        }

        /// <summary>
        /// Hàm ghi thông tin ra file
        /// </summary>
        /// <param name="duongDan"></param>
        /// <param name="noiDung"></param>
        public static void GhiThongTin(string duongDan, string noiDung)
        {
            FileStream fileStream = null;

            FileInfo fi = new FileInfo(duongDan);
            //Nếu file tồn tại
            if(fi.Exists)
            {
                fileStream = new FileStream(duongDan, FileMode.Truncate, FileAccess.Write);
            }
            else
            {
                fileStream = new FileStream(duongDan, FileMode.OpenOrCreate, FileAccess.Write);
            }

            //Khai báo 1 đối tượng để ghi ra file
            StreamWriter writer = new StreamWriter(fileStream);

            //Nội dung cần ghi ra file
            writer.Write(noiDung);

            //Đẩy thông tin xuống file
            writer.Flush();

            //Đóng luồng
            writer.Close();
            fileStream.Close();
        }

    }
}
