namespace QLKhoHang
{
    partial class frmPhieuNhap
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
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtMaSoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.lblDienGiai = new DevExpress.XtraEditors.LabelControl();
            this.lblNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.lblNgay = new DevExpress.XtraEditors.LabelControl();
            this.lblSoPhieu = new DevExpress.XtraEditors.LabelControl();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKHODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKHODataSet = new QLKhoHang.QLKHODataSet();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelPhieuNhap = new System.Windows.Forms.GroupBox();
            this.btnThemPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.datePhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.lblKho = new DevExpress.XtraEditors.LabelControl();
            this.qLPHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PHANQUYENTableAdapter = new QLKhoHang.QLKHODataSetTableAdapters.QL_PHANQUYENTableAdapter();
            this.sAN_PHAMTableAdapter = new QLKhoHang.QLKHODataSetTableAdapters.SAN_PHAMTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.lblSanPham = new DevExpress.XtraEditors.LabelControl();
            this.grView = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAN_PHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHIEU_NHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.panelPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHANQUYENBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).BeginInit();
            this.grView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Enabled = false;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(462, 20);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(123, 21);
            this.cboNhanVien.TabIndex = 4;
            this.cboNhanVien.DropDown += new System.EventHandler(this.cboNhanVien_DropDown);
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(86, 6);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(210, 21);
            this.cboSP.TabIndex = 3;
            this.cboSP.DropDown += new System.EventHandler(this.cboSP_DropDown);
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(86, 61);
            this.txtDienGiai.Multiline = true;
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(963, 39);
            this.txtDienGiai.TabIndex = 5;
            // 
            // txtMaSoPhieu
            // 
            this.txtMaSoPhieu.Enabled = false;
            this.txtMaSoPhieu.Location = new System.Drawing.Point(86, 20);
            this.txtMaSoPhieu.Name = "txtMaSoPhieu";
            this.txtMaSoPhieu.Size = new System.Drawing.Size(192, 20);
            this.txtMaSoPhieu.TabIndex = 0;
            // 
            // lblDienGiai
            // 
            this.lblDienGiai.Location = new System.Drawing.Point(12, 61);
            this.lblDienGiai.Name = "lblDienGiai";
            this.lblDienGiai.Size = new System.Drawing.Size(40, 13);
            this.lblDienGiai.TabIndex = 0;
            this.lblDienGiai.Text = "Diễn giải";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Location = new System.Drawing.Point(397, 23);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(45, 13);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Người lập";
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(654, 22);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(25, 13);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.Location = new System.Drawing.Point(12, 20);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(41, 13);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu";
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SAN_PHAM";
            this.sANPHAMBindingSource.DataSource = this.qLKHODataSetBindingSource;
            // 
            // qLKHODataSetBindingSource
            // 
            this.qLKHODataSetBindingSource.DataSource = this.qLKHODataSet;
            this.qLKHODataSetBindingSource.Position = 0;
            // 
            // qLKHODataSet
            // 
            this.qLKHODataSet.DataSetName = "QLKHODataSet";
            this.qLKHODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnControl
            // 
            this.pnControl.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnControl.Appearance.Options.UseBackColor = true;
            this.pnControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnControl.Controls.Add(this.btnIn);
            this.pnControl.Controls.Add(this.btnSua);
            this.pnControl.Controls.Add(this.btnXoa);
            this.pnControl.Controls.Add(this.btnLuu);
            this.pnControl.Controls.Add(this.btnThem);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1084, 45);
            this.pnControl.TabIndex = 13;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIn.Enabled = false;
            this.btnIn.Image = global::QLKhoHang.Properties.Resources.printer;
            this.btnIn.Location = new System.Drawing.Point(172, 0);
            this.btnIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(43, 45);
            this.btnIn.TabIndex = 10;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::QLKhoHang.Properties.Resources.tsbRefresh;
            this.btnSua.Location = new System.Drawing.Point(129, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(43, 45);
            this.btnSua.TabIndex = 9;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::QLKhoHang.Properties.Resources.tsbDelete;
            this.btnXoa.Location = new System.Drawing.Point(86, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 45);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::QLKhoHang.Properties.Resources.tsbSave;
            this.btnLuu.Location = new System.Drawing.Point(43, 0);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(43, 45);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Image = global::QLKhoHang.Properties.Resources.tsbAddNew;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(43, 45);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelPhieuNhap
            // 
            this.panelPhieuNhap.Controls.Add(this.btnThemPhieuNhap);
            this.panelPhieuNhap.Controls.Add(this.datePhieuNhap);
            this.panelPhieuNhap.Controls.Add(this.cboKho);
            this.panelPhieuNhap.Controls.Add(this.cboNhanVien);
            this.panelPhieuNhap.Controls.Add(this.txtMaSoPhieu);
            this.panelPhieuNhap.Controls.Add(this.lblSoPhieu);
            this.panelPhieuNhap.Controls.Add(this.lblNgay);
            this.panelPhieuNhap.Controls.Add(this.txtDienGiai);
            this.panelPhieuNhap.Controls.Add(this.lblKho);
            this.panelPhieuNhap.Controls.Add(this.lblNhanVien);
            this.panelPhieuNhap.Controls.Add(this.lblDienGiai);
            this.panelPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhieuNhap.Location = new System.Drawing.Point(0, 45);
            this.panelPhieuNhap.Name = "panelPhieuNhap";
            this.panelPhieuNhap.Size = new System.Drawing.Size(1084, 112);
            this.panelPhieuNhap.TabIndex = 14;
            this.panelPhieuNhap.TabStop = false;
            this.panelPhieuNhap.Text = "Phiếu nhập";
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.Enabled = false;
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(284, 18);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(75, 23);
            this.btnThemPhieuNhap.TabIndex = 7;
            this.btnThemPhieuNhap.Text = "Thêm phiếu";
            this.btnThemPhieuNhap.Click += new System.EventHandler(this.btnThemPhieuNhap_Click);
            // 
            // datePhieuNhap
            // 
            this.datePhieuNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePhieuNhap.Location = new System.Drawing.Point(695, 19);
            this.datePhieuNhap.Name = "datePhieuNhap";
            this.datePhieuNhap.Size = new System.Drawing.Size(119, 21);
            this.datePhieuNhap.TabIndex = 6;
            // 
            // cboKho
            // 
            this.cboKho.Enabled = false;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(910, 20);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(139, 21);
            this.cboKho.TabIndex = 4;
            this.cboKho.DropDown += new System.EventHandler(this.cboKho_DropDown);
            // 
            // lblKho
            // 
            this.lblKho.Location = new System.Drawing.Point(867, 23);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(18, 13);
            this.lblKho.TabIndex = 0;
            this.lblKho.Text = "Kho";
            // 
            // qLPHANQUYENBindingSource
            // 
            this.qLPHANQUYENBindingSource.DataMember = "QL_PHANQUYEN";
            this.qLPHANQUYENBindingSource.DataSource = this.qLKHODataSetBindingSource;
            // 
            // qL_PHANQUYENTableAdapter
            // 
            this.qL_PHANQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // sAN_PHAMTableAdapter
            // 
            this.sAN_PHAMTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaSP);
            this.panel1.Controls.Add(this.btnThemSP);
            this.panel1.Controls.Add(this.cboSP);
            this.panel1.Controls.Add(this.lblSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 37);
            this.panel1.TabIndex = 15;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Enabled = false;
            this.btnXoaSP.Location = new System.Drawing.Point(397, 4);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Enabled = false;
            this.btnThemSP.Location = new System.Drawing.Point(316, 4);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(75, 23);
            this.btnThemSP.TabIndex = 2;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // lblSanPham
            // 
            this.lblSanPham.Location = new System.Drawing.Point(12, 14);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(47, 13);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "Sản phẩm";
            // 
            // grView
            // 
            this.grView.Controls.Add(this.dataGridViewSP);
            this.grView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grView.Location = new System.Drawing.Point(0, 194);
            this.grView.Name = "grView";
            this.grView.Size = new System.Drawing.Size(1084, 288);
            this.grView.TabIndex = 16;
            this.grView.Text = "Danh sách hàng hóa";
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSP.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.MASP,
            this.SAN_PHAM,
            this.PHIEU_NHAP,
            this.TEN_SP,
            this.MAUSAC,
            this.DVT,
            this.GIANHAP,
            this.SL,
            this.ThanhTien,
            this.MOTA});
            this.dataGridViewSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSP.Location = new System.Drawing.Point(2, 20);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.Size = new System.Drawing.Size(1080, 266);
            this.dataGridViewSP.TabIndex = 0;
            this.dataGridViewSP.DataSourceChanged += new System.EventHandler(this.dataGridViewSP_DataSourceChanged);
            this.dataGridViewSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSP_CellContentClick);
            this.dataGridViewSP.SelectionChanged += new System.EventHandler(this.dataGridViewSP_SelectionChanged);
            // 
            // MAPN
            // 
            this.MAPN.DataPropertyName = "MAPN";
            this.MAPN.HeaderText = "Mã phiếu nhập";
            this.MAPN.Name = "MAPN";
            this.MAPN.Visible = false;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.Visible = false;
            // 
            // SAN_PHAM
            // 
            this.SAN_PHAM.DataPropertyName = "SAN_PHAM";
            this.SAN_PHAM.HeaderText = "tableSanPham";
            this.SAN_PHAM.Name = "SAN_PHAM";
            this.SAN_PHAM.Visible = false;
            // 
            // PHIEU_NHAP
            // 
            this.PHIEU_NHAP.DataPropertyName = "PHIEU_NHAP";
            this.PHIEU_NHAP.HeaderText = "table Phiếu nhập";
            this.PHIEU_NHAP.Name = "PHIEU_NHAP";
            this.PHIEU_NHAP.Visible = false;
            // 
            // TEN_SP
            // 
            this.TEN_SP.DataPropertyName = "TEN_SP";
            this.TEN_SP.HeaderText = "Tên sản phẩm";
            this.TEN_SP.Name = "TEN_SP";
            this.TEN_SP.ReadOnly = true;
            // 
            // MAUSAC
            // 
            this.MAUSAC.DataPropertyName = "MAUSAC";
            this.MAUSAC.HeaderText = "Màu sắc";
            this.MAUSAC.Name = "MAUSAC";
            this.MAUSAC.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.HeaderText = "Giá nhập";
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            // 
            // frmPhieuNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 482);
            this.Controls.Add(this.grView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPhieuNhap);
            this.Controls.Add(this.pnControl);
            this.Name = "frmPhieuNhap";
            this.Text = "Phiếu nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.panelPhieuNhap.ResumeLayout(false);
            this.panelPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHANQUYENBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).EndInit();
            this.grView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.TextEdit txtMaSoPhieu;
        private DevExpress.XtraEditors.LabelControl lblDienGiai;
        private DevExpress.XtraEditors.LabelControl lblNhanVien;
        private DevExpress.XtraEditors.LabelControl lblNgay;
        private DevExpress.XtraEditors.LabelControl lblSoPhieu;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.GroupBox panelPhieuNhap;
        private QLKHODataSet qLKHODataSet;
        private System.Windows.Forms.BindingSource qLKHODataSetBindingSource;
        private System.Windows.Forms.BindingSource qLPHANQUYENBindingSource;
        private QLKHODataSetTableAdapters.QL_PHANQUYENTableAdapter qL_PHANQUYENTableAdapter;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLKHODataSetTableAdapters.SAN_PHAMTableAdapter sAN_PHAMTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        private DevExpress.XtraEditors.LabelControl lblSanPham;
        private DevExpress.XtraEditors.GroupControl grView;
        private System.Windows.Forms.DataGridView dataGridViewSP;
        private System.Windows.Forms.DateTimePicker datePhieuNhap;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuNhap;
        private System.Windows.Forms.ComboBox cboKho;
        private DevExpress.XtraEditors.LabelControl lblKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAN_PHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHIEU_NHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUSAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
    }
}