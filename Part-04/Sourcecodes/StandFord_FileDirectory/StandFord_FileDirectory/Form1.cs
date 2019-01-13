using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StandFord_FileDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            //Xử lý chọn file
            string duongDan = "";

            //Nếu người dùng chọn file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Lấy đường dẫn
                duongDan = openFileDialog1.FileName;
                txtTenFile.Text = duongDan;
                txtTenFile.ReadOnly = true;
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            //Tạo Stream truy cập tới file;
            FileStream stream = new FileStream(txtTenFile.Text, FileMode.OpenOrCreate);

            //Sử dụng StreamReader để đọc dữ liệu
            StreamReader reader = new StreamReader(stream);
            txtNoiDung.Text = reader.ReadToEnd();

            reader.Close();

            // Các bạn có thể viết các nội dung đọc thành 1 file tiên ích dùng static FileHelper để xử lý
            // Gọi hàm đọc file
            //FileHelper.DocNoiDungFile(txtTenFile.Text);

            //Thông báo cho người dùng
            MessageBox.Show("Đọc dữ liệu file thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Định nghĩa và tạo FileStream cho việc ghi file
                FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);

                //Sử dụng StreamWriter để đọc dữ liệu
                StreamWriter writer = new StreamWriter(stream);

                writer.WriteLine(txtNoiDung.Text);

                writer.Close();

                //Các bạn có thể viết các nội dung đọc thành 1 file tiên ích dùng static FileHelper để xử lý
                // Gọi hàm ghi file
                // FileHelper.GhiDuLieuRaFile(saveFileDialog1.FileName, txtNoiDung.Text);

                //Thông báo cho người dùng
                MessageBox.Show("Ghi file thành công", "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}
