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
using QuanLyNhanSu.HopDong;

namespace QuanLyNhanSu.KhenThuong
{
    public partial class formThemKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        ChiTietHopDongBL blCTHD;
        KhenThuongBL blKT;
        public formThemKhenThuong()
        {
            InitializeComponent();
            blCTHD = new ChiTietHopDongBL();
            blKT = new KhenThuongBL();
        }

        private void formThemKT_Load(object sender, EventArgs e)
        {
            LoadListNhanVien();
            listNhanVien.SelectedItem = null;
        }
        public void LoadListNhanVien()
        {
            DataTable dt = blCTHD.LayMaNVTenNV();
            listNhanVien.DataSource = dt;
            listNhanVien.DisplayMember = "HoTen";
            listNhanVien.ValueMember = "MaNhanVien";
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

            try
            {
                listNhanVien.SelectedValue = txtMaNV.Text;
            }
            catch
            {

            }
        }

        private void listNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listNhanVien.SelectedItem != null)
            {
                txtMaNV.Text = listNhanVien.SelectedValue.ToString();
            }
            else
            {
                txtMaNV.Text = "";
            }
        }

        private void txtTienThuong_TextChanged(object sender, EventArgs e)
        {
            if (txtTienThuong.Text != "")
            {
                lbTienThuong.Text = String.Format("{0:C0}", Int64.Parse(txtTienThuong.Text.Trim()));
            }
            else
            {
                lbTienThuong.Text = "0 đ";
            }
        }

        public bool KiemTra()
        {
            if (txtMaNV.Text == "" || listNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên hoặc nhân viên không tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTienThuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tiền thưởng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                KhenThuong kt = new KhenThuong();
                kt.MaNhanVien = Int32.Parse(txtMaNV.Text.Trim());
                kt.TienThuong = Int64.Parse(txtTienThuong.Text.Trim());
                kt.NgayThuong = dateNgayThuong.Value.ToShortDateString();
                kt.GhiChu = txtGhiChu.Text;
                blKT.ThemKhenThuong(kt);
                MessageBox.Show("Thêm khen thưởng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Text = "";
                txtTienThuong.Text = "";
                txtGhiChu.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTienThuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}