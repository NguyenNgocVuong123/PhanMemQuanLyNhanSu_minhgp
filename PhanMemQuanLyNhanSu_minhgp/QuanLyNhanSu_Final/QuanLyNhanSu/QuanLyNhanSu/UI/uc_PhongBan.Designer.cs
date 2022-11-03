namespace QuanLyNhanSu.UI
{
    partial class uc_PhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_PhongBan));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPhongBan = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChuPB = new System.Windows.Forms.RichTextBox();
            this.btnClosePhongBan = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapNhatPB = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaPB = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPB = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPhongBan.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
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
            this.tabControl1.SelectedTabPage = this.tabPhongBan;
            this.tabControl1.Size = new System.Drawing.Size(722, 443);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPhongBan});
            // 
            // tabPhongBan
            // 
            this.tabPhongBan.Controls.Add(this.tableLayoutPanel3);
            this.tabPhongBan.Controls.Add(this.tableLayoutPanel2);
            this.tabPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhongBan.Name = "tabPhongBan";
            this.tabPhongBan.PageVisible = false;
            this.tabPhongBan.Size = new System.Drawing.Size(720, 408);
            this.tabPhongBan.Text = "Phòng ban";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvPhongBan, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSearchPB, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(270, 408);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.AllowUserToResizeColumns = false;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhongBan,
            this.TenPhongBan,
            this.GhiChu});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvPhongBan, 2);
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.Location = new System.Drawing.Point(3, 27);
            this.dgvPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhongBan.MultiSelect = false;
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.RowHeadersVisible = false;
            this.dgvPhongBan.RowTemplate.Height = 30;
            this.dgvPhongBan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongBan.Size = new System.Drawing.Size(264, 379);
            this.dgvPhongBan.TabIndex = 3;
            // 
            // MaPhongBan
            // 
            this.MaPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaPhongBan.DataPropertyName = "MaPhongBan";
            this.MaPhongBan.HeaderText = "Mã phòng ban";
            this.MaPhongBan.Name = "MaPhongBan";
            this.MaPhongBan.ReadOnly = true;
            this.MaPhongBan.Width = 92;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenPhongBan.DataPropertyName = "TenPhongBan";
            this.TenPhongBan.HeaderText = "Tên phòng ban";
            this.TenPhongBan.Name = "TenPhongBan";
            this.TenPhongBan.ReadOnly = true;
            this.TenPhongBan.Width = 96;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchPB
            // 
            this.txtSearchPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchPB.Location = new System.Drawing.Point(68, 2);
            this.txtSearchPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchPB.Name = "txtSearchPB";
            this.txtSearchPB.Size = new System.Drawing.Size(199, 21);
            this.txtSearchPB.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMaPB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTenPB, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtGhiChuPB, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnClosePhongBan, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel27, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(270, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 408);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng ban";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(88, 31);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.ReadOnly = true;
            this.txtMaPB.Size = new System.Drawing.Size(180, 21);
            this.txtMaPB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên phòng ban";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenPB.Location = new System.Drawing.Point(88, 61);
            this.txtTenPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(359, 21);
            this.txtTenPB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ghi chú";
            // 
            // txtGhiChuPB
            // 
            this.txtGhiChuPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChuPB.Location = new System.Drawing.Point(88, 91);
            this.txtGhiChuPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChuPB.Name = "txtGhiChuPB";
            this.txtGhiChuPB.Size = new System.Drawing.Size(359, 71);
            this.txtGhiChuPB.TabIndex = 4;
            this.txtGhiChuPB.Text = "";
            // 
            // btnClosePhongBan
            // 
            this.btnClosePhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePhongBan.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePhongBan.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnClosePhongBan.Appearance.Options.UseFont = true;
            this.btnClosePhongBan.Appearance.Options.UseForeColor = true;
            this.btnClosePhongBan.Location = new System.Drawing.Point(422, 2);
            this.btnClosePhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClosePhongBan.Name = "btnClosePhongBan";
            this.btnClosePhongBan.Size = new System.Drawing.Size(25, 25);
            this.btnClosePhongBan.TabIndex = 1;
            this.btnClosePhongBan.Text = "X";
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 4;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel27, 2);
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel27.Controls.Add(this.btnCapNhatPB, 1, 2);
            this.tableLayoutPanel27.Controls.Add(this.btnXoaPB, 0, 2);
            this.tableLayoutPanel27.Controls.Add(this.btnThemPB, 2, 2);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 166);
            this.tableLayoutPanel27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 3;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(444, 240);
            this.tableLayoutPanel27.TabIndex = 6;
            // 
            // btnCapNhatPB
            // 
            this.btnCapNhatPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatPB.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatPB.Appearance.Options.UseFont = true;
            this.btnCapNhatPB.Enabled = false;
            this.btnCapNhatPB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCapNhatPB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatPB.ImageOptions.SvgImage")));
            this.btnCapNhatPB.Location = new System.Drawing.Point(126, 142);
            this.btnCapNhatPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatPB.Name = "btnCapNhatPB";
            this.btnCapNhatPB.Size = new System.Drawing.Size(117, 96);
            this.btnCapNhatPB.TabIndex = 5;
            this.btnCapNhatPB.Text = "Cập nhật";
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPB.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaPB.Appearance.Options.UseFont = true;
            this.btnXoaPB.Appearance.Options.UseForeColor = true;
            this.btnXoaPB.Enabled = false;
            this.btnXoaPB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaPB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaPB.ImageOptions.SvgImage")));
            this.btnXoaPB.Location = new System.Drawing.Point(3, 142);
            this.btnXoaPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(117, 96);
            this.btnXoaPB.TabIndex = 5;
            this.btnXoaPB.Text = "Xóa";
            // 
            // btnThemPB
            // 
            this.btnThemPB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemPB.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPB.Appearance.Options.UseFont = true;
            this.tableLayoutPanel27.SetColumnSpan(this.btnThemPB, 2);
            this.btnThemPB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThemPB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPB.ImageOptions.SvgImage")));
            this.btnThemPB.Location = new System.Drawing.Point(249, 142);
            this.btnThemPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(192, 96);
            this.btnThemPB.TabIndex = 5;
            this.btnThemPB.Text = "Thêm phòng ban";
            // 
            // uc_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_PhongBan";
            this.Size = new System.Drawing.Size(722, 443);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPhongBan.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPhongBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchPB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtGhiChuPB;
        private DevExpress.XtraEditors.SimpleButton btnClosePhongBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatPB;
        private DevExpress.XtraEditors.SimpleButton btnXoaPB;
        private DevExpress.XtraEditors.SimpleButton btnThemPB;
    }
}
