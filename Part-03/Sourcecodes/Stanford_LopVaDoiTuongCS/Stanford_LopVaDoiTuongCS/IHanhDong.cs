using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stanford_LopVaDoiTuongCS
{
   public interface IHanhDong
    {
        List<SinhVien> layDanhSach();

        void taoDuLieuBanDau();

        bool themMoiSinhVien(SinhVien objSV);

        SinhVien TimKiemSinhVienTheoMa(string pMaSV);

        List<SinhVien>  TimKiemSinhVien(string pTenSinhVien);

        bool CapNhatSinhVien(SinhVien sv);

        bool XoaSinhVien(string pMaSV);
    }
}
