using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StandFord_FileDirectory
{
    public class FileDatNQ
    {
        public static void CreateThuMuc(string path)
        {
            DirectoryInfo folder = new DirectoryInfo(path);

            folder.Create();
        }
    }
}
