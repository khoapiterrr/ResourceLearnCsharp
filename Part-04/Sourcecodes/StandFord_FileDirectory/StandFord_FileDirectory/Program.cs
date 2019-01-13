using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace StandFord_FileDirectory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //// FileDatNQ.CreateThuMuc(@"D:\ThoDD\CBS005");
            ////string folderPath = @"D:\ThoDD\CBS005";

            ////DirectoryInfo folder = new DirectoryInfo(folderPath);

            ////try
            ////{
            ////    //if (folder.Exists)
            ////    //{
            ////    folder.Delete();
            ////    //}
            ////}
            ////catch
            ////{
            ////}

            //string filePath = @"D:\ThoDD\CBS006\CBS010.txt";

            ////FileInfo file = new FileInfo(filePath);

            ////FileStream stream = file.Create();

            //FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);

            //// Bước 4, ghi dữ liệu vào file
            //StreamWriter writer = new StreamWriter(stream);

            //writer.WriteLine("Nguyễn Việt Anh");

            //writer.Flush();
            //writer.Close();

            ////File.WriteAllText(@"D:\ThoDD\CBS006\CBS009.txt", "Anh đẹp trai");

            ////Directory.CreateDirectory(@"D:\ThoDD\CBS009");
        }


    } 
}
