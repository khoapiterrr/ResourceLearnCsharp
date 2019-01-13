using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_LopVaDoiTuongCS
{
    /// <summary>
    /// Xử lý nghiệp vụ với các đối tượng sinh viên
    /// </summary>
    public class SinhVienBusiness: IHanhDong
    {
        //Khai báo 1 danh sách để chứa thông tin
        private List<SinhVien> lstSinhVien = new List<SinhVien>();

        public List<SinhVien> layDanhSach()
        {
            //Nếu danh sách chưa có thông tin
            if (lstSinhVien.Count == 0)
            {
                //Gọi hàm tạo dữ liệu ban đầu
                taoDuLieuBanDau();
            }

            return lstSinhVien;
        }

        public void taoDuLieuBanDau()
        {
            //Tạo 1 đối tượng lưu thông tin đạt
            SinhVien objDat = new SinhVien();

            //Gán giá trị cho các thuộc tính
            objDat.MaSV = "SF001";
            objDat.HoTen = "Mai Quốc Đạt";
            objDat.DienThoai = "0988333568";
            objDat.Email = "quocdat@gmail.com";

            //Thêm vào danh sách
            lstSinhVien.Add(objDat);

            //Tạo 1 đối tượng lưu thông tin đạt
            SinhVien objChinh = new SinhVien();

            //Gán giá trị cho các thuộc tính
            objChinh.MaSV = "SF002";
            objChinh.HoTen = "Vũ Gia Chình";
            objChinh.DienThoai = "0988332558";
            objChinh.Email = "chinhvg@gmail.com";
            objChinh.DiaChi = "Thái Bình";

            //Thêm vào danh sách
            lstSinhVien.Add(objChinh);

            //Tạo sinh viên Việt Anh
            SinhVien objVietAnh = new SinhVien("Hải Dương");

            objVietAnh.MaSV = "SF003";
            objVietAnh.HoTen = "Nguyễn Việt Anh";
            objVietAnh.DienThoai = "0904568195";
            objVietAnh.Email = "vietanh@gmail.com";

            //Thêm vào danh sách
            lstSinhVien.Add(objVietAnh);

            //Tạo sinh viên Duy
            SinhVien objDuy = new SinhVien("SF004", "Trần Thạch Duy", "0905125689", "thachduy@gmail.com", "Hà Nội");
            lstSinhVien.Add(objDuy);
        }

        /// <summary>
        /// Hàm thêm mới 1 sinh viên vào trong danh sách
        /// </summary>
        /// <param name="objSV"></param>
        /// <returns></returns>
        public bool themMoiSinhVien(SinhVien objSV)
        {
            if (objSV != null)
            {
                //Thêm vào danh sách
                lstSinhVien.Add(objSV);
                return true;
            }

            return false;
        }


        /// <summary>
        /// Tìm kiếm sinh viên theo mã sinh viên
        /// </summary>
        /// <param name="pMaSV">Mã sinh viên</param>
        /// <returns>Đối tương sinh viên tìm được</returns>
        public SinhVien TimKiemSinhVienTheoMa(string pMaSV)
        {
            List<SinhVien> list = layDanhSach();

            SinhVien sinhvien = null;
            foreach (SinhVien sv in list)
            {
                if (sv.MaSV == pMaSV)
                {
                    sinhvien = sv;
                    break;
                }
            }

            return sinhvien;
        }

        /// <summary>
        /// Tìm kiếm sinh viên theo tên
        /// </summary>
        /// <param name="pTenSinhVien">Tên sinh viên</param>
        /// <returns>Danh sách sinh viên</returns>
        public List<SinhVien> TimKiemSinhVien(string pTenSinhVien)
        {
            List<SinhVien> list = layDanhSach();

            List<SinhVien> listketQua = new List<SinhVien>();

            foreach (SinhVien sv in list)
            {
                if (sv.HoTen.Contains(pTenSinhVien))
                {
                    listketQua.Add(sv);
                }
            }

            return listketQua;
        }

        /// <summary>
        /// Cập nhật sinh viên
        /// </summary>
        /// <param name="sv">Đối tượng Sinh viên</param>
        /// <returns>Trạng thái việc cập nhật</returns>
        public bool CapNhatSinhVien(SinhVien sv)
        {
            List<SinhVien> list = layDanhSach();

            for (int i = 0; i < list.Count; i++)
            {
                // Tìm sinh viên để cập nhật
                if (list[i].MaSV == sv.MaSV)
                {
                    list[i] = sv;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Xóa sinh viên theo mã sinh viên
        /// </summary>
        /// <param name="pMaSV">Mã sinh vien</param>
        /// <returns>Trạng thái xóa sinh viên</returns>
        public bool XoaSinhVien(string pMaSV)
        {
            List<SinhVien> list = layDanhSach();

            foreach (SinhVien sv in list)
            {
                // Kiểm tra sinh viên them mã
                if (sv.MaSV == pMaSV)
                {
                    // Tìm thấy thì xóa bằng phương thức Remove
                    list.Remove(sv);
                    return true;
                }
            }

            return false;
        }
    }
}
