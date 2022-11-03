using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu.QueQuan
{
    class QueQuanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public QueQuanDAL()
        {
            dc = new DataConnection();
        }

        public DataTable TatCaQueQuan()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from QueQuan";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void CapNhatQueQuan(QueQuan qq)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update QueQuan set TenQueQuan=@TenQQ where MaQueQuan=@MaQQ";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaQQ", SqlDbType.Char).Value = qq.MaQueQuan;
                cmd.Parameters.Add("@TenQQ", SqlDbType.NVarChar).Value = qq.TenQueQuan;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool KiemTraQueQuan(string maqq)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from QueQuan where MaQueQuan='" + maqq + "'";
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

        public void ThemQueQuan(QueQuan qq)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into QueQuan values(@MaQQ,@TenQQ)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaQQ", SqlDbType.Char).Value = qq.MaQueQuan;
                cmd.Parameters.Add("@TenQQ", SqlDbType.NVarChar).Value = qq.TenQueQuan;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaQueQuan(QueQuan qq)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from QueQuan where MaQueQuan=@MaQQ";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaQQ", SqlDbType.Char).Value = qq.MaQueQuan;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchQueQuan(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from QueQuan where MaQueQuan like '%" + tukhoa + "%' or TenQueQuan like N'%" + tukhoa + "%'";
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
