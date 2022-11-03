using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.HopDong
{
    public partial class formThemChiTietHopDong : DevExpress.XtraEditors.XtraForm
    {
        ChiTietHopDongBL blCTHD;
        HopDongBL blHD;
        public formThemChiTietHopDong()
        {
            InitializeComponent();
            blCTHD = new ChiTietHopDongBL();
            blHD = new HopDongBL();
        }

        private void formThemChiTietHopDong_Load(object sender, EventArgs e)
        {
            LoadListNhanVien();
            LoadListHopDong();
            listNhanVien.SelectedItem = null;
            listHopDong.SelectedItem = null;
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
                }
                catch
                {
                    
                }
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

        public void LoadListHopDong()
        {
            DataTable dt = blHD.TatCaHopDong();
            listHopDong.DataSource = dt;
            listHopDong.DisplayMember = "TenHopDong";
            listHopDong.ValueMember = "MaHopDong";
        }

        public bool KiemTra()
        {
            if (txtMaNV.Text == "" || listNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listHopDong.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn hợp đồng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNoiDung.Text == "")
            {
                MessageBox.Show("Bạn chưa đính kèm hợp đồng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blCTHD.KiemTraMaNV(Int32.Parse(txtMaNV.Text.Trim())))
                {
                    ChiTietHopDong cthd = new ChiTietHopDong();
                    cthd.MaNhanVien = Int32.Parse(txtMaNV.Text.Trim());
                    cthd.MaHopDong = listHopDong.SelectedValue.ToString().Trim();
                    cthd.NgayLap = dateNgayLap.Value.ToShortDateString();
                    cthd.NgayHetHan = dateNgayHH.Value.ToShortDateString();
                    cthd.NoiDung = "hdnv" + txtMaNV.Text.Trim() + ".docx";
                    cthd.GhiChu = txtGhiChu.Text;
                    blCTHD.ThemCTHD(cthd);
                    File.Copy(fname, Path.Combine(duongdanhd, "hdnv" + txtMaNV.Text.Trim() + ".docx"), true);
                    MessageBox.Show("Thêm chi tiết hợp đồng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Text = "";
                    listNhanVien.SelectedItem = null;
                    listHopDong.SelectedItem = null;
                    txtNoiDung.Text = "";
                    txtGhiChu.Text = "";
                }
                else
                {
                    MessageBox.Show("Nhân viên này đã có hợp đồng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string duongdanhd = Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\HopDong\";
        public string fname;
        private void btnThemFileDK_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (.docx)|*.docx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fname = ofd.FileName;
                txtNoiDung.Text = "hdnv" + txtMaNV.Text.Trim() + ".docx";
                MessageBox.Show("Thêm file hợp đồng đính kèm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
