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
using System.Net.Mail;

namespace QuanLyNhanSu.PhatLuong
{
    public partial class formThemPhatLuong : DevExpress.XtraEditors.XtraForm
    {
        PhatLuongBL blPL;
        ChiTietHopDongBL blCTHD;
        DiemDanh.DiemDanhBL blDD;
        public Int64 LuongNgay;
        public int SoNgayLamViec;
        public Int64 LuongCoBan;
        public Int64 TienTru;
        public Int64 TienTangCa;
        public Int64 TienBHYT;
        public Int64 TienBHXH;
        public Int64 TienBHTN;
        public Int64 TienPhuCapCV;
        public Int64 TienTamUng;
        public Int64 TongLanh;
        public int ThuongTangCa;
        public formThemPhatLuong()
        {
            InitializeComponent();
            blPL = new PhatLuongBL();
            blCTHD = new ChiTietHopDongBL();
            blDD = new DiemDanh.DiemDanhBL();
        }

        private void formThemPhatLuong_Load(object sender, EventArgs e)
        {
            LoadListNhanVien();
            listNhanVien.SelectedItem = null;
            DataTable dt = blPL.CauHinhPhatLuong();
            SoNgayLamViec = Int32.Parse(dt.Rows[0]["SoNgayLamViec"].ToString());
            txtBHYT.Text = dt.Rows[0]["BHYT"].ToString();
            txtBHXH.Text = dt.Rows[0]["BHXH"].ToString();
            txtBHTN.Text = dt.Rows[0]["BHTN"].ToString();
            ThuongTangCa = Int32.Parse(dt.Rows[0]["ThuongTangCa"].ToString());
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
            txtSNV.Text = "";
            txtSNTC.Text = "";
            if (txtMaNV.Text != "" && listNhanVien.ValueMember != null)
            { 
                try
                {        
                    listNhanVien.SelectedValue = txtMaNV.Text;
                    int manv = Int32.Parse(txtMaNV.Text.Trim());
                    txtSNV.Text = blPL.LaySoNgayVang(manv).ToString();
                    txtSNTC.Text = blDD.LaySoNgayTangCa(manv).ToString();         
                }
                catch
                {
                    
                }
            }
            else
            {
                txtSNV.Text = "";
                txtSNTC.Text = "";
                txtTienTru.Text = "";
                txtTienTangCa.Text = "";
                txtDaTamUng.Text = "";
                lbBHYT.Text = "0 đ";
                lbBHXH.Text = "0 đ";
                lbBHTN.Text = "0 đ";
                txtTongLanh.Text = "";
                txtGhiChu.Text = "";
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

        private void txtTienTru_TextChanged(object sender, EventArgs e)
        {
            if (txtTienTru.Text != "")
            {
                lbTienTru.Text = String.Format("{0:C0}", Int64.Parse(txtTienTru.Text));
            }
            else
            {
                lbTienTru.Text = "0 đ";
            }
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

        public bool KiemTra()
        {
            if (txtMaNV.Text == "" || listNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên hoặc nhân viên không tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void GuiMailPL(string mailto, string noidung)
        {
            string senderID = "giaminh095@gmail.com";
            string senderPassword = "phamminh0112";
            string body = noidung;
            MailMessage mail = new MailMessage();
            mail.To.Add(mailto);
            mail.From = new MailAddress(senderID);
            mail.Subject = "Thông tin phát lương";
            mail.Body = body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                PhatLuong pl = new PhatLuong();
                pl.MaNhanVien = Int32.Parse(txtMaNV.Text.Trim());
                pl.NgayLanh = dateNgayLanh.Value.ToShortDateString();
                pl.TongLanh = Int64.Parse(txtTongLanh.Text.Trim());
                pl.GhiChu = txtGhiChu.Text;
                blPL.ThemPhatLuong(pl);
                blPL.ResetNVNTC(pl.MaNhanVien);
                MessageBox.Show("Thêm phát lương thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    string noidung = "Thông tin phát lương tháng " + DateTime.Parse(pl.NgayLanh).Month.ToString() + " năm " + DateTime.Parse(pl.NgayLanh).Year + " chi tiết như sau:<br/>Ngày lãnh: " + pl.NgayLanh + "<br/>Lương cơ bản: " + String.Format("{0:C0}", LuongCoBan) + "<br/>Phụ cấp chức vụ: " + String.Format("{0:C0}", TienPhuCapCV) + " (+)<br/>Tiền tăng ca: " + lbTienTru.Text + " (+)<br/>Tiền trừ vắng: " + lbTienTru.Text + " (-)<br/>Tiền Bảo hiểm y tế: " + lbBHYT.Text + " (-)<br/>Tiền Bảo hiểm xã hội: " + lbBHXH.Text + " (-)<br/>Tiền bảo hiểm thất nghiệp: " + lbBHTN.Text + " (-)<br/>Tiền đã tạm ứng: " + lbDaTamUng.Text + " (-)<br/>Tổng lãnh: " + lbTongLanh.Text;
                    GuiMailPL(blPL.LayEmail(pl.MaNhanVien), noidung);
                    MessageBox.Show("Gửi thông tin phát lương về mail nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình gửi thông tin lương về mail nhân viên", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtMaNV.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtBHYT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBHXH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBHTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSNV_TextChanged(object sender, EventArgs e)
        {
            if (txtSNV.Text != "")
            {
                LuongCoBan = blPL.LayLuongCB(Int32.Parse(txtMaNV.Text.Trim()));
                LuongNgay = LuongCoBan / SoNgayLamViec;
                int snv = Int32.Parse(txtSNV.Text.Trim());
                TienTru = snv * LuongNgay;
                txtTienTru.Text = TienTru.ToString();
                TienBHYT = LuongCoBan * Int32.Parse(txtBHYT.Text.Trim()) / 100;
                TienBHXH = LuongCoBan * Int32.Parse(txtBHXH.Text.Trim()) / 100;
                TienBHTN = LuongCoBan * Int32.Parse(txtBHTN.Text.Trim()) / 100;
                TienTamUng = blPL.LayTienTamUng(Int32.Parse(txtMaNV.Text.Trim()));
                TienPhuCapCV = blPL.LayPhuCapCV(Int32.Parse(txtMaNV.Text.Trim()));
                lbBHYT.Text = String.Format("{0:C0}", TienBHYT);
                lbBHXH.Text = String.Format("{0:C0}", TienBHXH);
                lbBHTN.Text = String.Format("{0:C0}", TienBHTN);
                txtDaTamUng.Text = TienTamUng.ToString();
            }
        }

        private void txtSNTC_TextChanged(object sender, EventArgs e)
        {
            if (txtSNTC.Text != "")
            {
                TienTangCa = LuongNgay * Int64.Parse(txtSNTC.Text.Trim()) * ThuongTangCa / 100;
                txtTienTangCa.Text = TienTangCa.ToString();
                //
                TongLanh = LuongCoBan + TienPhuCapCV + TienTangCa - TienTru - TienBHYT - TienBHXH - TienBHTN - TienTamUng;
                txtGhiChu.Text = "Lương CB + Phụ cấp CV + Tiền tăng ca (nếu có) - Tiền vắng (nếu có) - BHYT - BHXH - BHTN - Tạm ứng(nếu có) = Tổng lãnh" + Environment.NewLine + LuongCoBan.ToString() + " + " + TienPhuCapCV.ToString() + " + " + TienTangCa + " - " + TienTru.ToString() + " - " + TienBHYT.ToString() + " - " + TienBHXH + " - " + TienBHTN.ToString() + " - " + TienTamUng.ToString() + " = " + TongLanh.ToString();
                txtTongLanh.Text = TongLanh.ToString();
            }
        }

        private void txtTienTangCa_TextChanged(object sender, EventArgs e)
        {
            if (txtTienTangCa.Text != "")
            {
                lbTienTangCa.Text = String.Format("{0:C0}", Int64.Parse(txtTienTangCa.Text));
            }
            else
            {
                lbTienTangCa.Text = "0";
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
    }
}
