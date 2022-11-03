namespace QuanLyNhanSu.UI
{
    partial class uc_ChuyenMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ChuyenMon));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabChuyenMon = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchCM = new System.Windows.Forms.TextBox();
            this.dgvChuyenMon = new System.Windows.Forms.DataGridView();
            this.MaChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaCM = new System.Windows.Forms.TextBox();
            this.txtTenCM = new System.Windows.Forms.TextBox();
            this.btnCloseChuyenMon = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapNhatCM = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaCM = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCM = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabChuyenMon.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
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
            this.tabControl1.SelectedTabPage = this.tabChuyenMon;
            this.tabControl1.Size = new System.Drawing.Size(795, 531);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabChuyenMon});
            // 
            // tabChuyenMon
            // 
            this.tabChuyenMon.Controls.Add(this.tableLayoutPanel9);
            this.tabChuyenMon.Controls.Add(this.tableLayoutPanel8);
            this.tabChuyenMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChuyenMon.Name = "tabChuyenMon";
            this.tabChuyenMon.PageVisible = false;
            this.tabChuyenMon.Size = new System.Drawing.Size(793, 496);
            this.tabChuyenMon.Text = "Chuyên môn";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtSearchCM, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.dgvChuyenMon, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(343, 496);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tìm kiếm";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchCM
            // 
            this.txtSearchCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchCM.Location = new System.Drawing.Point(95, 2);
            this.txtSearchCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCM.Name = "txtSearchCM";
            this.txtSearchCM.Size = new System.Drawing.Size(245, 21);
            this.txtSearchCM.TabIndex = 1;
            // 
            // dgvChuyenMon
            // 
            this.dgvChuyenMon.AllowUserToAddRows = false;
            this.dgvChuyenMon.AllowUserToDeleteRows = false;
            this.dgvChuyenMon.AllowUserToResizeColumns = false;
            this.dgvChuyenMon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuyenMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenMon,
            this.TenChuyenMon});
            this.tableLayoutPanel9.SetColumnSpan(this.dgvChuyenMon, 2);
            this.dgvChuyenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuyenMon.Location = new System.Drawing.Point(3, 27);
            this.dgvChuyenMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChuyenMon.MultiSelect = false;
            this.dgvChuyenMon.Name = "dgvChuyenMon";
            this.dgvChuyenMon.ReadOnly = true;
            this.dgvChuyenMon.RowHeadersVisible = false;
            this.dgvChuyenMon.RowTemplate.Height = 30;
            this.dgvChuyenMon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChuyenMon.Size = new System.Drawing.Size(337, 467);
            this.dgvChuyenMon.TabIndex = 2;
            // 
            // MaChuyenMon
            // 
            this.MaChuyenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaChuyenMon.DataPropertyName = "MaChuyenMon";
            this.MaChuyenMon.HeaderText = "Mã chuyên môn";
            this.MaChuyenMon.Name = "MaChuyenMon";
            this.MaChuyenMon.ReadOnly = true;
            this.MaChuyenMon.Width = 98;
            // 
            // TenChuyenMon
            // 
            this.TenChuyenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenChuyenMon.DataPropertyName = "TenChuyenMon";
            this.TenChuyenMon.HeaderText = "Tên chuyên môn";
            this.TenChuyenMon.Name = "TenChuyenMon";
            this.TenChuyenMon.ReadOnly = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.txtMaCM, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.txtTenCM, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.btnCloseChuyenMon, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel28, 0, 4);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(343, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(450, 496);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Mã chuyên môn";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tên chuyên môn";
            // 
            // txtMaCM
            // 
            this.txtMaCM.Location = new System.Drawing.Point(95, 31);
            this.txtMaCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCM.Name = "txtMaCM";
            this.txtMaCM.ReadOnly = true;
            this.txtMaCM.Size = new System.Drawing.Size(170, 21);
            this.txtMaCM.TabIndex = 3;
            // 
            // txtTenCM
            // 
            this.txtTenCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenCM.Location = new System.Drawing.Point(95, 61);
            this.txtTenCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCM.Name = "txtTenCM";
            this.txtTenCM.Size = new System.Drawing.Size(352, 21);
            this.txtTenCM.TabIndex = 3;
            // 
            // btnCloseChuyenMon
            // 
            this.btnCloseChuyenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseChuyenMon.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChuyenMon.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCloseChuyenMon.Appearance.Options.UseFont = true;
            this.btnCloseChuyenMon.Appearance.Options.UseForeColor = true;
            this.btnCloseChuyenMon.Location = new System.Drawing.Point(422, 2);
            this.btnCloseChuyenMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseChuyenMon.Name = "btnCloseChuyenMon";
            this.btnCloseChuyenMon.Size = new System.Drawing.Size(25, 25);
            this.btnCloseChuyenMon.TabIndex = 1;
            this.btnCloseChuyenMon.Text = "X";
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 4;
            this.tableLayoutPanel8.SetColumnSpan(this.tableLayoutPanel28, 2);
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel28.Controls.Add(this.btnXoaCM, 1, 2);
            this.tableLayoutPanel28.Controls.Add(this.btnCapNhatCM, 0, 2);
            this.tableLayoutPanel28.Controls.Add(this.btnThemCM, 2, 2);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(3, 86);
            this.tableLayoutPanel28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 3;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(444, 408);
            this.tableLayoutPanel28.TabIndex = 5;
            // 
            // btnCapNhatCM
            // 
            this.btnCapNhatCM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatCM.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatCM.Appearance.Options.UseFont = true;
            this.btnCapNhatCM.Enabled = false;
            this.btnCapNhatCM.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCapNhatCM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatCM.ImageOptions.SvgImage")));
            this.btnCapNhatCM.Location = new System.Drawing.Point(3, 290);
            this.btnCapNhatCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatCM.Name = "btnCapNhatCM";
            this.btnCapNhatCM.Size = new System.Drawing.Size(97, 116);
            this.btnCapNhatCM.TabIndex = 4;
            this.btnCapNhatCM.Text = "Cập nhật";
            // 
            // btnXoaCM
            // 
            this.btnXoaCM.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCM.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaCM.Appearance.Options.UseFont = true;
            this.btnXoaCM.Appearance.Options.UseForeColor = true;
            this.btnXoaCM.Enabled = false;
            this.btnXoaCM.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaCM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaCM.ImageOptions.SvgImage")));
            this.btnXoaCM.Location = new System.Drawing.Point(106, 290);
            this.btnXoaCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaCM.Name = "btnXoaCM";
            this.btnXoaCM.Size = new System.Drawing.Size(97, 116);
            this.btnXoaCM.TabIndex = 4;
            this.btnXoaCM.Text = "Xóa";
            // 
            // btnThemCM
            // 
            this.btnThemCM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemCM.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCM.Appearance.Options.UseFont = true;
            this.tableLayoutPanel28.SetColumnSpan(this.btnThemCM, 2);
            this.btnThemCM.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThemCM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemCM.ImageOptions.SvgImage")));
            this.btnThemCM.Location = new System.Drawing.Point(209, 290);
            this.btnThemCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCM.Name = "btnThemCM";
            this.btnThemCM.Size = new System.Drawing.Size(232, 116);
            this.btnThemCM.TabIndex = 4;
            this.btnThemCM.Text = "Thêm chuyên môn";
            // 
            // uc_ChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_ChuyenMon";
            this.Size = new System.Drawing.Size(795, 531);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabChuyenMon.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenMon)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel28.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabChuyenMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchCM;
        private System.Windows.Forms.DataGridView dgvChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuyenMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaCM;
        private System.Windows.Forms.TextBox txtTenCM;
        private DevExpress.XtraEditors.SimpleButton btnCloseChuyenMon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatCM;
        private DevExpress.XtraEditors.SimpleButton btnXoaCM;
        private DevExpress.XtraEditors.SimpleButton btnThemCM;
    }
}
