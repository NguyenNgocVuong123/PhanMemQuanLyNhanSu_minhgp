using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.ChucVu
{
    class ChucVuDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ChucVuDAL()
        {
            dc = new DataConnection();
        }

        public DataTable TatCaChucVu()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from ChucVu";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public bool KiemTraChucVu(string MaCV)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from ChucVu where MaChucVu='" + MaCV + "'";
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

        public void ThemChucVu(ChucVu cv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into ChucVu values(@MaCV,@TenCV,@PhuCapCV)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = cv.MaChucVu;
                cmd.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = cv.TenChucVu;
                cmd.Parameters.Add("@PhuCapCV", SqlDbType.BigInt).Value = cv.PhuCap;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void CapNhatChucVu(ChucVu cv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update ChucVu set TenChucVu=@TenCV, PhuCap=@PhuCapCV where MaChucVu=@MaCV";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = cv.MaChucVu;
                cmd.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = cv.TenChucVu;
                cmd.Parameters.Add("@PhuCapCV",SqlDbType.BigInt).Value = cv.PhuCap;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaChucVu(ChucVu cv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from ChucVu where MaChucVu=@MaCV";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = cv.MaChucVu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchCV(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from ChucVu where MaChucVu like '%" + tukhoa + "%' or TenChucVu like N'%" + tukhoa + "%'";
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
