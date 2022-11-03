using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.BaoCao
{
    class BaoCaoBL
    {
        BaoCaoDAL dalBC;
        public BaoCaoBL()
        {
            dalBC = new BaoCaoDAL();
        }

        public DataTable NhanVienMoiThang()
        {
            return dalBC.NhanVienMoiThang();
        }

        public DataTable NhanVienNghiThang()
        {
            return dalBC.NhanVienNghiThang();
        }

        public DataTable NhanVienSapHetHD()
        {
            return dalBC.NhanVienSapHetHD();
        }

        public DataTable NhanVienMoiQuy()
        {
            return dalBC.NhanVienMoiQuy();
        }

        public DataTable NhanVienNghiQuy()
        {
            return dalBC.NhanVienNghiQuy();
        }

        public DataTable NhanVienMoiNam()
        {
            return dalBC.NhanVienMoiNam();
        }

        public DataTable NhanVienNghiNam()
        {
            return dalBC.NhanVienNghiNam();
        }
    }
}
