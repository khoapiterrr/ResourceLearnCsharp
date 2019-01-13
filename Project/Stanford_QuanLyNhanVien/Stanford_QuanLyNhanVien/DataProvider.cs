using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Khai báo thư viện để làm việc với db
using System.Data;
using System.Data.SqlClient;

namespace Stanford_QuanLyNhanVien
{
   public class DataProvider
    {
        /// <summary>
        /// Khai báo chuỗi kết nối đến cơ sở dữ liệu
        /// </summary>
        private static string ChuoiKetNoi = @"Server=DANGBQ_INSPIRON\SQL2012; Database=CS051801CB; Integrated Security = True;";

        /// <summary>
        /// Hàm lấy thông tin danh sách từ db dựa trên câu lệnh truy vấn
        /// </summary>
        /// <param name="strSQL">Câu lệnh truy vấn</param>
        /// <returns>True nếu thành công, False nếu thất bại</returns>
        public static DataTable  LayDanhSach(string strSQL)
        {
            //Khai báo 1 đối tượng để chứa danh sách
            DataTable dt = new DataTable();

            //Khai báo 1 đối tượng kết nối
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);

            try
            {
                //Mở kết nối
                conn.Open();

                //Khai báo 1 công việc
                SqlCommand comm = new SqlCommand();

                //Thực hiện công việc trên đâu
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;

                //Khai báo 1 đối tượng để chứa thông tin
                SqlDataAdapter adapter = new SqlDataAdapter(comm);

                //Đổ thông tin vào datable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

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
        /// Hàm thực hiện công việc thêm mới, sửa, xóa
        /// </summary>
        /// <param name="strSQL">Công việc cần thực hiện</param>
        /// <param name="pars">Tham số của câu lệnh nếu có</param>
        /// <returns>True nếu thực hiện thành công, False nếu thất bại</returns>
        public static bool ThucHienCongViec(string strSQL, SqlParameter[] pars)
        {
            //Khai báo để phân biệt trạng thái công việc thực hiện thành công hay thất bại
            bool ketQua = false;

            //Khai báo 1 đối tượng kết nối
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);

            try
            {
                //Mở kết nối
                conn.Open();

                //Khai báo 1 công việc
                SqlCommand comm = new SqlCommand();

                //Thực hiện công việc trên đâu
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;

                //Nếu câu lệnh có tham số
                if(pars != null && pars.Length > 0)
                {
                    //Thêm tham số vào câu lệnh
                    comm.Parameters.AddRange(pars);
                }

                //Thực hiện công việc insert, update, delete
                ketQua = comm.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Đóng kết nối
                conn.Close();
            }

            return ketQua;
        }

        /// <summary>
        /// Khai báo 1 thuộc tính dạng static để có thể truy xuất và làm việc với các hàm trong lớp NhanVienBusiness ở bất kỳ đâu
        /// </summary>
        private static NhanVienBusiness _nhanVienBus = null;
        public static NhanVienBusiness nhanVienBus
        {
            get
            {
                if(_nhanVienBus == null)
                {
                    _nhanVienBus = new NhanVienBusiness();
                }
                return _nhanVienBus;
            }
        }
    }
}
