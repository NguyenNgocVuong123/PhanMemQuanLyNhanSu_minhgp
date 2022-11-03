using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.TaiKhoan
{
    class TaiKhoanBL
    {
        TaiKhoanDAL dalTK;
        public TaiKhoanBL()
        {
            dalTK = new TaiKhoanDAL();
        }

        public DataTable DanhSachTaiKhoan()
        {
            return dalTK.DanhSachTaiKhoan();
        }

        public void DoiMatKhau(TaiKhoan tk)
        {
            dalTK.DoiMatKhau(tk);
        }
        public void DoiEmail(TaiKhoan tk)
        {
            dalTK.DoiEmail(tk);
        }

        public void DoiPhanQuyen(TaiKhoan tk)
        {
            dalTK.DoiPhanQuyen(tk);
        }

        public bool KiemTraTaiKhoan(string tk)
        {
            return dalTK.KiemTraTaiKhoan(tk);
        }

        public void ThemTaiKhoan(TaiKhoan tk)
        {
            dalTK.ThemTaiKhoan(tk);
        }
        public void XoaTaiKhoan(TaiKhoan tk)
        {
            dalTK.XoaTaiKhoan(tk);
        }
    }
}
