namespace QLKhoHang
{
    partial class frmKhachHang
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lblSDT = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKH = new DevExpress.XtraEditors.LabelControl();
            this.grDSKH = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewKH = new QLKhoHang.dataGridViewSTT(this.components);
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAILKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.btnTiemKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDSKH)).BeginInit();
            this.grDSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnControl.Appearance.Options.UseBackColor = true;
            this.pnControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnControl.Controls.Add(this.btnTiemKiem);
            this.pnControl.Controls.Add(this.txtTimKiem);
            this.pnControl.Controls.Add(this.btnIn);
            this.pnControl.Controls.Add(this.btnSua);
            this.pnControl.Controls.Add(this.btnXoa);
            this.pnControl.Controls.Add(this.btnLuu);
            this.pnControl.Controls.Add(this.btnThem);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(774, 45);
            this.pnControl.TabIndex = 15;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTenKH);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.txtEmail);
            this.panelControl1.Controls.Add(this.txtSDT);
            this.panelControl1.Controls.Add(this.txtMaKH);
            this.panelControl1.Controls.Add(this.lblDiaChi);
            this.panelControl1.Controls.Add(this.lblEmail);
            this.panelControl1.Controls.Add(this.lblTenKH);
            this.panelControl1.Controls.Add(this.lblSDT);
            this.panelControl1.Controls.Add(this.lblMaKH);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Enabled = false;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(774, 148);
            this.panelControl1.TabIndex = 16;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(495, 18);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(241, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(113, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(623, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(495, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(113, 61);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(241, 20);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(113, 18);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(241, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(75, 107);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(32, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(465, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(24, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblTenKH
            // 
            this.lblTenKH.Location = new System.Drawing.Point(413, 21);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(76, 13);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(45, 64);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(62, 13);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Location = new System.Drawing.Point(35, 21);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(72, 13);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // grDSKH
            // 
            this.grDSKH.Controls.Add(this.dataGridViewKH);
            this.grDSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSKH.Location = new System.Drawing.Point(0, 193);
            this.grDSKH.Name = "grDSKH";
            this.grDSKH.Size = new System.Drawing.Size(774, 276);
            this.grDSKH.TabIndex = 17;
            this.grDSKH.Text = "Danh sách khách hàng";
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.SDTKH,
            this.EMAILKH,
            this.DIACHIKH});
            this.dataGridViewKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKH.Location = new System.Drawing.Point(2, 20);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.Size = new System.Drawing.Size(770, 254);
            this.dataGridViewKH.TabIndex = 0;
            this.dataGridViewKH.DataSourceChanged += new System.EventHandler(this.dataGridViewKH_DataSourceChanged);
            this.dataGridViewKH.SelectionChanged += new System.EventHandler(this.dataGridViewKH_SelectionChanged);
            // 
            // MAKH
            // 
            this.MAKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.Name = "TENKH";
            // 
            // SDTKH
            // 
            this.SDTKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTKH.DataPropertyName = "SDTKH";
            this.SDTKH.HeaderText = "Số điện thoại";
            this.SDTKH.Name = "SDTKH";
            // 
            // EMAILKH
            // 
            this.EMAILKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMAILKH.DataPropertyName = "EMAILKH";
            this.EMAILKH.HeaderText = "Email";
            this.EMAILKH.Name = "EMAILKH";
            // 
            // DIACHIKH
            // 
            this.DIACHIKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHIKH.DataPropertyName = "DIACHIKH";
            this.DIACHIKH.HeaderText = "Địa chỉ";
            this.DIACHIKH.Name = "DIACHIKH";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(583, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(179, 20);
            this.txtTimKiem.TabIndex = 11;
            // 
            // btnTiemKiem
            // 
            this.btnTiemKiem.Location = new System.Drawing.Point(495, 11);
            this.btnTiemKiem.Name = "btnTiemKiem";
            this.btnTiemKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTiemKiem.TabIndex = 12;
            this.btnTiemKiem.Text = "simpleButton1";
            this.btnTiemKiem.Click += new System.EventHandler(this.btnTiemKiem_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 469);
            this.Controls.Add(this.grDSKH);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnControl);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDSKH)).EndInit();
            this.grDSKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl lblSDT;
        private DevExpress.XtraEditors.LabelControl lblMaKH;
        private DevExpress.XtraEditors.GroupControl grDSKH;
        private dataGridViewSTT dataGridViewKH;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIKH;
        private DevExpress.XtraEditors.SimpleButton btnTiemKiem;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
    }
}