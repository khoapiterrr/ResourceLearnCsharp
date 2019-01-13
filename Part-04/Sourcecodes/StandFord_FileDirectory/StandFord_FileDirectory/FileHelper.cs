using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StandFord_FileDirectory
{
    public class FileHelper
    {
        /// <summary>
        /// Hàm ghi thông tin ra file
        /// </summary>
        /// <param name="duongDan">Đường dẫn tới file</param>
        /// <param name="noiDung">Nội dung cần ghi ra file</param>
        public static void GhiDuLieuRaFile(string duongDan, string noiDung)
        {
            FileStream fileStream = new FileStream(duongDan, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Định nghĩa một đối tượng StreamWriter hỗ trợ đọc file từ FileStream
            StreamWriter streamWrite = new StreamWriter(fileStream);

            // Dùng phương thức WriteLine để viết dữ liệu vào file theo dòng
            streamWrite.WriteLine(noiDung);

            // Giải phóng bộ nhớ của Stream sau khi sử dụng
            streamWrite.Flush();
        }

        /// <summary>
        /// Hàm đọc dữ liệu từ file
        /// </summary>
        /// <param name="duongDan">Đường dẫn tới file</param>
        /// <returns>Nội dung đọc được từ file</returns>
        public static string DocNoiDungFile(string duongDan)
        {
            String noiDung = "";
            FileStream fileStream = new FileStream(duongDan, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Đinh nghĩa một đối tượng StreamReader để hỗ trợ đọc file từ đối tượng fileStream
            StreamReader streamReader = new StreamReader(fileStream);

            // Dùng phương thức ReadLine để đọc từng dòng.
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                noiDung += line + "\r\n";
            }

            // Nhớ phải đóng StreamReader sau khi đã sử dụng.
            streamReader.Close();

            return noiDung;
        }
    }
}
