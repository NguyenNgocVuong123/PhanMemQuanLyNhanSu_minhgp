using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.PhatLuong
{
    class DanhSachTamUngDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public DanhSachTamUngDAL()
        {
            dc = new DataConnection();
        }

        public DataTable DanhSachTamUng()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayTamUng,TienTamUng,DanhSachTamUng.GhiChu from DanhSachTamUng,NhanVien where NhanVien.MaNhanVien=DanhSachTamUng.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public int LayMaNhanVien(int stt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaNhanVien from DanhSachTamUng where STT=" + stt;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int32.Parse(dt.Rows[0]["MaNhanVien"].ToString());
            }
        }

        public Int64 LayLuongCB(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select LuongCoBan from NhanVien where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int64.Parse(dt.Rows[0]["LuongCoBan"].ToString());
            }
        }

        public Int64 LayDaTamUng(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select DaTamUng from NhanVien where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int64.Parse(dt.Rows[0]["DaTamUng"].ToString());
            }
        }

        public void ThemTUNV(Int64 dtu,int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set DaTamUng=" + dtu + " where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ThemTamUng(DanhSachTamUng dstu)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into DanhSachTamUng(MaNhanVien,NgayTamUng,TienTamUng,GhiChu) values(@manv,@ntu,@ttu,@gc)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@manv", SqlDbType.Int).Value = dstu.MaNhanVien;
                cmd.Parameters.Add("@ntu", SqlDbType.Char).Value = dstu.NgayTamUng;
                cmd.Parameters.Add("@ttu", SqlDbType.BigInt).Value = dstu.TienTamUng;
                cmd.Parameters.Add("@gc", SqlDbType.NVarChar).Value = dstu.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaTamUng(int stt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from DanhSachTamUng where STT=" + stt;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaTUNV(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set DaTamUng=0 where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchDSTU(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayTamUng,TienTamUng,DanhSachTamUng.GhiChu from DanhSachTamUng,NhanVien where (NhanVien.HoTen like N'%" + tukhoa + "%' or NgayTamUng like '%" + tukhoa + "%') and NhanVien.MaNhanVien=DanhSachTamUng.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable TimMNVDSTU(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayTamUng,TienTamUng,DanhSachTamUng.GhiChu from DanhSachTamUng,NhanVien where NhanVien.MaNhanVien=DanhSachTamUng.MaNhanVien and DanhSachTamUng.MaNhanVien=" + manv + " order by STT desc";
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
