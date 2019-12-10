namespace QLKhoHang
{
    partial class frmDSPhieuNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGVPhieuNhap = new QLKhoHang.dataGridViewSTT(this.components);
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHAN_VIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHOHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGVDSHangNhap = new QLKhoHang.dataGridViewSTT(this.components);
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHIEU_NHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAN_PHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSHangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnControl.Appearance.Options.UseBackColor = true;
            this.pnControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnControl.Controls.Add(this.panel1);
            this.pnControl.Controls.Add(this.btnIn);
            this.pnControl.Controls.Add(this.btnSua);
            this.pnControl.Controls.Add(this.btnXoa);
            this.pnControl.Controls.Add(this.btnLuu);
            this.pnControl.Controls.Add(this.btnThem);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(887, 45);
            this.pnControl.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboKho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(587, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 45);
            this.panel1.TabIndex = 12;
            // 
            // cboKho
            // 
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(70, 13);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(218, 21);
            this.cboKho.TabIndex = 1;
            this.cboKho.DropDown += new System.EventHandler(this.cboKho_DropDown);
            this.cboKho.SelectedIndexChanged += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kho";
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
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGVPhieuNhap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(887, 182);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Danh sách phiếu";
            // 
            // dataGVPhieuNhap
            // 
            this.dataGVPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dataGVPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.MANV,
            this.NGAYNHAP,
            this.NOIDUNG,
            this.MAKHO,
            this.NHAN_VIEN,
            this.KHOHANG,
            this.TENNV});
            this.dataGVPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVPhieuNhap.Location = new System.Drawing.Point(2, 20);
            this.dataGVPhieuNhap.Name = "dataGVPhieuNhap";
            this.dataGVPhieuNhap.Size = new System.Drawing.Size(883, 160);
            this.dataGVPhieuNhap.TabIndex = 0;
            this.dataGVPhieuNhap.DataSourceChanged += new System.EventHandler(this.dataGVPhieuNhap_DataSourceChanged_1);
            this.dataGVPhieuNhap.SelectionChanged += new System.EventHandler(this.dataGVPhieuNhap_SelectionChanged);
            // 
            // MAPN
            // 
            this.MAPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPN.DataPropertyName = "MAPN";
            this.MAPN.HeaderText = "Số phiếu";
            this.MAPN.Name = "MAPN";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nv";
            this.MANV.Name = "MANV";
            this.MANV.Visible = false;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.Name = "NOIDUNG";
            // 
            // MAKHO
            // 
            this.MAKHO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã kho";
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.Visible = false;
            // 
            // NHAN_VIEN
            // 
            this.NHAN_VIEN.DataPropertyName = "NHAN_VIEN";
            this.NHAN_VIEN.HeaderText = "Nhân viên";
            this.NHAN_VIEN.Name = "NHAN_VIEN";
            this.NHAN_VIEN.Visible = false;
            // 
            // KHOHANG
            // 
            this.KHOHANG.DataPropertyName = "KHOHANG";
            this.KHOHANG.HeaderText = "Kho hàng";
            this.KHOHANG.Name = "KHOHANG";
            this.KHOHANG.Visible = false;
            // 
            // TENNV
            // 
            this.TENNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Người lập phiếu";
            this.TENNV.Name = "TENNV";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGVDSHangNhap);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 227);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(887, 235);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Danh sách hàng";
            // 
            // dataGVDSHangNhap
            // 
            this.dataGVDSHangNhap.BackgroundColor = System.Drawing.Color.White;
            this.dataGVDSHangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDSHangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN_SP,
            this.MAPHIEU,
            this.MASP,
            this.SL,
            this.ThanhTien,
            this.PHIEU_NHAP,
            this.SAN_PHAM,
            this.MAUSAC,
            this.DVT,
            this.GIANHAP,
            this.MOTA});
            this.dataGVDSHangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDSHangNhap.Location = new System.Drawing.Point(2, 20);
            this.dataGVDSHangNhap.Name = "dataGVDSHangNhap";
            this.dataGVDSHangNhap.Size = new System.Drawing.Size(883, 213);
            this.dataGVDSHangNhap.TabIndex = 0;
            this.dataGVDSHangNhap.DataSourceChanged += new System.EventHandler(this.dataGVDSHangNhap_DataSourceChanged);
            // 
            // TEN_SP
            // 
            this.TEN_SP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_SP.DataPropertyName = "TEN_SP";
            this.TEN_SP.HeaderText = "Sản phẩm";
            this.TEN_SP.Name = "TEN_SP";
            // 
            // MAPHIEU
            // 
            this.MAPHIEU.DataPropertyName = "MAPN";
            this.MAPHIEU.HeaderText = "Mã phiếu";
            this.MAPHIEU.Name = "MAPHIEU";
            this.MAPHIEU.Visible = false;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.Visible = false;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // PHIEU_NHAP
            // 
            this.PHIEU_NHAP.DataPropertyName = "PHIEU_NHAP";
            this.PHIEU_NHAP.HeaderText = "Phiếu nhập";
            this.PHIEU_NHAP.Name = "PHIEU_NHAP";
            this.PHIEU_NHAP.Visible = false;
            // 
            // SAN_PHAM
            // 
            this.SAN_PHAM.DataPropertyName = "SAN_PHAM";
            this.SAN_PHAM.HeaderText = "Sản phẩm";
            this.SAN_PHAM.Name = "SAN_PHAM";
            this.SAN_PHAM.Visible = false;
            // 
            // MAUSAC
            // 
            this.MAUSAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAUSAC.DataPropertyName = "MAUSAC";
            this.MAUSAC.HeaderText = "Màu sắc";
            this.MAUSAC.Name = "MAUSAC";
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // GIANHAP
            // 
            this.GIANHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.HeaderText = "Giá nhập";
            this.GIANHAP.Name = "GIANHAP";
            // 
            // MOTA
            // 
            this.MOTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            // 
            // frmDSPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 462);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pnControl);
            this.Name = "frmDSPhieuNhap";
            this.Text = "frmDSPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSHangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private dataGridViewSTT dataGVPhieuNhap;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private dataGridViewSTT dataGVDSHangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHAN_VIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHOHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHIEU_NHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAN_PHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUSAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
    }
}