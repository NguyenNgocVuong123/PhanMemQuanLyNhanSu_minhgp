using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.HopDong
{
    class HopDongBL
    {
        HopDongDAL dalHD;
        public HopDongBL()
        {
            dalHD = new HopDongDAL();
        }

        public DataTable TatCaHopDong()
        {
            return dalHD.TatCaHopDong();
        }

        public void CapNhatHopDong(HopDong hd)
        {
            dalHD.CapNhatHopDong(hd);
        }

        public void XoaHopDong(HopDong hd)
        {
            dalHD.XoaHopDong(hd);
        }

        public bool KiemTraMaHD(string mahd)
        {
            return dalHD.KiemTraMaHD(mahd);
        }

        public void ThemHopDong(HopDong hd)
        {
            dalHD.ThemHopDong(hd);
        }
    }
}
