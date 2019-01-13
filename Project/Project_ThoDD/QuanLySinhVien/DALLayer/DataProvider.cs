using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Khai báo thư viện để làm việc với SQL
using System.Data;
using System.Data.SqlClient;

namespace DALLayer
{
    public class DataProvider
    {

        /// <summary>
        /// Hàm lấy dữ liệu từ db
        /// </summary>
        /// <param name="strSQL">Câu lệnh truy vấn lấy thông tin</param>
        /// <returns>Danh sách trả về phù hợp với câu lệnh</returns>
        public static DataTable LayDanhSach(string strSQL)
        {
            //Khai báo biến
            DataTable dt = new DataTable();

            //Khai báo 1 đối tượng để kết nối đến db
            SqlConnection conn = new SqlConnection(Common.ConnectString);

            try
            {
                //Mở kết nối
                conn.Open();

                //Tạo 1 công việc thực hiện trong sql, là lấy thông tin
                SqlCommand comm = new SqlCommand();
                //Thực hiện trong db nào
                comm.Connection = conn;
                //Kiểu công việc
                comm.CommandType = CommandType.Text;
                //Công việc
                comm.CommandText = strSQL;

                //Khai báo 1 đối tượng để chứa kết quả lấy đc từ db
                SqlDataAdapter adapter = new SqlDataAdapter(comm);

                //Đổ dữ liệu vào dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra. Chi tiết: " + ex.StackTrace);
                throw ex;
            }
            finally
            {
                //Đóng kết nối
                conn.Close();
            }
            return dt;
        }

        /// <summary>
        /// Hàm thực hiện công việc thêm mới, sửa và xóa trong db
        /// </summary>
        /// <param name="strSQL">Câu lệnh insert, update, delete,...</param>
        /// <param name="pars">Tham số của câu lệnh nếu có</param>
        /// <returns>True: Nếu thực hiện thành công; False: Nếu thực hiện thất bại</returns>
        public static bool ThucHien(string strSQL, SqlParameter[] pars = null)
        {
            //Khai báo biến
            bool ketQua = false;

            //Khai báo 1 đối tượng để kết nối đến db
            SqlConnection conn = new SqlConnection(Common.ConnectString);

            try
            {
                //Mở kết nối
                conn.Open();

                //Tạo 1 công việc thực hiện trong sql, là lấy thông tin
                SqlCommand comm = new SqlCommand();
                //Thực hiện trong db nào
                comm.Connection = conn;
                //Kiểu công việc
                comm.CommandType = CommandType.Text;
                //Công việc
                comm.CommandText = strSQL;

                //Kiểm tra xem có tham số ko
                if (pars != null && pars.Length > 0)
                {
                    comm.Parameters.AddRange(pars);
                }

                //Thực hiện công việc insert, update, delete,...
                ketQua = (comm.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra. Chi tiết: " + ex.StackTrace);
                throw ex;
            }
            finally
            {
                //Đóng kết nối
                conn.Close();
            }
            return ketQua;
        }
    }
}
