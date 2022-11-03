using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.PhatLuong
{
    class PhatLuongDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public PhatLuongDAL()
        {
            dc = new DataConnection();
        }

        public DataTable DanhSachPhatLuong()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayLanh,TongLanh,PhatLuong.GhiChu from PhatLuong,NhanVien where PhatLuong.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void CapNhatPhatLuong(PhatLuong pl)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update PhatLuong set NgayLanh=@NL,GhiChu=@GC where STT=@STT";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@STT", SqlDbType.Int).Value = pl.STT;
                cmd.Parameters.Add("@NL", SqlDbType.Char).Value = pl.NgayLanh;
                cmd.Parameters.Add("@GC", SqlDbType.NVarChar).Value = pl.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaPhatLuong(PhatLuong pl)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from PhatLuong where STT=@STT";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@STT", SqlDbType.Int).Value = pl.STT;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public int LaySoNgayVang(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select SoNgayVang from NhanVien where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int32.Parse(dt.Rows[0]["SoNgayVang"].ToString());
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

        public Int64 LayPhuCapCV(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select PhuCap from NhanVien,ChucVu where NhanVien.MaChucVu=ChucVu.MaChucVu and NhanVien.MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int64.Parse(dt.Rows[0]["PhuCap"].ToString());
            }
        }

        public Int64 LayTienTamUng(int manv)
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

        public DataTable CauHinhPhatLuong()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from CauHinhPhatLuong";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void ThemPhatLuong(PhatLuong pl)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into PhatLuong(MaNhanVien,NgayLanh,TongLanh,GhiChu) values(@MaNV,@NL,@TL,@GC)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = pl.MaNhanVien;
                cmd.Parameters.Add("@NL", SqlDbType.Char).Value = pl.NgayLanh;
                cmd.Parameters.Add("@TL", SqlDbType.BigInt).Value = pl.TongLanh;
                cmd.Parameters.Add("@GC", SqlDbType.NVarChar).Value = pl.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ResetNVNTC(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set SoNgayVang=0,SoNgayTangCa=0,DaTamUng=0 where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchPL(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayLanh,TongLanh,PhatLuong.GhiChu from PhatLuong,NhanVien where (PhatLuong.MaNhanVien like '" + tukhoa + "' or NhanVien.HoTen like N'%" + tukhoa + "%' or NgayLanh like '%" + tukhoa + "%' or TongLanh like '%" + tukhoa + "%') and PhatLuong.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
        public DataTable TimMNVPL(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayLanh,TongLanh,PhatLuong.GhiChu from PhatLuong,NhanVien where PhatLuong.MaNhanVien=NhanVien.MaNhanVien and PhatLuong.MaNhanVien=" + manv + " order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public string LayEmail(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select Email from NhanVien where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt.Rows[0]["Email"].ToString();
            }
        }
    }
}
