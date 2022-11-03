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

namespace QuanLyNhanSu.QueQuan
{
    public partial class formThemQQ : DevExpress.XtraEditors.XtraForm
    {
        QueQuanBL blQQ;
        public formThemQQ()
        {
            InitializeComponent();
            blQQ = new QueQuanBL();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public bool KiemTra()
        {
            if (txtMaQQ.Text == "")
            {
                MessageBox.Show("Mã quê quán không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenQQ.Text == "")
            {
                MessageBox.Show("Tên quê quán không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemQQ_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blQQ.KiemTraQueQuan(txtMaQQ.Text.Trim()))
                {
                    QueQuan qq = new QueQuan();
                    qq.MaQueQuan = txtMaQQ.Text.Trim();
                    qq.TenQueQuan = txtTenQQ.Text.Trim();
                    blQQ.ThemQueQuan(qq);
                    MessageBox.Show("Thêm quê quán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaQQ.Text = "";
                    txtTenQQ.Text = "";
                }
                else
                {
                    MessageBox.Show("Mã quê quán này đã tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMaQQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || e.KeyChar == 8);
        }
    }
}