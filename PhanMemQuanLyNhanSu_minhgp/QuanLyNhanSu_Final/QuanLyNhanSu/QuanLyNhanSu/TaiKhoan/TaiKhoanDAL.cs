using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.TaiKhoan
{
    class TaiKhoanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public TaiKhoanDAL()
        {
            dc = new DataConnection();
        }

        public DataTable DanhSachTaiKhoan()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select TenTaiKhoan,Email,PhanQuyen from TaiKhoan";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void DoiMatKhau(TaiKhoan tk)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update TaiKhoan set MatKhau=@matkhau where TenTaiKhoan=@taikhoan";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@taikhoan", SqlDbType.Char).Value = tk.TenTaiKhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = tk.MatKhau;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DoiEmail(TaiKhoan tk)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update TaiKhoan set Email=@email where TenTaiKhoan=@taikhoan";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@taikhoan", SqlDbType.Char).Value = tk.TenTaiKhoan;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = tk.Email;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DoiPhanQuyen(TaiKhoan tk)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update TaiKhoan set PhanQuyen=@phanquyen where TenTaiKhoan=@taikhoan";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@taikhoan", SqlDbType.Char).Value = tk.TenTaiKhoan;
                cmd.Parameters.Add("@phanquyen", SqlDbType.Int).Value = tk.PhanQuyen;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool KiemTraTaiKhoan(string tk)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select TenTaiKhoan from TaiKhoan where TenTaiKhoan='" + tk + "'";
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

        public void ThemTaiKhoan(TaiKhoan tk)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into TaiKhoan values (@taikhoan,@matkhau,@email,@phanquyen)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@taikhoan", SqlDbType.Char).Value = tk.TenTaiKhoan;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = tk.MatKhau;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = tk.Email;
                cmd.Parameters.Add("@phanquyen", SqlDbType.Int).Value = tk.PhanQuyen;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaTaiKhoan(TaiKhoan tk)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from TaiKhoan where TenTaiKhoan=@taikhoan";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@taikhoan", SqlDbType.Char).Value = tk.TenTaiKhoan;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
