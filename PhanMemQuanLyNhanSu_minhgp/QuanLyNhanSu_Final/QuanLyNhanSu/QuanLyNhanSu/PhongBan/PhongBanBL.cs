using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace QuanLyNhanSu.PhongBan
{
    class PhongBanBL
    {
        PhongBanDAL dalPB;

        public PhongBanBL()
        {
            dalPB = new PhongBanDAL();
        }

        public DataTable TatCaPhongBan()
        {
            return dalPB.TatCaPhongBan();
        }

        public bool KiemTraPhongBan(string MaPB)
        {
            return dalPB.KiemTraPhongBan(MaPB);
        }

        public void ThemPhongBan(PhongBan pb)
        {
            dalPB.ThemPhongBan(pb);
        }

        public void CapNhatPhongBan(PhongBan pb)
        {
            dalPB.CapNhatPhongBan(pb);
        }

        public void XoaPhongBan(PhongBan pb)
        {
            dalPB.XoaPhongBan(pb);
        }

        public DataTable SearchPhongBan(string tukhoa)
        {
            return dalPB.SearchPhongBan(tukhoa);
        }
    }
}
