namespace QuanLyNhanSu.UI
{
    partial class uc_ChucVu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ChucVu));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabChucVu = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchCV = new System.Windows.Forms.TextBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCapCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtPhuCapCV = new System.Windows.Forms.TextBox();
            this.lbPhuCapCV = new System.Windows.Forms.Label();
            this.btnCloseChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaCV = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatCV = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabChucVu.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.AppearancePage.Header.Options.UseFont = true;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabPage = this.tabChucVu;
            this.tabControl1.Size = new System.Drawing.Size(773, 489);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabChucVu});
            // 
            // tabChucVu
            // 
            this.tabChucVu.Controls.Add(this.tableLayoutPanel7);
            this.tabChucVu.Controls.Add(this.tableLayoutPanel6);
            this.tabChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChucVu.Name = "tabChucVu";
            this.tabChucVu.PageVisible = false;
            this.tabChucVu.Size = new System.Drawing.Size(771, 454);
            this.tabChucVu.Text = "Chức vụ";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtSearchCV, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.dgvChucVu, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(321, 454);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tìm kiếm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchCV
            // 
            this.txtSearchCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchCV.Location = new System.Drawing.Point(95, 2);
            this.txtSearchCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCV.Name = "txtSearchCV";
            this.txtSearchCV.Size = new System.Drawing.Size(223, 21);
            this.txtSearchCV.TabIndex = 1;
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AllowUserToDeleteRows = false;
            this.dgvChucVu.AllowUserToResizeColumns = false;
            this.dgvChucVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.TenChucVu,
            this.PhuCapCV});
            this.tableLayoutPanel7.SetColumnSpan(this.dgvChucVu, 2);
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.Location = new System.Drawing.Point(3, 27);
            this.dgvChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChucVu.MultiSelect = false;
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.ReadOnly = true;
            this.dgvChucVu.RowHeadersVisible = false;
            this.dgvChucVu.RowTemplate.Height = 30;
            this.dgvChucVu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucVu.Size = new System.Drawing.Size(315, 425);
            this.dgvChucVu.TabIndex = 2;
            // 
            // MaChucVu
            // 
            this.MaChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã chức vụ";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            this.MaChucVu.Width = 70;
            // 
            // TenChucVu
            // 
            this.TenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Tên chức vụ";
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.ReadOnly = true;
            this.TenChucVu.Width = 73;
            // 
            // PhuCapCV
            // 
            this.PhuCapCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhuCapCV.DataPropertyName = "PhuCap";
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.PhuCapCV.DefaultCellStyle = dataGridViewCellStyle1;
            this.PhuCapCV.HeaderText = "Phụ cấp chức vụ";
            this.PhuCapCV.Name = "PhuCapCV";
            this.PhuCapCV.ReadOnly = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.txtMaCV, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtTenCV, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtPhuCapCV, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.lbPhuCapCV, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.btnCloseChucVu, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel26, 0, 7);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(321, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(450, 454);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã chức vụ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên chức vụ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Phụ cấp";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(75, 31);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.ReadOnly = true;
            this.txtMaCV.Size = new System.Drawing.Size(180, 21);
            this.txtMaCV.TabIndex = 3;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenCV.Location = new System.Drawing.Point(75, 61);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(372, 21);
            this.txtTenCV.TabIndex = 3;
            // 
            // txtPhuCapCV
            // 
            this.txtPhuCapCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhuCapCV.Location = new System.Drawing.Point(75, 91);
            this.txtPhuCapCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhuCapCV.MaxLength = 13;
            this.txtPhuCapCV.Name = "txtPhuCapCV";
            this.txtPhuCapCV.Size = new System.Drawing.Size(372, 21);
            this.txtPhuCapCV.TabIndex = 3;
            // 
            // lbPhuCapCV
            // 
            this.lbPhuCapCV.AutoSize = true;
            this.lbPhuCapCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPhuCapCV.ForeColor = System.Drawing.Color.Blue;
            this.lbPhuCapCV.Location = new System.Drawing.Point(75, 114);
            this.lbPhuCapCV.Name = "lbPhuCapCV";
            this.lbPhuCapCV.Size = new System.Drawing.Size(372, 13);
            this.lbPhuCapCV.TabIndex = 4;
            this.lbPhuCapCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCloseChucVu
            // 
            this.btnCloseChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChucVu.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCloseChucVu.Appearance.Options.UseFont = true;
            this.btnCloseChucVu.Appearance.Options.UseForeColor = true;
            this.btnCloseChucVu.Location = new System.Drawing.Point(422, 2);
            this.btnCloseChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseChucVu.Name = "btnCloseChucVu";
            this.btnCloseChucVu.Size = new System.Drawing.Size(25, 25);
            this.btnCloseChucVu.TabIndex = 1;
            this.btnCloseChucVu.Text = "X";
            // 
            // btnThemCV
            // 
            this.btnThemCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemCV.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCV.Appearance.Options.UseFont = true;
            this.tableLayoutPanel26.SetColumnSpan(this.btnThemCV, 2);
            this.btnThemCV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThemCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemCV.ImageOptions.SvgImage")));
            this.btnThemCV.Location = new System.Drawing.Point(214, 231);
            this.btnThemCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(225, 90);
            this.btnThemCV.TabIndex = 5;
            this.btnThemCV.Text = "Thêm chức vụ";
            this.btnThemCV.Click += new System.EventHandler(this.btnThemCV_Click);
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCV.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaCV.Appearance.Options.UseFont = true;
            this.btnXoaCV.Appearance.Options.UseForeColor = true;
            this.btnXoaCV.Enabled = false;
            this.btnXoaCV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaCV.ImageOptions.SvgImage")));
            this.btnXoaCV.Location = new System.Drawing.Point(112, 231);
            this.btnXoaCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.Size = new System.Drawing.Size(94, 90);
            this.btnXoaCV.TabIndex = 5;
            this.btnXoaCV.Text = "Xóa";
            // 
            // btnCapNhatCV
            // 
            this.btnCapNhatCV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatCV.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatCV.Appearance.Options.UseFont = true;
            this.btnCapNhatCV.Enabled = false;
            this.btnCapNhatCV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCapNhatCV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatCV.ImageOptions.SvgImage")));
            this.btnCapNhatCV.Location = new System.Drawing.Point(6, 231);
            this.btnCapNhatCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatCV.Name = "btnCapNhatCV";
            this.btnCapNhatCV.Size = new System.Drawing.Size(100, 90);
            this.btnCapNhatCV.TabIndex = 5;
            this.btnCapNhatCV.Text = "Cập nhật";
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 4;
            this.tableLayoutPanel6.SetColumnSpan(this.tableLayoutPanel26, 2);
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.1327F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.8673F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel26.Controls.Add(this.btnCapNhatCV, 0, 2);
            this.tableLayoutPanel26.Controls.Add(this.btnThemCV, 2, 2);
            this.tableLayoutPanel26.Controls.Add(this.btnXoaCV, 1, 2);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 3;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(444, 323);
            this.tableLayoutPanel26.TabIndex = 6;
            // 
            // uc_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_ChucVu";
            this.Size = new System.Drawing.Size(773, 489);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabChucVu.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabChucVu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchCV;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCapCV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtPhuCapCV;
        private System.Windows.Forms.Label lbPhuCapCV;
        private DevExpress.XtraEditors.SimpleButton btnCloseChucVu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatCV;
        private DevExpress.XtraEditors.SimpleButton btnThemCV;
        private DevExpress.XtraEditors.SimpleButton btnXoaCV;
    }
}
