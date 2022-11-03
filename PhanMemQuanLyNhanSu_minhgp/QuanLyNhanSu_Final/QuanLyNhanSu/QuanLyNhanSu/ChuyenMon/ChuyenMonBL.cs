using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.ChuyenMon
{
    class ChuyenMonBL
    {
        ChuyenMonDAL dalCM;
        public ChuyenMonBL()
        {
            dalCM = new ChuyenMonDAL();
        }

        public DataTable TatCaChuyenMon()
        {
            return dalCM.TatCaChuyenMon();
        }

        public bool KiemTraChuyenMon(string macm)
        {
            return dalCM.KiemTraChuyenMon(macm);
        }

        public void ThemChuyenMon(ChuyenMon cm)
        {
            dalCM.ThemChuyenMon(cm);
        }

        public void CapNhatChuyenMon(ChuyenMon cm)
        {
            dalCM.CapNhatChuyenMon(cm);
        }

        public void XoaChuyenMon(ChuyenMon cm)
        {
            dalCM.XoaChuyenMon(cm);
        }

        public DataTable SearchChuyenMon(string tukhoa)
        {
            return dalCM.SearchChuyenMon(tukhoa);
        }
    }
}
