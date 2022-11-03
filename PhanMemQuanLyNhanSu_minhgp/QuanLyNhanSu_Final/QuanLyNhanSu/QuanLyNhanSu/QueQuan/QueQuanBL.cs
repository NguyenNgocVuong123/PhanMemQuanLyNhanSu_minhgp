using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhanSu.QueQuan
{
    class QueQuanBL
    {
        QueQuanDAL dalQQ;
        public QueQuanBL()
        {
            dalQQ = new QueQuanDAL();
        }

        public DataTable TatCaQueQuan()
        {
            return dalQQ.TatCaQueQuan();
        }

        public void CapNhatQueQuan(QueQuan qq)
        {
            dalQQ.CapNhatQueQuan(qq);
        }

        public bool KiemTraQueQuan(string maqq)
        {
            return dalQQ.KiemTraQueQuan(maqq);
        }

        public void ThemQueQuan(QueQuan qq)
        {
            dalQQ.ThemQueQuan(qq);
        }

        public void XoaQueQuan(QueQuan qq)
        {
            dalQQ.XoaQueQuan(qq);
        }

        public DataTable SearchQueQuan(string tukhoa)
        {
            return dalQQ.SearchQueQuan(tukhoa);
        }
    }
}
