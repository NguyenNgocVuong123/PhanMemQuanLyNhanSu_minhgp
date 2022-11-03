using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.NhanVien
{
    class NhanVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NhanVienDAL()
        {
            dc = new DataConnection();
        }

        public DataTable TatCaNhanVien()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaNhanVien,HoTen,GioiTinh,Email,SDT,TinhTrang from NhanVien";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public string LayUrlAnh(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select UrlAnh from NhanVien where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt.Rows[0]["UrlAnh"].ToString();
            }
        }

        public DataTable LayThongTinNhanVien(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from NhanVien where MaNhanVien=" + manv;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public void CapNhatNhanVien(NhanVien nv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set MaPhongBan=@MaPB,MaChucVu=@MaCV,MaChuyenMon=@MaCM,MaQueQuan=@MaQQ, HoTen=@TenNV,GioiTinh=@gt, Email=@email, SDT=@sdt, CMND=@cmnd, LuongCoBan=@LuongCB, TinhTrang=@tt, GhiChu=@gc where MaNhanVien=@MaNV";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNhanVien;
                cmd.Parameters.Add("@MaPB", SqlDbType.Char).Value = nv.MaPhongBan;
                cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = nv.MaChucVu;
                cmd.Parameters.Add("@MaCM", SqlDbType.Char).Value = nv.MaChuyenMon;
                cmd.Parameters.Add("@MaQQ", SqlDbType.Char).Value = nv.MaQueQuan;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@gt", SqlDbType.Int).Value = nv.GioiTinh;
                cmd.Parameters.Add("@email", SqlDbType.Char).Value = nv.Emai;
                cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = nv.SDT;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char).Value = nv.CMND;
                cmd.Parameters.Add("@LuongCB", SqlDbType.BigInt).Value = nv.LuongCoBan;
                cmd.Parameters.Add("@tt", SqlDbType.Int).Value = nv.TinhTrang;
                cmd.Parameters.Add("@gc", SqlDbType.NVarChar).Value = nv.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public int LayIDMoiNhatNV()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select top 1 (MaNhanVien) from NhanVien order by MaNhanVien desc";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int32.Parse(dt.Rows[0]["MaNhanVien"].ToString());
            }
        }

        public void CapNhatUrlAnh(int manv, string data)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update NhanVien set UrlAnh='" + data + "' where MaNhanVien=" + manv;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ThemNhanVien(NhanVien nv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "insert into NhanVien(MaPhongBan,MaChucVu,MaChuyenMon,MaQueQuan,HoTen,GioiTinh,Email,SDT,CMND,UrlAnh,LuongCoBan,SoNgayVang,SoNgayTangCa,TinhTrang,GhiChu) values(@MaPB,@MaCV,@MaCM,@MaQQ,@TenNV,@gt,@email,@sdt,@cmnd,@url,@LuongCB,0,0,@tt,@gc)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaPB", SqlDbType.Char).Value = nv.MaPhongBan;
                cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = nv.MaChucVu;
                cmd.Parameters.Add("@MaCM", SqlDbType.Char).Value = nv.MaChuyenMon;
                cmd.Parameters.Add("@MaQQ", SqlDbType.Char).Value = nv.MaQueQuan;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.HoTen;
                cmd.Parameters.Add("@gt", SqlDbType.Int).Value = nv.GioiTinh;
                cmd.Parameters.Add("@email", SqlDbType.Char).Value = nv.Emai;
                cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = nv.SDT;
                cmd.Parameters.Add("@cmnd", SqlDbType.Char).Value = nv.CMND;
                cmd.Parameters.Add("@url", SqlDbType.Char).Value = nv.UrlAnh;
                cmd.Parameters.Add("@LuongCB", SqlDbType.BigInt).Value = nv.LuongCoBan;
                cmd.Parameters.Add("@tt", SqlDbType.Int).Value = nv.TinhTrang;
                cmd.Parameters.Add("@gc", SqlDbType.NVarChar).Value = nv.GhiChu;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void XoaNhanVien(NhanVien nv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "delete from NhanVien where MaNhanVien=@MaNV";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNhanVien;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable SearchNV(string tukhoa)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select NhanVien.MaNhanVien,NhanVien.HoTen,NhanVien.GioiTinh,NhanVien.Email,NhanVien.SDT,NhanVien.TinhTrang from NhanVien,PhongBan,ChucVu,QueQuan,ChuyenMon where (MaNhanVien like '%"+tukhoa+"%' or Hoten like N'%" + tukhoa + "%' or Email like '%" + tukhoa + "%' or SDT like '%" + tukhoa + "%' or CMND like '%" + tukhoa + "%' or PhongBan.TenPhongBan like N'%" + tukhoa + "%' or ChucVu.TenChucVu like N'%" + tukhoa + "%' or ChuyenMon.TenChuyenMon like N'%" + tukhoa + "%' or QueQuan.TenQueQuan like N'%" + tukhoa + "%') and PhongBan.MaPhongBan=NhanVien.MaPhongBan and QueQuan.MaQueQuan=NhanVien.MaQueQuan and ChuyenMon.MaChuyenMon=NhanVien.MaChuyenMon and ChucVu.MaChucVu=NhanVien.MaChucVu";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable TimMNVNV(int manv)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MaNhanVien,HoTen,GioiTinh,Email,SDT,TinhTrang from NhanVien where MaNhanVien=" + manv;
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
