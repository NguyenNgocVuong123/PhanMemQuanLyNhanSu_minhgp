using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.ChuyenMon
{
    class ChuyenMonDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ChuyenMonDAL()
        {
            dc = new DataConnection();
        }

        public DataTable TatCaChuyenMon()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from ChuyenMon";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public bool KiemTraChuyenMon(string macm)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from ChuyenMon where MaChuyenMon='" + macm + "'";
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

        public void ThemChuyenMon(ChuyenMon cm)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into ChuyenMon values(@MaCM,@TenCM)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaCM", SqlDbType.Char).Value = cm.MaChuyenMon;
                cmd.Parameters.Add("@TenCM", SqlDbType.NVarChar).Value = cm.TenChuyenMon;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void CapNhatChuyenMon(ChuyenMon cm)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update ChuyenMon set TenChuyenMon=@TenCM where MaChuyenMon=@MaCM";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaCM", SqlDbType.Char).Value = cm.MaChuyenMon;
                cmd.Parameters.Add("@TenCM", SqlDbType.NVarChar).Value = cm.TenChuyenMon;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaChuyenMon(ChuyenMon cm)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from ChuyenMon where MaChuyenMon=@MaCM";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaCM", SqlDbType.Char).Value = cm.MaChuyenMon;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchChuyenMon(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from ChuyenMon where MaChuyenMon like '%" + tukhoa + "%' or TenChuyenMon like N'%" + tukhoa + "%'";
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
