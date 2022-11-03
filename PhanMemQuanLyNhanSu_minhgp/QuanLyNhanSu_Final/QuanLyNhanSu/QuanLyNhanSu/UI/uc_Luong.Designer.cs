namespace QuanLyNhanSu.UI
{
    partial class uc_Luong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Luong));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPhatLuong = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.label48 = new System.Windows.Forms.Label();
            this.txtSearchPL = new System.Windows.Forms.TextBox();
            this.dgvPhatLuong = new System.Windows.Forms.DataGridView();
            this.STTPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVienPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChuPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label69 = new System.Windows.Forms.Label();
            this.txtTimMNVPL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClosePhatLuong = new DevExpress.XtraEditors.SimpleButton();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtSTTPL = new System.Windows.Forms.TextBox();
            this.txtTenNVPL = new System.Windows.Forms.TextBox();
            this.txtTongLanh = new System.Windows.Forms.TextBox();
            this.dateNgayLanh = new System.Windows.Forms.DateTimePicker();
            this.label53 = new System.Windows.Forms.Label();
            this.txtGhiChuPL = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoaPL = new DevExpress.XtraEditors.SimpleButton();
            this.btnCHPL = new DevExpress.XtraEditors.SimpleButton();
            this.lbTongLanh = new System.Windows.Forms.Label();
            this.btnDSTU = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPL = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatPL = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPhatLuong.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatLuong)).BeginInit();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
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
            this.tabControl1.SelectedTabPage = this.tabPhatLuong;
            this.tabControl1.Size = new System.Drawing.Size(835, 546);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPhatLuong});
            this.tabControl1.TabStop = false;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPhatLuong
            // 
            this.tabPhatLuong.Controls.Add(this.tableLayoutPanel21);
            this.tabPhatLuong.Controls.Add(this.tableLayoutPanel20);
            this.tabPhatLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPhatLuong.Name = "tabPhatLuong";
            this.tabPhatLuong.PageVisible = false;
            this.tabPhatLuong.Size = new System.Drawing.Size(833, 511);
            this.tabPhatLuong.Text = "Phát lương";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 4;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel21.Controls.Add(this.label48, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.txtSearchPL, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.dgvPhatLuong, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.label69, 2, 0);
            this.tableLayoutPanel21.Controls.Add(this.txtTimMNVPL, 3, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(383, 511);
            this.tableLayoutPanel21.TabIndex = 5;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(3, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(59, 25);
            this.label48.TabIndex = 0;
            this.label48.Text = "Tìm kiếm";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchPL
            // 
            this.txtSearchPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchPL.Location = new System.Drawing.Point(68, 2);
            this.txtSearchPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchPL.Name = "txtSearchPL";
            this.txtSearchPL.Size = new System.Drawing.Size(123, 21);
            this.txtSearchPL.TabIndex = 1;
            // 
            // dgvPhatLuong
            // 
            this.dgvPhatLuong.AllowUserToAddRows = false;
            this.dgvPhatLuong.AllowUserToDeleteRows = false;
            this.dgvPhatLuong.AllowUserToResizeColumns = false;
            this.dgvPhatLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhatLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhatLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTPL,
            this.TenNhanVienPL,
            this.NgayLanh,
            this.TongLanh,
            this.GhiChuPL});
            this.tableLayoutPanel21.SetColumnSpan(this.dgvPhatLuong, 4);
            this.dgvPhatLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhatLuong.Location = new System.Drawing.Point(3, 27);
            this.dgvPhatLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhatLuong.MultiSelect = false;
            this.dgvPhatLuong.Name = "dgvPhatLuong";
            this.dgvPhatLuong.ReadOnly = true;
            this.dgvPhatLuong.RowHeadersVisible = false;
            this.dgvPhatLuong.RowTemplate.Height = 30;
            this.dgvPhatLuong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhatLuong.Size = new System.Drawing.Size(377, 482);
            this.dgvPhatLuong.TabIndex = 2;
            // 
            // STTPL
            // 
            this.STTPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STTPL.DataPropertyName = "STT";
            this.STTPL.HeaderText = "STT";
            this.STTPL.Name = "STTPL";
            this.STTPL.ReadOnly = true;
            this.STTPL.Width = 50;
            // 
            // TenNhanVienPL
            // 
            this.TenNhanVienPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNhanVienPL.DataPropertyName = "HoTen";
            this.TenNhanVienPL.HeaderText = "Tên nhân viên";
            this.TenNhanVienPL.Name = "TenNhanVienPL";
            this.TenNhanVienPL.ReadOnly = true;
            this.TenNhanVienPL.Width = 92;
            // 
            // NgayLanh
            // 
            this.NgayLanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayLanh.DataPropertyName = "NgayLanh";
            this.NgayLanh.HeaderText = "Ngày lãnh";
            this.NgayLanh.Name = "NgayLanh";
            this.NgayLanh.ReadOnly = true;
            this.NgayLanh.Width = 74;
            // 
            // TongLanh
            // 
            this.TongLanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TongLanh.DataPropertyName = "TongLanh";
            dataGridViewCellStyle1.Format = "C0";
            this.TongLanh.DefaultCellStyle = dataGridViewCellStyle1;
            this.TongLanh.HeaderText = "Tổng lãnh";
            this.TongLanh.Name = "TongLanh";
            this.TongLanh.ReadOnly = true;
            this.TongLanh.Width = 73;
            // 
            // GhiChuPL
            // 
            this.GhiChuPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChuPL.DataPropertyName = "GhiChu";
            this.GhiChuPL.HeaderText = "Ghi chú";
            this.GhiChuPL.Name = "GhiChuPL";
            this.GhiChuPL.ReadOnly = true;
            // 
            // label69
            // 
            this.label69.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label69.ForeColor = System.Drawing.Color.Black;
            this.label69.Location = new System.Drawing.Point(197, 5);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(77, 15);
            this.label69.TabIndex = 3;
            this.label69.Text = "Tìm theo mã";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimMNVPL
            // 
            this.txtTimMNVPL.Location = new System.Drawing.Point(280, 2);
            this.txtTimMNVPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimMNVPL.MaxLength = 4;
            this.txtTimMNVPL.Name = "txtTimMNVPL";
            this.txtTimMNVPL.Size = new System.Drawing.Size(100, 21);
            this.txtTimMNVPL.TabIndex = 4;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 2;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.btnClosePhatLuong, 1, 0);
            this.tableLayoutPanel20.Controls.Add(this.label49, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.label50, 0, 3);
            this.tableLayoutPanel20.Controls.Add(this.label51, 0, 5);
            this.tableLayoutPanel20.Controls.Add(this.label52, 0, 7);
            this.tableLayoutPanel20.Controls.Add(this.txtSTTPL, 1, 1);
            this.tableLayoutPanel20.Controls.Add(this.txtTenNVPL, 1, 3);
            this.tableLayoutPanel20.Controls.Add(this.txtTongLanh, 1, 7);
            this.tableLayoutPanel20.Controls.Add(this.dateNgayLanh, 1, 5);
            this.tableLayoutPanel20.Controls.Add(this.label53, 0, 9);
            this.tableLayoutPanel20.Controls.Add(this.txtGhiChuPL, 1, 9);
            this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel22, 0, 10);
            this.tableLayoutPanel20.Controls.Add(this.lbTongLanh, 1, 8);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(383, 0);
            this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 11;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(450, 511);
            this.tableLayoutPanel20.TabIndex = 4;
            // 
            // btnClosePhatLuong
            // 
            this.btnClosePhatLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePhatLuong.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePhatLuong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnClosePhatLuong.Appearance.Options.UseFont = true;
            this.btnClosePhatLuong.Appearance.Options.UseForeColor = true;
            this.btnClosePhatLuong.Location = new System.Drawing.Point(422, 2);
            this.btnClosePhatLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClosePhatLuong.Name = "btnClosePhatLuong";
            this.btnClosePhatLuong.Size = new System.Drawing.Size(25, 25);
            this.btnClosePhatLuong.TabIndex = 3;
            this.btnClosePhatLuong.Text = "X";
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(3, 35);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(25, 13);
            this.label49.TabIndex = 4;
            this.label49.Text = "STT";
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(3, 65);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(75, 13);
            this.label50.TabIndex = 4;
            this.label50.Text = "Tên nhân viên";
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(3, 95);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(55, 13);
            this.label51.TabIndex = 4;
            this.label51.Text = "Ngày lãnh";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(3, 125);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(54, 13);
            this.label52.TabIndex = 4;
            this.label52.Text = "Tổng lãnh";
            // 
            // txtSTTPL
            // 
            this.txtSTTPL.Location = new System.Drawing.Point(84, 31);
            this.txtSTTPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSTTPL.Name = "txtSTTPL";
            this.txtSTTPL.ReadOnly = true;
            this.txtSTTPL.Size = new System.Drawing.Size(130, 21);
            this.txtSTTPL.TabIndex = 5;
            // 
            // txtTenNVPL
            // 
            this.txtTenNVPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNVPL.Location = new System.Drawing.Point(84, 61);
            this.txtTenNVPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNVPL.Name = "txtTenNVPL";
            this.txtTenNVPL.ReadOnly = true;
            this.txtTenNVPL.Size = new System.Drawing.Size(363, 21);
            this.txtTenNVPL.TabIndex = 5;
            // 
            // txtTongLanh
            // 
            this.txtTongLanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongLanh.Location = new System.Drawing.Point(84, 121);
            this.txtTongLanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongLanh.Name = "txtTongLanh";
            this.txtTongLanh.ReadOnly = true;
            this.txtTongLanh.Size = new System.Drawing.Size(363, 21);
            this.txtTongLanh.TabIndex = 5;
            // 
            // dateNgayLanh
            // 
            this.dateNgayLanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLanh.Location = new System.Drawing.Point(84, 91);
            this.dateNgayLanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayLanh.Name = "dateNgayLanh";
            this.dateNgayLanh.Size = new System.Drawing.Size(130, 21);
            this.dateNgayLanh.TabIndex = 6;
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(3, 192);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(42, 13);
            this.label53.TabIndex = 4;
            this.label53.Text = "Ghi chú";
            // 
            // txtGhiChuPL
            // 
            this.txtGhiChuPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChuPL.Location = new System.Drawing.Point(84, 159);
            this.txtGhiChuPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChuPL.Name = "txtGhiChuPL";
            this.txtGhiChuPL.Size = new System.Drawing.Size(363, 80);
            this.txtGhiChuPL.TabIndex = 7;
            this.txtGhiChuPL.Text = "";
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 3;
            this.tableLayoutPanel20.SetColumnSpan(this.tableLayoutPanel22, 2);
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel22.Controls.Add(this.btnDSTU, 0, 4);
            this.tableLayoutPanel22.Controls.Add(this.btnCHPL, 2, 4);
            this.tableLayoutPanel22.Controls.Add(this.btnXoaPL, 1, 3);
            this.tableLayoutPanel22.Controls.Add(this.btnCapNhatPL, 0, 3);
            this.tableLayoutPanel22.Controls.Add(this.btnThemPL, 2, 3);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanel22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 5;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(444, 266);
            this.tableLayoutPanel22.TabIndex = 8;
            // 
            // btnXoaPL
            // 
            this.btnXoaPL.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPL.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaPL.Appearance.Options.UseFont = true;
            this.btnXoaPL.Appearance.Options.UseForeColor = true;
            this.btnXoaPL.Enabled = false;
            this.btnXoaPL.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaPL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaPL.ImageOptions.SvgImage")));
            this.btnXoaPL.Location = new System.Drawing.Point(118, 2);
            this.btnXoaPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPL.Name = "btnXoaPL";
            this.btnXoaPL.Size = new System.Drawing.Size(109, 128);
            this.btnXoaPL.TabIndex = 0;
            this.btnXoaPL.Text = "Xóa";
            // 
            // btnCHPL
            // 
            this.btnCHPL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCHPL.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHPL.Appearance.Options.UseFont = true;
            this.btnCHPL.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCHPL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHPL.ImageOptions.SvgImage")));
            this.btnCHPL.Location = new System.Drawing.Point(233, 134);
            this.btnCHPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCHPL.Name = "btnCHPL";
            this.btnCHPL.Size = new System.Drawing.Size(208, 130);
            this.btnCHPL.TabIndex = 0;
            this.btnCHPL.Text = "Cấu hình phát lương";
            // 
            // lbTongLanh
            // 
            this.lbTongLanh.AutoSize = true;
            this.lbTongLanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTongLanh.ForeColor = System.Drawing.Color.Blue;
            this.lbTongLanh.Location = new System.Drawing.Point(84, 144);
            this.lbTongLanh.Name = "lbTongLanh";
            this.lbTongLanh.Size = new System.Drawing.Size(363, 13);
            this.lbTongLanh.TabIndex = 9;
            this.lbTongLanh.Text = "0 đ";
            this.lbTongLanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDSTU
            // 
            this.btnDSTU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDSTU.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSTU.Appearance.Options.UseFont = true;
            this.tableLayoutPanel22.SetColumnSpan(this.btnDSTU, 2);
            this.btnDSTU.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDSTU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDSTU.ImageOptions.SvgImage")));
            this.btnDSTU.Location = new System.Drawing.Point(3, 134);
            this.btnDSTU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSTU.Name = "btnDSTU";
            this.btnDSTU.Size = new System.Drawing.Size(224, 128);
            this.btnDSTU.TabIndex = 0;
            this.btnDSTU.Text = "Danh sách tạm ứng";
            // 
            // btnThemPL
            // 
            this.btnThemPL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemPL.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPL.Appearance.Options.UseFont = true;
            this.btnThemPL.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThemPL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPL.ImageOptions.SvgImage")));
            this.btnThemPL.Location = new System.Drawing.Point(233, 2);
            this.btnThemPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPL.Name = "btnThemPL";
            this.btnThemPL.Size = new System.Drawing.Size(208, 128);
            this.btnThemPL.TabIndex = 0;
            this.btnThemPL.Text = "Thêm phát lương";
            // 
            // btnCapNhatPL
            // 
            this.btnCapNhatPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatPL.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatPL.Appearance.Options.UseFont = true;
            this.btnCapNhatPL.Enabled = false;
            this.btnCapNhatPL.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCapNhatPL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatPL.ImageOptions.SvgImage")));
            this.btnCapNhatPL.Location = new System.Drawing.Point(3, 2);
            this.btnCapNhatPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatPL.Name = "btnCapNhatPL";
            this.btnCapNhatPL.Size = new System.Drawing.Size(109, 128);
            this.btnCapNhatPL.TabIndex = 0;
            this.btnCapNhatPL.Text = "Cập nhật";
            // 
            // uc_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_Luong";
            this.Size = new System.Drawing.Size(835, 546);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPhatLuong.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatLuong)).EndInit();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPhatLuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtSearchPL;
        private System.Windows.Forms.DataGridView dgvPhatLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVienPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChuPL;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox txtTimMNVPL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private DevExpress.XtraEditors.SimpleButton btnClosePhatLuong;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtSTTPL;
        private System.Windows.Forms.TextBox txtTenNVPL;
        private System.Windows.Forms.TextBox txtTongLanh;
        private System.Windows.Forms.DateTimePicker dateNgayLanh;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.RichTextBox txtGhiChuPL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private DevExpress.XtraEditors.SimpleButton btnXoaPL;
        private DevExpress.XtraEditors.SimpleButton btnCHPL;
        private System.Windows.Forms.Label lbTongLanh;
        private DevExpress.XtraEditors.SimpleButton btnDSTU;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatPL;
        private DevExpress.XtraEditors.SimpleButton btnThemPL;
    }
}
