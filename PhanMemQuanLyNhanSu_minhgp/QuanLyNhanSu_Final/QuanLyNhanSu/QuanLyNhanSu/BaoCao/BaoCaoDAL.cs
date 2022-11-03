using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.BaoCao
{
    class BaoCaoDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        public BaoCaoDAL()
        {
            dc = new DataConnection();
        }

        public DataTable NhanVienMoiThang()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                DateTime date = DateTime.Now;
                int thang = date.Month;
                int nam = date.Year;
                string sql = "select NhanVien.MaNhanVien,HoTen,GioiTinh,NgayLap,NgayHetHan,TinhTrang from NhanVien,ChiTietHopDong where NhanVien.MaNhanVien=ChiTietHopDong.MaNhanVien and TinhTrang=1 and CONVERT(int,SUBSTRING(NgayLap,4,2))=" + thang + " and CONVERT(int,SUBSTRING(NgayLap,7,4))=" + nam;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable NhanVienNghiThang()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                DateTime date = DateTime.Now;
                int thang = date.Month;
                int nam = date.Year;
                string sql = "select NhanVien.MaNhanVien,HoTen,GioiTinh,NgayLap,NgayHetHan,TinhTrang from NhanVien,ChiTietHopDong where NhanVien.MaNhanVien=ChiTietHopDong.MaNhanVien and TinhTrang=0 and CONVERT(int,SUBSTRING(NgayLap,4,2))=" + thang + " and CONVERT(int,SUBSTRING(NgayLap,7,4))=" + nam;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable NhanVienSapHetHD()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                DateTime date = DateTime.Now;
                int thang = date.Month+1;
                int nam = date.Year;
                string sql = "select NhanVien.MaNhanVien,HoTen,GioiTinh,NgayLap,NgayHetHan,TinhTrang from NhanVien,ChiTietHopDong where NhanVien.MaNhanVien=ChiTietHopDong.MaNhanVien and TinhTrang=1 and CONVERT(int,SUBSTRING(NgayHetHan,4,2))=" + thang + " and CONVERT(int,SUBSTRING(NgayHetHan,7,4))=" + nam;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable NhanVienMoiQuy()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                DateTime date = DateTime.Now;
                int thang = date.Month + 1;
                int quy = ((thang - 1) / 3) + 1;
                int nam = date.Year;
                string sql = "select NhanVien.MaNhanVien,HoTen,GioiTinh,NgayLap,NgayHetHan,TinhTrang from NhanVien,ChiTietHopDong where NhanVien.MaNhanVien=ChiTietHopDong.MaNhanVien and TinhTrang=1 and ((CONVERT(int,SUBSTRING(NgayLap,4,2))-1)/3)+1=" + quy + " and CONVERT(int,SUBSTRING(NgayLap,7,4))=" + nam;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable NhanVienNghiQuy()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                DateTime date = DateTime.Now;
                int thang = date.Month + 1;
                int quy = ((thang - 1) / 3) + 1;
                int nam = date.Year;
                string sql = "select NhanVien.MaNhanVien,HoTen,GioiTinh,NgayLap,NgayHetHan,TinhTrang from NhanVien,ChiTietHopDong where NhanVien.MaNhanVien=ChiTietHopDong.MaNhanVien and TinhTrang=0 and ((CONVERT(int,SUBSTRING(NgayLap,4,2))-1)/3)+1=" + quy + " and CONVERT(int,SUBSTRING(NgayLap,7,4))=" + nam;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable NhanVienMoiNam()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                DateTime date = DateTime.Now;
                int nam = date.Year;
                string sql = "select NhanVien.MaNhanVien,HoTen,GioiTinh,NgayLap,NgayHetHan,TinhTrang from NhanVien,ChiTietHopDong where NhanVien.MaNhanVien=ChiTietHopDong.MaNhanVien and TinhTrang=1 and CONVERT(int,SUBSTRING(NgayLap,7,4))=" + nam;
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable NhanVienNghiNam()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                DateTime date = DateTime.Now;
                int nam = date.Year;
                string sql = "select NhanVien.MaNhanVien,HoTen,GioiTinh,NgayLap,NgayHetHan,TinhTrang from NhanVien,ChiTietHopDong where NhanVien.MaNhanVien=ChiTietHopDong.MaNhanVien and TinhTrang=0 and CONVERT(int,SUBSTRING(NgayLap,7,4))=" + nam;
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
