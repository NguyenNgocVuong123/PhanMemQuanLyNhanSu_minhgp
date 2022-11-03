using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ChucVu
{
    public partial class formThemChucVu : DevExpress.XtraEditors.XtraForm
    {
        ChucVuBL blCV;
        public formThemChucVu()
        {
            InitializeComponent();
            blCV = new ChucVuBL();
        }

        public bool KiemTra()
        {
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Mã chức vụ không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Tên chức vụ không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPhuCapCV.Text == "")
            {
                MessageBox.Show("Phụ cấp không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blCV.KiemTraChucVu(txtMaCV.Text.Trim()))
                {
                    ChucVu cv = new ChucVu();
                    cv.MaChucVu = txtMaCV.Text.Trim();
                    cv.TenChucVu = txtTenCV.Text.Trim();
                    cv.PhuCap = Int64.Parse(txtPhuCapCV.Text);
                    blCV.ThemChucVu(cv);
                    MessageBox.Show("Thêm chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaCV.Text = "";
                    txtTenCV.Text = "";
                    txtPhuCapCV.Text = "";
                }
                else
                {
                    MessageBox.Show("Mã chức vụ này đã tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPhuCapCV_TextChanged(object sender, EventArgs e)
        {
            if (txtPhuCapCV.Text != "")
            {
                Int64 pccv = Int64.Parse(txtPhuCapCV.Text);
                string pc = String.Format("{0:C0}", pccv);
                lbPhuCapCV.Text = pc;
            }
            else
            {
                lbPhuCapCV.Text = "0 đ";
            }
        }

        private void txtPhuCapCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || e.KeyChar == 8);
        }
    }
}
