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

namespace QuanLyNhanSu.BaoCao
{
    public partial class formXemBaoCao : DevExpress.XtraEditors.XtraForm
    {
        BaoCaoBL blBC;
        public formXemBaoCao()
        {
            InitializeComponent();
            blBC = new BaoCaoBL();
        }

        private void btnNVMThang_Click(object sender, EventArgs e)
        {
            DataTable dt = blBC.NhanVienMoiThang();
            dgvNhanVien.DataSource = dt;
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
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

        private void btnNVNThang_Click(object sender, EventArgs e)
        {
            DataTable dt = blBC.NhanVienNghiThang();
            dgvNhanVien.DataSource = dt;
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy báo cáo trùng khớp", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNVSapHetHD_Click(object sender, EventArgs e)
        {
            DataTable dt = blBC.NhanVienSapHetHD();
            dgvNhanVien.DataSource = dt;
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy báo cáo trùng khớp", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNVMQuy_Click(object sender, EventArgs e)
        {
            DataTable dt = blBC.NhanVienMoiQuy();
            dgvNhanVien.DataSource = dt;
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy báo cáo trùng khớp", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNVNQuy_Click(object sender, EventArgs e)
        {
            DataTable dt = blBC.NhanVienNghiQuy();
            dgvNhanVien.DataSource = dt;
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy báo cáo trùng khớp", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNVMNam_Click(object sender, EventArgs e)
        {
            DataTable dt = blBC.NhanVienMoiNam();
            dgvNhanVien.DataSource = dt;
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy báo cáo trùng khớp", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNVNNam_Click(object sender, EventArgs e)
        {
            DataTable dt = blBC.NhanVienNghiNam();
            dgvNhanVien.DataSource = dt;
            if (dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.CurrentRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy báo cáo trùng khớp", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application myExcel = new Microsoft.Office.Interop.Excel.Application();
                myExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvNhanVien.Columns.Count + 1; i++)
                {
                    myExcel.Cells[1, i] = dgvNhanVien.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvNhanVien.Columns.Count; j++)
                    {
                        myExcel.Cells[i + 2, j + 1] = dgvNhanVien.Rows[i].Cells[j].Value.ToString();
                    }
                }
                myExcel.Columns.AutoFit();
                myExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu cần xuất báo cáo", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}