﻿namespace QLNHANSU
{
    partial class fmHopDongLaoDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHopDongLaoDong));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.NGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOIHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LANKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSOHD = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboThoiHan = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spLanKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NGAYKY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 566);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnPrint});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 6;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1012, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 590);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1012, 20);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1012, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 566);
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYBATDAU.AppearanceCell.Options.UseFont = true;
            this.NGAYBATDAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYBATDAU.AppearanceHeader.Options.UseFont = true;
            this.NGAYBATDAU.Caption = "Ngày bắt đầu";
            this.NGAYBATDAU.FieldName = "NGAYBATDAU";
            this.NGAYBATDAU.MaxWidth = 200;
            this.NGAYBATDAU.MinWidth = 200;
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.Visible = true;
            this.NGAYBATDAU.VisibleIndex = 1;
            this.NGAYBATDAU.Width = 200;
            // 
            // SOHD
            // 
            this.SOHD.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOHD.AppearanceCell.Options.UseFont = true;
            this.SOHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOHD.AppearanceHeader.Options.UseFont = true;
            this.SOHD.Caption = "Số hợp đồng";
            this.SOHD.FieldName = "SOHD";
            this.SOHD.MaxWidth = 200;
            this.SOHD.MinWidth = 200;
            this.SOHD.Name = "SOHD";
            this.SOHD.Visible = true;
            this.SOHD.VisibleIndex = 0;
            this.SOHD.Width = 200;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOHD,
            this.NGAYBATDAU,
            this.NGAYKY,
            this.NGAYKETTHUC,
            this.THOIHAN,
            this.HESOLUONG,
            this.LANKY,
            this.MANV,
            this.HOTEN});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NGAYBATDAU, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYKETTHUC.AppearanceCell.Options.UseFont = true;
            this.NGAYKETTHUC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYKETTHUC.AppearanceHeader.Options.UseFont = true;
            this.NGAYKETTHUC.Caption = "Ngày kết thúc";
            this.NGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.NGAYKETTHUC.MaxWidth = 200;
            this.NGAYKETTHUC.MinWidth = 200;
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.Visible = true;
            this.NGAYKETTHUC.VisibleIndex = 3;
            this.NGAYKETTHUC.Width = 200;
            // 
            // THOIHAN
            // 
            this.THOIHAN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THOIHAN.AppearanceCell.Options.UseFont = true;
            this.THOIHAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THOIHAN.AppearanceHeader.Options.UseFont = true;
            this.THOIHAN.Caption = "Thời hạn";
            this.THOIHAN.FieldName = "THOIHAN";
            this.THOIHAN.MaxWidth = 200;
            this.THOIHAN.MinWidth = 200;
            this.THOIHAN.Name = "THOIHAN";
            this.THOIHAN.Visible = true;
            this.THOIHAN.VisibleIndex = 4;
            this.THOIHAN.Width = 200;
            // 
            // HESOLUONG
            // 
            this.HESOLUONG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HESOLUONG.AppearanceCell.Options.UseFont = true;
            this.HESOLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HESOLUONG.AppearanceHeader.Options.UseFont = true;
            this.HESOLUONG.Caption = "Hệ số lương";
            this.HESOLUONG.FieldName = "HESOLUONG";
            this.HESOLUONG.MaxWidth = 100;
            this.HESOLUONG.MinWidth = 100;
            this.HESOLUONG.Name = "HESOLUONG";
            this.HESOLUONG.Visible = true;
            this.HESOLUONG.VisibleIndex = 5;
            this.HESOLUONG.Width = 100;
            // 
            // LANKY
            // 
            this.LANKY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LANKY.AppearanceCell.Options.UseFont = true;
            this.LANKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LANKY.AppearanceHeader.Options.UseFont = true;
            this.LANKY.Caption = "Lần ký";
            this.LANKY.FieldName = "LANKY";
            this.LANKY.MaxWidth = 50;
            this.LANKY.MinWidth = 50;
            this.LANKY.Name = "LANKY";
            this.LANKY.Visible = true;
            this.LANKY.VisibleIndex = 6;
            this.LANKY.Width = 50;
            // 
            // MANV
            // 
            this.MANV.Caption = "MANV";
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN.AppearanceCell.Options.UseFont = true;
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "Nhân viên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 200;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 7;
            this.HOTEN.Width = 200;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1012, 197);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSoHD.Location = new System.Drawing.Point(100, 24);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.ReadOnly = true;
            this.txtSoHD.Size = new System.Drawing.Size(172, 24);
            this.txtSoHD.TabIndex = 1;
            // 
            // lblSOHD
            // 
            this.lblSOHD.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSOHD.Appearance.Options.UseFont = true;
            this.lblSOHD.Location = new System.Drawing.Point(34, 27);
            this.lblSOHD.Name = "lblSOHD";
            this.lblSOHD.Size = new System.Drawing.Size(44, 17);
            this.lblSOHD.TabIndex = 0;
            this.lblSOHD.Text = "Số HĐ:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.cboThoiHan);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKetThuc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayBatDau);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoHD);
            this.splitContainer1.Panel1.Controls.Add(this.lblSOHD);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 566);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(563, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 17);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Thời hạn:";
            // 
            // cboThoiHan
            // 
            this.cboThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThoiHan.FormattingEnabled = true;
            this.cboThoiHan.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "12 tháng ",
            "3 năm"});
            this.cboThoiHan.Location = new System.Drawing.Point(637, 25);
            this.cboThoiHan.Name = "cboThoiHan";
            this.cboThoiHan.Size = new System.Drawing.Size(168, 21);
            this.cboThoiHan.TabIndex = 16;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(101, 144);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(792, 219);
            this.txtNoiDung.TabIndex = 15;
            this.txtNoiDung.Text = "richEditControl1";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(34, 144);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 17);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Nội dung:";
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(414, 85);
            this.slkNhanVien.MenuManager = this.barManager1;
            this.slkNhanVien.Name = "slkNhanVien";
            this.slkNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slkNhanVien.Properties.Appearance.Options.UseFont = true;
            this.slkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanVien.Size = new System.Drawing.Size(262, 22);
            this.slkNhanVien.TabIndex = 13;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHoTen});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMANV
            // 
            this.colMANV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMANV.AppearanceHeader.Options.UseFont = true;
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MaxWidth = 100;
            this.colMANV.MinWidth = 100;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 100;
            // 
            // colHoTen
            // 
            this.colHoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHoTen.AppearanceHeader.Options.UseFont = true;
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.MaxWidth = 200;
            this.colHoTen.MinWidth = 200;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 200;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(320, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Nhân viên :";
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(414, 56);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spHeSoLuong.Properties.Appearance.Options.UseFont = true;
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Size = new System.Drawing.Size(126, 22);
            this.spHeSoLuong.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(320, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Hệ số lương:";
            // 
            // spLanKy
            // 
            this.spLanKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKy.Location = new System.Drawing.Point(414, 26);
            this.spLanKy.MenuManager = this.barManager1;
            this.spLanKy.Name = "spLanKy";
            this.spLanKy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spLanKy.Properties.Appearance.Options.UseFont = true;
            this.spLanKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKy.Properties.IsFloatValue = false;
            this.spLanKy.Properties.MaskSettings.Set("mask", "N00");
            this.spLanKy.Size = new System.Drawing.Size(126, 22);
            this.spLanKy.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(352, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Lần ký:";
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKy.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKy.Location = new System.Drawing.Point(100, 108);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(172, 23);
            this.dtNgayKy.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ngày ký:";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(100, 81);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(172, 23);
            this.dtNgayKetThuc.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(34, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ngày KT:";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(100, 54);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(172, 23);
            this.dtNgayBatDau.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngày BĐ:";
            // 
            // NGAYKY
            // 
            this.NGAYKY.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYKY.AppearanceCell.Options.UseFont = true;
            this.NGAYKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAYKY.AppearanceHeader.Options.UseFont = true;
            this.NGAYKY.Caption = "Ngày ký";
            this.NGAYKY.FieldName = "NGAYKY";
            this.NGAYKY.MaxWidth = 200;
            this.NGAYKY.MinWidth = 200;
            this.NGAYKY.Name = "NGAYKY";
            this.NGAYKY.Visible = true;
            this.NGAYKY.VisibleIndex = 2;
            this.NGAYKY.Width = 200;
            // 
            // fmHopDongLaoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 610);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "fmHopDongLaoDong";
            this.Text = "Hợp đồng lao động";
            this.Load += new System.EventHandler(this.fmHopDongLaoDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSoHD;
        private DevExpress.XtraEditors.LabelControl lblSOHD;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SOHD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYBATDAU;
        private DevExpress.XtraEditors.SpinEdit spLanKy;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKETTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn THOIHAN;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn LANKY;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraRichEdit.RichEditControl txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ComboBox cboThoiHan;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKY;
    }
}