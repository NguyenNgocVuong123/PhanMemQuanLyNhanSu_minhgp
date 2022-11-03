using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.PhongBan
{
    public partial class formThemPhongBan : DevExpress.XtraEditors.XtraForm
    {
        PhongBanBL blPB;
        public formThemPhongBan()
        {
            InitializeComponent();
            blPB = new PhongBanBL();
        }

        public bool KiemTra()
        {
            if (txtMaPB.Text == "")
            {
                MessageBox.Show("Mã phòng ban không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenPB.Text == "")
            {
                MessageBox.Show("Tên phòng ban không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blPB.KiemTraPhongBan(txtMaPB.Text.Trim()))
                {
                    PhongBan pb = new PhongBan();
                    pb.MaPhongBan = txtMaPB.Text.Trim();
                    pb.TenPhongBan = txtTenPB.Text.Trim();
                    pb.GhiChu = txtGhiChuPB.Text;
                    blPB.ThemPhongBan(pb);
                    MessageBox.Show("Thêm phòng ban thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaPB.Text = "";
                    txtTenPB.Text = "";
                    txtGhiChuPB.Text = "";
                }
                else
                {
                    MessageBox.Show("Mã phòng ban này đã tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtMaPB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || e.KeyChar == 8);
        }
    }
}
