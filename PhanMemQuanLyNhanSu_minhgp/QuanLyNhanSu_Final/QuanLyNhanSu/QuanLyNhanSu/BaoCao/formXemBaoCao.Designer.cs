namespace QuanLyNhanSu.BaoCao
{
    partial class formXemBaoCao
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formXemBaoCao));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHenHanHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNVMThang = new DevExpress.XtraEditors.SimpleButton();
            this.btnNVNThang = new DevExpress.XtraEditors.SimpleButton();
            this.btnNVSapHetHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnNVNQuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnNVNNam = new DevExpress.XtraEditors.SimpleButton();
            this.btnNVMQuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnNVMNam = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatRaExcel = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.dgvNhanVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNVMThang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNVNThang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNVSapHetHD, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNVNQuy, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNVNNam, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNVMQuy, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNVMNam, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXuatRaExcel, 5, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTen,
            this.GioiTinh,
            this.NgayLapHD,
            this.NgayHenHanHD,
            this.TinhTrang});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvNhanVien, 7);
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 129);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowTemplate.Height = 30;
            this.dgvNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.Size = new System.Drawing.Size(930, 323);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhanVien_CellFormatting);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 60;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên nhân viên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 65;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayLapHD.DataPropertyName = "NgayLap";
            this.NgayLapHD.HeaderText = "Ngày lập hợp đồng";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            this.NgayLapHD.Width = 101;
            // 
            // NgayHenHanHD
            // 
            this.NgayHenHanHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayHenHanHD.DataPropertyName = "NgayHetHan";
            this.NgayHenHanHD.HeaderText = "Ngày hết hợp đồng";
            this.NgayHenHanHD.Name = "NgayHenHanHD";
            this.NgayHenHanHD.ReadOnly = true;
            this.NgayHenHanHD.Width = 101;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 105;
            // 
            // btnNVMThang
            // 
            this.btnNVMThang.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVMThang.Appearance.Options.UseFont = true;
            this.btnNVMThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNVMThang.Image = ((System.Drawing.Image)(resources.GetObject("btnNVMThang.Image")));
            this.btnNVMThang.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNVMThang.Location = new System.Drawing.Point(3, 3);
            this.btnNVMThang.Name = "btnNVMThang";
            this.btnNVMThang.Size = new System.Drawing.Size(127, 120);
            this.btnNVMThang.TabIndex = 1;
            this.btnNVMThang.Text = "Nhân viên\r\nmới\r\ntháng này";
            this.btnNVMThang.Click += new System.EventHandler(this.btnNVMThang_Click);
            // 
            // btnNVNThang
            // 
            this.btnNVNThang.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVNThang.Appearance.Options.UseFont = true;
            this.btnNVNThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNVNThang.Image = ((System.Drawing.Image)(resources.GetObject("btnNVNThang.Image")));
            this.btnNVNThang.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNVNThang.Location = new System.Drawing.Point(136, 3);
            this.btnNVNThang.Name = "btnNVNThang";
            this.btnNVNThang.Size = new System.Drawing.Size(127, 120);
            this.btnNVNThang.TabIndex = 1;
            this.btnNVNThang.Text = "Nhân viên\r\nđã nghỉ\r\ntháng này";
            this.btnNVNThang.Click += new System.EventHandler(this.btnNVNThang_Click);
            // 
            // btnNVSapHetHD
            // 
            this.btnNVSapHetHD.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVSapHetHD.Appearance.Options.UseFont = true;
            this.btnNVSapHetHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNVSapHetHD.Image = ((System.Drawing.Image)(resources.GetObject("btnNVSapHetHD.Image")));
            this.btnNVSapHetHD.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNVSapHetHD.Location = new System.Drawing.Point(801, 3);
            this.btnNVSapHetHD.Name = "btnNVSapHetHD";
            this.btnNVSapHetHD.Size = new System.Drawing.Size(132, 120);
            this.btnNVSapHetHD.TabIndex = 1;
            this.btnNVSapHetHD.Text = "Nhân viên\r\nsắp hết hạn\r\nhợp đồng";
            this.btnNVSapHetHD.Click += new System.EventHandler(this.btnNVSapHetHD_Click);
            // 
            // btnNVNQuy
            // 
            this.btnNVNQuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVNQuy.Appearance.Options.UseFont = true;
            this.btnNVNQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNVNQuy.Image = ((System.Drawing.Image)(resources.GetObject("btnNVNQuy.Image")));
            this.btnNVNQuy.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNVNQuy.Location = new System.Drawing.Point(402, 3);
            this.btnNVNQuy.Name = "btnNVNQuy";
            this.btnNVNQuy.Size = new System.Drawing.Size(127, 120);
            this.btnNVNQuy.TabIndex = 1;
            this.btnNVNQuy.Text = "Nhân viên\r\nđã nghỉ\r\nquý này";
            this.btnNVNQuy.Click += new System.EventHandler(this.btnNVNQuy_Click);
            // 
            // btnNVNNam
            // 
            this.btnNVNNam.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVNNam.Appearance.Options.UseFont = true;
            this.btnNVNNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNVNNam.Image = ((System.Drawing.Image)(resources.GetObject("btnNVNNam.Image")));
            this.btnNVNNam.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNVNNam.Location = new System.Drawing.Point(668, 3);
            this.btnNVNNam.Name = "btnNVNNam";
            this.btnNVNNam.Size = new System.Drawing.Size(127, 120);
            this.btnNVNNam.TabIndex = 1;
            this.btnNVNNam.Text = "Nhân viên\r\nđã nghỉ\r\nnăm nay";
            this.btnNVNNam.Click += new System.EventHandler(this.btnNVNNam_Click);
            // 
            // btnNVMQuy
            // 
            this.btnNVMQuy.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVMQuy.Appearance.Options.UseFont = true;
            this.btnNVMQuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNVMQuy.Image = ((System.Drawing.Image)(resources.GetObject("btnNVMQuy.Image")));
            this.btnNVMQuy.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNVMQuy.Location = new System.Drawing.Point(269, 3);
            this.btnNVMQuy.Name = "btnNVMQuy";
            this.btnNVMQuy.Size = new System.Drawing.Size(127, 120);
            this.btnNVMQuy.TabIndex = 1;
            this.btnNVMQuy.Text = "Nhân viên\r\nmới\r\nquý này";
            this.btnNVMQuy.Click += new System.EventHandler(this.btnNVMQuy_Click);
            // 
            // btnNVMNam
            // 
            this.btnNVMNam.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVMNam.Appearance.Options.UseFont = true;
            this.btnNVMNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNVMNam.Image = ((System.Drawing.Image)(resources.GetObject("btnNVMNam.Image")));
            this.btnNVMNam.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNVMNam.Location = new System.Drawing.Point(535, 3);
            this.btnNVMNam.Name = "btnNVMNam";
            this.btnNVMNam.Size = new System.Drawing.Size(127, 120);
            this.btnNVMNam.TabIndex = 1;
            this.btnNVMNam.Text = "Nhân viên\r\nmới\r\nnăm nay";
            this.btnNVMNam.Click += new System.EventHandler(this.btnNVMNam_Click);
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatRaExcel.Appearance.Options.UseFont = true;
            this.tableLayoutPanel1.SetColumnSpan(this.btnXuatRaExcel, 2);
            this.btnXuatRaExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXuatRaExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.Image")));
            this.btnXuatRaExcel.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(668, 458);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(265, 50);
            this.btnXuatRaExcel.TabIndex = 2;
            this.btnXuatRaExcel.Text = "Xuất báo cáo ra Excel";
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // formXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formXemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem báo cáo";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnNVMThang;
        private DevExpress.XtraEditors.SimpleButton btnNVNThang;
        private DevExpress.XtraEditors.SimpleButton btnNVSapHetHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHenHanHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private DevExpress.XtraEditors.SimpleButton btnNVNQuy;
        private DevExpress.XtraEditors.SimpleButton btnNVNNam;
        private DevExpress.XtraEditors.SimpleButton btnNVMQuy;
        private DevExpress.XtraEditors.SimpleButton btnNVMNam;
        private DevExpress.XtraEditors.SimpleButton btnXuatRaExcel;
    }
}