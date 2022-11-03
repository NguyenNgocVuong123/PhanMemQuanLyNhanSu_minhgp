using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.HopDong
{
    class ChiTietHopDongBL
    {
        ChiTietHopDongDAL dalCTHD;
        public ChiTietHopDongBL()
        {
            dalCTHD = new ChiTietHopDongDAL();
        }

        public DataTable TatCaChiTietHopDong()
        {
            return dalCTHD.TatCaChiTietHopDong();
        }

        public DataTable LayThongTin(int stt)
        {
            return dalCTHD.LayThongTin(stt);
        }

        public void CapNhatChiTietHopDong(ChiTietHopDong cthd)
        {
            dalCTHD.CapNhatChiTietHopDong(cthd);
        }

        public void XoaChiTietHopDong(ChiTietHopDong cthd)
        {
            dalCTHD.XoaChiTietHopDong(cthd);
        }

        public int LayMaNhanVien(int stt)
        {
            return dalCTHD.LayMaNhanVien(stt);
        }

        public DataTable LayMaNVTenNV()
        {
            return dalCTHD.LayMaNVTenNV();
        }

        public bool KiemTraMaNV(int manv)
        {
            return dalCTHD.KiemTraMaNV(manv);
        }

        public void ThemCTHD(ChiTietHopDong cthd)
        {
            dalCTHD.ThemCTHD(cthd);
        }

        public DataTable SearchCTHD(string tukhoa)
        {
            return dalCTHD.SearchCTHD(tukhoa);
        }

        public DataTable TimMNVCTHD(int manv)
        {
            return dalCTHD.TimMNVCTHD(manv);
        }
    }
}
