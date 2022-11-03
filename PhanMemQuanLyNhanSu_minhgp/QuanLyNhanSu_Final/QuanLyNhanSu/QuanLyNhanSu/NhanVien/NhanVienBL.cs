using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.NhanVien
{
    class NhanVienBL
    {
        NhanVienDAL dalNV;

        public NhanVienBL()
        {
            dalNV = new NhanVienDAL();
        }

        public DataTable TatCaNhanVien()
        {
            return dalNV.TatCaNhanVien();
        }

        public string LayUrlAnh(int manv)
        {
            return dalNV.LayUrlAnh(manv);
        }

        public DataTable LayThongTinNhanVien(int manv)
        {
            return dalNV.LayThongTinNhanVien(manv);
        }

        public void CapNhatNhanVien(NhanVien nv)
        {
            dalNV.CapNhatNhanVien(nv);
        }

        public int LayIDMoiNhatNV()
        {
            return dalNV.LayIDMoiNhatNV();
        }

        public void CapNhatUrlAnh(int manv, string data)
        {
            dalNV.CapNhatUrlAnh(manv, data);
        }

        public void ThemNhanVien(NhanVien nv)
        {
            dalNV.ThemNhanVien(nv);
        }

        public void XoaNhanVien(NhanVien nv)
        {
            dalNV.XoaNhanVien(nv);
        }

        public DataTable SearchNV(string tukhoa)
        {
            return dalNV.SearchNV(tukhoa);
        }

        public DataTable TimMNVNV(int manv)
        {
            return dalNV.TimMNVNV(manv);
        }
    }
}
