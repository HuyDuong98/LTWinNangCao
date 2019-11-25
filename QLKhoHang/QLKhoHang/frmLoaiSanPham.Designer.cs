namespace QLKhoHang
{
    partial class frmLoaiSanPham
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
            this.pnNhapLoaiSP = new DevExpress.XtraEditors.PanelControl();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtLoaiSP = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLoaiSP = new DevExpress.XtraEditors.TextEdit();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblMaLoaiSP = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataLoaiSP = new System.Windows.Forms.DataGridView();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnNhapLoaiSP)).BeginInit();
            this.pnNhapLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiSP)).BeginInit();
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
            this.pnControl.Size = new System.Drawing.Size(855, 45);
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
            // pnNhapLoaiSP
            // 
            this.pnNhapLoaiSP.Controls.Add(this.txtMoTa);
            this.pnNhapLoaiSP.Controls.Add(this.txtLoaiSP);
            this.pnNhapLoaiSP.Controls.Add(this.txtMaLoaiSP);
            this.pnNhapLoaiSP.Controls.Add(this.lblMoTa);
            this.pnNhapLoaiSP.Controls.Add(this.lblLoaiSP);
            this.pnNhapLoaiSP.Controls.Add(this.lblMaLoaiSP);
            this.pnNhapLoaiSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNhapLoaiSP.Enabled = false;
            this.pnNhapLoaiSP.Location = new System.Drawing.Point(0, 45);
            this.pnNhapLoaiSP.Name = "pnNhapLoaiSP";
            this.pnNhapLoaiSP.Size = new System.Drawing.Size(855, 149);
            this.pnNhapLoaiSP.TabIndex = 15;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(161, 74);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(620, 57);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(161, 43);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(620, 20);
            this.txtLoaiSP.TabIndex = 1;
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.EditValue = "";
            this.txtMaLoaiSP.Enabled = false;
            this.txtMaLoaiSP.Location = new System.Drawing.Point(161, 12);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(620, 20);
            this.txtMaLoaiSP.TabIndex = 1;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(40, 77);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(34, 13);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location = new System.Drawing.Point(40, 46);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(75, 13);
            this.lblLoaiSP.TabIndex = 0;
            this.lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblMaLoaiSP
            // 
            this.lblMaLoaiSP.AutoSize = true;
            this.lblMaLoaiSP.Location = new System.Drawing.Point(40, 15);
            this.lblMaLoaiSP.Name = "lblMaLoaiSP";
            this.lblMaLoaiSP.Size = new System.Drawing.Size(89, 13);
            this.lblMaLoaiSP.TabIndex = 0;
            this.lblMaLoaiSP.Text = "Mã loại sản phẩm";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLoaiSP);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 194);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(855, 286);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Danh sách loại sản phẩm";
            // 
            // dataLoaiSP
            // 
            this.dataLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataLoaiSP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAI,
            this.TENLOAI,
            this.MOTA});
            this.dataLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLoaiSP.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataLoaiSP.Location = new System.Drawing.Point(2, 20);
            this.dataLoaiSP.Name = "dataLoaiSP";
            this.dataLoaiSP.Size = new System.Drawing.Size(851, 264);
            this.dataLoaiSP.TabIndex = 0;
            this.dataLoaiSP.DataSourceChanged += new System.EventHandler(this.dataLoaiSP_DataSourceChanged);
            this.dataLoaiSP.SelectionChanged += new System.EventHandler(this.dataLoaiSP_SelectionChanged);
            // 
            // MALOAI
            // 
            this.MALOAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.HeaderText = "Mã loại sản phẩm";
            this.MALOAI.Name = "MALOAI";
            // 
            // TENLOAI
            // 
            this.TENLOAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Tên loại sản phẩm";
            this.TENLOAI.Name = "TENLOAI";
            // 
            // MOTA
            // 
            this.MOTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MOTA.DataPropertyName = "MOTALSP";
            this.MOTA.HeaderText = "Mô tả sản phẩm";
            this.MOTA.Name = "MOTA";
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 480);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pnNhapLoaiSP);
            this.Controls.Add(this.pnControl);
            this.Name = "frmLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiSanPham";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnNhapLoaiSP)).EndInit();
            this.pnNhapLoaiSP.ResumeLayout(false);
            this.pnNhapLoaiSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.PanelControl pnNhapLoaiSP;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblMaLoaiSP;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataLoaiSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtLoaiSP;
        private DevExpress.XtraEditors.TextEdit txtMaLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
    }
}