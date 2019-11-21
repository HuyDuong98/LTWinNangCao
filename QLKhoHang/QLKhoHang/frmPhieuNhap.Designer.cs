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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.lblGiaBan = new DevExpress.XtraEditors.LabelControl();
            this.lblTenSP = new DevExpress.XtraEditors.LabelControl();
            this.lblMaSanPham = new DevExpress.XtraEditors.LabelControl();
            this.lblDienGiai = new DevExpress.XtraEditors.LabelControl();
            this.lblNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.lblNgay = new DevExpress.XtraEditors.LabelControl();
            this.lblSoPhieu = new DevExpress.XtraEditors.LabelControl();
            this.grView = new DevExpress.XtraEditors.GroupControl();
            this.dataPhieuNhap = new System.Windows.Forms.DataGridView();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.datePhieuNhap = new DevExpress.XtraEditors.DateEdit();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABANLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).BeginInit();
            this.grView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.cboSP);
            this.groupBox1.Controls.Add(this.datePhieuNhap);
            this.groupBox1.Controls.Add(this.txtDienGiai);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtMaSoPhieu);
            this.groupBox1.Controls.Add(this.lblGiaBan);
            this.groupBox1.Controls.Add(this.lblTenSP);
            this.groupBox1.Controls.Add(this.lblMaSanPham);
            this.groupBox1.Controls.Add(this.lblDienGiai);
            this.groupBox1.Controls.Add(this.lblNhanVien);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Controls.Add(this.lblSoPhieu);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(86, 61);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(210, 21);
            this.cboNhanVien.TabIndex = 4;
            this.cboNhanVien.DropDown += new System.EventHandler(this.cboNhanVien_DropDown);
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(385, 38);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(435, 21);
            this.cboSP.TabIndex = 3;
            this.cboSP.DropDown += new System.EventHandler(this.cboSP_DropDown);
            this.cboSP.SelectedValueChanged += new System.EventHandler(this.cboSP_SelectedValueChanged);
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(86, 87);
            this.txtDienGiai.Multiline = true;
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(734, 39);
            this.txtDienGiai.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(655, 15);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(165, 20);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(385, 15);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(210, 20);
            this.txtMaSP.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(607, 18);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(42, 13);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.Click += new System.EventHandler(this.lblMST_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(385, 61);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(435, 20);
            this.txtGiaBan.TabIndex = 1;
            this.txtGiaBan.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txtMaSoPhieu
            // 
            this.txtMaSoPhieu.Enabled = false;
            this.txtMaSoPhieu.Location = new System.Drawing.Point(86, 15);
            this.txtMaSoPhieu.Name = "txtMaSoPhieu";
            this.txtMaSoPhieu.Size = new System.Drawing.Size(210, 20);
            this.txtMaSoPhieu.TabIndex = 0;
            this.txtMaSoPhieu.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Location = new System.Drawing.Point(316, 64);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(36, 13);
            this.lblGiaBan.TabIndex = 0;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Location = new System.Drawing.Point(316, 41);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(47, 13);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Sản phẩm";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.Location = new System.Drawing.Point(316, 18);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(63, 13);
            this.lblMaSanPham.TabIndex = 0;
            this.lblMaSanPham.Text = "Mã sản phẩm";
            // 
            // lblDienGiai
            // 
            this.lblDienGiai.Location = new System.Drawing.Point(6, 87);
            this.lblDienGiai.Name = "lblDienGiai";
            this.lblDienGiai.Size = new System.Drawing.Size(40, 13);
            this.lblDienGiai.TabIndex = 0;
            this.lblDienGiai.Text = "Diễn giải";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Location = new System.Drawing.Point(6, 64);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(59, 13);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "NV liên quan";
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(6, 41);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(25, 13);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.Location = new System.Drawing.Point(6, 18);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(41, 13);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu";
            // 
            // grView
            // 
            this.grView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grView.Controls.Add(this.dataPhieuNhap);
            this.grView.Location = new System.Drawing.Point(0, 179);
            this.grView.Name = "grView";
            this.grView.Size = new System.Drawing.Size(826, 303);
            this.grView.TabIndex = 1;
            this.grView.Text = "Danh sách hàng hóa";
            // 
            // dataPhieuNhap
            // 
            this.dataPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.TENSP,
            this.GIABANLE,
            this.DVT,
            this.MAUSAC,
            this.SL,
            this.NGAYNHAP,
            this.NhanVien,
            this.TENNV,
            this.NoiDung,
            this.MANV});
            this.dataPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhieuNhap.Enabled = false;
            this.dataPhieuNhap.Location = new System.Drawing.Point(2, 20);
            this.dataPhieuNhap.Name = "dataPhieuNhap";
            this.dataPhieuNhap.Size = new System.Drawing.Size(822, 281);
            this.dataPhieuNhap.TabIndex = 0;
            this.dataPhieuNhap.DataSourceChanged += new System.EventHandler(this.dataPhieuNhap_DataSourceChanged);
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
            this.pnControl.Size = new System.Drawing.Size(826, 30);
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
            this.btnIn.Size = new System.Drawing.Size(43, 30);
            this.btnIn.TabIndex = 10;
            this.btnIn.UseVisualStyleBackColor = false;
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
            this.btnSua.Size = new System.Drawing.Size(43, 30);
            this.btnSua.TabIndex = 9;
            this.btnSua.UseVisualStyleBackColor = false;
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
            this.btnXoa.Size = new System.Drawing.Size(43, 30);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.UseVisualStyleBackColor = false;
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
            this.btnLuu.Size = new System.Drawing.Size(43, 30);
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
            this.btnThem.Size = new System.Drawing.Size(43, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // datePhieuNhap
            // 
            this.datePhieuNhap.EditValue = null;
            this.datePhieuNhap.Location = new System.Drawing.Point(86, 38);
            this.datePhieuNhap.Name = "datePhieuNhap";
            this.datePhieuNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePhieuNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePhieuNhap.Size = new System.Drawing.Size(210, 20);
            this.datePhieuNhap.TabIndex = 2;
            // 
            // MAPN
            // 
            this.MAPN.DataPropertyName = "MAPN";
            this.MAPN.HeaderText = "Mã phiếu nhập hàng";
            this.MAPN.Name = "MAPN";
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TEN_SAN_1";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            // 
            // GIABANLE
            // 
            this.GIABANLE.DataPropertyName = "GIABANLE1";
            this.GIABANLE.HeaderText = "Giá bán lẻ";
            this.GIABANLE.Name = "GIABANLE";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT1";
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // MAUSAC
            // 
            this.MAUSAC.DataPropertyName = "MAUSAC1";
            this.MAUSAC.HeaderText = "Màu sắc";
            this.MAUSAC.Name = "MAUSAC";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "NHAN_VIEN";
            this.NhanVien.HeaderText = "Nhân viên";
            this.NhanVien.Name = "NhanVien";
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV1";
            this.TENNV.HeaderText = "Tên nhân viên";
            this.TENNV.Name = "TENNV";
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NOIDUNG";
            this.NoiDung.HeaderText = "Diễn giải";
            this.NoiDung.Name = "NoiDung";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.Visible = false;
            // 
            // frmPhieuNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 482);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.grView);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).EndInit();
            this.grView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl grView;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.LabelControl lblSoLuong;
        private DevExpress.XtraEditors.TextEdit txtMaSoPhieu;
        private DevExpress.XtraEditors.LabelControl lblMaSanPham;
        private DevExpress.XtraEditors.LabelControl lblDienGiai;
        private DevExpress.XtraEditors.LabelControl lblNhanVien;
        private DevExpress.XtraEditors.LabelControl lblNgay;
        private DevExpress.XtraEditors.LabelControl lblSoPhieu;
        private System.Windows.Forms.TextBox txtDienGiai;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
        private DevExpress.XtraEditors.LabelControl lblGiaBan;
        private DevExpress.XtraEditors.LabelControl lblTenSP;
        private System.Windows.Forms.DataGridView dataPhieuNhap;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private DevExpress.XtraEditors.DateEdit datePhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABANLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUSAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
    }
}