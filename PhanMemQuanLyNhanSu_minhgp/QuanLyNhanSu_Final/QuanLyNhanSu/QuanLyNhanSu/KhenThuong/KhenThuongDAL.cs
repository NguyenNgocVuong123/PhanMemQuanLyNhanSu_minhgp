using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.KhenThuong
{
    class KhenThuongDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public KhenThuongDAL()
        {
            dc = new DataConnection();
        }

        public DataTable DanhSachKhenThuong()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,TienThuong,NgayThuong,KhenThuong.GhiChu from KhenThuong,NhanVien where KhenThuong.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void CapNhatKhenThuong(KhenThuong kt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update KhenThuong set TienThuong=@TT,NgayThuong=@NT,GhiChu=@GC where STT=@STT";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@STT", SqlDbType.Int).Value = kt.STT;
                cmd.Parameters.Add("@TT", SqlDbType.BigInt).Value = kt.TienThuong;
                cmd.Parameters.Add("@NT", SqlDbType.Char).Value = kt.NgayThuong;
                cmd.Parameters.Add("@GC", SqlDbType.NVarChar).Value = kt.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaKhenThuong(KhenThuong kt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from KhenThuong where STT=@STT";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@STT", SqlDbType.Int).Value = kt.STT;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ThemKhenThuong(KhenThuong kt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into KhenThuong(MaNhanVien,TienThuong,NgayThuong,GhiChu) values(@MaNV,@TT,@NT,@GC)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = kt.MaNhanVien;
                cmd.Parameters.Add("@TT", SqlDbType.BigInt).Value = kt.TienThuong;
                cmd.Parameters.Add("@NT", SqlDbType.Char).Value = kt.NgayThuong;
                cmd.Parameters.Add("@GC", SqlDbType.NVarChar).Value = kt.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SearchKhenThuong(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,TienThuong,NgayThuong,KhenThuong.GhiChu from KhenThuong,NhanVien where (KhenThuong.MaNhanVien like '" + tukhoa + "' or NhanVien.HoTen like N'%" + tukhoa + "%' or NgayThuong like '%" + tukhoa + "%' or TienThuong like '%" + tukhoa + "%') and KhenThuong.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable TimMNVKT(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,TienThuong,NgayThuong,KhenThuong.GhiChu from KhenThuong,NhanVien where KhenThuong.MaNhanVien=NhanVien.MaNhanVien and KhenThuong.MaNhanVien=" + manv + " order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
    }
}
