using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.PhongBan;
using QuanLyNhanSu.QueQuan;
using QuanLyNhanSu.ChucVu;
using QuanLyNhanSu.ChuyenMon;
using QuanLyNhanSu.NhanVien;
using QuanLyNhanSu.HopDong;
using QuanLyNhanSu.DiemDanh;
using QuanLyNhanSu.PhatLuong;
using QuanLyNhanSu.KhenThuong;
using QuanLyNhanSu.TaiKhoan;
using QuanLyNhanSu.BaoCao;
using System.IO;
using System.Numerics;
using System.Diagnostics;

namespace QuanLyNhanSu
{
    public partial class formMain : DevExpress.XtraEditors.XtraForm
    {
        PhongBanBL blPB;
        QueQuanBL blQQ;
        ChucVuBL blCV;
        ChuyenMonBL blCM;
        NhanVienBL blNV;
        HopDongBL blHD;
        ChiTietHopDongBL blCTHD;
        DiemDanhBL blDD;
        PhatLuongBL blPL;
        KhenThuongBL blKT;
        TaiKhoanBL blTK;
        DataConnection dc;
        public int phanquyen;
        public formMain()
        {
            InitializeComponent();
            blPB = new PhongBanBL();
            blQQ = new QueQuanBL();
            blCV = new ChucVuBL();
            blCM = new ChuyenMonBL();
            blNV = new NhanVienBL();
            blHD = new HopDongBL();
            blCTHD = new ChiTietHopDongBL();
            blDD = new DiemDanhBL();
            blPL = new PhatLuongBL();
            blKT = new KhenThuongBL();
            blTK = new TaiKhoanBL();
            dc = new DataConnection();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1100, 590);
            SttLabel1.Text = "Bạn đang ở cửa sổ Công Cụ. Hãy chọn chức năng bạn muốn sử dụng.";
            if (phanquyen == 1)
            {
                btnPhongBan.Enabled = false;
                btnChucVu.Enabled = false;
                btnChuyenMon.Enabled = false;
                btnPhatLuong.Enabled = false;
                btnKhenThuong.Enabled = false;
                btnHopDong.Enabled = false;
                btnQueQuan.Enabled = false;
                btnCDTK.Enabled = false;
            }
            else if (phanquyen == 2)
            {
                btnDSNV.Enabled = false;
                btnPhongBan.Enabled = false;
                btnChucVu.Enabled = false;
                btnChuyenMon.Enabled = false;
                btnDiemDanh.Enabled = false;
                btnHopDong.Enabled = false;
                btnQueQuan.Enabled = false;
                btnCDTK.Enabled = false;
            }
            else if (phanquyen == 3)
            {
                btnDSNV.Enabled = false;
                btnPhongBan.Enabled = false;
                btnChucVu.Enabled = false;
                btnChuyenMon.Enabled = false;
                btnDiemDanh.Enabled = false;
                btnPhatLuong.Enabled = false;
                btnKhenThuong.Enabled = false;
                btnQueQuan.Enabled = false;
                btnCDTK.Enabled = false;
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        #region CacNutCongCu
        private void btnDSNV_Click(object sender, EventArgs e)
        {
            tabDSNV.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 1;
            SttLabel1.Text = "Bạn đang ở cửa sổ Nhân Viên. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm, Đổi ảnh nhân viên.";
        }
        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            tabPhongBan.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 2;
            SttLabel1.Text = "Bạn đang ở cửa sổ Phòng Ban. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
        }
        private void btnCloseDSNV_Click(object sender, EventArgs e)
        {
            tabDSNV.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Nhân Viên.";
        }
        private void btnClosePhongBan_Click(object sender, EventArgs e)
        {
            tabPhongBan.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Phòng Ban.";
        }
        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            tabDiemDanh.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 5;
            SttLabel1.Text = "Bạn đang ở cửa sổ Điểm Danh. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
        }
        private void btnPhatLuong_Click(object sender, EventArgs e)
        {
            tabPhatLuong.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 6;
            SttLabel1.Text = "Bạn đang ở cửa sổ Phát Lương. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
        }
        private void btnKhenThuong_Click(object sender, EventArgs e)
        {
            tabKhenThuong.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 7;
            SttLabel1.Text = "Bạn đang ở cửa sổ Khen Thưởng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
        }
        private void btnCloseKT_Click(object sender, EventArgs e)
        {
            tabKhenThuong.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Khen Thưởng";
        }
        private void btnCloseDiemDanh_Click(object sender, EventArgs e)
        {
            tabDiemDanh.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Điểm Danh";
        }
        private void btnClosePhatLuong_Click(object sender, EventArgs e)
        {
            tabPhatLuong.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Phát Lương.";
        }
        private void btnChucVu_Click(object sender, EventArgs e)
        {
            tabChucVu.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 3;
            SttLabel1.Text = "Bạn đang ở cửa sổ Chức Vụ. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
        }
        private void btnChuyenMon_Click(object sender, EventArgs e)
        {
            tabChuyenMon.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 4;
            SttLabel1.Text = "Bạn đang ở cửa sổ Chuyên Môn. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
        }
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            tabHopDong.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 8;
            SttLabel1.Text = "Bạn đang ở cửa sổ Hợp Đồng và Chi Tiết Hợp Đồng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm, Mở file hợp đồng, Đổi file đính kèm hợp đồng.";
        }
        private void btnQueQuan_Click(object sender, EventArgs e)
        {
            tabQueQuan.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 9;
            SttLabel1.Text = "Bạn đang ở cửa sổ Quê Quán. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
        }
        private void btnCDTK_Click(object sender, EventArgs e)
        {
            tabCDTK.PageVisible = true;
            tabControl1.SelectedTabPageIndex = 10;
            SttLabel1.Text = "Bạn đang ở cửa sổ Tài Khoản. Có các chức năng quản lý: Đổi mật khẩu, Đổi email, Đổi phân quyền, Thêm tài khoản, Xóa tài khoản";
        }
        private void btnCloseChucVu_Click(object sender, EventArgs e)
        {
            tabChucVu.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Chức Vụ.";
        }
        private void btnCloseChuyenMon_Click(object sender, EventArgs e)
        {
            tabChuyenMon.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Chuyên Môn.";
        }
        private void btnCloseHopDong_Click(object sender, EventArgs e)
        {
            tabHopDong.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Hợp Đồng";
        }
        private void btnCloseQueQuan_Click(object sender, EventArgs e)
        {
            tabQueQuan.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Quê Quán.";
        }
        private void btnCloseCDTK_Click(object sender, EventArgs e)
        {
            tabCDTK.PageVisible = false;
            SttLabel1.Text = "Bạn vừa đóng cửa sổ Tài Khoản.";
        }
        private void btnTTPM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đồ án cơ sở 1: Phần mềm quản lý nhân sự" + Environment.NewLine + "- Phiên bản: 1.3" + Environment.NewLine + "- Thời hạn sử dụng: vĩnh viễn" + Environment.NewLine + "- Tác giả: Phạm Gia Minh, Trần Văn Quyền" + Environment.NewLine + "- Nhật ký cập nhật" + Environment.NewLine + "1.3: Xóa mục hướng dẫn thay bằng mục báo cáo, thêm một số icon vào các nút chức năng, phân quyền tài khoản" + Environment.NewLine + "1.2: Bổ sung gửi mail về nhân viên sau khi phát lương, điều chỉnh chức năng xóa thông tin tạm ứng" + Environment.NewLine + "1.1: Điều chỉnh cơ cấu phát lương, thêm chức năng cấu hình phát lương, thêm chức năng tạm ứng lương, thêm tìm kiếm theo nhân viên" + Environment.NewLine + "1.0: Bản chính thức đầu tiên", "Thông tin phần mềm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tabControl1.SelectedTabPageIndex == 0)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Công Cụ. Hãy chọn chức năng bạn muốn sử dụng.";
            }
            if (tabControl1.SelectedTabPageIndex == 1)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Nhân Viên. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm, Đổi ảnh nhân viên.";
            }
            if (tabControl1.SelectedTabPageIndex == 2)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Phòng Ban. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            if (tabControl1.SelectedTabPageIndex == 3)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Chức Vụ. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            if (tabControl1.SelectedTabPageIndex == 4)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Chuyên Môn. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            if (tabControl1.SelectedTabPageIndex == 5)
            {
                SttLabel1.Text="Bạn đang ở cửa sổ Điểm Danh. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            if (tabControl1.SelectedTabPageIndex == 6)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Phát Lương. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            if (tabControl1.SelectedTabPageIndex == 7)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Khen Thưởng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            if (tabControl1.SelectedTabPageIndex == 8)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Hợp Đồng và Chi Tiết Hợp Đồng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm, Mở file hợp đồng, Đổi file đính kèm hợp đồng.";
            }
            if (tabControl1.SelectedTabPageIndex == 9)
            {
                SttLabel1.Text = "Bạn đang ở cửa sổ Quê Quán. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            } if (tabControl1.SelectedTabPageIndex == 10)
            {
                
            }
        }
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            formXemBaoCao fXBC = new formXemBaoCao();
            fXBC.ShowDialog();
        }
        #endregion

        #region PhongBan
        public void TatCaPhongBan()
        {
            DataTable dt = blPB.TatCaPhongBan();
            dgvPhongBan.DataSource = dt;
        }

        private void tabPhongBan_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPhongBan.PageVisible == true)
            {
                TatCaPhongBan();
                if (dgvPhongBan.Rows.Count > 0)
                {
                    dgvPhongBan.CurrentRow.Selected = true;
                    HienThiThongTinPhongBan();
                }
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPhongBan.CurrentRow.Selected = true;
            HienThiThongTinPhongBan();
        }

        public void HienThiThongTinPhongBan()
        {
            if (dgvPhongBan.Rows.Count > 0)
            {
                dgvPhongBan.CurrentRow.Selected = true;
                txtMaPB.Text = dgvPhongBan.CurrentRow.Cells["MaPhongBan"].Value.ToString().Trim();
                txtTenPB.Text = dgvPhongBan.CurrentRow.Cells["TenPhongBan"].Value.ToString();
                txtGhiChuPB.Text = dgvPhongBan.CurrentRow.Cells["GhiChu"].Value.ToString();
                SttLabel1.Text = "Bạn đang xem thông tin phòng ban: " + txtMaPB.Text + " - " + txtTenPB.Text + ".";
                btnCapNhatPB.Enabled = true;
                btnXoaPB.Enabled = true;
            }
            else
            {
                txtMaPB.Text = "";
                txtTenPB.Text = "";
                txtGhiChuPB.Text = "";
            }
        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            formThemPhongBan fTPB = new formThemPhongBan();
            var result = fTPB.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                TatCaPhongBan();
                HienThiThongTinPhongBan();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa phòng ban này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PhongBan.PhongBan pb = new PhongBan.PhongBan();
                    pb.MaPhongBan = txtMaPB.Text.Trim();
                    pb.TenPhongBan = txtTenPB.Text.Trim();
                    blPB.XoaPhongBan(pb);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaPhongBan();
                    HienThiThongTinPhongBan();
                    SttLabel1.Text = "Bạn vừa xóa phòng ban: " + pb.MaPhongBan + " - " + pb.TenPhongBan + ".";
                }
            }
            catch
            {
                MessageBox.Show("Đã có nhân viên trong phòng ban này, không thể xóa", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public bool KiemTraTextPB()
        {
            if (txtTenPB.Text == "")
            {
                MessageBox.Show("Tên phòng ban không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCapNhatPB_Click(object sender, EventArgs e)
        {

            if (KiemTraTextPB())
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin phòng ban này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PhongBan.PhongBan pb = new PhongBan.PhongBan();
                    pb.MaPhongBan = txtMaPB.Text.Trim();
                    pb.TenPhongBan = txtTenPB.Text.Trim();
                    pb.GhiChu = txtGhiChuPB.Text;
                    blPB.CapNhatPhongBan(pb);
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaPhongBan();
                    HienThiThongTinPhongBan();
                    SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                }
            }
         
        }

        private void txtSearchPB_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPB.Text == "")
            {
                TatCaPhongBan();
                HienThiThongTinPhongBan();
                SttLabel1.Text = "Bạn đang ở cửa sổ Phòng Ban. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            else
            {
                DataTable dt = blPB.SearchPhongBan(txtSearchPB.Text.Trim());
                dgvPhongBan.DataSource = dt;
                HienThiThongTinPhongBan();
                SttLabel1.Text = "Tìm thấy " + dgvPhongBan.Rows.Count.ToString() + " kết quả.";
            }
        }
        private void txtMaPB_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPB.Text == "")
            {
                btnCapNhatPB.Enabled = false;
                btnXoaPB.Enabled = false;
            }
            else
            {
                btnCapNhatPB.Enabled = true;
                btnXoaPB.Enabled = true;
            }
        }
        #endregion

        #region QueQuan
        public void TatCaQueQuan()
        {
            DataTable dt = blQQ.TatCaQueQuan();
            dgvQueQuan.DataSource = dt;
        }
        public void HienThiThongTinQueQuan()
        {
            if (dgvQueQuan.Rows.Count > 0)
            {
                dgvQueQuan.CurrentRow.Selected = true;
                txtMaQQ.Text = dgvQueQuan.CurrentRow.Cells["MaQueQuan"].Value.ToString().Trim();
                txtTenQQ.Text = dgvQueQuan.CurrentRow.Cells["TenQueQuan"].Value.ToString();
                btnCapNhatQQ.Enabled = true;
                btnXoaQQ.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin quê quán: " + txtMaQQ.Text + " - " + txtTenQQ.Text + ".";
            }
            else
            {
                txtMaQQ.Text = "";
                txtTenQQ.Text = "";
            }
        }
        private void tabQueQuan_VisibleChanged(object sender, EventArgs e)
        {
            if (tabQueQuan.PageVisible == true)
            {
                TatCaQueQuan();
                if (dgvQueQuan.Rows.Count > 0)
                {
                    dgvQueQuan.CurrentRow.Selected = true;
                    HienThiThongTinQueQuan();
                }
            }
        }
        public bool KiemTraTextQQ()
        {
            if (txtTenQQ.Text == "")
            {
                MessageBox.Show("Tên quê quán không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnCapNhatQQ_Click(object sender, EventArgs e)
        {

            if (KiemTraTextQQ())
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin quê quán này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QueQuan.QueQuan qq = new QueQuan.QueQuan();
                    qq.MaQueQuan = txtMaQQ.Text.Trim();
                    qq.TenQueQuan = txtTenQQ.Text.Trim();
                    blQQ.CapNhatQueQuan(qq);
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaQueQuan();
                    HienThiThongTinQueQuan();
                    SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                }
            }
            
        }
        private void btnXoaQQ_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bạn thực sự muốn xóa quê quán này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QueQuan.QueQuan qq = new QueQuan.QueQuan();
                    qq.MaQueQuan = txtMaQQ.Text.Trim();
                    qq.TenQueQuan = txtTenQQ.Text.Trim();
                    blQQ.XoaQueQuan(qq);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaQueQuan();
                    HienThiThongTinQueQuan();
                    SttLabel1.Text = "Bạn vừa xóa quê quán: " + qq.MaQueQuan + " - " + qq.TenQueQuan + ".";
                }
                
            }
            catch
            {
                MessageBox.Show("Có dữ liệu liên quan đến quê quán này, không thể xóa", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemQQ_Click(object sender, EventArgs e)
        {
            formThemQQ fTQQ = new formThemQQ();
            var result = fTQQ.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                TatCaQueQuan();
                HienThiThongTinQueQuan();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }
        private void dgvQueQuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvQueQuan.CurrentRow.Selected = true;
            HienThiThongTinQueQuan();
        }
        private void txtSearchQQ_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchQQ.Text == "")
            {
                TatCaQueQuan();
                HienThiThongTinQueQuan();
                SttLabel1.Text = "Bạn đang ở cửa sổ Quê Quán. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            else
            {
                DataTable dt = blQQ.SearchQueQuan(txtSearchQQ.Text.Trim());
                dgvQueQuan.DataSource = dt;
                HienThiThongTinQueQuan();
                SttLabel1.Text = "Tìm thấy " + dgvQueQuan.Rows.Count.ToString() + " kết quả.";
            }
        }
        private void txtMaQQ_TextChanged(object sender, EventArgs e)
        {
            if (txtMaQQ.Text == "")
            {
                btnCapNhatQQ.Enabled = false;
                btnXoaQQ.Enabled = false;
            }
            else
            {
                btnCapNhatQQ.Enabled = true;
                btnXoaQQ.Enabled = true;
            }
        }
        #endregion

        #region ChucVu
        public void TatCaChucVu()
        {
            DataTable dt = blCV.TatCaChucVu();
            dgvChucVu.DataSource = dt;
        }

        public void HienThiThongTinChucVu()
        {
            if (dgvChucVu.Rows.Count > 0)
            {
                dgvChucVu.CurrentRow.Selected = true;
                txtMaCV.Text = dgvChucVu.CurrentRow.Cells["MaChucVu"].Value.ToString().Trim();
                txtTenCV.Text = dgvChucVu.CurrentRow.Cells["TenChucVu"].Value.ToString().Trim();
                txtPhuCapCV.Text = dgvChucVu.CurrentRow.Cells["PhuCapCV"].Value.ToString().Trim();
                BigInteger pccv = BigInteger.Parse(txtPhuCapCV.Text);
                string pc = String.Format("{0:C0}", pccv);
                lbPhuCapCV.Text = pc;
                btnCapNhatCV.Enabled = true;
                btnXoaCV.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin chức vụ: " + txtMaCV.Text + " - " + txtTenCV.Text + ".";
            }
            else
            {
                txtMaCV.Text = "";
                txtTenCV.Text = "";
                txtPhuCapCV.Text = "";
            }
        }

        private void tabChucVu_VisibleChanged(object sender, EventArgs e)
        {
            if (tabChucVu.PageVisible == true)
            {
                TatCaChucVu();
                if (dgvChucVu.Rows.Count > 0)
                {
                    dgvChucVu.CurrentRow.Selected = true;
                    HienThiThongTinChucVu();
                }
            }
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvChucVu.CurrentRow.Selected = true;
            HienThiThongTinChucVu();
        }

        private void txtPhuCapCV_TextChanged(object sender, EventArgs e)
        {
            if (txtPhuCapCV.Text != "")
            {
                BigInteger pccv = BigInteger.Parse(txtPhuCapCV.Text);
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

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa chức vụ này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ChucVu.ChucVu cv = new ChucVu.ChucVu();
                    cv.MaChucVu = txtMaCV.Text.Trim();
                    cv.TenChucVu = txtTenCV.Text.Trim();
                    blCV.XoaChucVu(cv);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaChucVu();
                    HienThiThongTinChucVu();
                    SttLabel1.Text = "Bạn vừa xóa chức vụ: " + cv.MaChucVu + " - " + cv.TenChucVu + ".";
                }
                
            }
            catch
            {
                MessageBox.Show("Có dữ liệu liên quan đến chức vụ này, không thể xóa", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool KiemTraTextCV()
        {
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Tên chức vụ không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPhuCapCV.Text == "")
            {
                MessageBox.Show("Phụ cấp chức vụ không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCapNhatCV_Click(object sender, EventArgs e)
        {

            if (KiemTraTextCV())
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin chức vụ này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChucVu.ChucVu cv = new ChucVu.ChucVu();
                    cv.MaChucVu = txtMaCV.Text.Trim();
                    cv.TenChucVu = txtTenCV.Text.Trim();
                    cv.PhuCap = Int64.Parse(txtPhuCapCV.Text.Trim());
                    blCV.CapNhatChucVu(cv);
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaChucVu();
                    HienThiThongTinChucVu();
                    SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                }
            }
            
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            formThemChucVu fTCV = new formThemChucVu();
            var result = fTCV.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                TatCaChucVu();
                HienThiThongTinChucVu();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }

        private void txtSearchCV_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCV.Text == "")
            {
                TatCaChucVu();
                HienThiThongTinChucVu();
                SttLabel1.Text = "Bạn đang ở cửa sổ Chức Vụ. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            else
            {
                DataTable dt = blCV.SearchCV(txtSearchCV.Text.Trim());
                dgvChucVu.DataSource = dt;
                HienThiThongTinChucVu();
                SttLabel1.Text = "Tìm thấy " + dgvChucVu.Rows.Count.ToString() + " kết quả.";
            }
        }
        private void txtMaCV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "")
            {
                btnCapNhatCV.Enabled = false;
                btnXoaCV.Enabled = false;
            }
            else
            {
                btnCapNhatCV.Enabled = true;
                btnXoaCV.Enabled = true;
            }
        }
        #endregion

        #region ChuyenMon
        public void TatCaChuyenMon()
        {
            DataTable dt = blCM.TatCaChuyenMon();
            dgvChuyenMon.DataSource = dt;
        }

        public void HienThiThongTinChuyenMon()
        {
            if (dgvChuyenMon.Rows.Count > 0)
            {
                dgvChuyenMon.CurrentRow.Selected = true;
                txtMaCM.Text = dgvChuyenMon.CurrentRow.Cells["MaChuyenMon"].Value.ToString().Trim();
                txtTenCM.Text = dgvChuyenMon.CurrentRow.Cells["TenChuyenMon"].Value.ToString().Trim();
                SttLabel1.Text = "Bạn đang xem thông tin chuyên môn: " + txtMaCM.Text + " - " + txtTenCM.Text + ".";
                btnCapNhatCM.Enabled = true;
                btnXoaCM.Enabled = true;
            }
            else
            {
                txtMaCM.Text = "";
                txtTenCM.Text = "";
            }
        }

        private void tabChuyenMon_VisibleChanged(object sender, EventArgs e)
        {
            if (tabChuyenMon.PageVisible == true)
            {
                TatCaChuyenMon();
                if (dgvChuyenMon.Rows.Count > 0)
                {
                    dgvChuyenMon.CurrentRow.Selected = true;
                    HienThiThongTinChuyenMon();
                }
            }
        }

        private void dgvChuyenMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvChuyenMon.CurrentRow.Selected = true;
            HienThiThongTinChuyenMon();
        }

        public bool KiemTraTextCM()
        {
            if (txtTenCM.Text == "")
            {
                MessageBox.Show("Tên chuyên môn không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCapNhatCM_Click(object sender, EventArgs e)
        {

            if (KiemTraTextCM())
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin chuyên môn này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChuyenMon.ChuyenMon cm = new ChuyenMon.ChuyenMon();
                    cm.MaChuyenMon = txtMaCM.Text.Trim();
                    cm.TenChuyenMon = txtTenCM.Text.Trim();
                    blCM.CapNhatChuyenMon(cm);
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaChuyenMon();
                    HienThiThongTinChuyenMon();
                    SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                }
            }
            
        }

        private void btnXoaCM_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa chuyên môn này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChuyenMon.ChuyenMon cm = new ChuyenMon.ChuyenMon();
                    cm.MaChuyenMon = txtMaCM.Text.Trim();
                    cm.TenChuyenMon = txtTenCM.Text.Trim();
                    blCM.XoaChuyenMon(cm);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaChuyenMon();
                    HienThiThongTinChuyenMon();
                    SttLabel1.Text = "Bạn vừa xóa chức vụ: " + cm.MaChuyenMon + " - " + cm.TenChuyenMon + ".";
                }
                
            }
            catch
            {
                MessageBox.Show("Có dữ liệu liên quan đến chuyên môn này, không thể xóa", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemCM_Click(object sender, EventArgs e)
        {
            formThemChuyenMon fTCM = new formThemChuyenMon();
            var result = fTCM.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                TatCaChuyenMon();
                HienThiThongTinChuyenMon();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }

        private void txtSearchCM_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCM.Text == "")
            {
                TatCaChuyenMon();
                HienThiThongTinChuyenMon();
                SttLabel1.Text = "Bạn đang ở cửa sổ Chuyên Môn. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
            else
            {
                DataTable dt = blCM.SearchChuyenMon(txtSearchCM.Text.Trim());
                dgvChuyenMon.DataSource = dt;
                HienThiThongTinChuyenMon();
                SttLabel1.Text = "Tìm thấy " + dgvChuyenMon.Rows.Count.ToString() + " kết quả.";
            }
        }
        private void txtMaCM_TextChanged(object sender, EventArgs e)
        {
            if (txtMaCM.Text == "")
            {
                btnCapNhatCM.Enabled = false;
                btnXoaCM.Enabled = false;
            }
            else
            {
                btnCapNhatCM.Enabled = true;
                btnXoaCM.Enabled = true;
            }
        }
        #endregion

        #region NhanVien
        public void TatCaNhanVien()
        {
            DataTable dt = blNV.TatCaNhanVien();
            dgvNhanVien.DataSource = dt;
        }
        public string path = Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\UrlAnh\";
        public void HienThiThongTinNhanVien()
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString().Trim();
                DataTable dt = blNV.LayThongTinNhanVien(Int32.Parse(txtMaNV.Text));
                txtTenNV.Text = dt.Rows[0]["HoTen"].ToString().Trim();
                txtEmail.Text = dt.Rows[0]["Email"].ToString().Trim();
                txtSDT.Text = dt.Rows[0]["SDT"].ToString().Trim();
                txtCMND.Text = dt.Rows[0]["CMND"].ToString().Trim();
                listQueQuan.SelectedValue = dt.Rows[0]["MaQueQuan"].ToString().Trim();
                listChuyenMon.SelectedValue = dt.Rows[0]["MaChuyenMon"].ToString().Trim();
                listPhongBan.SelectedValue = dt.Rows[0]["MaPhongBan"].ToString().Trim();
                listChucVu.SelectedValue = dt.Rows[0]["MaChucVu"].ToString().Trim();
                txtLuongCB.Text = dt.Rows[0]["LuongCoBan"].ToString();
                txtSNV.Text = dt.Rows[0]["SoNgayVang"].ToString();
                txtSNTC.Text = dt.Rows[0]["SoNgayTangCa"].ToString();
                if (Int32.Parse(dt.Rows[0]["GioiTinh"].ToString()) == 0)
                {
                    listGioiTinh.SelectedItem = "Nam";
                }
                else
                {
                    listGioiTinh.SelectedItem = "Nữ";
                }
                if (Int32.Parse(dt.Rows[0]["TinhTrang"].ToString()) == 1)
                {
                    listTinhTrang.SelectedItem = "Đang làm";
                }
                else
                {
                    listTinhTrang.SelectedItem = "Đã nghỉ";
                }
                string url = dt.Rows[0]["UrlAnh"].ToString().Trim();
                try
                {
                    FileStream fs = new FileStream(path + url, FileMode.Open);
                    ptbNhanVien.Image = Image.FromStream(fs);
                    fs.Close();
                }
                catch
                {
                    ptbNhanVien.Image = null;
                    ptbNhanVien.BackColor = Color.Black;
                }
                btnDoiAnhNV.Enabled = true;
                btnCapNhatNV.Enabled = true;
                btnXoaNV.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin nhân viên: " + txtMaNV.Text + " - " + txtTenNV.Text + "."; ;
            }
            else
            {
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";
                listGioiTinh.SelectedItem = null;
                listQueQuan.SelectedItem = null;
                listChuyenMon.SelectedItem = null;
                listPhongBan.SelectedItem = null;
                listChucVu.SelectedItem = null;
                listTinhTrang.SelectedItem = null;
                txtSNV.Text = "";
                txtSNTC.Text = "";
                txtLuongCB.Text = "";
                txtGhiChu.Text = "";
                ptbNhanVien.Image = null;
            }
        }

        private void tabDSNV_VisibleChanged(object sender, EventArgs e)
        {
            if (tabDSNV.PageVisible == true)
            {
                TatCaNhanVien();
                LoadListQueQuan();
                LoadListChuyenMon();
                LoadListPhongBan();
                LoadListChucVu();
                if (dgvNhanVien.Rows.Count > 0)
                {
                    dgvNhanVien.CurrentRow.Selected = true;
                    HienThiThongTinNhanVien();
                }
            }
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name.Equals("GioiTinh"))
            {
                string vl = e.Value.ToString();
                if (vl == null)
                {
                    return;
                }
                switch (vl)
                {
                    case "0":
                        e.Value = "Nam";
                        break;
                    case "1":
                        e.Value = "Nữ";
                        break;
                }
            }

            if (dgvNhanVien.Columns[e.ColumnIndex].Name.Equals("TinhTrang"))
            {
                string vl = e.Value.ToString();
                if (vl == null)
                {
                    return;
                }
                switch (vl)
                {
                    case "0":
                        e.Value = "Đã nghỉ";
                        break;
                    case "1":
                        e.Value = "Đang làm";                
                        break;
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhanVien.CurrentRow.Selected = true;
            HienThiThongTinNhanVien();
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

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {
            if (txtLuongCB.Text != "")
            {
                Int64 luong = Int64.Parse(txtLuongCB.Text);
                lbLuongCB.Text = String.Format("{0:C0}", luong);
            }
            else
            {
                lbLuongCB.Text = "0";
            }
        }

        private void btnDoiAnhNV_Click(object sender, EventArgs e)
        {
            string fname;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (.jpg; .jpeg)|*.jpg;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fname = ofd.FileName;
                File.Copy(fname, Path.Combine(path, "nv" + txtMaNV.Text.Trim() + ".jpg"), true);
                MessageBox.Show("Đổi ảnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SttLabel1.Text = "Bạn vừa cập nhật hình ảnh cho nhân viên có mã là " + txtMaNV.Text + ".";
                FileStream fs = new FileStream(path + "nv" + txtMaNV.Text.Trim() + ".jpg", FileMode.Open);
                ptbNhanVien.Image = Image.FromStream(fs);
                fs.Close();
            }
            
        }
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        public bool KiemTraTextNV()
        {
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtEmail.Text == "")
            {
                MessageBox.Show("Email không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (regex.IsMatch(txtEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email không đúng định dạng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtSDT.Text== "" )
            {
                MessageBox.Show("Số điện thoại không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtCMND.Text == "" )
            {
                MessageBox.Show("Số CMND không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtLuongCB.Text == "")
            {
                MessageBox.Show("Lương cơ bản không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {

            if (KiemTraTextNV())
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin nhân viên này này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = dgvNhanVien.SelectedRows[0].Index;
                    NhanVien.NhanVien nv = new NhanVien.NhanVien();
                    nv.MaNhanVien = Int32.Parse(txtMaNV.Text);
                    nv.MaPhongBan = listPhongBan.SelectedValue.ToString();
                    nv.MaChucVu = listChucVu.SelectedValue.ToString();
                    nv.MaChuyenMon = listChuyenMon.SelectedValue.ToString();
                    nv.MaQueQuan = listQueQuan.SelectedValue.ToString();
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
                    nv.GhiChu = txtGhiChu.Text.Trim();
                    blNV.CapNhatNhanVien(nv);
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaNhanVien();
                    HienThiThongTinNhanVien();
                    SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                }
            }
            
        }

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bạn thực sự muốn xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NhanVien.NhanVien nv = new NhanVien.NhanVien();
                    nv.MaNhanVien = Int32.Parse(txtMaNV.Text.Trim());
                    nv.HoTen = txtTenNV.Text.Trim();
                    blNV.XoaNhanVien(nv);
                    File.Delete(path + "nv" + txtMaNV.Text.Trim() + ".jpg");
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaNhanVien();
                    HienThiThongTinNhanVien();
                    SttLabel1.Text = "Bạn vừa xóa chức vụ: " + nv.MaNhanVien + " - " + nv.HoTen + ".";
                }
                
                
            }
            catch
            {
                MessageBox.Show("Có dữ liệu liên quan đến nhân viên này, không thể xóa", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            formThemNhanVien fTNV = new formThemNhanVien();
            var result = fTNV.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                TatCaNhanVien();
                HienThiThongTinNhanVien();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }

        private void txtSearchNV_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchNV.Text == "")
            {
                TatCaNhanVien();
                HienThiThongTinNhanVien();
                SttLabel1.Text = "Bạn đang ở cửa sổ Danh Sách Nhân Viên. Có các chức năng quản lý: Đổi ảnh, Thêm, Sửa, Xóa, Tìm kiếm";
            }
            else
            {
                DataTable dt = blNV.SearchNV(txtSearchNV.Text.Trim());
                dgvNhanVien.DataSource = dt;
                HienThiThongTinNhanVien();
                SttLabel1.Text = "Tìm thấy " + dgvNhanVien.Rows.Count.ToString() + " kết quả.";
            }
        }

        private void txtTimMNVNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMNVNV.Text != "")
            {
                DataTable dt = blNV.TimMNVNV(Int32.Parse(txtTimMNVNV.Text.Trim()));
                dgvNhanVien.DataSource = dt;
                HienThiThongTinNhanVien();
                SttLabel1.Text = "Tìm thấy " + dgvNhanVien.Rows.Count.ToString() + " kết quả.";
            }
            else
            {
                TatCaNhanVien();
                HienThiThongTinNhanVien();
                SttLabel1.Text = "Bạn đang ở cửa sổ Danh Sách Nhân Viên. Có các chức năng quản lý: Đổi ảnh, Thêm, Sửa, Xóa, Tìm kiếm";
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                btnDoiAnhNV.Enabled = false;
                btnCapNhatNV.Enabled = false;
                btnXoaNV.Enabled = false;
            }
            else
            {
                btnDoiAnhNV.Enabled = true;
                btnCapNhatNV.Enabled = true;
                btnXoaNV.Enabled = true;
            }
        }
        private void txtTimMNVNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region HopDong&CTHD
        public void TatCaHopDong()
        {
            DataTable dt = blHD.TatCaHopDong();
            dgvHopDong.DataSource = dt;
        }
        public void HienThiThongTinHopDong()
        {
            if (dgvHopDong.Rows.Count > 0)
            {
                dgvHopDong.CurrentRow.Selected = true;
                txtIDHD.Text = dgvHopDong.CurrentRow.Cells["MaHopDong"].Value.ToString().Trim();
                txtTenHD.Text = dgvHopDong.CurrentRow.Cells["TenHopDong"].Value.ToString().Trim();
                txtGhiChuHD.Text = dgvHopDong.CurrentRow.Cells["GhiChuHD"].Value.ToString().Trim();
                btnCapNhatHD.Enabled = true;
                btnXoaHD.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin hợp đồng: " + txtIDHD.Text + " - " + txtTenHD.Text + ".";
            }
            else
            {
                txtIDHD.Text = "";
                txtTenHD.Text = "";
                txtGhiChuHD.Text = "";
            }
        }
        public void TatCaChiTietHopDong()
        {
            DataTable dt = blCTHD.TatCaChiTietHopDong();
            dgvChiTietHD.DataSource = dt;
        }
        public void HienThiThongTinChiTietHopDong()
        {
            if (dgvChiTietHD.Rows.Count > 0)
            {
                dgvChiTietHD.CurrentRow.Selected = true;
                txtSTTCTHD.Text = dgvChiTietHD.CurrentRow.Cells["STT"].Value.ToString();
                txtTenNVCTHD.Text = dgvChiTietHD.CurrentRow.Cells["TenNhanVien"].Value.ToString();
                DataTable dt = blCTHD.LayThongTin(Int32.Parse(txtSTTCTHD.Text));
                listHopDong.SelectedValue = dt.Rows[0]["MaHopDong"].ToString();
                dateNgayLap.Value = DateTime.Parse(dgvChiTietHD.CurrentRow.Cells["NgayLap"].Value.ToString());
                dateNgayHH.Value = DateTime.Parse(dgvChiTietHD.CurrentRow.Cells["NgayHetHan"].Value.ToString());
                txtNoiDung.Text = dt.Rows[0]["NoiDung"].ToString();
                txtGhiChuCTHD.Text = dt.Rows[0]["GhiChu"].ToString();
                btnCapNhatCTHD.Enabled = true;
                btnXoaCTHD.Enabled = true;
                btnMoFile.Enabled = true;
                btnDoiFileDK.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin chi tiết hợp đồng: " + txtSTTCTHD.Text + " - " + txtTenNVCTHD.Text + " - " + dateNgayLap.Text + " - " + dateNgayHH.Text + ".";
            }
            else
            {
                txtSTTCTHD.Text = "";
                txtTenNVCTHD.Text = "";
                listHopDong.SelectedItem = null;
                txtNoiDung.Text = "";
                txtGhiChuCTHD.Text = "";
                dateNgayLap.Text = "";
                dateNgayHH.Text = "";
            }
        }
        public void LoadListHopDong()
        {
            DataTable dt = blHD.TatCaHopDong();
            listHopDong.DataSource = dt;
            listHopDong.DisplayMember = "TenHopDong";
            listHopDong.ValueMember = "MaHopDong";
        }
        private void tabHopDong_VisibleChanged(object sender, EventArgs e)
        {
            if (tabHopDong.PageVisible == true)
            {
                LoadListHopDong();
                TatCaHopDong();
                TatCaChiTietHopDong();
                if (dgvHopDong.Rows.Count > 0)
                {
                    dgvHopDong.CurrentRow.Selected = true;
                    HienThiThongTinHopDong();
                    HienThiThongTinChiTietHopDong();
                }
            }
        }
        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHopDong.CurrentRow.Selected = true;
            HienThiThongTinHopDong();
        }
        public bool KiemTraTextHD()
        {
            if (txtTenHD.Text == "")
            {
                MessageBox.Show("Tên hợp đồng không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {

            if (KiemTraTextHD())
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin hợp đồng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    HopDong.HopDong hd = new HopDong.HopDong();
                    hd.MaHopDong = txtIDHD.Text.Trim();
                    hd.TenHopDong = txtTenHD.Text.Trim();
                    hd.GhiChu = txtGhiChuHD.Text.Trim();
                    blHD.CapNhatHopDong(hd);
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaHopDong();
                    HienThiThongTinHopDong();
                    LoadListHopDong();
                    TatCaChiTietHopDong();
                    HienThiThongTinChiTietHopDong();
                    SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                }
            }
           
        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn thực sự muốn xóa hợp đồng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    HopDong.HopDong hd = new HopDong.HopDong();
                    hd.MaHopDong = txtIDHD.Text.Trim();
                    hd.TenHopDong = txtTenHD.Text.Trim();
                    blHD.XoaHopDong(hd);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TatCaHopDong();
                    HienThiThongTinHopDong();
                    LoadListHopDong();
                    TatCaChiTietHopDong();
                    HienThiThongTinChiTietHopDong();
                    SttLabel1.Text = "Bạn vừa xóa hợp đồng: " + hd.MaHopDong + " - " + hd.TenHopDong + ".";
                }
            }
            catch
            {
                MessageBox.Show("Có dữ liệu liên quan đến hợp đồng này, không thể xóa", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCapNhatCTHD_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin chi tiết hợp đồng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ChiTietHopDong cthd = new ChiTietHopDong();
                cthd.STT = Int32.Parse(txtSTTCTHD.Text);
                cthd.MaHopDong = listHopDong.SelectedValue.ToString();
                cthd.NgayLap = dateNgayLap.Value.ToShortDateString();
                cthd.NgayHetHan = dateNgayHH.Value.ToShortDateString();
                cthd.GhiChu = txtGhiChuCTHD.Text;
                blCTHD.CapNhatChiTietHopDong(cthd);
                MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TatCaChiTietHopDong();
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
            
        }
        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn thực sự muốn xóa chi tiết hợp đồng này này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ChiTietHopDong cthd = new ChiTietHopDong();
                cthd.STT = Int32.Parse(txtSTTCTHD.Text);
                blCTHD.XoaChiTietHopDong(cthd);
                string tennv = txtTenNVCTHD.Text.Trim();
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TatCaChiTietHopDong();
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Bạn vừa xóa chi tiết hợp đồng: " + cthd.STT + " - " + tennv + ".";
            }
            
        }
        public string duongdanhd = Path.GetDirectoryName(Application.ExecutablePath).ToString() + @"\HopDong\";
        private void btnMoFile_Click(object sender, EventArgs e)
        {

            try
            {
                Process.Start(duongdanhd + txtNoiDung.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Tệp tin đính kèm không được tìm thấy, hãy cập nhật file hợp đồng đính kèm", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnDoiFileDK_Click(object sender, EventArgs e)
        {
            string fname;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (.docx)|*.docx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fname = ofd.FileName;
                int manv = blCTHD.LayMaNhanVien(Int32.Parse(txtSTTCTHD.Text));
                File.Copy(fname, Path.Combine(duongdanhd, "hdnv" + manv + ".docx"), true);
                MessageBox.Show("Cập nhật file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SttLabel1.Text = "Bạn vừa cập nhật file hợp đồng đính kèm cho nhân viên " + txtTenNVCTHD.Text + ".";
            }
            
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            formThemHopDong fTHD = new formThemHopDong();
            var result = fTHD.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                TatCaHopDong();
                HienThiThongTinHopDong();
                LoadListHopDong();
                TatCaChiTietHopDong();
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            formThemChiTietHopDong fTCTHD = new formThemChiTietHopDong();
            var result = fTCTHD.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                TatCaChiTietHopDong();
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }
        private void dgvChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvChiTietHD.CurrentRow.Selected = true;
            HienThiThongTinChiTietHopDong();
        }
        private void txtSearchCTHD_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCTHD.Text != "")
            {
                DataTable dt = blCTHD.SearchCTHD(txtSearchCTHD.Text.Trim());
                dgvChiTietHD.DataSource = dt;
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Tìm thấy " + dgvChiTietHD.Rows.Count + " kết quả.";
            }
            else
            {
                TatCaChiTietHopDong();
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Bạn đang ở cửa sổ Hợp Đồng và Chi Tiết Hợp Đồng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
        }
        private void txtTimMNVHD_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMNVHD.Text != "")
            {
                DataTable dt = blCTHD.TimMNVCTHD(Int32.Parse(txtTimMNVHD.Text.Trim()));
                dgvChiTietHD.DataSource = dt;
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Tìm thấy " + dgvChiTietHD.Rows.Count + " kết quả.";
            }
            else
            {
                TatCaChiTietHopDong();
                HienThiThongTinChiTietHopDong();
                SttLabel1.Text = "Bạn đang ở cửa sổ Hợp Đồng và Chi Tiết Hợp Đồng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
        }

        private void txtTimMNVHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtIDHD_TextChanged(object sender, EventArgs e)
        {
            if (txtIDHD.Text == "")
            {
                btnCapNhatHD.Enabled = false;
                btnXoaHD.Enabled = false;
            }
            else
            {
                btnCapNhatHD.Enabled = true;
                btnXoaHD.Enabled = true;
            }
        }
        private void txtSTTCTHD_TextChanged(object sender, EventArgs e)
        {
            if (txtSTTCTHD.Text == "")
            {
                btnCapNhatCTHD.Enabled = false;
                btnXoaCTHD.Enabled = false;
                btnMoFile.Enabled = false;
                btnDoiFileDK.Enabled = false;
            }
            else
            {
                btnCapNhatCTHD.Enabled = true;
                btnXoaCTHD.Enabled = true;
                btnMoFile.Enabled = true;
                btnDoiFileDK.Enabled = true;
            }
        }
        #endregion  

        #region DiemDanh
        public void DanhSachDiemDanh()
        {
            DataTable dt = blDD.DanhSachDiemDanh();
            dgvDiemDanh.DataSource = dt;
        }

        public void HienThiThongTinDiemDanh()
        {
            if (dgvDiemDanh.Rows.Count > 0)
            {
                dgvDiemDanh.CurrentRow.Selected = true;
                txtSTTDD.Text = dgvDiemDanh.CurrentRow.Cells["SttDD"].Value.ToString();
                dateNgayVang.Value = DateTime.Parse(dgvDiemDanh.CurrentRow.Cells["NgayVang"].Value.ToString());
                txtLyDoVang.Text = dgvDiemDanh.CurrentRow.Cells["LyDo"].Value.ToString().Trim();
                txtTenNVDD.Text = dgvDiemDanh.CurrentRow.Cells["TenNVDD"].Value.ToString().Trim();
                int manv = blDD.LayMaNhanVien(Int32.Parse(txtSTTDD.Text));
                txtSoNgayVang.Text = blDD.LaySoNgayVang(manv).ToString();
                txtSoNgayTC.Text = blDD.LaySoNgayTangCa(manv).ToString();
                if (dgvDiemDanh.CurrentRow.Cells["LoaiDiemDanh"].Value.ToString() == "0")
                {
                    txtLoaiDD.Text = "Vắng";
                }
                else
                {
                    txtLoaiDD.Text = "Tăng ca";
                }
                btnCapNhatDD.Enabled = true;
                btnXoaDD.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin điểm danh: " + txtSTTDD.Text + " - " + txtTenNVDD.Text + " - " + dateNgayVang.Text + " - " + txtLoaiDD.Text + ".";
            }
            else
            {
                txtSTTDD.Text = "";
                txtTenNVDD.Text = "";
                txtSoNgayVang.Text = "";
                txtLyDoVang.Text = "";
            }
        }

        private void tabDiemDanh_VisibleChanged(object sender, EventArgs e)
        {
            if (tabDiemDanh.PageVisible == true)
            {
                DanhSachDiemDanh();
                if (dgvDiemDanh.Rows.Count > 0)
                {
                    dgvDiemDanh.CurrentRow.Selected = true;
                    HienThiThongTinDiemDanh();
                }
            }
        }

        private void dgvDiemDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDiemDanh.CurrentRow.Selected = true;
            HienThiThongTinDiemDanh();
        }

        public bool KiemTraTextDD()
        {
            if (txtLyDoVang.Text == "")
            {
                MessageBox.Show("Lý do vắng không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCapNhatDD_Click(object sender, EventArgs e)
        {
            if (txtSTTDD.Text != "")
            {
                if (KiemTraTextDD())
                {
                    if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin điểm danh này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DiemDanh.DiemDanh dd = new DiemDanh.DiemDanh();
                        dd.STT = Int32.Parse(txtSTTDD.Text);
                        dd.NgayVang = dateNgayVang.Value.ToShortDateString();
                        dd.LyDo = txtLyDoVang.Text;
                        blDD.CapNhatDiemDanh(dd);
                        MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DanhSachDiemDanh();
                        HienThiThongTinDiemDanh();
                        SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số thứ tự điểm danh", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDanhDauVang_Click(object sender, EventArgs e)
        {
            formThemDiemDanh fTDD = new formThemDiemDanh();
            var result = fTDD.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                DanhSachDiemDanh();
                HienThiThongTinDiemDanh();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }
        private void btnXoaDD_Click(object sender, EventArgs e)
        {
            if (txtSTTDD.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa thông tin điểm danh này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DiemDanh.DiemDanh dd = new DiemDanh.DiemDanh();
                    dd.STT = Int32.Parse(txtSTTDD.Text);
                    int manv = blDD.LayMaNhanVien(dd.STT);
                    dd.NgayVang = dateNgayVang.Value.ToShortDateString();
                    if (txtLoaiDD.Text == "Vắng")
                    {
                        blDD.GiamSoNgayVang(manv);
                    }
                    else
                    {
                        blDD.GiamSoNgayTangCa(manv);
                    }
                    blDD.XoaDiemDanh(dd);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DanhSachDiemDanh();
                    HienThiThongTinDiemDanh();
                    SttLabel1.Text = "Bạn vừa xóa thông tin điểm danh " + dd.STT + " - " + txtTenNVDD.Text.Trim() + " - " + dd.NgayVang;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số thứ tự điểm danh", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearchDD_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchDD.Text != "")
            {
                DataTable dt = blDD.SearchDD(txtSearchDD.Text.Trim());
                dgvDiemDanh.DataSource = dt;
                HienThiThongTinDiemDanh();
                SttLabel1.Text = "Tìm thấy " + dgvDiemDanh.Rows.Count.ToString() + " kết quả";
            }
            else
            {
                DanhSachDiemDanh();
                HienThiThongTinDiemDanh();
                SttLabel1.Text = "Bạn đang ở cửa sổ Điểm Danh. Có các chức năng quản lý: Đánh dấu vắng, Cập nhật, Xóa";
            }
        }

        private void txtTimMNVDD_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMNVDD.Text != "")
            {
                DataTable dt = blDD.TimMNVDD(Int32.Parse(txtTimMNVDD.Text.Trim()));
                dgvDiemDanh.DataSource = dt;
                HienThiThongTinDiemDanh();
                SttLabel1.Text = "Tìm thấy " + dgvDiemDanh.Rows.Count.ToString() + " kết quả";
            }
            else
            {
                DanhSachDiemDanh();
                HienThiThongTinDiemDanh();
                SttLabel1.Text = "Bạn đang ở cửa sổ Điểm Danh. Có các chức năng quản lý: Đánh dấu vắng, Cập nhật, Xóa";
            }
        }

        private void txtSTTDD_TextChanged(object sender, EventArgs e)
        {
            if (txtSTTDD.Text == "")
            {
                btnCapNhatDD.Enabled = false;
                btnXoaDD.Enabled = false;
            }
            else
            {
                btnCapNhatDD.Enabled = true;
                btnXoaDD.Enabled = true;
            }
        }

        private void dgvDiemDanh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDiemDanh.Columns[e.ColumnIndex].Name.Equals("LoaiDiemDanh"))
            {
                string vl = e.Value.ToString();
                if (vl == null)
                {
                    return;
                }
                switch (vl)
                {
                    case "0":
                        e.Value = "Vắng";
                        break;
                    case "1":
                        e.Value = "Tăng ca";
                        break;
                }
            }
        }
        private void txtLoaiDD_TextChanged(object sender, EventArgs e)
        {
            if (txtLoaiDD.Text == "Tăng ca")
            {
                txtLyDoVang.Enabled = false;
            }
            else
            {
                txtLyDoVang.Enabled = true;
            }
        }

        private void txtTimMNVDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region PhatLuong
        public void DanhSachPhatLuong()
        {
            DataTable dt = blPL.DanhSachPhatLuong();
            dgvPhatLuong.DataSource = dt;
        }
        public void HienThiThongTinPhatLuong()
        {
            if (dgvPhatLuong.Rows.Count > 0)
            {
                dgvPhatLuong.CurrentRow.Selected = true;
                txtSTTPL.Text = dgvPhatLuong.CurrentRow.Cells["STTPL"].Value.ToString();
                txtTenNVPL.Text = dgvPhatLuong.CurrentRow.Cells["TenNhanVienPL"].Value.ToString();
                dateNgayLanh.Value = DateTime.Parse(dgvPhatLuong.CurrentRow.Cells["NgayLanh"].Value.ToString());
                txtTongLanh.Text = dgvPhatLuong.CurrentRow.Cells["TongLanh"].Value.ToString();
                txtGhiChuPL.Text = dgvPhatLuong.CurrentRow.Cells["GhiChuPL"].Value.ToString();
                btnCapNhatPL.Enabled = true;
                btnXoaPL.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin phát lương: " + txtSTTPL.Text + " - " + txtTenNVPL.Text + " - " + dateNgayLanh.Text + " - " + lbTongLanh.Text + ".";
            }
            else
            {
                txtSTTPL.Text = "";
                txtTenNVPL.Text = "";
                txtTongLanh.Text = "";
                txtGhiChuPL.Text = "";
                dateNgayLanh.Text = null;
            }
        }
        private void tabPhatLuong_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPhatLuong.PageVisible == true)
            {
                DanhSachPhatLuong();
                if (dgvPhatLuong.Rows.Count > 0)
                {
                    dgvPhatLuong.CurrentRow.Selected = true;
                    HienThiThongTinPhatLuong();
                }
            }
        }
        private void dgvPhatLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPhatLuong.CurrentRow.Selected = true;
            HienThiThongTinPhatLuong();
        }
        private void btnCapNhatPL_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin phát lương này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PhatLuong.PhatLuong pl = new PhatLuong.PhatLuong();
                pl.STT = Int32.Parse(txtSTTPL.Text);
                pl.NgayLanh = dateNgayLanh.Value.ToShortDateString();
                pl.GhiChu = txtGhiChuPL.Text;
                blPL.CapNhatPhatLuong(pl);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachPhatLuong();
                HienThiThongTinPhatLuong();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi";
            }
            
        }
        private void btnXoaPL_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin phát lương này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PhatLuong.PhatLuong pl = new PhatLuong.PhatLuong();
                pl.STT = Int32.Parse(txtSTTPL.Text);
                string tennv = txtTenNVPL.Text.Trim();
                blPL.XoaPhatLuong(pl);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachPhatLuong();
                HienThiThongTinPhatLuong();
                SttLabel1.Text = "Bạn vừa xóa thông tin phát lương " + pl.STT + " - " + tennv + ".";
            }
            
        }
        private void btnThemPL_Click(object sender, EventArgs e)
        {
            formThemPhatLuong fTPL = new formThemPhatLuong();
            var result = fTPL.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                DanhSachPhatLuong();
                HienThiThongTinPhatLuong();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }
        private void txtSearchPL_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPL.Text != "")
            {
                DataTable dt = blPL.SearchPL(txtSearchPL.Text.Trim());
                dgvPhatLuong.DataSource = dt;
                HienThiThongTinPhatLuong();
                SttLabel1.Text = "Tìm thấy " + dgvPhatLuong.Rows.Count + " kết quả";
            }
            else
            {
                DanhSachPhatLuong();
                HienThiThongTinPhatLuong();
            }
        }
        private void txtTimMNVPL_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMNVPL.Text != "")
            {
                DataTable dt = blPL.TimMNVPL(Int32.Parse(txtTimMNVPL.Text.Trim()));
                dgvPhatLuong.DataSource = dt;
                HienThiThongTinPhatLuong();
                SttLabel1.Text = "Tìm thấy " + dgvPhatLuong.Rows.Count + " kết quả";
            }
            else
            {
                DanhSachPhatLuong();
                HienThiThongTinPhatLuong();
                SttLabel1.Text = "Bạn đang ở cửa sổ Phát Lương. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
        }

        private void txtTimMNVPL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTongLanh_TextChanged(object sender, EventArgs e)
        {
            if (txtTongLanh.Text != "")
            {
                lbTongLanh.Text = String.Format("{0:C0}", Int64.Parse(txtTongLanh.Text));
            }
            else
            {
                lbTongLanh.Text = "0 đ";
            }
        }
        private void txtSTTPL_TextChanged(object sender, EventArgs e)
        {
            if (txtSTTPL.Text == "")
            {
                btnCapNhatPL.Enabled = false;
                btnXoaPL.Enabled = false;
            }
            else
            {
                btnCapNhatPL.Enabled = true;
                btnCapNhatPL.Enabled = true;
            }
        }

        private void btnCHPL_Click(object sender, EventArgs e)
        {
            formCauHinhPL fCHPL = new formCauHinhPL();
            fCHPL.ShowDialog();
        }
        private void btnDSTU_Click(object sender, EventArgs e)
        {
            formDSTamUng fDSTU = new formDSTamUng();
            fDSTU.ShowDialog();
        }
        #endregion

        #region KhenThuong
        public void DanhSachKhenThuong()
        {
            DataTable dt = blKT.DanhSachKhenThuong();
            dgvKhenThuong.DataSource = dt;
        }
        public void HienThiThongTinKhenThuong()
        {
            if (dgvKhenThuong.Rows.Count > 0)
            {
                dgvKhenThuong.CurrentRow.Selected = true;
                txtSTTKT.Text = dgvKhenThuong.CurrentRow.Cells["STTKT"].Value.ToString().Trim();
                txtTenNVKT.Text = dgvKhenThuong.CurrentRow.Cells["TenNVKT"].Value.ToString().Trim();
                txtTienThuong.Text = dgvKhenThuong.CurrentRow.Cells["TienThuong"].Value.ToString().Trim();
                dateNgayThuong.Value = DateTime.Parse(dgvKhenThuong.CurrentRow.Cells["NgayThuong"].Value.ToString());
                txtGhiChuKT.Text = dgvKhenThuong.CurrentRow.Cells["GhiChuKT"].Value.ToString().Trim();
                btnCapNhatKT.Enabled = true;
                btnXoaKT.Enabled = true;
                SttLabel1.Text = "Bạn đang xem thông tin khen thưởng: " + txtSTTKT.Text + " - " + txtTenNVKT.Text + " - " + dateNgayThuong.Text + " - " + lbTienThuong.Text + ".";
            }
            else
            {
                txtSTTKT.Text = "";
                txtTenNVKT.Text = "";
                txtTienThuong.Text = "";
                dateNgayThuong.Text = "";
                txtGhiChuKT.Text = "";
            }
        }
        private void tabKhenThuong_VisibleChanged(object sender, EventArgs e)
        {
            if (tabKhenThuong.PageVisible == true)
            {
                DanhSachKhenThuong();
                if (dgvKhenThuong.Rows.Count > 0)
                {
                    dgvKhenThuong.CurrentRow.Selected = true;
                    HienThiThongTinKhenThuong();
                }
            }
        }
        private void dgvKhenThuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKhenThuong.CurrentRow.Selected = true;
            HienThiThongTinKhenThuong();
        }
        public bool KiemTraTextKT()
        {
            if (txtTienThuong.Text == "")
            {
                MessageBox.Show("Tiền thưởng không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnCapNhatKT_Click(object sender, EventArgs e)
        {
            if (KiemTraTextKT())
            {
                if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin khen thưởng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    KhenThuong.KhenThuong kt = new KhenThuong.KhenThuong();
                    kt.STT = Int32.Parse(txtSTTKT.Text);
                    kt.TienThuong = Int64.Parse(txtTienThuong.Text.Trim());
                    kt.NgayThuong = dateNgayThuong.Value.ToShortDateString();
                    kt.GhiChu = txtGhiChuKT.Text;
                    blKT.CapNhatKhenThuong(kt);
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DanhSachKhenThuong();
                    HienThiThongTinKhenThuong();
                    SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
                }
            }
        }
        private void btnXoaKT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa thông tin khen thưởng này này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KhenThuong.KhenThuong kt = new KhenThuong.KhenThuong();
                kt.STT = Int32.Parse(txtSTTKT.Text);
                kt.TienThuong = Int64.Parse(txtTienThuong.Text.Trim());
                string tennv = txtTenNVKT.Text.Trim();
                blKT.XoaKhenThuong(kt);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachKhenThuong();
                HienThiThongTinKhenThuong();
                SttLabel1.Text = "Bạn vừa xóa thông tin khen thưởng: " + kt.STT + " - " + tennv + " - " + kt.TienThuong + ".";
            }
        }
        private void txtSTTKT_TextChanged(object sender, EventArgs e)
        {
            if (txtSTTKT.Text.Trim() == "")
            {
                btnCapNhatKT.Enabled = false;
                btnXoaKT.Enabled = false;
            }
            else
            {
                btnCapNhatKT.Enabled = true;
                btnXoaKT.Enabled = true;
            }
        }
        private void btnThemKT_Click(object sender, EventArgs e)
        {
            formThemKhenThuong fTKT = new formThemKhenThuong();
            var result = fTKT.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                DanhSachKhenThuong();
                HienThiThongTinKhenThuong();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi.";
            }
        }
        private void txtSearchKT_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchKT.Text != "")
            {
                DataTable dt = blKT.SearchKhenThuong(txtSearchKT.Text.Trim());
                dgvKhenThuong.DataSource = dt;
                HienThiThongTinKhenThuong();
                SttLabel1.Text = "Tìm thấy " + dgvKhenThuong.Rows.Count.ToString() + " kết quả.";
            }
            else
            {
                DanhSachKhenThuong();
                HienThiThongTinKhenThuong();
                SttLabel1.Text = "Bạn đang ở cửa sổ Khen Thưởng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
            }
        }
        private void txtMNVKT_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMNVKT.Text != "")
            {
                DataTable dt = blKT.TimMNVKT(Int32.Parse(txtTimMNVKT.Text.Trim()));
                dgvKhenThuong.DataSource = dt;
                HienThiThongTinKhenThuong();
                SttLabel1.Text = "Tìm thấy " + dgvKhenThuong.Rows.Count.ToString() + " kết quả.";
            }
            else
            {
                DanhSachKhenThuong();
                HienThiThongTinKhenThuong();
                SttLabel1.Text = "Bạn đang ở cửa sổ Khen Thưởng. Có các chức năng quản lý: Thêm, Sửa, Xóa, Tìm kiếm.";
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
        private void txtTienThuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTimMNVKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region TaiKhoan
        public void DanhSachTaiKhoan()
        {
            DataTable dt = blTK.DanhSachTaiKhoan();
            dgvTaiKhoan.DataSource = dt;
            if (dgvTaiKhoan.Rows.Count > 0)
            {
                dgvTaiKhoan.CurrentRow.Selected = true;
            }
        }

        public void HienThongTinTaiKhoan()
        {
            if (dgvTaiKhoan.Rows.Count > 0)
            {
                dgvTaiKhoan.CurrentRow.Selected = true;
                txtTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells["TaiKhoan"].Value.ToString().Trim();
                txtEmailAdmin.Text = dgvTaiKhoan.CurrentRow.Cells["EmailTK"].Value.ToString();
                if (dgvTaiKhoan.CurrentRow.Cells["PhanQuyen"].Value.ToString() == "0")
                {
                    listQuyen.SelectedItem = "Quản trị viên";
                }
                else if (dgvTaiKhoan.CurrentRow.Cells["PhanQuyen"].Value.ToString() == "1")
                {
                    listQuyen.SelectedItem = "Quản lý nhân viên";
                }
                else if (dgvTaiKhoan.CurrentRow.Cells["PhanQuyen"].Value.ToString() == "2")
                {
                    listQuyen.SelectedItem = "Quản lý phát lương";
                }
                else
                {
                    listQuyen.SelectedItem = "Quản lý hợp đồng";
                }
            }
        }

        private void tabCDTK_VisibleChanged(object sender, EventArgs e)
        {
            if (tabCDTK.PageVisible == true)
            {
                DanhSachTaiKhoan();
                HienThongTinTaiKhoan();
            }
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "")
            {
                QuanLyNhanSu.TaiKhoan.TaiKhoan tk = new QuanLyNhanSu.TaiKhoan.TaiKhoan();
                tk.TenTaiKhoan = txtTaiKhoan.Text.Trim();
                tk.MatKhau = txtMatKhau.Text.Trim();
                blTK.DoiMatKhau(tk);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachTaiKhoan();
                HienThongTinTaiKhoan();
                txtMatKhau.Text = "";
                SttLabel1.Text = "Bạn vừa đổi mật khẩu cho tài khoản: " + tk.TenTaiKhoan;
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới để đổi", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiEmail_Click(object sender, EventArgs e)
        {
            if (txtEmailAdmin.Text != "")
            {
                if (regex.IsMatch(txtEmailAdmin.Text.Trim()) == false)
                {
                    MessageBox.Show("Email không đúng định dạng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    QuanLyNhanSu.TaiKhoan.TaiKhoan tk = new QuanLyNhanSu.TaiKhoan.TaiKhoan();
                    tk.TenTaiKhoan = txtTaiKhoan.Text.Trim();
                    tk.Email = txtEmailAdmin.Text.Trim();
                    blTK.DoiEmail(tk);
                    MessageBox.Show("Đổi email thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DanhSachTaiKhoan();
                    HienThongTinTaiKhoan();
                    SttLabel1.Text = "Bạn vừa đổi email cho tài khoản: " + tk.TenTaiKhoan;
                }
            }
            else
            {
                MessageBox.Show("Email không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienMK.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTaiKhoan.Rows.Count > 0)
            {
                dgvTaiKhoan.CurrentRow.Selected = true;
                HienThongTinTaiKhoan();
            }
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTaiKhoan.Columns[e.ColumnIndex].Name.Equals("PhanQuyen"))
            {
                string vl = e.Value.ToString();
                if (vl == null)
                {
                    return;
                }
                switch (vl)
                {
                    case "0":
                        e.Value = "Quản trị viên";
                        break;
                    case "1":
                        e.Value = "Quản lý nhân viên";
                        break;
                    case "2":
                        e.Value = "Quản lý phát lương";
                        break;
                    case "3":
                        e.Value = "Quản lý hợp đồng";
                        break;
                }
            }
        }
        private void btnDoiPQ_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin")
            {
                MessageBox.Show("Bạn không thể đổi phân quyền cho tài khoản admin", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QuanLyNhanSu.TaiKhoan.TaiKhoan tk = new TaiKhoan.TaiKhoan();
                tk.TenTaiKhoan = txtTaiKhoan.Text.Trim();
                if (listQuyen.SelectedItem.ToString() == "Quản trị viên")
                {
                    tk.PhanQuyen = 0;
                }
                else if (listQuyen.SelectedItem.ToString() == "Quản lý nhân viên")
                {
                    tk.PhanQuyen = 1;
                }
                else if (listQuyen.SelectedItem.ToString() == "Quản lý phát lương")
                {
                    tk.PhanQuyen = 2;
                }
                else
                {
                    tk.PhanQuyen = 3;
                }
                blTK.DoiPhanQuyen(tk);
                MessageBox.Show("Đổi phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhSachTaiKhoan();
                HienThongTinTaiKhoan();
                SttLabel1.Text = "Bạn vừa đổi phân quyền cho tài khoản: " + tk.TenTaiKhoan;
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            formThemTaiKhoan fTTK = new formThemTaiKhoan();
            if (fTTK.ShowDialog() == DialogResult.Cancel)
            {
                DanhSachTaiKhoan();
                HienThongTinTaiKhoan();
                SttLabel1.Text = "Đã cập nhật tất cả thay đổi";
            }
        }
        #endregion

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin")
            {
                MessageBox.Show("Bạn không thể xóa tài khoản admin", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Cảnh bảo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    QuanLyNhanSu.TaiKhoan.TaiKhoan tk = new TaiKhoan.TaiKhoan();
                    tk.TenTaiKhoan = txtTaiKhoan.Text.Trim();
                    blTK.XoaTaiKhoan(tk);
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DanhSachTaiKhoan();
                    HienThongTinTaiKhoan();
                    SttLabel1.Text = "Bạn vừa xóa tài khoản: " + tk.TenTaiKhoan;
                }
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "")
            {
                btnDoiMatKhau.Enabled = true;
                btnDoiEmail.Enabled = true;
                btnDoiPQ.Enabled = true;
                btnXoaTK.Enabled = true;
            }
            else
            {
                btnDoiMatKhau.Enabled = false;
                btnDoiEmail.Enabled = false;
                btnDoiPQ.Enabled = false;
                btnXoaTK.Enabled = false;
            }
        }
    }
}
