using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.HopDong
{
    class HopDongDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public HopDongDAL()
        {
            dc = new DataConnection();
        }

        public DataTable TatCaHopDong()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from HopDong";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void CapNhatHopDong(HopDong hd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update HopDong set TenHopDong=@TenHD,GhiChu=@gc where MaHopDong=@MaHD";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = hd.MaHopDong;
                cmd.Parameters.Add("TenHD", SqlDbType.NVarChar).Value = hd.TenHopDong;
                cmd.Parameters.Add("@gc", SqlDbType.NVarChar).Value = hd.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaHopDong(HopDong hd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from HopDong where MaHopDong=@MaHD";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = hd.MaHopDong;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool KiemTraMaHD(string mahd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from HopDong where MaHopDong='" + mahd + "'";
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

        public void ThemHopDong(HopDong hd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into HopDong values(@MaHD,@TenHD,@GC)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = hd.MaHopDong;
                cmd.Parameters.Add("@TenHD", SqlDbType.NVarChar).Value = hd.TenHopDong;
                cmd.Parameters.Add("@GC", SqlDbType.NVarChar).Value = hd.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
