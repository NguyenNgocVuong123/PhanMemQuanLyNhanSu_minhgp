namespace QuanLyNhanSu
{
    partial class frmM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmM));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mnhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mphongban = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mchucvu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mchuyenmon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mdiemdanh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mluong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mthuong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mhopdong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Mbaocao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Ctaikhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Cthongtin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Cthoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(595, 519);
            this.fluentDesignFormContainer1.TabIndex = 0;
            this.fluentDesignFormContainer1.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement11});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 519);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.accordionControlElement1.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Mnhanvien,
            this.Mphongban,
            this.Mchucvu,
            this.Mchuyenmon,
            this.Mdiemdanh,
            this.Mluong,
            this.Mthuong,
            this.Mhopdong,
            this.Mbaocao});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Menu";
            // 
            // Mnhanvien
            // 
            this.Mnhanvien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mnhanvien.ImageOptions.SvgImage")));
            this.Mnhanvien.Name = "Mnhanvien";
            this.Mnhanvien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mnhanvien.Text = "Nhân viên";
            this.Mnhanvien.Click += new System.EventHandler(this.Mnhanvien_Click);
            // 
            // Mphongban
            // 
            this.Mphongban.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mphongban.ImageOptions.SvgImage")));
            this.Mphongban.Name = "Mphongban";
            this.Mphongban.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mphongban.Text = "Phòng ban";
            this.Mphongban.Click += new System.EventHandler(this.Mphongban_Click);
            // 
            // Mchucvu
            // 
            this.Mchucvu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mchucvu.ImageOptions.SvgImage")));
            this.Mchucvu.Name = "Mchucvu";
            this.Mchucvu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mchucvu.Text = "Chức vụ";
            this.Mchucvu.Click += new System.EventHandler(this.Mchucvu_Click);
            // 
            // Mchuyenmon
            // 
            this.Mchuyenmon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mchuyenmon.ImageOptions.SvgImage")));
            this.Mchuyenmon.Name = "Mchuyenmon";
            this.Mchuyenmon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mchuyenmon.Text = "Chuyên môn";
            // 
            // Mdiemdanh
            // 
            this.Mdiemdanh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mdiemdanh.ImageOptions.SvgImage")));
            this.Mdiemdanh.Name = "Mdiemdanh";
            this.Mdiemdanh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mdiemdanh.Text = "Điểm danh";
            this.Mdiemdanh.Click += new System.EventHandler(this.Mdiemdanh_Click);
            // 
            // Mluong
            // 
            this.Mluong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mluong.ImageOptions.SvgImage")));
            this.Mluong.Name = "Mluong";
            this.Mluong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mluong.Text = "Lương";
            this.Mluong.Click += new System.EventHandler(this.Mluong_Click);
            // 
            // Mthuong
            // 
            this.Mthuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mthuong.ImageOptions.SvgImage")));
            this.Mthuong.Name = "Mthuong";
            this.Mthuong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mthuong.Text = "Thưởng";
            // 
            // Mhopdong
            // 
            this.Mhopdong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mhopdong.ImageOptions.SvgImage")));
            this.Mhopdong.Name = "Mhopdong";
            this.Mhopdong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mhopdong.Text = "Hợp đồng";
            // 
            // Mbaocao
            // 
            this.Mbaocao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Mbaocao.ImageOptions.SvgImage")));
            this.Mbaocao.Name = "Mbaocao";
            this.Mbaocao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Mbaocao.Text = "Báo cáo";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Ctaikhoan,
            this.Cthongtin,
            this.Cthoat});
            this.accordionControlElement11.Expanded = true;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Text = "Cài đặt";
            // 
            // Ctaikhoan
            // 
            this.Ctaikhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Ctaikhoan.ImageOptions.SvgImage")));
            this.Ctaikhoan.Name = "Ctaikhoan";
            this.Ctaikhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Ctaikhoan.Text = "Tài khoản";
            // 
            // Cthongtin
            // 
            this.Cthongtin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Cthongtin.ImageOptions.SvgImage")));
            this.Cthongtin.Name = "Cthongtin";
            this.Cthongtin.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Cthongtin.Text = "Thông tin";
            // 
            // Cthoat
            // 
            this.Cthoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Cthoat.ImageOptions.SvgImage")));
            this.Cthoat.Name = "Cthoat";
            this.Cthoat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Cthoat.Text = "Thoát";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(855, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 550);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmM";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmM";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mnhanvien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mphongban;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mchucvu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mchuyenmon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mdiemdanh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mluong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mthuong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mhopdong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Mbaocao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Ctaikhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Cthongtin;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Cthoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}