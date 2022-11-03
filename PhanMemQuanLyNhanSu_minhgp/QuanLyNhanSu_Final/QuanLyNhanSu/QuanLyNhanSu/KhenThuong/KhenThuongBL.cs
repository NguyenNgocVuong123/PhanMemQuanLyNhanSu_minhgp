using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.KhenThuong
{
    class KhenThuongBL
    {
        KhenThuongDAL dalKT;

        public KhenThuongBL()
        {
            dalKT = new KhenThuongDAL();
        }

        public DataTable DanhSachKhenThuong()
        {
            return dalKT.DanhSachKhenThuong();
        }

        public void CapNhatKhenThuong(KhenThuong kt)
        {
            dalKT.CapNhatKhenThuong(kt);
        }

        public void XoaKhenThuong(KhenThuong kt)
        {
            dalKT.XoaKhenThuong(kt);
        }

        public void ThemKhenThuong(KhenThuong kt)
        {
            dalKT.ThemKhenThuong(kt);
        }

        public DataTable SearchKhenThuong(string tukhoa)
        {
            return dalKT.SearchKhenThuong(tukhoa);
        }

        public DataTable TimMNVKT(int manv)
        {
            return dalKT.TimMNVKT(manv);
        }
    }
}
