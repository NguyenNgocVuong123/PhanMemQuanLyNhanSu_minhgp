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

namespace QuanLyNhanSu.PhatLuong
{
    public partial class formCauHinhPL : DevExpress.XtraEditors.XtraForm
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public formCauHinhPL()
        {
            InitializeComponent();
            dc = new DataConnection();
        }

        private void formCauHinhPL_Load(object sender, EventArgs e)
        {
            LoadCHPL();
        }

        public void LoadCHPL()
        {
            DataTable dt = LayCHPL();
            txtSoNgayLamViec.Text = dt.Rows[0]["SoNgayLamViec"].ToString();
            txtThuongTangCa.Text = dt.Rows[0]["ThuongTangCa"].ToString();
            txtBHYT.Text = dt.Rows[0]["BHYT"].ToString();
            txtBHXH.Text = dt.Rows[0]["BHXH"].ToString();
            txtBHTN.Text = dt.Rows[0]["BHTN"].ToString();
        }

        public DataTable LayCHPL()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select * from CauHinhPhatLuong";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CapNhatCHPL(int snlv, int ttc, int bhyt, int bhxh, int bhtn)
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "update CauHinhPhatLuong set SoNgayLamViec=" + snlv + ",ThuongTangCa=" + ttc + ",BHYT=" + bhyt + ",BHXH=" + bhxh + ",BHTN=" + bhtn;
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool KiemTra()
        {
            if (txtSoNgayLamViec.Text == "")
            {
                MessageBox.Show("Số ngày làm việc không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNgayLamViec.Undo();
                return false;
            }
            if (txtThuongTangCa.Text == "")
            {
                MessageBox.Show("Thưởng tăng ca không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThuongTangCa.Undo();
                return false;
            }
            if (txtBHYT.Text == "")
            {
                MessageBox.Show("Chi phí Bảo hiểm y tế không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBHYT.Undo();
                return false;
            }
            if (txtBHXH.Text == "")
            {
                MessageBox.Show("Chi phí Bảo hiểm xã hội không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBHXH.Undo();
                return false;
            }
            if (txtBHTN.Text == "")
            {
                MessageBox.Show("Chi phí Bảo hiểm thất nghiệp không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBHTN.Undo();
                return false;
            }
            return true;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                int snlv = Int32.Parse(txtSoNgayLamViec.Text.Trim());
                int ttc = Int32.Parse(txtThuongTangCa.Text.Trim());
                int bhyt = Int32.Parse(txtBHYT.Text.Trim());
                int bhxh = Int32.Parse(txtBHXH.Text.Trim());
                int bhtn = Int32.Parse(txtBHTN.Text.Trim());
                CapNhatCHPL(snlv, ttc, bhyt, bhxh, bhtn);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSoNgayLamViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtThuongTangCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBHYT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBHXH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBHTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}