using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyNhanSu.ChuyenMon
{
    public partial class formThemChuyenMon : DevExpress.XtraEditors.XtraForm
    {
        ChuyenMonBL blCM;
        public formThemChuyenMon()
        {
            InitializeComponent();
            blCM = new ChuyenMonBL();
        }

        public bool KiemTra()
        {
            if (txtMaCM.Text == "")
            {
                MessageBox.Show("Mã chuyên môn không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenCM.Text == "")
            {
                MessageBox.Show("Tên chuyên môn không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemCM_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blCM.KiemTraChuyenMon(txtMaCM.Text.Trim()))
                {
                    ChuyenMon cm = new ChuyenMon();
                    cm.MaChuyenMon = txtMaCM.Text.Trim();
                    cm.TenChuyenMon = txtTenCM.Text.Trim();
                    blCM.ThemChuyenMon(cm);
                    MessageBox.Show("Thêm chuyên môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaCM.Text = "";
                    txtTenCM.Text = "";
                }
                else
                {
                    MessageBox.Show("Mã chuyên môn này đã tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMaCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || e.KeyChar == 8);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
