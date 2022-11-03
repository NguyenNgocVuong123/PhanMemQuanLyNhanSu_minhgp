using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;

namespace QuanLyNhanSu.NhanVien
{
    public partial class formThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBL blNV;
        PhongBan.PhongBanBL blPB;
        ChuyenMon.ChuyenMonBL blCM;
        QueQuan.QueQuanBL blQQ;
        ChucVu.ChucVuBL blCV;
        public formThemNhanVien()
        {
            InitializeComponent();
            blNV = new NhanVienBL();
            blPB = new PhongBan.PhongBanBL();
            blCM = new ChuyenMon.ChuyenMonBL();
            blQQ = new QueQuan.QueQuanBL();
            blCV = new ChucVu.ChucVuBL();
        }

        private void formThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadListPhongBan();
            LoadListChuyenMon();
            LoadListChucVu();
            LoadListQueQuan();
            listTinhTrang.SelectedItem = "Đang làm";
            listChuyenMon.SelectedItem = null;
            listPhongBan.SelectedItem = null;
            listQueQuan.SelectedItem = null;
            listChucVu.SelectedItem = null;
        }

        public void LoadListQueQuan()
        {
            DataTable dt = blQQ.TatCaQueQuan();
            listQueQuan.DataSource = dt;
            listQueQuan.ValueMember = "MaQueQuan";
            listQueQuan.DisplayMember = "TenQueQuan";
        }

        public void LoadListChuyenMon()
        {
            DataTable dt = blCM.TatCaChuyenMon();
            listChuyenMon.DataSource = dt;
            listChuyenMon.ValueMember = "MaChuyenMon";
            listChuyenMon.DisplayMember = "TenChuyenMon";
        }

        public void LoadListPhongBan()
        {
            DataTable dt = blPB.TatCaPhongBan();
            listPhongBan.DataSource = dt;
            listPhongBan.ValueMember = "MaPhongBan";
            listPhongBan.DisplayMember = "TenPhongBan";
        }

        public void LoadListChucVu()
        {
            DataTable dt = blCV.TatCaChucVu();
            listChucVu.DataSource = dt;
            listChucVu.ValueMember = "MaChucVu";
            listChucVu.DisplayMember = "TenChucVu";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        public bool KiemTra()
        {
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (regex.IsMatch(txtEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email không đúng định dạng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Số CMND không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listGioiTinh.SelectedItem == null)
            {
                MessageBox.Show("Giới tính không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listQueQuan.SelectedItem == null)
            {
                MessageBox.Show("Quê quán không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listChuyenMon.SelectedItem == null)
            {
                MessageBox.Show("Chuyên môn không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listPhongBan.SelectedItem == null)
            {
                MessageBox.Show("Phòng ban không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listChucVu.SelectedItem == null)
            {
                MessageBox.Show("Chức vụ không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLuongCB.Text == "")
            {
                MessageBox.Show("Lương cơ bản không được bỏ trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                NhanVien nv = new NhanVien();
                nv.MaPhongBan = listPhongBan.SelectedValue.ToString().Trim();
                nv.MaChucVu = listChucVu.SelectedValue.ToString().Trim();
                nv.MaChuyenMon = listChuyenMon.SelectedValue.ToString().Trim();
                nv.MaQueQuan = listQueQuan.SelectedValue.ToString().Trim();
                nv.HoTen = txtTenNV.Text.Trim();
                if (listGioiTinh.SelectedItem.ToString() == "Nam")
                {
                    nv.GioiTinh = 0;
                }
                else
                {
                    nv.GioiTinh = 1;
                }
                nv.Emai = txtEmail.Text.Trim();
                nv.SDT = txtSDT.Text.Trim();
                nv.CMND = txtCMND.Text.Trim();
                nv.LuongCoBan = Int64.Parse(txtLuongCB.Text.Trim());
                if (listTinhTrang.SelectedItem.ToString() == "Đang làm")
                {
                    nv.TinhTrang = 1;
                }
                else
                {
                    nv.TinhTrang = 0;
                }
                nv.GhiChu = txtGhiChu.Text;
                nv.UrlAnh = "nv.jpg";
                blNV.ThemNhanVien(nv);
                int idnv = blNV.LayIDMoiNhatNV();
                string data = "nv" + idnv + ".jpg";
                blNV.CapNhatUrlAnh(idnv, data);
                if (ptbNhanVien.Image != null)
                {
                    File.Copy(fname, Path.Combine(path, data), true);
                }
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";
                txtLuongCB.Text = "";
                txtGhiChu.Text = "";
                listGioiTinh.SelectedItem = null;
                listQueQuan.SelectedItem = null;
                listChuyenMon.SelectedItem = null;
                listPhongBan.SelectedItem = null;
                listChucVu.SelectedItem = null;
                ptbNhanVien.Image = null;
            }
        }
        public string fname;
        public string path = Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\UrlAnh\";
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (.jpg; .jpeg)|*.jpg;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fname = ofd.FileName;
                FileStream fs = new FileStream(fname, FileMode.Open);
                ptbNhanVien.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {
            if (txtLuongCB.Text != "")
            {
                Int64 luong = Int64.Parse(txtLuongCB.Text);
                lbLuongCB.Text = String.Format("{0:C0}", luong);
            }
            else
            {
                lbLuongCB.Text = "0 đ";
            }
        }

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
