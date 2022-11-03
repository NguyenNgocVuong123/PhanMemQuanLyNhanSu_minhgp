namespace QuanLyNhanSu.UI
{
    partial class uc_TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_TaiKhoan));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabCDTK = new DevExpress.XtraTab.XtraTabPage();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel33 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoiEmail = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemTK = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmailAdmin = new System.Windows.Forms.TextBox();
            this.checkHienMK = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.btnCloseCDTK = new DevExpress.XtraEditors.SimpleButton();
            this.label72 = new System.Windows.Forms.Label();
            this.listQuyen = new System.Windows.Forms.ComboBox();
            this.btnDoiPQ = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaTK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCDTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tableLayoutPanel33.SuspendLayout();
            this.tableLayoutPanel32.SuspendLayout();
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
            this.tabControl1.SelectedTabPage = this.tabCDTK;
            this.tabControl1.Size = new System.Drawing.Size(875, 527);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabCDTK});
            // 
            // tabCDTK
            // 
            this.tabCDTK.Controls.Add(this.dgvTaiKhoan);
            this.tabCDTK.Controls.Add(this.tableLayoutPanel33);
            this.tabCDTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCDTK.Name = "tabCDTK";
            this.tabCDTK.PageVisible = false;
            this.tabCDTK.Size = new System.Drawing.Size(873, 492);
            this.tabCDTK.Text = "Tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoan,
            this.EmailTK,
            this.PhanQuyen});
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.MultiSelect = false;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowTemplate.Height = 30;
            this.dgvTaiKhoan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(423, 492);
            this.dgvTaiKhoan.TabIndex = 4;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            this.TaiKhoan.Width = 78;
            // 
            // EmailTK
            // 
            this.EmailTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailTK.DataPropertyName = "Email";
            this.EmailTK.HeaderText = "Email";
            this.EmailTK.Name = "EmailTK";
            this.EmailTK.ReadOnly = true;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhanQuyen.DataPropertyName = "PhanQuyen";
            this.PhanQuyen.HeaderText = "Phân quyền";
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.ReadOnly = true;
            this.PhanQuyen.Width = 89;
            // 
            // tableLayoutPanel33
            // 
            this.tableLayoutPanel33.ColumnCount = 2;
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Controls.Add(this.tableLayoutPanel32, 0, 8);
            this.tableLayoutPanel33.Controls.Add(this.txtEmailAdmin, 1, 3);
            this.tableLayoutPanel33.Controls.Add(this.checkHienMK, 1, 6);
            this.tableLayoutPanel33.Controls.Add(this.txtMatKhau, 1, 5);
            this.tableLayoutPanel33.Controls.Add(this.label62, 0, 5);
            this.tableLayoutPanel33.Controls.Add(this.label60, 0, 3);
            this.tableLayoutPanel33.Controls.Add(this.txtTaiKhoan, 1, 1);
            this.tableLayoutPanel33.Controls.Add(this.label59, 0, 1);
            this.tableLayoutPanel33.Controls.Add(this.btnCloseCDTK, 1, 0);
            this.tableLayoutPanel33.Controls.Add(this.label72, 0, 7);
            this.tableLayoutPanel33.Controls.Add(this.listQuyen, 1, 7);
            this.tableLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel33.Location = new System.Drawing.Point(423, 0);
            this.tableLayoutPanel33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel33.Name = "tableLayoutPanel33";
            this.tableLayoutPanel33.RowCount = 9;
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Size = new System.Drawing.Size(450, 492);
            this.tableLayoutPanel33.TabIndex = 3;
            // 
            // tableLayoutPanel32
            // 
            this.tableLayoutPanel32.ColumnCount = 2;
            this.tableLayoutPanel33.SetColumnSpan(this.tableLayoutPanel32, 2);
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel32.Controls.Add(this.btnDoiMatKhau, 0, 0);
            this.tableLayoutPanel32.Controls.Add(this.btnDoiEmail, 1, 0);
            this.tableLayoutPanel32.Controls.Add(this.btnXoaTK, 1, 3);
            this.tableLayoutPanel32.Controls.Add(this.btnDoiPQ, 0, 3);
            this.tableLayoutPanel32.Controls.Add(this.btnThemTK, 1, 3);
            this.tableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel32.Location = new System.Drawing.Point(3, 162);
            this.tableLayoutPanel32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel32.Name = "tableLayoutPanel32";
            this.tableLayoutPanel32.RowCount = 4;
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel32.Size = new System.Drawing.Size(444, 328);
            this.tableLayoutPanel32.TabIndex = 2;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.Enabled = false;
            this.btnDoiMatKhau.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDoiMatKhau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiMatKhau.ImageOptions.SvgImage")));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(3, 2);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(216, 73);
            this.btnDoiMatKhau.TabIndex = 0;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // btnDoiEmail
            // 
            this.btnDoiEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiEmail.Appearance.Options.UseFont = true;
            this.btnDoiEmail.Enabled = false;
            this.btnDoiEmail.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDoiEmail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiEmail.ImageOptions.SvgImage")));
            this.btnDoiEmail.Location = new System.Drawing.Point(225, 2);
            this.btnDoiEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiEmail.Name = "btnDoiEmail";
            this.btnDoiEmail.Size = new System.Drawing.Size(216, 73);
            this.btnDoiEmail.TabIndex = 0;
            this.btnDoiEmail.Text = "Đổi Email";
            // 
            // btnThemTK
            // 
            this.btnThemTK.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.Appearance.Options.UseFont = true;
            this.btnThemTK.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThemTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemTK.ImageOptions.SvgImage")));
            this.btnThemTK.Location = new System.Drawing.Point(225, 79);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(216, 85);
            this.btnThemTK.TabIndex = 0;
            this.btnThemTK.Text = "Thêm tài khoản";
            // 
            // txtEmailAdmin
            // 
            this.txtEmailAdmin.Location = new System.Drawing.Point(79, 61);
            this.txtEmailAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailAdmin.Name = "txtEmailAdmin";
            this.txtEmailAdmin.Size = new System.Drawing.Size(316, 21);
            this.txtEmailAdmin.TabIndex = 1;
            // 
            // checkHienMK
            // 
            this.checkHienMK.AutoSize = true;
            this.checkHienMK.Location = new System.Drawing.Point(79, 116);
            this.checkHienMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkHienMK.Name = "checkHienMK";
            this.checkHienMK.Size = new System.Drawing.Size(94, 17);
            this.checkHienMK.TabIndex = 3;
            this.checkHienMK.Text = "Hiện mật khẩu";
            this.checkHienMK.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(79, 91);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(316, 21);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(3, 95);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(70, 13);
            this.label62.TabIndex = 0;
            this.label62.Text = "Mật khẩu mới";
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(3, 65);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(31, 13);
            this.label60.TabIndex = 0;
            this.label60.Text = "Email";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(79, 31);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(170, 21);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(3, 35);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(53, 13);
            this.label59.TabIndex = 0;
            this.label59.Text = "Tài khoản";
            // 
            // btnCloseCDTK
            // 
            this.btnCloseCDTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseCDTK.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCDTK.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCloseCDTK.Appearance.Options.UseFont = true;
            this.btnCloseCDTK.Appearance.Options.UseForeColor = true;
            this.btnCloseCDTK.Location = new System.Drawing.Point(422, 2);
            this.btnCloseCDTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseCDTK.Name = "btnCloseCDTK";
            this.btnCloseCDTK.Size = new System.Drawing.Size(25, 25);
            this.btnCloseCDTK.TabIndex = 1;
            this.btnCloseCDTK.Text = "X";
            // 
            // label72
            // 
            this.label72.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(3, 141);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(64, 13);
            this.label72.TabIndex = 0;
            this.label72.Text = "Phân quyền";
            // 
            // listQuyen
            // 
            this.listQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listQuyen.FormattingEnabled = true;
            this.listQuyen.Items.AddRange(new object[] {
            "Quản trị viên",
            "Quản lý nhân viên",
            "Quản lý phát lương",
            "Quản lý hợp đồng"});
            this.listQuyen.Location = new System.Drawing.Point(79, 137);
            this.listQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listQuyen.Name = "listQuyen";
            this.listQuyen.Size = new System.Drawing.Size(368, 21);
            this.listQuyen.TabIndex = 4;
            // 
            // btnDoiPQ
            // 
            this.btnDoiPQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiPQ.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPQ.Appearance.Options.UseFont = true;
            this.btnDoiPQ.Enabled = false;
            this.btnDoiPQ.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDoiPQ.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoiPQ.ImageOptions.SvgImage")));
            this.btnDoiPQ.Location = new System.Drawing.Point(3, 79);
            this.btnDoiPQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiPQ.Name = "btnDoiPQ";
            this.btnDoiPQ.Size = new System.Drawing.Size(216, 85);
            this.btnDoiPQ.TabIndex = 0;
            this.btnDoiPQ.Text = "Đổi phân quyền";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaTK.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.Appearance.Options.UseFont = true;
            this.tableLayoutPanel32.SetColumnSpan(this.btnXoaTK, 2);
            this.btnXoaTK.Enabled = false;
            this.btnXoaTK.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaTK.ImageOptions.SvgImage")));
            this.btnXoaTK.Location = new System.Drawing.Point(3, 168);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(438, 150);
            this.btnXoaTK.TabIndex = 0;
            this.btnXoaTK.Text = "Xóa tài khoản";
            // 
            // uc_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_TaiKhoan";
            this.Size = new System.Drawing.Size(875, 527);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCDTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tableLayoutPanel33.ResumeLayout(false);
            this.tableLayoutPanel33.PerformLayout();
            this.tableLayoutPanel32.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabCDTK;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDoiEmail;
        private DevExpress.XtraEditors.SimpleButton btnThemTK;
        private System.Windows.Forms.TextBox txtEmailAdmin;
        private System.Windows.Forms.CheckBox checkHienMK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label59;
        private DevExpress.XtraEditors.SimpleButton btnCloseCDTK;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ComboBox listQuyen;
        private DevExpress.XtraEditors.SimpleButton btnXoaTK;
        private DevExpress.XtraEditors.SimpleButton btnDoiPQ;
    }
}
