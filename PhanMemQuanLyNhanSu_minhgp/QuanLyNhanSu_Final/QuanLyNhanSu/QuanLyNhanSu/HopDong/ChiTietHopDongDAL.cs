using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.HopDong
{
    class ChiTietHopDongDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ChiTietHopDongDAL()
        {
            dc = new DataConnection();
        }

        public DataTable TatCaChiTietHopDong()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayLap,NgayHetHan from ChiTietHopDong,NhanVien where ChiTietHopDong.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable LayThongTin(int stt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaHopDong,NoiDung,GhiChu from ChiTietHopDong where STT=" + stt;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void CapNhatChiTietHopDong(ChiTietHopDong cthd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update ChiTietHopDong set MaHopDong=@MaHD,NgayLap=@NgayLap,NgayHetHan=@NgayHH,GhiChu=@GhiChu where STT=@stt";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@stt", SqlDbType.Int).Value = cthd.STT;
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = cthd.MaHopDong;
                cmd.Parameters.Add("@NgayLap", SqlDbType.Char).Value = cthd.NgayLap;
                cmd.Parameters.Add("@NgayHH", SqlDbType.Char).Value = cthd.NgayHetHan;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = cthd.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaChiTietHopDong(ChiTietHopDong cthd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from ChiTietHopDong where STT=@stt";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@stt", SqlDbType.Int).Value = cthd.STT;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public int LayMaNhanVien(int stt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaNhanVien from ChiTietHopDong where STT=" + stt;
                da = new SqlDataAdapter(sql,con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int32.Parse(dt.Rows[0]["MaNhanVien"].ToString());
            }
        }

        public DataTable LayMaNVTenNV()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaNhanVien,HoTen from NhanVien";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public bool KiemTraMaNV(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaNhanVien from ChiTietHopDong where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void ThemCTHD(ChiTietHopDong cthd)
        {
            using(SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into ChiTietHopDong(MaNhanVien,MaHopDong,NgayLap,NgayHetHan,NoiDung,GhiChu) values(@MaNV,@MaHD,@NL,@NHH,@ND,@GC)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = cthd.MaNhanVien;
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = cthd.MaHopDong;
                cmd.Parameters.Add("@NL", SqlDbType.Char).Value = cthd.NgayLap;
                cmd.Parameters.Add("@NHH", SqlDbType.Char).Value = cthd.NgayHetHan;
                cmd.Parameters.Add("@ND", SqlDbType.NVarChar).Value = cthd.NoiDung;
                cmd.Parameters.Add("@GC", SqlDbType.NVarChar).Value = cthd.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public DataTable SearchCTHD(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayLap,NgayHetHan from ChiTietHopDong,NhanVien where (STT like '%" + tukhoa + "%' or NhanVien.HoTen like N'%" + tukhoa + "%' or ChiTietHopDong.MaNhanVien like '%" + tukhoa + "%') and ChiTietHopDong.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable TimMNVCTHD(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,NgayLap,NgayHetHan from ChiTietHopDong,NhanVien where ChiTietHopDong.MaNhanVien=NhanVien.MaNhanVien and ChiTietHopDong.MaNhanVien=" + manv + " order by STT desc";
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
