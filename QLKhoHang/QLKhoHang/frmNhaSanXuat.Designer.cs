namespace QLKhoHang
{
    partial class frmNhaSanXuat
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
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelNhaSanXuat = new DevExpress.XtraEditors.PanelControl();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.lblWebsite = new DevExpress.XtraEditors.LabelControl();
            this.lblMoTa = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblMa = new DevExpress.XtraEditors.LabelControl();
            this.GrpDanhSachNSX = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewNSX = new System.Windows.Forms.DataGridView();
            this.MANSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAILNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEBSITENSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTANSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhaSanXuat)).BeginInit();
            this.panelNhaSanXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpDanhSachNSX)).BeginInit();
            this.GrpDanhSachNSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNSX)).BeginInit();
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
            this.pnControl.Size = new System.Drawing.Size(844, 45);
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
            // panelNhaSanXuat
            // 
            this.panelNhaSanXuat.Controls.Add(this.txtMoTa);
            this.panelNhaSanXuat.Controls.Add(this.txtWebsite);
            this.panelNhaSanXuat.Controls.Add(this.txtTen);
            this.panelNhaSanXuat.Controls.Add(this.txtEmail);
            this.panelNhaSanXuat.Controls.Add(this.txtMa);
            this.panelNhaSanXuat.Controls.Add(this.lblWebsite);
            this.panelNhaSanXuat.Controls.Add(this.lblMoTa);
            this.panelNhaSanXuat.Controls.Add(this.lblTen);
            this.panelNhaSanXuat.Controls.Add(this.lblEmail);
            this.panelNhaSanXuat.Controls.Add(this.lblMa);
            this.panelNhaSanXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhaSanXuat.Enabled = false;
            this.panelNhaSanXuat.Location = new System.Drawing.Point(0, 45);
            this.panelNhaSanXuat.Name = "panelNhaSanXuat";
            this.panelNhaSanXuat.Size = new System.Drawing.Size(844, 163);
            this.panelNhaSanXuat.TabIndex = 15;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(109, 92);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(723, 47);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(539, 54);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(293, 20);
            this.txtWebsite.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(539, 14);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(293, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(109, 14);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(313, 20);
            this.txtMa.TabIndex = 1;
            // 
            // lblWebsite
            // 
            this.lblWebsite.Location = new System.Drawing.Point(492, 57);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(39, 13);
            this.lblWebsite.TabIndex = 0;
            this.lblWebsite.Text = "Website";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Location = new System.Drawing.Point(79, 100);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(27, 13);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(447, 17);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(84, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên nhà sản xuất";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(79, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(24, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(23, 17);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(80, 13);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã nhà sản xuất";
            // 
            // GrpDanhSachNSX
            // 
            this.GrpDanhSachNSX.Controls.Add(this.dataGridViewNSX);
            this.GrpDanhSachNSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpDanhSachNSX.Location = new System.Drawing.Point(0, 208);
            this.GrpDanhSachNSX.Name = "GrpDanhSachNSX";
            this.GrpDanhSachNSX.Size = new System.Drawing.Size(844, 275);
            this.GrpDanhSachNSX.TabIndex = 16;
            this.GrpDanhSachNSX.Text = "Danh sách nhà sản xuất";
            // 
            // dataGridViewNSX
            // 
            this.dataGridViewNSX.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANSX,
            this.TENNSX,
            this.EMAILNSX,
            this.WEBSITENSX,
            this.MOTANSX});
            this.dataGridViewNSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNSX.Location = new System.Drawing.Point(2, 20);
            this.dataGridViewNSX.Name = "dataGridViewNSX";
            this.dataGridViewNSX.Size = new System.Drawing.Size(840, 253);
            this.dataGridViewNSX.TabIndex = 0;
            this.dataGridViewNSX.DataSourceChanged += new System.EventHandler(this.dataGridViewNSX_DataSourceChanged_1);
            this.dataGridViewNSX.SelectionChanged += new System.EventHandler(this.dataGridViewNSX_SelectionChanged);
            // 
            // MANSX
            // 
            this.MANSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANSX.DataPropertyName = "MANSX";
            this.MANSX.HeaderText = "Mã nhà sản xuất";
            this.MANSX.Name = "MANSX";
            this.MANSX.ReadOnly = true;
            // 
            // TENNSX
            // 
            this.TENNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNSX.DataPropertyName = "TENNSX";
            this.TENNSX.HeaderText = "Tên nhà sản xuất";
            this.TENNSX.Name = "TENNSX";
            // 
            // EMAILNSX
            // 
            this.EMAILNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMAILNSX.DataPropertyName = "EMAILNSX";
            this.EMAILNSX.HeaderText = "Email";
            this.EMAILNSX.Name = "EMAILNSX";
            // 
            // WEBSITENSX
            // 
            this.WEBSITENSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WEBSITENSX.DataPropertyName = "WEBSITENSX";
            this.WEBSITENSX.HeaderText = "Website";
            this.WEBSITENSX.Name = "WEBSITENSX";
            // 
            // MOTANSX
            // 
            this.MOTANSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTANSX.DataPropertyName = "MOTANSX";
            this.MOTANSX.HeaderText = "Mô tả";
            this.MOTANSX.Name = "MOTANSX";
            // 
            // frmNhaSanXuat
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 483);
            this.Controls.Add(this.GrpDanhSachNSX);
            this.Controls.Add(this.panelNhaSanXuat);
            this.Controls.Add(this.pnControl);
            this.Name = "frmNhaSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhaSanXuat";
            this.Load += new System.EventHandler(this.frmNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelNhaSanXuat)).EndInit();
            this.panelNhaSanXuat.ResumeLayout(false);
            this.panelNhaSanXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpDanhSachNSX)).EndInit();
            this.GrpDanhSachNSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNSX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.PanelControl panelNhaSanXuat;
        private System.Windows.Forms.TextBox txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl lblWebsite;
        private DevExpress.XtraEditors.LabelControl lblMoTa;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblMa;
        private DevExpress.XtraEditors.GroupControl GrpDanhSachNSX;
        private System.Windows.Forms.DataGridView dataGridViewNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEBSITENSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTANSX;


    }
}