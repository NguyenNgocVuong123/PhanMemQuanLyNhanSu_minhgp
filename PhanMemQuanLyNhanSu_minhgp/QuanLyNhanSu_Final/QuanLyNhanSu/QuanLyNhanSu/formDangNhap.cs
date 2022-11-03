using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class formDangNhap : DevExpress.XtraEditors.XtraForm
    {
        DataConnection dc;
        public formDangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
            dc = new DataConnection();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        public bool KiemTra()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public int LayPhanQuyen(string tk)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select PhanQuyen from TaiKhoan where TenTaiKhoan='" + tk + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return Int32.Parse(dt.Rows[0]["PhanQuyen"].ToString());
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTra())
                {
                    using (SqlConnection con = dc.GetConnect())
                    {
                        string taikhoan = txtTaiKhoan.Text.Trim();
                        string matkhau = txtMatKhau.Text.Trim();
                        string sql = "select TenTaiKhoan,MatKhau from TaiKhoan where TenTaiKhoan='" + taikhoan + "' COLLATE SQL_Latin1_General_CP1_CS_AS and MatKhau='" + matkhau + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
                        SqlDataAdapter da = new SqlDataAdapter(sql, con);
                        DataTable dt = new System.Data.DataTable();
                        con.Open();
                        da.Fill(dt);
                        con.Close();
                        if (dt.Rows.Count > 0)
                        {
                            formMain fM = new formMain();
                            fM.phanquyen = LayPhanQuyen(taikhoan);
                            this.Hide();
                            if (fM.ShowDialog() == DialogResult.Cancel)
                            {
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu, hãy kiểm tra lại chuỗi kết nối trong file .config", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formQuenMatKhau fQMK = new formQuenMatKhau();
            fQMK.ShowDialog();
        }
    }
}