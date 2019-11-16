namespace QLKhoHang
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGV_SanPham = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhomSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoaiSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnDVT = new DevExpress.XtraEditors.SimpleButton();
            this.btnNSX = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoMaVach = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_SanPham)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(787, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(787, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(787, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(670, 423);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGV_SanPham);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 20);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(666, 401);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách sản phẩm";
            // 
            // dataGV_SanPham
            // 
            this.dataGV_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.MaLoai,
            this.MaNCC,
            this.MaNSX,
            this.MaHD,
            this.TenSP,
            this.MauSac,
            this.KichThuoc,
            this.GiaNhap,
            this.GiaBanSi,
            this.GiaBanLe,
            this.DVT,
            this.TrangThai,
            this.MoTaSP});
            this.dataGV_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_SanPham.Location = new System.Drawing.Point(2, 20);
            this.dataGV_SanPham.Name = "dataGV_SanPham";
            this.dataGV_SanPham.Size = new System.Drawing.Size(662, 379);
            this.dataGV_SanPham.TabIndex = 0;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MALOAI";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Visible = false;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MANCC";
            this.MaNCC.HeaderText = "MaNCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Visible = false;
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MANSX";
            this.MaNSX.HeaderText = "MNSX";
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.Visible = false;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MAHD";
            this.MaHD.HeaderText = "MaHD";
            this.MaHD.Name = "MaHD";
            this.MaHD.Visible = false;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TEN_SAN_";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MAUSAC";
            this.MauSac.HeaderText = "Màu sắc";
            this.MauSac.Name = "MauSac";
            // 
            // KichThuoc
            // 
            this.KichThuoc.DataPropertyName = "KICHTHUOC";
            this.KichThuoc.HeaderText = "Kích thước";
            this.KichThuoc.Name = "KichThuoc";
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GIANHAP";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.Name = "GiaNhap";
            // 
            // GiaBanSi
            // 
            this.GiaBanSi.DataPropertyName = "GIABANSI";
            this.GiaBanSi.HeaderText = "Giá bán sỉ";
            this.GiaBanSi.Name = "GiaBanSi";
            // 
            // GiaBanLe
            // 
            this.GiaBanLe.DataPropertyName = "GIABANLE";
            this.GiaBanLe.HeaderText = "Giá bán lẻ";
            this.GiaBanLe.Name = "GiaBanLe";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TRANGTHAI";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // MoTaSP
            // 
            this.MoTaSP.DataPropertyName = "MOTASP";
            this.MoTaSP.HeaderText = "Mô tả";
            this.MoTaSP.Name = "MoTaSP";
            // 
            // btnNhomSP
            // 
            this.btnNhomSP.Location = new System.Drawing.Point(676, 53);
            this.btnNhomSP.Name = "btnNhomSP";
            this.btnNhomSP.Size = new System.Drawing.Size(101, 23);
            this.btnNhomSP.TabIndex = 6;
            this.btnNhomSP.Text = "Nhóm sản phẩm";
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.Location = new System.Drawing.Point(676, 82);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.Size = new System.Drawing.Size(101, 23);
            this.btnLoaiSP.TabIndex = 6;
            this.btnLoaiSP.Text = "Loại sản phẩm";
            // 
            // btnDVT
            // 
            this.btnDVT.Location = new System.Drawing.Point(676, 111);
            this.btnDVT.Name = "btnDVT";
            this.btnDVT.Size = new System.Drawing.Size(101, 23);
            this.btnDVT.TabIndex = 6;
            this.btnDVT.Text = "Đơn vị tính";
            // 
            // btnNSX
            // 
            this.btnNSX.Location = new System.Drawing.Point(676, 140);
            this.btnNSX.Name = "btnNSX";
            this.btnNSX.Size = new System.Drawing.Size(101, 23);
            this.btnNSX.TabIndex = 6;
            this.btnNSX.Text = "Nhà sản xuất";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(676, 169);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(101, 23);
            this.simpleButton5.TabIndex = 6;
            this.simpleButton5.Text = "Hình ảnh";
            // 
            // btnTaoMaVach
            // 
            this.btnTaoMaVach.Location = new System.Drawing.Point(676, 198);
            this.btnTaoMaVach.Name = "btnTaoMaVach";
            this.btnTaoMaVach.Size = new System.Drawing.Size(101, 23);
            this.btnTaoMaVach.TabIndex = 6;
            this.btnTaoMaVach.Text = "Tạo mã vạch";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSave,
            this.btnXoa,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(259, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThem.Image = global::QLKhoHang.Properties.Resources.tsbAddNew;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(24, 24);
            this.btnThem.Text = "toolStripButton1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::QLKhoHang.Properties.Resources.tsbSave;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.Text = "Save";
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXoa.Image = global::QLKhoHang.Properties.Resources.tsbDelete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(24, 24);
            this.btnXoa.Text = "Xóa";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 454);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnTaoMaVach);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.btnNSX);
            this.Controls.Add(this.btnDVT);
            this.Controls.Add(this.btnLoaiSP);
            this.Controls.Add(this.btnNhomSP);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_SanPham)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private DevExpress.XtraEditors.SimpleButton btnTaoMaVach;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnNSX;
        private DevExpress.XtraEditors.SimpleButton btnDVT;
        private DevExpress.XtraEditors.SimpleButton btnLoaiSP;
        private DevExpress.XtraEditors.SimpleButton btnNhomSP;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGV_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaSP;
    }
}