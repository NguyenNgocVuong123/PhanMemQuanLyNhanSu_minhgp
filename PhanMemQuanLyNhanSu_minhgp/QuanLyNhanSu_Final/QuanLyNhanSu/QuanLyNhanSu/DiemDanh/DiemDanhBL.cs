using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.DiemDanh
{
    class DiemDanhBL
    {
        DiemDanhDAL dalDD;
        public DiemDanhBL()
        {
            dalDD = new DiemDanhDAL();
        }

        public DataTable DanhSachDiemDanh()
        {
            return dalDD.DanhSachDiemDanh();
        }

        public int LayMaNhanVien(int stt)
        {
            return dalDD.LayMaNV(stt);
        }

        public int LaySoNgayVang(int manv)
        {
            return dalDD.LaySNV(manv);
        }

        public int LaySoNgayTangCa(int manv)
        {
            return dalDD.LaySNTC(manv);
        }

        public void CapNhatDiemDanh(DiemDanh dd)
        {
            dalDD.CapNhatDiemDanh(dd);
        }

        public void DanhDauVang(DiemDanh dd)
        {
            dalDD.DanhDauVang(dd);
        }

        public void CapNhatSoNgayVang(int manv)
        {
            dalDD.CapNhatSoNgayVang(manv);
        }

        public void GiamSoNgayVang(int manv)
        {
            dalDD.GiamSoNgayVang(manv);
        }
        public void CapNhatSoNgayTangCa(int manv)
        {
            dalDD.CapNhatSoNgayTangCa(manv);
        }

        public void GiamSoNgayTangCa(int manv)
        {
            dalDD.GiamSoNgayTangCa(manv);
        }
        public void XoaDiemDanh(DiemDanh dd)
        {
            dalDD.XoaDiemDanh(dd);
        }

        public DataTable SearchDD(string tukhoa)
        {
            return dalDD.SearchDD(tukhoa);
        }

        public DataTable TimMNVDD(int manv)
        {
            return dalDD.TimMNVDD(manv);
        }
    }
}
