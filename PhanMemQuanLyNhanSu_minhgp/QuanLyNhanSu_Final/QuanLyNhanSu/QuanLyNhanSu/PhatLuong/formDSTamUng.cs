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

namespace QuanLyNhanSu.PhatLuong
{
    public partial class formDSTamUng : DevExpress.XtraEditors.XtraForm
    {
        HopDong.ChiTietHopDongBL blCTHD;
        DanhSachTamUngBL blDSTU;
        public Int64 LuongCB;
        public Int64 DaTamUng;
        public formDSTamUng()
        {
            InitializeComponent();
            blCTHD = new HopDong.ChiTietHopDongBL();
            blDSTU = new DanhSachTamUngBL();
        }

        public void LoadListNhanVien()
        {
            DataTable dt = blCTHD.LayMaNVTenNV();
            listNhanVien.DataSource = dt;
            listNhanVien.DisplayMember = "HoTen";
            listNhanVien.ValueMember = "MaNhanVien";
        }

        private void formDSTamUng_Load(object sender, EventArgs e)
        {
            LoadListNhanVien();
            DanhSachTamUng();
            listNhanVien.SelectedItem = null;
            txtMaNV.Text = "";
        }

        public void DanhSachTamUng()
        {
            DataTable dt = blDSTU.DanhSachTamUng();
            dgvTamUng.DataSource = dt;
            if (dgvTamUng.Rows.Count > 0)
            {
                dgvTamUng.CurrentRow.Selected = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && listNhanVien.ValueMember != null)
            {
                try
                {
                    listNhanVien.SelectedValue = txtMaNV.Text;
                    LuongCB = blDSTU.LayLuongCB(Int32.Parse(txtMaNV.Text.Trim()));
                    txtLuongCB.Text = LuongCB.ToString();
                    DaTamUng = blDSTU.LayDaTamUng(Int32.Parse(txtMaNV.Text.Trim()));
                    txtDaTamUng.Text = DaTamUng.ToString();
                    txtTienTamUng.ReadOnly = false;
                }
                catch
                {

                }
            }
            else
            {
                listNhanVien.SelectedItem = null;
                txtLuongCB.Text = "";
                txtTienTamUng.Text = "";
                txtDaTamUng.Text = "";
                txtTienTamUng.ReadOnly = true;
            }
        }

        private void listNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            txtTienTamUng.Text = "";
            if (listNhanVien.SelectedItem != null)
            {
                txtMaNV.Text = listNhanVien.SelectedValue.ToString();
            }
            else
            {
                
            }
        }

        public bool KiemTra()
        {
            if (txtMaNV.Text == "" || listNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (DaTamUng != 0)
            {
                MessageBox.Show("Nhân viên bạn chọn đã tạm ứng tháng này", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTienTamUng.Text == "")
            {
                MessageBox.Show("Tiền tạm ứng không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dgvTamUng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTamUng.Rows.Count > 0)
            {
                dgvTamUng.CurrentRow.Selected = true;
                
            }
        }

        private void txtTienTamUng_TextChanged(object sender, EventArgs e)
        {
            if (txtTienTamUng.Text != "")
            {
                lbTienTamUng.Text = String.Format("{0:C0}", Int64.Parse(txtTienTamUng.Text.Trim()));
                if (Int64.Parse(txtTienTamUng.Text.Trim()) > LuongCB)
                {
                    MessageBox.Show("Tiền tạm ứng không được nhiều hơn lương cơ bản", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTienTamUng.Text = txtLuongCB.Text;
                }
            }
            else
            {
                lbTienTamUng.Text = "0 đ";
            }
        }

        private void txtTienTamUng_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                DanhSachTamUng dstu = new DanhSachTamUng();
                dstu.MaNhanVien = Int32.Parse(txtMaNV.Text.Trim());
                dstu.NgayTamUng = dateTamUng.Value.ToShortDateString();
                dstu.TienTamUng = Int64.Parse(txtTienTamUng.Text.Trim());
                dstu.GhiChu = txtGhiChu.Text;
                blDSTU.ThemTamUng(dstu);
                blDSTU.ThemTUNV(dstu.TienTamUng, dstu.MaNhanVien);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachTamUng();
                txtMaNV.Text = "";
                txtGhiChu.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            DateTime dateDGV = DateTime.Parse(dgvTamUng.CurrentRow.Cells["NgayTU"].Value.ToString());
            if (dateDGV.Month != dateNow.Month)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa thông tin tạm ứng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    blDSTU.XoaTamUng(Int32.Parse(dgvTamUng.CurrentRow.Cells["STT"].Value.ToString()));
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DanhSachTamUng();
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa thông tin tạm ứng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int manv = blDSTU.LayMaNhanVien(Int32.Parse(dgvTamUng.CurrentRow.Cells["STT"].Value.ToString()));
                    blDSTU.XoaTamUng(Int32.Parse(dgvTamUng.CurrentRow.Cells["STT"].Value.ToString()));
                    blDSTU.XoaTUNV(manv);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DanhSachTamUng();
                }
            }
        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {
            if (txtLuongCB.Text != "")
            {
                lbLuongCB.Text = String.Format("{0:C0}", Int64.Parse(txtLuongCB.Text.Trim()));
            }
            else
            {
                lbLuongCB.Text = "0 đ";
            }
        }

        private void txtDaTamUng_TextChanged(object sender, EventArgs e)
        {
            if (txtDaTamUng.Text != "")
            {
                lbDaTamUng.Text = String.Format("{0:C0}", Int64.Parse(txtDaTamUng.Text.Trim()));
            }
            else
            {
                lbDaTamUng.Text = "0 đ";
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                DataTable dt = blDSTU.SearchDSTU(txtTimKiem.Text.Trim());
                dgvTamUng.DataSource = dt;
                if (dgvTamUng.Rows.Count > 0)
                {
                    dgvTamUng.CurrentRow.Selected = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                DanhSachTamUng();
            }
        }

        private void txtTimMNVDSTU_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMNVDSTU.Text != "")
            {
                DataTable dt = blDSTU.TimMNVDSTU(Int32.Parse(txtTimMNVDSTU.Text.Trim()));
                dgvTamUng.DataSource = dt;
                if (dgvTamUng.Rows.Count > 0)
                {
                    dgvTamUng.CurrentRow.Selected = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                DanhSachTamUng();
            }
        }

        private void txtTimMNVDSTU_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}