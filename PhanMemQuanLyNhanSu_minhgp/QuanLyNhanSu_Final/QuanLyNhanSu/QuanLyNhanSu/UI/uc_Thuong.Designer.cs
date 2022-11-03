namespace QuanLyNhanSu.UI
{
    partial class uc_Thuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Thuong));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabKhenThuong = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.label43 = new System.Windows.Forms.Label();
            this.txtSearchKT = new System.Windows.Forms.TextBox();
            this.dgvKhenThuong = new System.Windows.Forms.DataGridView();
            this.STTKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNVKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChuKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label70 = new System.Windows.Forms.Label();
            this.txtTimMNVKT = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCloseKT = new DevExpress.XtraEditors.SimpleButton();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.txtSTTKT = new System.Windows.Forms.TextBox();
            this.txtTenNVKT = new System.Windows.Forms.TextBox();
            this.txtTienThuong = new System.Windows.Forms.TextBox();
            this.txtGhiChuKT = new System.Windows.Forms.RichTextBox();
            this.dateNgayThuong = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapNhatKT = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaKT = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKT = new DevExpress.XtraEditors.SimpleButton();
            this.lbTienThuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabKhenThuong.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).BeginInit();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
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
            this.tabControl1.SelectedTabPage = this.tabKhenThuong;
            this.tabControl1.Size = new System.Drawing.Size(917, 542);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabKhenThuong});
            // 
            // tabKhenThuong
            // 
            this.tabKhenThuong.Controls.Add(this.tableLayoutPanel24);
            this.tabKhenThuong.Controls.Add(this.tableLayoutPanel23);
            this.tabKhenThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabKhenThuong.Name = "tabKhenThuong";
            this.tabKhenThuong.PageVisible = false;
            this.tabKhenThuong.Size = new System.Drawing.Size(915, 507);
            this.tabKhenThuong.Text = "Khen thưởng";
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 4;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel24.Controls.Add(this.label43, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.txtSearchKT, 1, 0);
            this.tableLayoutPanel24.Controls.Add(this.dgvKhenThuong, 0, 1);
            this.tableLayoutPanel24.Controls.Add(this.label70, 2, 0);
            this.tableLayoutPanel24.Controls.Add(this.txtTimMNVKT, 3, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 2;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(465, 507);
            this.tableLayoutPanel24.TabIndex = 1;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(3, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(59, 25);
            this.label43.TabIndex = 0;
            this.label43.Text = "Tìm kiếm";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchKT
            // 
            this.txtSearchKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchKT.Location = new System.Drawing.Point(68, 2);
            this.txtSearchKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchKT.Name = "txtSearchKT";
            this.txtSearchKT.Size = new System.Drawing.Size(205, 21);
            this.txtSearchKT.TabIndex = 1;
            // 
            // dgvKhenThuong
            // 
            this.dgvKhenThuong.AllowUserToAddRows = false;
            this.dgvKhenThuong.AllowUserToDeleteRows = false;
            this.dgvKhenThuong.AllowUserToResizeColumns = false;
            this.dgvKhenThuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTKT,
            this.TenNVKT,
            this.TienThuong,
            this.NgayThuong,
            this.GhiChuKT});
            this.tableLayoutPanel24.SetColumnSpan(this.dgvKhenThuong, 4);
            this.dgvKhenThuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhenThuong.Location = new System.Drawing.Point(3, 27);
            this.dgvKhenThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhenThuong.MultiSelect = false;
            this.dgvKhenThuong.Name = "dgvKhenThuong";
            this.dgvKhenThuong.ReadOnly = true;
            this.dgvKhenThuong.RowHeadersVisible = false;
            this.dgvKhenThuong.RowTemplate.Height = 30;
            this.dgvKhenThuong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhenThuong.Size = new System.Drawing.Size(459, 478);
            this.dgvKhenThuong.TabIndex = 2;
            // 
            // STTKT
            // 
            this.STTKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STTKT.DataPropertyName = "STT";
            this.STTKT.HeaderText = "STT";
            this.STTKT.Name = "STTKT";
            this.STTKT.ReadOnly = true;
            this.STTKT.Width = 50;
            // 
            // TenNVKT
            // 
            this.TenNVKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNVKT.DataPropertyName = "HoTen";
            this.TenNVKT.HeaderText = "Tên nhân viên";
            this.TenNVKT.Name = "TenNVKT";
            this.TenNVKT.ReadOnly = true;
            this.TenNVKT.Width = 92;
            // 
            // TienThuong
            // 
            this.TienThuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TienThuong.DataPropertyName = "TienThuong";
            dataGridViewCellStyle1.Format = "C0";
            this.TienThuong.DefaultCellStyle = dataGridViewCellStyle1;
            this.TienThuong.HeaderText = "Tiền thưởng";
            this.TienThuong.Name = "TienThuong";
            this.TienThuong.ReadOnly = true;
            this.TienThuong.Width = 83;
            // 
            // NgayThuong
            // 
            this.NgayThuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayThuong.DataPropertyName = "NgayThuong";
            this.NgayThuong.HeaderText = "Ngày thưởng";
            this.NgayThuong.Name = "NgayThuong";
            this.NgayThuong.ReadOnly = true;
            this.NgayThuong.Width = 88;
            // 
            // GhiChuKT
            // 
            this.GhiChuKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChuKT.DataPropertyName = "GhiChu";
            this.GhiChuKT.HeaderText = "Nội dung khen thưởng";
            this.GhiChuKT.Name = "GhiChuKT";
            this.GhiChuKT.ReadOnly = true;
            // 
            // label70
            // 
            this.label70.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label70.ForeColor = System.Drawing.Color.Black;
            this.label70.Location = new System.Drawing.Point(279, 5);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(77, 15);
            this.label70.TabIndex = 4;
            this.label70.Text = "Tìm theo mã";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimMNVKT
            // 
            this.txtTimMNVKT.Location = new System.Drawing.Point(362, 2);
            this.txtTimMNVKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimMNVKT.MaxLength = 4;
            this.txtTimMNVKT.Name = "txtTimMNVKT";
            this.txtTimMNVKT.Size = new System.Drawing.Size(100, 21);
            this.txtTimMNVKT.TabIndex = 5;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 2;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Controls.Add(this.btnCloseKT, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.label54, 0, 1);
            this.tableLayoutPanel23.Controls.Add(this.label55, 0, 3);
            this.tableLayoutPanel23.Controls.Add(this.label56, 0, 5);
            this.tableLayoutPanel23.Controls.Add(this.label57, 0, 7);
            this.tableLayoutPanel23.Controls.Add(this.label58, 0, 9);
            this.tableLayoutPanel23.Controls.Add(this.txtSTTKT, 1, 1);
            this.tableLayoutPanel23.Controls.Add(this.txtTenNVKT, 1, 3);
            this.tableLayoutPanel23.Controls.Add(this.txtTienThuong, 1, 5);
            this.tableLayoutPanel23.Controls.Add(this.txtGhiChuKT, 1, 9);
            this.tableLayoutPanel23.Controls.Add(this.dateNgayThuong, 1, 7);
            this.tableLayoutPanel23.Controls.Add(this.tableLayoutPanel25, 0, 10);
            this.tableLayoutPanel23.Controls.Add(this.lbTienThuong, 1, 6);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(465, 0);
            this.tableLayoutPanel23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 11;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(450, 507);
            this.tableLayoutPanel23.TabIndex = 0;
            // 
            // btnCloseKT
            // 
            this.btnCloseKT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseKT.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseKT.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCloseKT.Appearance.Options.UseFont = true;
            this.btnCloseKT.Appearance.Options.UseForeColor = true;
            this.btnCloseKT.Location = new System.Drawing.Point(422, 2);
            this.btnCloseKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseKT.Name = "btnCloseKT";
            this.btnCloseKT.Size = new System.Drawing.Size(25, 25);
            this.btnCloseKT.TabIndex = 4;
            this.btnCloseKT.Text = "X";
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(3, 35);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(25, 13);
            this.label54.TabIndex = 5;
            this.label54.Text = "STT";
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(3, 65);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(75, 13);
            this.label55.TabIndex = 5;
            this.label55.Text = "Tên nhân viên";
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(3, 95);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(65, 13);
            this.label56.TabIndex = 5;
            this.label56.Text = "Tiền thưởng";
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(3, 133);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(70, 13);
            this.label57.TabIndex = 5;
            this.label57.Text = "Ngày thưởng";
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(3, 262);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(64, 13);
            this.label58.TabIndex = 5;
            this.label58.Text = "Nội dung KT";
            // 
            // txtSTTKT
            // 
            this.txtSTTKT.Location = new System.Drawing.Point(84, 31);
            this.txtSTTKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSTTKT.Name = "txtSTTKT";
            this.txtSTTKT.ReadOnly = true;
            this.txtSTTKT.Size = new System.Drawing.Size(130, 21);
            this.txtSTTKT.TabIndex = 6;
            // 
            // txtTenNVKT
            // 
            this.txtTenNVKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNVKT.Location = new System.Drawing.Point(84, 61);
            this.txtTenNVKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNVKT.Name = "txtTenNVKT";
            this.txtTenNVKT.ReadOnly = true;
            this.txtTenNVKT.Size = new System.Drawing.Size(363, 21);
            this.txtTenNVKT.TabIndex = 6;
            // 
            // txtTienThuong
            // 
            this.txtTienThuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTienThuong.Location = new System.Drawing.Point(84, 91);
            this.txtTienThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTienThuong.MaxLength = 13;
            this.txtTienThuong.Name = "txtTienThuong";
            this.txtTienThuong.Size = new System.Drawing.Size(363, 21);
            this.txtTienThuong.TabIndex = 6;
            // 
            // txtGhiChuKT
            // 
            this.txtGhiChuKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChuKT.Location = new System.Drawing.Point(84, 159);
            this.txtGhiChuKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChuKT.Name = "txtGhiChuKT";
            this.txtGhiChuKT.Size = new System.Drawing.Size(363, 219);
            this.txtGhiChuKT.TabIndex = 7;
            this.txtGhiChuKT.Text = "";
            // 
            // dateNgayThuong
            // 
            this.dateNgayThuong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayThuong.Location = new System.Drawing.Point(84, 129);
            this.dateNgayThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayThuong.Name = "dateNgayThuong";
            this.dateNgayThuong.Size = new System.Drawing.Size(130, 21);
            this.dateNgayThuong.TabIndex = 8;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 3;
            this.tableLayoutPanel23.SetColumnSpan(this.tableLayoutPanel25, 2);
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel25.Controls.Add(this.btnXoaKT, 1, 2);
            this.tableLayoutPanel25.Controls.Add(this.btnCapNhatKT, 0, 2);
            this.tableLayoutPanel25.Controls.Add(this.btnThemKT, 2, 2);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(3, 382);
            this.tableLayoutPanel25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 3;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(444, 123);
            this.tableLayoutPanel25.TabIndex = 9;
            // 
            // btnCapNhatKT
            // 
            this.btnCapNhatKT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatKT.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatKT.Appearance.Options.UseFont = true;
            this.btnCapNhatKT.Enabled = false;
            this.btnCapNhatKT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCapNhatKT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatKT.ImageOptions.SvgImage")));
            this.btnCapNhatKT.Location = new System.Drawing.Point(3, 15);
            this.btnCapNhatKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatKT.Name = "btnCapNhatKT";
            this.btnCapNhatKT.Size = new System.Drawing.Size(117, 106);
            this.btnCapNhatKT.TabIndex = 0;
            this.btnCapNhatKT.Text = "Cập nhật";
            // 
            // btnXoaKT
            // 
            this.btnXoaKT.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKT.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaKT.Appearance.Options.UseFont = true;
            this.btnXoaKT.Appearance.Options.UseForeColor = true;
            this.btnXoaKT.Enabled = false;
            this.btnXoaKT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaKT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaKT.ImageOptions.SvgImage")));
            this.btnXoaKT.Location = new System.Drawing.Point(126, 15);
            this.btnXoaKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKT.Name = "btnXoaKT";
            this.btnXoaKT.Size = new System.Drawing.Size(117, 106);
            this.btnXoaKT.TabIndex = 0;
            this.btnXoaKT.Text = "Xóa";
            // 
            // btnThemKT
            // 
            this.btnThemKT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemKT.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKT.Appearance.Options.UseFont = true;
            this.btnThemKT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThemKT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKT.ImageOptions.SvgImage")));
            this.btnThemKT.Location = new System.Drawing.Point(249, 15);
            this.btnThemKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKT.Name = "btnThemKT";
            this.btnThemKT.Size = new System.Drawing.Size(192, 106);
            this.btnThemKT.TabIndex = 0;
            this.btnThemKT.Text = "Thêm khen thưởng";
            // 
            // lbTienThuong
            // 
            this.lbTienThuong.AutoSize = true;
            this.lbTienThuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTienThuong.ForeColor = System.Drawing.Color.Blue;
            this.lbTienThuong.Location = new System.Drawing.Point(84, 114);
            this.lbTienThuong.Name = "lbTienThuong";
            this.lbTienThuong.Size = new System.Drawing.Size(363, 13);
            this.lbTienThuong.TabIndex = 10;
            this.lbTienThuong.Text = "0 đ";
            this.lbTienThuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uc_Thuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_Thuong";
            this.Size = new System.Drawing.Size(917, 542);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabKhenThuong.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).EndInit();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel25.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabKhenThuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtSearchKT;
        private System.Windows.Forms.DataGridView dgvKhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNVKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChuKT;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtTimMNVKT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private DevExpress.XtraEditors.SimpleButton btnCloseKT;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox txtSTTKT;
        private System.Windows.Forms.TextBox txtTenNVKT;
        private System.Windows.Forms.TextBox txtTienThuong;
        private System.Windows.Forms.RichTextBox txtGhiChuKT;
        private System.Windows.Forms.DateTimePicker dateNgayThuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatKT;
        private DevExpress.XtraEditors.SimpleButton btnXoaKT;
        private DevExpress.XtraEditors.SimpleButton btnThemKT;
        private System.Windows.Forms.Label lbTienThuong;
    }
}
