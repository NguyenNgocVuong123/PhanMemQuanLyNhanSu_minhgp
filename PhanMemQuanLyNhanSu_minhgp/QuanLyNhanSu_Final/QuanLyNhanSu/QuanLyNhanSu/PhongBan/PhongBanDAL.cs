using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.PhongBan
{
    class PhongBanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PhongBanDAL()
        {
            dc = new DataConnection();
        }
        public DataTable TatCaPhongBan()
        {
            using(SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from PhongBan";
                da = new SqlDataAdapter(sql, con);
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public bool KiemTraPhongBan(string MaPB)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from PhongBan where MaPhongBan='" + MaPB + "'";
                da = new SqlDataAdapter(sql, con);
                con.Open();
                DataTable dt = new DataTable();
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

        public void ThemPhongBan(PhongBan pb)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into PhongBan values(@MaPB,@TenPB,@GhiChuPB)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaPB", SqlDbType.Char).Value = pb.MaPhongBan;
                cmd.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = pb.TenPhongBan;
                cmd.Parameters.Add("GhiChuPB", SqlDbType.NVarChar).Value = pb.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void CapNhatPhongBan(PhongBan pb)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update PhongBan set TenPhongBan=@TenPB,GhiChu=@GhiChuPB where MaPhongBan=@MaPB";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaPB", SqlDbType.Char).Value = pb.MaPhongBan;
                cmd.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = pb.TenPhongBan;
                cmd.Parameters.Add("@GhiChuPB", SqlDbType.NVarChar).Value = pb.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaPhongBan(PhongBan pb)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from PhongBan where MaPhongBan=@MaPB";
                cmd = new SqlCommand(sql,con);
                con.Open();
                cmd.Parameters.Add("@MaPB", SqlDbType.Char).Value = pb.MaPhongBan;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchPhongBan(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from PhongBan where MaPhongBan like '%" + tukhoa + "%' or TenPhongBan like N'%" + tukhoa + "%'";
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
