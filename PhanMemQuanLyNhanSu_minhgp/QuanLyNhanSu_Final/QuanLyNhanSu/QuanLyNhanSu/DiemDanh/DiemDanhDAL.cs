using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.DiemDanh
{
    class DiemDanhDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public DiemDanhDAL()
        {
            dc = new DataConnection();
        }

        public DataTable DanhSachDiemDanh()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,LoaiDiemDanh,NgayDiemDanh,LyDo from DiemDanh,NhanVien where DiemDanh.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public int LayMaNV(int stt)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaNhanVien from DiemDanh where STT=" + stt;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int32.Parse(dt.Rows[0]["MaNhanVien"].ToString());
            }
        }

        public int LaySNV(int manv)
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

        public int LaySNTC(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select SoNgayTangCa from NhanVien where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int32.Parse(dt.Rows[0]["SoNgayTangCa"].ToString());
            }
        }

        public void CapNhatDiemDanh(DiemDanh dd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update DiemDanh set NgayDiemDanh=@NV,LyDo=@LD where STT=@stt";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@stt", SqlDbType.Int).Value = dd.STT;
                cmd.Parameters.Add("@NV", SqlDbType.Char).Value = dd.NgayVang;
                cmd.Parameters.Add("@LD", SqlDbType.NVarChar).Value = dd.LyDo;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DanhDauVang(DiemDanh dd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into DiemDanh(MaNhanVien,LoaiDiemDanh,NgayDiemDanh,LyDo) values(@MaNV,@LoaiDD,@NV,@LD)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = dd.MaNhanVien;
                cmd.Parameters.Add("@LoaiDD", SqlDbType.Int).Value = dd.LoaiDiemDanh;
                cmd.Parameters.Add("@NV", SqlDbType.Char).Value = dd.NgayVang;
                cmd.Parameters.Add("@LD", SqlDbType.NVarChar).Value = dd.LyDo;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void CapNhatSoNgayVang(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set SoNgayVang=SoNgayVang+1 where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void GiamSoNgayVang(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set SoNgayVang=SoNgayVang-1 where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void CapNhatSoNgayTangCa(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set SoNgayTangCa=SoNgayTangCa+1 where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void GiamSoNgayTangCa(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set SoNgayTangCa=SoNgayTangCa-1 where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaDiemDanh(DiemDanh dd)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from DiemDanh where STT=@stt";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@stt", SqlDbType.Int).Value = dd.STT;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchDD(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,LoaiDiemDanh,NgayDiemDanh,LyDo from DiemDanh,NhanVien where (DiemDanh.MaNhanVien like '%" + tukhoa + "%' or NhanVien.HoTen like N'%" + tukhoa + "%' or NgayDiemDanh like '%" + tukhoa + "%' or LyDo like N'%" + tukhoa + "%') and DiemDanh.MaNhanVien=NhanVien.MaNhanVien order by STT desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable TimMNVDD(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select STT,NhanVien.HoTen,LoaiDiemDanh,NgayDiemDanh,LyDo from DiemDanh,NhanVien where DiemDanh.MaNhanVien=NhanVien.MaNhanVien and DiemDanh.MaNhanVien=" + manv + " order by STT desc";
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
