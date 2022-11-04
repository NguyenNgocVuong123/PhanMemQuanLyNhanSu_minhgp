namespace QuanLyNhanSu.UI
{
    partial class uc_QueQuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QueQuan));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabQueQuan = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvQueQuan = new System.Windows.Forms.DataGridView();
            this.MaQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchQQ = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaQQ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenQQ = new System.Windows.Forms.TextBox();
            this.btnCloseQueQuan = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapNhatQQ = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaQQ = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemQQ = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabQueQuan.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueQuan)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
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
            this.tabControl1.SelectedTabPage = this.tabQueQuan;
            this.tabControl1.Size = new System.Drawing.Size(1063, 580);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabQueQuan});
            // 
            // tabQueQuan
            // 
            this.tabQueQuan.Controls.Add(this.tableLayoutPanel5);
            this.tabQueQuan.Controls.Add(this.tableLayoutPanel4);
            this.tabQueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabQueQuan.Name = "tabQueQuan";
            this.tabQueQuan.PageVisible = false;
            this.tabQueQuan.Size = new System.Drawing.Size(1061, 536);
            this.tabQueQuan.Text = "Quê quán";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dgvQueQuan, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtSearchQQ, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(611, 536);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // dgvQueQuan
            // 
            this.dgvQueQuan.AllowUserToAddRows = false;
            this.dgvQueQuan.AllowUserToDeleteRows = false;
            this.dgvQueQuan.AllowUserToResizeColumns = false;
            this.dgvQueQuan.BackgroundColor = System.Drawing.Color.White;
            this.dgvQueQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQueQuan,
            this.TenQueQuan});
            this.tableLayoutPanel5.SetColumnSpan(this.dgvQueQuan, 2);
            this.dgvQueQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQueQuan.Location = new System.Drawing.Point(3, 29);
            this.dgvQueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQueQuan.MultiSelect = false;
            this.dgvQueQuan.Name = "dgvQueQuan";
            this.dgvQueQuan.ReadOnly = true;
            this.dgvQueQuan.RowHeadersVisible = false;
            this.dgvQueQuan.RowHeadersWidth = 51;
            this.dgvQueQuan.RowTemplate.Height = 30;
            this.dgvQueQuan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQueQuan.Size = new System.Drawing.Size(605, 505);
            this.dgvQueQuan.TabIndex = 0;
            // 
            // MaQueQuan
            // 
            this.MaQueQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaQueQuan.DataPropertyName = "MaQueQuan";
            this.MaQueQuan.HeaderText = "Mã quê quán";
            this.MaQueQuan.MinimumWidth = 6;
            this.MaQueQuan.Name = "MaQueQuan";
            this.MaQueQuan.ReadOnly = true;
            this.MaQueQuan.Width = 110;
            // 
            // TenQueQuan
            // 
            this.TenQueQuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenQueQuan.DataPropertyName = "TenQueQuan";
            this.TenQueQuan.HeaderText = "Tên quê quán";
            this.TenQueQuan.MinimumWidth = 6;
            this.TenQueQuan.Name = "TenQueQuan";
            this.TenQueQuan.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tìm kiếm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchQQ
            // 
            this.txtSearchQQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchQQ.Location = new System.Drawing.Point(83, 2);
            this.txtSearchQQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchQQ.Name = "txtSearchQQ";
            this.txtSearchQQ.Size = new System.Drawing.Size(525, 23);
            this.txtSearchQQ.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtMaQQ, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtTenQQ, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnCloseQueQuan, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel29, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(611, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(450, 536);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã quê quán";
            // 
            // txtMaQQ
            // 
            this.txtMaQQ.Location = new System.Drawing.Point(95, 30);
            this.txtMaQQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaQQ.Name = "txtMaQQ";
            this.txtMaQQ.ReadOnly = true;
            this.txtMaQQ.Size = new System.Drawing.Size(170, 23);
            this.txtMaQQ.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên quê quán";
            // 
            // txtTenQQ
            // 
            this.txtTenQQ.Location = new System.Drawing.Point(95, 62);
            this.txtTenQQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenQQ.Name = "txtTenQQ";
            this.txtTenQQ.Size = new System.Drawing.Size(270, 23);
            this.txtTenQQ.TabIndex = 3;
            // 
            // btnCloseQueQuan
            // 
            this.btnCloseQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseQueQuan.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseQueQuan.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCloseQueQuan.Appearance.Options.UseFont = true;
            this.btnCloseQueQuan.Appearance.Options.UseForeColor = true;
            this.btnCloseQueQuan.Location = new System.Drawing.Point(422, 2);
            this.btnCloseQueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseQueQuan.Name = "btnCloseQueQuan";
            this.btnCloseQueQuan.Size = new System.Drawing.Size(25, 24);
            this.btnCloseQueQuan.TabIndex = 1;
            this.btnCloseQueQuan.Text = "X";
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 3;
            this.tableLayoutPanel4.SetColumnSpan(this.tableLayoutPanel29, 2);
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel29.Controls.Add(this.btnCapNhatQQ, 0, 2);
            this.tableLayoutPanel29.Controls.Add(this.btnXoaQQ, 1, 2);
            this.tableLayoutPanel29.Controls.Add(this.btnThemQQ, 2, 2);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 3;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(444, 445);
            this.tableLayoutPanel29.TabIndex = 5;
            // 
            // btnCapNhatQQ
            // 
            this.btnCapNhatQQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatQQ.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatQQ.Appearance.Options.UseFont = true;
            this.btnCapNhatQQ.Enabled = false;
            this.btnCapNhatQQ.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCapNhatQQ.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatQQ.ImageOptions.SvgImage")));
            this.btnCapNhatQQ.Location = new System.Drawing.Point(3, 274);
            this.btnCapNhatQQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatQQ.Name = "btnCapNhatQQ";
            this.btnCapNhatQQ.Size = new System.Drawing.Size(123, 169);
            this.btnCapNhatQQ.TabIndex = 4;
            this.btnCapNhatQQ.Text = "Cập nhật";
            // 
            // btnXoaQQ
            // 
            this.btnXoaQQ.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaQQ.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaQQ.Appearance.Options.UseFont = true;
            this.btnXoaQQ.Appearance.Options.UseForeColor = true;
            this.btnXoaQQ.Enabled = false;
            this.btnXoaQQ.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaQQ.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaQQ.ImageOptions.SvgImage")));
            this.btnXoaQQ.Location = new System.Drawing.Point(132, 274);
            this.btnXoaQQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaQQ.Name = "btnXoaQQ";
            this.btnXoaQQ.Size = new System.Drawing.Size(117, 169);
            this.btnXoaQQ.TabIndex = 4;
            this.btnXoaQQ.Text = "Xóa";
            // 
            // btnThemQQ
            // 
            this.btnThemQQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemQQ.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemQQ.Appearance.Options.UseFont = true;
            this.btnThemQQ.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThemQQ.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemQQ.ImageOptions.SvgImage")));
            this.btnThemQQ.Location = new System.Drawing.Point(255, 274);
            this.btnThemQQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemQQ.Name = "btnThemQQ";
            this.btnThemQQ.Size = new System.Drawing.Size(186, 169);
            this.btnThemQQ.TabIndex = 4;
            this.btnThemQQ.Text = "Thêm quê quán";
            // 
            // uc_QueQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_QueQuan";
            this.Size = new System.Drawing.Size(1063, 580);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabQueQuan.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueQuan)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel29.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabQueQuan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQueQuan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchQQ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaQQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenQQ;
        private DevExpress.XtraEditors.SimpleButton btnCloseQueQuan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatQQ;
        private DevExpress.XtraEditors.SimpleButton btnXoaQQ;
        private DevExpress.XtraEditors.SimpleButton btnThemQQ;
    }
}
