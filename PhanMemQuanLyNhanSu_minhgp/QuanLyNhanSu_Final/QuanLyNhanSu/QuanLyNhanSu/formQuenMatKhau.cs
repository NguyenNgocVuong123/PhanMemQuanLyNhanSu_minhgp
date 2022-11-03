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
using System.Data.SqlClient;
using System.Net.Mail;

namespace QuanLyNhanSu
{
    public partial class formQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        DataConnection dc;
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        public formQuenMatKhau()
        {
            InitializeComponent();
            this.AcceptButton = btnChapNhan;
            dc = new DataConnection();
        }
        
        public bool CheckEmail()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select Email from TaiKhoan where Email='" + txtEmail.Text.Trim() + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool KiemTra()
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (regex.IsMatch(txtEmail.Text.Trim())==false)
            {
                MessageBox.Show("Email không đúng định dạng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CheckEmail() == false)
            {
                MessageBox.Show("Email không khớp với cơ sở dữ liệu", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public string LayMatKhau()
        {
            using (SqlConnection con = dc.GetConnect())
            {
                string sql = "select MatKhau from TaiKhoan where Email='" + txtEmail.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt.Rows[0]["MatKhau"].ToString();
            }
        }

        public void GuiMail()
        {
            if (KiemTra())
            {
                string senderID = "giaminh095@gmail.com";
                string senderPassword = "phamminh0112";
                string body = "Mật khẩu của bạn là: " + LayMatKhau();
                MailMessage mail = new MailMessage();
                mail.To.Add(txtEmail.Text.Trim());
                mail.From = new MailAddress(senderID);
                mail.Subject = "Lấy lại mật khẩu";
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Đã gửi mật khẩu về email thành công, hãy kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            try
            {
                GuiMail();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình gửi mật khẩu", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}