using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.PhatLuong
{
    class DanhSachTamUngBL
    {
        DanhSachTamUngDAL dalDSTU;
        public DanhSachTamUngBL()
        {
            dalDSTU = new DanhSachTamUngDAL();
        }

        public DataTable DanhSachTamUng()
        {
            return dalDSTU.DanhSachTamUng();
        }

        public int LayMaNhanVien(int stt)
        {
            return dalDSTU.LayMaNhanVien(stt);
        }

        public Int64 LayLuongCB(int manv)
        {
            return dalDSTU.LayLuongCB(manv);
        }

        public Int64 LayDaTamUng(int manv)
        {
            return dalDSTU.LayDaTamUng(manv);
        }

        public void ThemTUNV(Int64 dtu, int manv)
        {
            dalDSTU.ThemTUNV(dtu, manv);
        }

        public void ThemTamUng(DanhSachTamUng dstu)
        {
            dalDSTU.ThemTamUng(dstu);
        }

        public void XoaTamUng(int stt)
        {
            dalDSTU.XoaTamUng(stt);
        }

        public void XoaTUNV(int manv)
        {
            dalDSTU.XoaTUNV(manv);
        }

        public DataTable SearchDSTU(string tukhoa)
        {
            return dalDSTU.SearchDSTU(tukhoa);
        }
        public DataTable TimMNVDSTU(int manv)
        {
            return dalDSTU.TimMNVDSTU(manv);
        }
    }
}
