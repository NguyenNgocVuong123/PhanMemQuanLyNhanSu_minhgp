using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.HopDong;
using QuanLyNhanSu.PhatLuong;

namespace QuanLyNhanSu.DiemDanh
{
    public partial class formThemDiemDanh : DevExpress.XtraEditors.XtraForm
    {
        ChiTietHopDongBL blCTHD;
        DiemDanhBL blDD;
        PhatLuongBL blPL;
        public formThemDiemDanh()
        {
            InitializeComponent();
            blCTHD = new ChiTietHopDongBL();
            blDD = new DiemDanhBL();
            blPL = new PhatLuongBL();
        }

        private void formThemDiemDanh_Load(object sender, EventArgs e)
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
            if (txtMaNV.Text != "" && listNhanVien.ValueMember != null)
            {
                try
                {
                    listNhanVien.SelectedValue = txtMaNV.Text;
                    txtSoNgayVang.Text = blPL.LaySoNgayVang(Int32.Parse(txtMaNV.Text)).ToString();
                    txtSNTC.Text = blDD.LaySoNgayTangCa(Int32.Parse(txtMaNV.Text)).ToString();
                }
                catch
                {

                }
            }
            else
            {
                txtSoNgayVang.Text = "";
                txtSNTC.Text = "";
                listNhanVien.SelectedItem = null;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public bool KiemTra()
        {
            if (txtMaNV.Text == "" || listNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên hoặc nhân viên không tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listLoaiDD.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn loại điểm danh", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLyDo.Text == "")
            {
                MessageBox.Show("Lý do vắng không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                DiemDanh dd = new DiemDanh();
                dd.MaNhanVien = Int32.Parse(txtMaNV.Text);
                if (listLoaiDD.SelectedItem.ToString() == "Vắng")
                {
                    dd.LoaiDiemDanh = 0;
                }
                else
                {
                    dd.LoaiDiemDanh = 1;
                }
                dd.NgayVang = dateNgayVang.Value.ToShortDateString();
                dd.LyDo = txtLyDo.Text;
                blDD.DanhDauVang(dd);
                if (dd.LoaiDiemDanh == 0)
                {
                    blDD.CapNhatSoNgayVang(dd.MaNhanVien);
                }
                else
                {
                    blDD.CapNhatSoNgayTangCa(dd.MaNhanVien);
                }

                MessageBox.Show("Thêm điểm danh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Text = "";
                txtLyDo.Text = "";
            }
        }

        private void listLoaiDD_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listLoaiDD.SelectedItem.ToString() == "Tăng ca")
            {
                txtLyDo.Text = "Tăng ca";
                txtLyDo.Enabled = false;
            }
            else
            {
                txtLyDo.Text = "";
                txtLyDo.Enabled = true;
            }
        }
    }
}
