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
            this.datePhieuNhap = new DevExpress.XtraEditors.DateEdit();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qLPHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PHANQUYENTableAdapter = new QLKhoHang.QLKHODataSetTableAdapters.QL_PHANQUYENTableAdapter();
            this.sAN_PHAMTableAdapter = new QLKhoHang.QLKHODataSetTableAdapters.SAN_PHAMTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grView = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.lblSanPham = new DevExpress.XtraEditors.LabelControl();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHANQUYENBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grView)).BeginInit();
            this.grView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(610, 24);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(151, 21);
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
            // datePhieuNhap
            // 
            this.datePhieuNhap.EditValue = null;
            this.datePhieuNhap.Location = new System.Drawing.Point(338, 20);
            this.datePhieuNhap.Name = "datePhieuNhap";
            this.datePhieuNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePhieuNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePhieuNhap.Size = new System.Drawing.Size(151, 20);
            this.datePhieuNhap.TabIndex = 2;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(86, 61);
            this.txtDienGiai.Multiline = true;
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(734, 39);
            this.txtDienGiai.TabIndex = 5;
            // 
            // txtMaSoPhieu
            // 
            this.txtMaSoPhieu.Enabled = false;
            this.txtMaSoPhieu.Location = new System.Drawing.Point(86, 20);
            this.txtMaSoPhieu.Name = "txtMaSoPhieu";
            this.txtMaSoPhieu.Size = new System.Drawing.Size(148, 20);
            this.txtMaSoPhieu.TabIndex = 0;
            this.txtMaSoPhieu.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // lblDienGiai
            // 
            this.lblDienGiai.Location = new System.Drawing.Point(39, 61);
            this.lblDienGiai.Name = "lblDienGiai";
            this.lblDienGiai.Size = new System.Drawing.Size(40, 13);
            this.lblDienGiai.TabIndex = 0;
            this.lblDienGiai.Text = "Diễn giải";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Location = new System.Drawing.Point(545, 27);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(59, 13);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "NV liên quan";
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(307, 23);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(25, 13);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.Location = new System.Drawing.Point(39, 23);
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
            this.pnControl.Size = new System.Drawing.Size(826, 45);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.txtMaSoPhieu);
            this.groupBox1.Controls.Add(this.lblSoPhieu);
            this.groupBox1.Controls.Add(this.datePhieuNhap);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Controls.Add(this.txtDienGiai);
            this.groupBox1.Controls.Add(this.lblNhanVien);
            this.groupBox1.Controls.Add(this.lblDienGiai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
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
            this.panel1.Size = new System.Drawing.Size(826, 37);
            this.panel1.TabIndex = 15;
            // 
            // grView
            // 
            this.grView.Controls.Add(this.dataGridViewSP);
            this.grView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grView.Location = new System.Drawing.Point(0, 194);
            this.grView.Name = "grView";
            this.grView.Size = new System.Drawing.Size(826, 288);
            this.grView.TabIndex = 16;
            this.grView.Text = "Danh sách hàng hóa";
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSP.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TEN_SP,
            this.MAUSAC,
            this.DVT,
            this.GIANHAP,
            this.MOTASP});
            this.dataGridViewSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSP.Enabled = false;
            this.dataGridViewSP.Location = new System.Drawing.Point(2, 20);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.Size = new System.Drawing.Size(822, 266);
            this.dataGridViewSP.TabIndex = 0;
            // 
            // lblSanPham
            // 
            this.lblSanPham.Location = new System.Drawing.Point(6, 9);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(47, 13);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "Sản phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(316, 4);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(75, 23);
            this.btnThemSP.TabIndex = 2;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(397, 4);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "Xóa";
            // 
            // MASP
            // 
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            // 
            // TEN_SP
            // 
            this.TEN_SP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_SP.DataPropertyName = "TEN_SP";
            this.TEN_SP.HeaderText = "Tên sản phẩm";
            this.TEN_SP.Name = "TEN_SP";
            this.TEN_SP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MAUSAC
            // 
            this.MAUSAC.HeaderText = "Màu sắc";
            this.MAUSAC.Name = "MAUSAC";
            // 
            // DVT
            // 
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // GIANHAP
            // 
            this.GIANHAP.HeaderText = "Giá nhập";
            this.GIANHAP.Name = "GIANHAP";
            // 
            // MOTASP
            // 
            this.MOTASP.HeaderText = "Mô tả";
            this.MOTASP.Name = "MOTASP";
            // 
            // frmPhieuNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 482);
            this.Controls.Add(this.grView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnControl);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private DevExpress.XtraEditors.DateEdit datePhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUSAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTASP;
    }
}