using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.ChucVu
{
    class ChucVuBL
    {
        ChucVuDAL dalCV;

        public ChucVuBL()
        {
            dalCV = new ChucVuDAL();
        }

        public DataTable TatCaChucVu()
        {
            return dalCV.TatCaChucVu();
        }

        public bool KiemTraChucVu(string MaCV)
        {
            return dalCV.KiemTraChucVu(MaCV);
        }

        public void ThemChucVu(ChucVu cv)
        {
            dalCV.ThemChucVu(cv);
        }

        public void CapNhatChucVu(ChucVu cv)
        {
            dalCV.CapNhatChucVu(cv);
        }

        public void XoaChucVu(ChucVu cv)
        {
            dalCV.XoaChucVu(cv);
        }

        public DataTable SearchCV(string tukhoa)
        {
            return dalCV.SearchCV(tukhoa);
        }
    }
}
