namespace QLKhoHang
{
    partial class frmNhaCungCap
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
            this.panelNCC = new System.Windows.Forms.Panel();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtNguoiLH = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNCC = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNCC = new DevExpress.XtraEditors.TextEdit();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.lblMota = new DevExpress.XtraEditors.LabelControl();
            this.lblWebsite = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblSDT = new DevExpress.XtraEditors.LabelControl();
            this.lblNguoiLH = new DevExpress.XtraEditors.LabelControl();
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lblTenNCC = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKV = new DevExpress.XtraEditors.LabelControl();
            this.lblMaNCC = new DevExpress.XtraEditors.LabelControl();
            this.grDanhSachNCC = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewNCC = new QLKhoHang.dataGridViewSTT(this.components);
            this.txtSDT = new QLKhoHang.txtChiNhapSo(this.components);
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHU_VUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHINCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOILIENHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAILNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEBSITENCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.panelNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiLH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhSachNCC)).BeginInit();
            this.grDanhSachNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
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
            this.pnControl.Size = new System.Drawing.Size(847, 45);
            this.pnControl.TabIndex = 18;
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
            // panelNCC
            // 
            this.panelNCC.Controls.Add(this.txtSDT);
            this.panelNCC.Controls.Add(this.cboKhuVuc);
            this.panelNCC.Controls.Add(this.txtWebsite);
            this.panelNCC.Controls.Add(this.txtEmail);
            this.panelNCC.Controls.Add(this.txtNguoiLH);
            this.panelNCC.Controls.Add(this.txtDiaChi);
            this.panelNCC.Controls.Add(this.txtTenNCC);
            this.panelNCC.Controls.Add(this.txtMaNCC);
            this.panelNCC.Controls.Add(this.txtMota);
            this.panelNCC.Controls.Add(this.lblMota);
            this.panelNCC.Controls.Add(this.lblWebsite);
            this.panelNCC.Controls.Add(this.lblEmail);
            this.panelNCC.Controls.Add(this.lblSDT);
            this.panelNCC.Controls.Add(this.lblNguoiLH);
            this.panelNCC.Controls.Add(this.lblDiaChi);
            this.panelNCC.Controls.Add(this.lblTenNCC);
            this.panelNCC.Controls.Add(this.lblMaKV);
            this.panelNCC.Controls.Add(this.lblMaNCC);
            this.panelNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNCC.Enabled = false;
            this.panelNCC.Location = new System.Drawing.Point(0, 45);
            this.panelNCC.Name = "panelNCC";
            this.panelNCC.Size = new System.Drawing.Size(847, 209);
            this.panelNCC.TabIndex = 19;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(531, 12);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(279, 21);
            this.cboKhuVuc.TabIndex = 3;
            this.cboKhuVuc.DropDown += new System.EventHandler(this.cboKhuVuc_DropDown);
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(531, 111);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(279, 20);
            this.txtWebsite.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNguoiLH
            // 
            this.txtNguoiLH.Location = new System.Drawing.Point(129, 77);
            this.txtNguoiLH.Name = "txtNguoiLH";
            this.txtNguoiLH.Size = new System.Drawing.Size(231, 20);
            this.txtNguoiLH.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(531, 43);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(279, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(129, 43);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(231, 20);
            this.txtTenNCC.TabIndex = 2;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Location = new System.Drawing.Point(129, 9);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(231, 20);
            this.txtMaNCC.TabIndex = 2;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(129, 148);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(681, 41);
            this.txtMota.TabIndex = 1;
            // 
            // lblMota
            // 
            this.lblMota.Location = new System.Drawing.Point(32, 148);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(27, 13);
            this.lblMota.TabIndex = 0;
            this.lblMota.Text = "Mô tả";
            // 
            // lblWebsite
            // 
            this.lblWebsite.Location = new System.Drawing.Point(424, 114);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(39, 13);
            this.lblWebsite.TabIndex = 0;
            this.lblWebsite.Text = "Website";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(32, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(24, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(424, 80);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(62, 13);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblNguoiLH
            // 
            this.lblNguoiLH.Location = new System.Drawing.Point(32, 80);
            this.lblNguoiLH.Name = "lblNguoiLH";
            this.lblNguoiLH.Size = new System.Drawing.Size(62, 13);
            this.lblNguoiLH.TabIndex = 0;
            this.lblNguoiLH.Text = "Người liên hệ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(424, 46);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(32, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.Location = new System.Drawing.Point(32, 46);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(85, 13);
            this.lblTenNCC.TabIndex = 0;
            this.lblTenNCC.Text = "Tên nhà cung cấp";
            // 
            // lblMaKV
            // 
            this.lblMaKV.Location = new System.Drawing.Point(424, 12);
            this.lblMaKV.Name = "lblMaKV";
            this.lblMaKV.Size = new System.Drawing.Size(55, 13);
            this.lblMaKV.TabIndex = 0;
            this.lblMaKV.Text = "Mã khu vực";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.Location = new System.Drawing.Point(32, 12);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(81, 13);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // grDanhSachNCC
            // 
            this.grDanhSachNCC.Controls.Add(this.dataGridViewNCC);
            this.grDanhSachNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDanhSachNCC.Location = new System.Drawing.Point(0, 254);
            this.grDanhSachNCC.Name = "grDanhSachNCC";
            this.grDanhSachNCC.Size = new System.Drawing.Size(847, 225);
            this.grDanhSachNCC.TabIndex = 20;
            this.grDanhSachNCC.Text = "Danh sách nhà cung cấp";
            // 
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANCC,
            this.KHU_VUC,
            this.MAKV,
            this.TENNCC,
            this.DIACHINCC,
            this.NGUOILIENHE,
            this.SDTNCC,
            this.EMAILNCC,
            this.WEBSITENCC,
            this.MOTANCC});
            this.dataGridViewNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNCC.Location = new System.Drawing.Point(2, 20);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.Size = new System.Drawing.Size(843, 203);
            this.dataGridViewNCC.TabIndex = 0;
            this.dataGridViewNCC.DataSourceChanged += new System.EventHandler(this.dataGridViewNCC_DataSourceChanged);
            this.dataGridViewNCC.SelectionChanged += new System.EventHandler(this.dataGridViewNCC_SelectionChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(531, 77);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(279, 21);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // MANCC
            // 
            this.MANCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            // 
            // KHU_VUC
            // 
            this.KHU_VUC.DataPropertyName = "KHU_VUC";
            this.KHU_VUC.HeaderText = "Khu vực";
            this.KHU_VUC.Name = "KHU_VUC";
            this.KHU_VUC.Visible = false;
            // 
            // MAKV
            // 
            this.MAKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAKV.DataPropertyName = "MAKV";
            this.MAKV.HeaderText = "Mã khu vực";
            this.MAKV.Name = "MAKV";
            this.MAKV.ReadOnly = true;
            // 
            // TENNCC
            // 
            this.TENNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên nhà cung cấp";
            this.TENNCC.Name = "TENNCC";
            // 
            // DIACHINCC
            // 
            this.DIACHINCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHINCC.DataPropertyName = "DIACHINCC";
            this.DIACHINCC.HeaderText = "Địa chỉ";
            this.DIACHINCC.Name = "DIACHINCC";
            // 
            // NGUOILIENHE
            // 
            this.NGUOILIENHE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGUOILIENHE.DataPropertyName = "NGUOILIENHE";
            this.NGUOILIENHE.HeaderText = "Người liên hệ";
            this.NGUOILIENHE.Name = "NGUOILIENHE";
            // 
            // SDTNCC
            // 
            this.SDTNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTNCC.DataPropertyName = "SDTNCC";
            this.SDTNCC.HeaderText = "SDT";
            this.SDTNCC.Name = "SDTNCC";
            // 
            // EMAILNCC
            // 
            this.EMAILNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMAILNCC.DataPropertyName = "EMAILNCC";
            this.EMAILNCC.HeaderText = "Email";
            this.EMAILNCC.Name = "EMAILNCC";
            // 
            // WEBSITENCC
            // 
            this.WEBSITENCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WEBSITENCC.DataPropertyName = "WEBSITENCC";
            this.WEBSITENCC.HeaderText = "Website";
            this.WEBSITENCC.Name = "WEBSITENCC";
            // 
            // MOTANCC
            // 
            this.MOTANCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTANCC.DataPropertyName = "MOTANCC";
            this.MOTANCC.HeaderText = "Mô tả";
            this.MOTANCC.Name = "MOTANCC";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 479);
            this.Controls.Add(this.grDanhSachNCC);
            this.Controls.Add(this.panelNCC);
            this.Controls.Add(this.pnControl);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.panelNCC.ResumeLayout(false);
            this.panelNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiLH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhSachNCC)).EndInit();
            this.grDanhSachNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelNCC;
        private DevExpress.XtraEditors.GroupControl grDanhSachNCC;
        private dataGridViewSTT dataGridViewNCC;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtNguoiLH;
        private DevExpress.XtraEditors.TextEdit txtTenNCC;
        private DevExpress.XtraEditors.TextEdit txtMaNCC;
        private System.Windows.Forms.TextBox txtMota;
        private DevExpress.XtraEditors.LabelControl lblMota;
        private DevExpress.XtraEditors.LabelControl lblWebsite;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblSDT;
        private DevExpress.XtraEditors.LabelControl lblNguoiLH;
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraEditors.LabelControl lblTenNCC;
        private DevExpress.XtraEditors.LabelControl lblMaKV;
        private DevExpress.XtraEditors.LabelControl lblMaNCC;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private txtChiNhapSo txtSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHU_VUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHINCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOILIENHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEBSITENCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTANCC;
    }
}