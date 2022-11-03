namespace QuanLyNhanSu.UI
{
    partial class uc_DiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_DiemDanh));
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabDiemDanh = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label41 = new System.Windows.Forms.Label();
            this.txtSearchDD = new System.Windows.Forms.TextBox();
            this.dgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.SttDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNVDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label68 = new System.Windows.Forms.Label();
            this.txtTimMNVDD = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label42 = new System.Windows.Forms.Label();
            this.txtTenNVDD = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtSoNgayVang = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.dateNgayVang = new System.Windows.Forms.DateTimePicker();
            this.label46 = new System.Windows.Forms.Label();
            this.txtLyDoVang = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapNhatDD = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDD = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhDauVang = new DevExpress.XtraEditors.SimpleButton();
            this.label47 = new System.Windows.Forms.Label();
            this.txtSTTDD = new System.Windows.Forms.TextBox();
            this.btnCloseDiemDanh = new DevExpress.XtraEditors.SimpleButton();
            this.label65 = new System.Windows.Forms.Label();
            this.txtSoNgayTC = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.txtLoaiDD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDiemDanh.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).BeginInit();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
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
            this.tabControl1.SelectedTabPage = this.tabDiemDanh;
            this.tabControl1.Size = new System.Drawing.Size(866, 539);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabDiemDanh});
            // 
            // tabDiemDanh
            // 
            this.tabDiemDanh.Controls.Add(this.tableLayoutPanel18);
            this.tabDiemDanh.Controls.Add(this.tableLayoutPanel17);
            this.tabDiemDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDiemDanh.Name = "tabDiemDanh";
            this.tabDiemDanh.PageVisible = false;
            this.tabDiemDanh.Size = new System.Drawing.Size(864, 504);
            this.tabDiemDanh.Text = "Điểm danh";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 4;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.Controls.Add(this.label41, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.txtSearchDD, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.dgvDiemDanh, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.label68, 2, 0);
            this.tableLayoutPanel18.Controls.Add(this.txtTimMNVDD, 3, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(414, 504);
            this.tableLayoutPanel18.TabIndex = 4;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(3, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 25);
            this.label41.TabIndex = 0;
            this.label41.Text = "Tìm kiếm";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchDD
            // 
            this.txtSearchDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchDD.Location = new System.Drawing.Point(68, 2);
            this.txtSearchDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchDD.Name = "txtSearchDD";
            this.txtSearchDD.Size = new System.Drawing.Size(97, 21);
            this.txtSearchDD.TabIndex = 1;
            // 
            // dgvDiemDanh
            // 
            this.dgvDiemDanh.AllowUserToAddRows = false;
            this.dgvDiemDanh.AllowUserToDeleteRows = false;
            this.dgvDiemDanh.AllowUserToResizeColumns = false;
            this.dgvDiemDanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SttDD,
            this.TenNVDD,
            this.LoaiDiemDanh,
            this.NgayVang,
            this.LyDo});
            this.tableLayoutPanel18.SetColumnSpan(this.dgvDiemDanh, 4);
            this.dgvDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemDanh.Location = new System.Drawing.Point(3, 27);
            this.dgvDiemDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDiemDanh.MultiSelect = false;
            this.dgvDiemDanh.Name = "dgvDiemDanh";
            this.dgvDiemDanh.ReadOnly = true;
            this.dgvDiemDanh.RowHeadersVisible = false;
            this.dgvDiemDanh.RowTemplate.Height = 30;
            this.dgvDiemDanh.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemDanh.Size = new System.Drawing.Size(408, 475);
            this.dgvDiemDanh.TabIndex = 2;
            // 
            // SttDD
            // 
            this.SttDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SttDD.DataPropertyName = "STT";
            this.SttDD.HeaderText = "STT";
            this.SttDD.Name = "SttDD";
            this.SttDD.ReadOnly = true;
            this.SttDD.Width = 50;
            // 
            // TenNVDD
            // 
            this.TenNVDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNVDD.DataPropertyName = "HoTen";
            this.TenNVDD.HeaderText = "Tên nhân viên";
            this.TenNVDD.Name = "TenNVDD";
            this.TenNVDD.ReadOnly = true;
            this.TenNVDD.Width = 92;
            // 
            // LoaiDiemDanh
            // 
            this.LoaiDiemDanh.DataPropertyName = "LoaiDiemDanh";
            this.LoaiDiemDanh.HeaderText = "Loại điểm danh";
            this.LoaiDiemDanh.Name = "LoaiDiemDanh";
            this.LoaiDiemDanh.ReadOnly = true;
            // 
            // NgayVang
            // 
            this.NgayVang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayVang.DataPropertyName = "NgayDiemDanh";
            this.NgayVang.HeaderText = "Ngày điểm danh";
            this.NgayVang.Name = "NgayVang";
            this.NgayVang.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // label68
            // 
            this.label68.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(171, 5);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(134, 15);
            this.label68.TabIndex = 3;
            this.label68.Text = "Tìm theo mã nhân viên";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimMNVDD
            // 
            this.txtTimMNVDD.Location = new System.Drawing.Point(311, 2);
            this.txtTimMNVDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimMNVDD.MaxLength = 4;
            this.txtTimMNVDD.Name = "txtTimMNVDD";
            this.txtTimMNVDD.Size = new System.Drawing.Size(100, 21);
            this.txtTimMNVDD.TabIndex = 4;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel17.Controls.Add(this.label42, 0, 3);
            this.tableLayoutPanel17.Controls.Add(this.txtTenNVDD, 1, 3);
            this.tableLayoutPanel17.Controls.Add(this.label44, 0, 7);
            this.tableLayoutPanel17.Controls.Add(this.txtSoNgayVang, 1, 7);
            this.tableLayoutPanel17.Controls.Add(this.label45, 0, 11);
            this.tableLayoutPanel17.Controls.Add(this.dateNgayVang, 1, 11);
            this.tableLayoutPanel17.Controls.Add(this.label46, 0, 13);
            this.tableLayoutPanel17.Controls.Add(this.txtLyDoVang, 1, 13);
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel19, 0, 14);
            this.tableLayoutPanel17.Controls.Add(this.label47, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.txtSTTDD, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.btnCloseDiemDanh, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.label65, 0, 9);
            this.tableLayoutPanel17.Controls.Add(this.txtSoNgayTC, 1, 9);
            this.tableLayoutPanel17.Controls.Add(this.label66, 0, 5);
            this.tableLayoutPanel17.Controls.Add(this.txtLoaiDD, 1, 5);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(414, 0);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 15;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(450, 504);
            this.tableLayoutPanel17.TabIndex = 3;
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 65);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(75, 13);
            this.label42.TabIndex = 3;
            this.label42.Text = "Tên nhân viên";
            // 
            // txtTenNVDD
            // 
            this.txtTenNVDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNVDD.Location = new System.Drawing.Point(97, 61);
            this.txtTenNVDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNVDD.Name = "txtTenNVDD";
            this.txtTenNVDD.ReadOnly = true;
            this.txtTenNVDD.Size = new System.Drawing.Size(350, 21);
            this.txtTenNVDD.TabIndex = 4;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 125);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(88, 13);
            this.label44.TabIndex = 3;
            this.label44.Text = "Số ngày đã vắng";
            // 
            // txtSoNgayVang
            // 
            this.txtSoNgayVang.Location = new System.Drawing.Point(97, 121);
            this.txtSoNgayVang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoNgayVang.Name = "txtSoNgayVang";
            this.txtSoNgayVang.ReadOnly = true;
            this.txtSoNgayVang.Size = new System.Drawing.Size(130, 21);
            this.txtSoNgayVang.TabIndex = 4;
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(3, 185);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(84, 13);
            this.label45.TabIndex = 3;
            this.label45.Text = "Ngày điểm danh";
            // 
            // dateNgayVang
            // 
            this.dateNgayVang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayVang.Location = new System.Drawing.Point(97, 181);
            this.dateNgayVang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayVang.Name = "dateNgayVang";
            this.dateNgayVang.Size = new System.Drawing.Size(130, 21);
            this.dateNgayVang.TabIndex = 6;
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 249);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(33, 13);
            this.label46.TabIndex = 3;
            this.label46.Text = "Lý do";
            // 
            // txtLyDoVang
            // 
            this.txtLyDoVang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLyDoVang.Location = new System.Drawing.Point(97, 211);
            this.txtLyDoVang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLyDoVang.Name = "txtLyDoVang";
            this.txtLyDoVang.Size = new System.Drawing.Size(350, 90);
            this.txtLyDoVang.TabIndex = 7;
            this.txtLyDoVang.Text = "";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel17.SetColumnSpan(this.tableLayoutPanel19, 2);
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.19355F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.80645F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel19.Controls.Add(this.btnDanhDauVang, 2, 2);
            this.tableLayoutPanel19.Controls.Add(this.btnXoaDD, 1, 2);
            this.tableLayoutPanel19.Controls.Add(this.btnCapNhatDD, 0, 2);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 305);
            this.tableLayoutPanel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 3;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(444, 197);
            this.tableLayoutPanel19.TabIndex = 8;
            // 
            // btnCapNhatDD
            // 
            this.btnCapNhatDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatDD.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDD.Appearance.Options.UseFont = true;
            this.btnCapNhatDD.Enabled = false;
            this.btnCapNhatDD.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCapNhatDD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapNhatDD.ImageOptions.SvgImage")));
            this.btnCapNhatDD.Location = new System.Drawing.Point(3, 73);
            this.btnCapNhatDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatDD.Name = "btnCapNhatDD";
            this.btnCapNhatDD.Size = new System.Drawing.Size(116, 122);
            this.btnCapNhatDD.TabIndex = 0;
            this.btnCapNhatDD.Text = "Cập nhật";
            // 
            // btnXoaDD
            // 
            this.btnXoaDD.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDD.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaDD.Appearance.Options.UseFont = true;
            this.btnXoaDD.Appearance.Options.UseForeColor = true;
            this.btnXoaDD.Enabled = false;
            this.btnXoaDD.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaDD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaDD.ImageOptions.SvgImage")));
            this.btnXoaDD.Location = new System.Drawing.Point(125, 73);
            this.btnXoaDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDD.Name = "btnXoaDD";
            this.btnXoaDD.Size = new System.Drawing.Size(120, 122);
            this.btnXoaDD.TabIndex = 0;
            this.btnXoaDD.Text = "Xóa";
            // 
            // btnDanhDauVang
            // 
            this.btnDanhDauVang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDanhDauVang.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhDauVang.Appearance.Options.UseFont = true;
            this.btnDanhDauVang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDanhDauVang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanhDauVang.ImageOptions.SvgImage")));
            this.btnDanhDauVang.Location = new System.Drawing.Point(251, 73);
            this.btnDanhDauVang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhDauVang.Name = "btnDanhDauVang";
            this.btnDanhDauVang.Size = new System.Drawing.Size(190, 122);
            this.btnDanhDauVang.TabIndex = 0;
            this.btnDanhDauVang.Text = "Thêm điểm danh";
            this.btnDanhDauVang.Click += new System.EventHandler(this.btnDanhDauVang_Click);
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(3, 35);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(25, 13);
            this.label47.TabIndex = 3;
            this.label47.Text = "STT";
            // 
            // txtSTTDD
            // 
            this.txtSTTDD.Location = new System.Drawing.Point(97, 31);
            this.txtSTTDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSTTDD.Name = "txtSTTDD";
            this.txtSTTDD.ReadOnly = true;
            this.txtSTTDD.Size = new System.Drawing.Size(130, 21);
            this.txtSTTDD.TabIndex = 4;
            // 
            // btnCloseDiemDanh
            // 
            this.btnCloseDiemDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseDiemDanh.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDiemDanh.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnCloseDiemDanh.Appearance.Options.UseFont = true;
            this.btnCloseDiemDanh.Appearance.Options.UseForeColor = true;
            this.btnCloseDiemDanh.Location = new System.Drawing.Point(422, 2);
            this.btnCloseDiemDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseDiemDanh.Name = "btnCloseDiemDanh";
            this.btnCloseDiemDanh.Size = new System.Drawing.Size(25, 25);
            this.btnCloseDiemDanh.TabIndex = 2;
            this.btnCloseDiemDanh.Text = "X";
            // 
            // label65
            // 
            this.label65.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(3, 155);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(85, 13);
            this.label65.TabIndex = 3;
            this.label65.Text = "Số ngày tăng ca";
            // 
            // txtSoNgayTC
            // 
            this.txtSoNgayTC.Location = new System.Drawing.Point(97, 151);
            this.txtSoNgayTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoNgayTC.Name = "txtSoNgayTC";
            this.txtSoNgayTC.ReadOnly = true;
            this.txtSoNgayTC.Size = new System.Drawing.Size(130, 21);
            this.txtSoNgayTC.TabIndex = 4;
            // 
            // label66
            // 
            this.label66.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(3, 95);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(78, 13);
            this.label66.TabIndex = 3;
            this.label66.Text = "Loại điểm danh";
            // 
            // txtLoaiDD
            // 
            this.txtLoaiDD.Location = new System.Drawing.Point(97, 91);
            this.txtLoaiDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiDD.Name = "txtLoaiDD";
            this.txtLoaiDD.ReadOnly = true;
            this.txtLoaiDD.Size = new System.Drawing.Size(130, 21);
            this.txtLoaiDD.TabIndex = 4;
            // 
            // uc_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uc_DiemDanh";
            this.Size = new System.Drawing.Size(866, 539);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDiemDanh.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).EndInit();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage tabDiemDanh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtSearchDD;
        private System.Windows.Forms.DataGridView dgvDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SttDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNVDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtTimMNVDD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtTenNVDD;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtSoNgayVang;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.DateTimePicker dateNgayVang;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.RichTextBox txtLyDoVang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatDD;
        private DevExpress.XtraEditors.SimpleButton btnXoaDD;
        private DevExpress.XtraEditors.SimpleButton btnDanhDauVang;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtSTTDD;
        private DevExpress.XtraEditors.SimpleButton btnCloseDiemDanh;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox txtSoNgayTC;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox txtLoaiDD;
    }
}
