namespace QLKhoHang
{
    partial class frmPhieuXuat
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
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelNhap = new System.Windows.Forms.Panel();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new DevExpress.XtraEditors.TextEdit();
            this.datePhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnThemPheu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGVDSHangXuat = new QLKhoHang.dataGridViewSTT(this.components);
            this.MAPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHIEU_XUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAN_PHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABANLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.panelNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSHangXuat)).BeginInit();
            this.SuspendLayout();
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
            this.pnControl.Size = new System.Drawing.Size(949, 45);
            this.pnControl.TabIndex = 14;
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
            // panelNhap
            // 
            this.panelNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNhap.Controls.Add(this.cboKho);
            this.panelNhap.Controls.Add(this.txtMoTa);
            this.panelNhap.Controls.Add(this.datePhieuXuat);
            this.panelNhap.Controls.Add(this.cboNhanVien);
            this.panelNhap.Controls.Add(this.groupBox1);
            this.panelNhap.Controls.Add(this.btnThemPheu);
            this.panelNhap.Controls.Add(this.txtMaPhieu);
            this.panelNhap.Controls.Add(this.labelControl4);
            this.panelNhap.Controls.Add(this.labelControl3);
            this.panelNhap.Controls.Add(this.labelControl2);
            this.panelNhap.Controls.Add(this.labelControl6);
            this.panelNhap.Controls.Add(this.labelControl1);
            this.panelNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhap.Location = new System.Drawing.Point(0, 45);
            this.panelNhap.Name = "panelNhap";
            this.panelNhap.Size = new System.Drawing.Size(949, 130);
            this.panelNhap.TabIndex = 15;
            // 
            // cboKho
            // 
            this.cboKho.Enabled = false;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(86, 45);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(180, 21);
            this.cboKho.TabIndex = 9;
            this.cboKho.DropDown += new System.EventHandler(this.cboKho_DropDown);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(320, 45);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(617, 20);
            this.txtMoTa.TabIndex = 8;
            // 
            // datePhieuXuat
            // 
            this.datePhieuXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePhieuXuat.Location = new System.Drawing.Point(781, 12);
            this.datePhieuXuat.Name = "datePhieuXuat";
            this.datePhieuXuat.Size = new System.Drawing.Size(156, 21);
            this.datePhieuXuat.TabIndex = 7;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Enabled = false;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(522, 12);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(165, 21);
            this.cboNhanVien.TabIndex = 4;
            this.cboNhanVien.DropDown += new System.EventHandler(this.cboNhanVien_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnXoaSP);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.cboSP);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sản phẩm";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Enabled = false;
            this.btnXoaSP.Location = new System.Drawing.Point(389, 18);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSP.TabIndex = 5;
            this.btnXoaSP.Text = "Xóa";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Enabled = false;
            this.btnThemSP.Location = new System.Drawing.Point(308, 18);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(75, 23);
            this.btnThemSP.TabIndex = 6;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(76, 20);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(210, 21);
            this.cboSP.TabIndex = 4;
            this.cboSP.DropDown += new System.EventHandler(this.cboSP_DropDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 20);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Sản phẩm";
            // 
            // btnThemPheu
            // 
            this.btnThemPheu.Enabled = false;
            this.btnThemPheu.Location = new System.Drawing.Point(287, 9);
            this.btnThemPheu.Name = "btnThemPheu";
            this.btnThemPheu.Size = new System.Drawing.Size(75, 23);
            this.btnThemPheu.TabIndex = 2;
            this.btnThemPheu.Text = "Thêm phiếu";
            this.btnThemPheu.Click += new System.EventHandler(this.btnThemPheu_Click);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Location = new System.Drawing.Point(86, 12);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(180, 20);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(735, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(423, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Người lập phiếu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(287, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mô tả";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Kho";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGVDSHangXuat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 175);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(949, 286);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Danh sách sản phẩm";
            // 
            // dataGVDSHangXuat
            // 
            this.dataGVDSHangXuat.BackgroundColor = System.Drawing.Color.White;
            this.dataGVDSHangXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDSHangXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPX,
            this.PHIEU_XUAT,
            this.SAN_PHAM,
            this.TEN_SP,
            this.MAUSAC,
            this.MASP,
            this.SoLuong,
            this.ThanhTien,
            this.DVT,
            this.GIABANLE});
            this.dataGVDSHangXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDSHangXuat.Location = new System.Drawing.Point(2, 20);
            this.dataGVDSHangXuat.Name = "dataGVDSHangXuat";
            this.dataGVDSHangXuat.Size = new System.Drawing.Size(945, 264);
            this.dataGVDSHangXuat.TabIndex = 0;
            this.dataGVDSHangXuat.DataSourceChanged += new System.EventHandler(this.dataGVDSHangXuat_DataSourceChanged);
            // 
            // MAPX
            // 
            this.MAPX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPX.DataPropertyName = "MAPX";
            this.MAPX.HeaderText = "Mã phiếu xuất";
            this.MAPX.Name = "MAPX";
            this.MAPX.Visible = false;
            // 
            // PHIEU_XUAT
            // 
            this.PHIEU_XUAT.DataPropertyName = "PHIEU_XUAT";
            this.PHIEU_XUAT.HeaderText = "Phiếu xuất";
            this.PHIEU_XUAT.Name = "PHIEU_XUAT";
            this.PHIEU_XUAT.Visible = false;
            // 
            // SAN_PHAM
            // 
            this.SAN_PHAM.DataPropertyName = "SAN_PHAM";
            this.SAN_PHAM.HeaderText = "Sản phẩm";
            this.SAN_PHAM.Name = "SAN_PHAM";
            this.SAN_PHAM.Visible = false;
            // 
            // TEN_SP
            // 
            this.TEN_SP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_SP.DataPropertyName = "TEN_SP";
            this.TEN_SP.HeaderText = "Tên sản phẩm";
            this.TEN_SP.Name = "TEN_SP";
            // 
            // MAUSAC
            // 
            this.MAUSAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAUSAC.DataPropertyName = "MAUSAC";
            this.MAUSAC.HeaderText = "Màu sắc";
            this.MAUSAC.Name = "MAUSAC";
            // 
            // MASP
            // 
            this.MASP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.Visible = false;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // GIABANLE
            // 
            this.GIABANLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIABANLE.DataPropertyName = "GIABANLE";
            this.GIABANLE.HeaderText = "Giá bán";
            this.GIABANLE.Name = "GIABANLE";
            // 
            // frmPhieuXuat
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 461);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelNhap);
            this.Controls.Add(this.pnControl);
            this.Name = "frmPhieuXuat";
            this.Text = "Phiếu xuất";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.panelNhap.ResumeLayout(false);
            this.panelNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSHangXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelNhap;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private dataGridViewSTT dataGVDSHangXuat;
        private DevExpress.XtraEditors.SimpleButton btnThemPheu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private DevExpress.XtraEditors.TextEdit txtMoTa;
        private System.Windows.Forms.DateTimePicker datePhieuXuat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cboSP;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        private System.Windows.Forms.ComboBox cboKho;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHIEU_XUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAN_PHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUSAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABANLE;
    }
}