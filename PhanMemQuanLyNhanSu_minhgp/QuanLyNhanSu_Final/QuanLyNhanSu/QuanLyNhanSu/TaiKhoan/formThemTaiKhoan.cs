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

namespace QuanLyNhanSu.TaiKhoan
{
    public partial class formThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        TaiKhoanBL blTK;
        public formThemTaiKhoan()
        {
            InitializeComponent();
            blTK = new TaiKhoanBL();
        }

        public bool KiemTra()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email không được để trống", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (regex.IsMatch(txtEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email không đúng định dạng", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (listQuyen.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn phân quyền", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (blTK.KiemTraTaiKhoan(txtTaiKhoan.Text.Trim()))
                {
                    TaiKhoan tk = new TaiKhoan();
                    tk.TenTaiKhoan = txtTaiKhoan.Text.Trim();
                    tk.MatKhau = txtMatKhau.Text.Trim();
                    tk.Email = txtEmail.Text.Trim();
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
                    blTK.ThemTaiKhoan(tk);
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtEmail.Text = "";
                    listQuyen.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Tài khoản này đã tồn tại", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}