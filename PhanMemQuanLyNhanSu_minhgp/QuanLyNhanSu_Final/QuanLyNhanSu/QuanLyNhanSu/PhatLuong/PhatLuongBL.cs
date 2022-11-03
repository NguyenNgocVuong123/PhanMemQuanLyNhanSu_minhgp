using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.PhatLuong
{
    class PhatLuongBL
    {
        PhatLuongDAL dalPL;

        public PhatLuongBL()
        {
            dalPL = new PhatLuongDAL();
        }

        public DataTable DanhSachPhatLuong()
        {
            return dalPL.DanhSachPhatLuong();
        }

        public void CapNhatPhatLuong(PhatLuong pl)
        {
            dalPL.CapNhatPhatLuong(pl);
        }

        public void XoaPhatLuong(PhatLuong pl)
        {
            dalPL.XoaPhatLuong(pl);
        }

        public int LaySoNgayVang(int manv)
        {
            return dalPL.LaySoNgayVang(manv);
        }

        public Int64 LayLuongCB(int manv)
        {
            return dalPL.LayLuongCB(manv);
        }

        public Int64 LayTienTamUng(int manv)
        {
            return dalPL.LayTienTamUng(manv);
        }

        public Int64 LayPhuCapCV(int manv)
        {
            return dalPL.LayPhuCapCV(manv);
        }

        public DataTable CauHinhPhatLuong()
        {
            return dalPL.CauHinhPhatLuong();
        }

        public void ThemPhatLuong(PhatLuong pl)
        {
            dalPL.ThemPhatLuong(pl);
        }

        public void ResetNVNTC(int manv)
        {
            dalPL.ResetNVNTC(manv);
        }
        public DataTable SearchPL(string tukhoa)
        {
            return dalPL.SearchPL(tukhoa);
        }
        public DataTable TimMNVPL(int manv)
        {
            return dalPL.TimMNVPL(manv);
        }

        public string LayEmail(int manv)
        { 
            return dalPL.LayEmail(manv); 
        }
    }
}
