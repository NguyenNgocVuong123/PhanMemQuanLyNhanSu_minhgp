using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.HopDong
{
    public partial class formThemHopDong : DevExpress.XtraEditors.XtraForm
    {
        HopDongBL blHD;
        public formThemHopDong()
        {
            InitializeComponent();
            blHD = new HopDongBL();
        }

        public bool KiemTra()
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Mã hợp đồng không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenHD.Text == "")
            {
                MessageBox.Show("Tên hợp đồng không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || e.KeyChar == 8);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blHD.KiemTraMaHD(txtMaHD.Text))
                {
                    HopDong hd = new HopDong();
                    hd.MaHopDong = txtMaHD.Text.Trim();
                    hd.TenHopDong = txtTenHD.Text.Trim();
                    hd.GhiChu = txtGhiChu.Text.Trim();
                    blHD.ThemHopDong(hd);
                    MessageBox.Show("Thêm hợp đồng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaHD.Text = "";
                    txtTenHD.Text = "";
                    txtGhiChu.Text = "";
                }
                else
                {
                    MessageBox.Show("Mã hợp đồng này đã tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
