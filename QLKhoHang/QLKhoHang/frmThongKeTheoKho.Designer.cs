namespace QLKhoHang
{
    partial class frmThongKeTheoKho
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
            this.dataGVThongKe = new QLKhoHang.dataGridViewSTT(this.components);
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABANLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABANSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGGIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGGIAXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGGIATON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongKe)).BeginInit();
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
            this.pnControl.Size = new System.Drawing.Size(1046, 45);
            this.pnControl.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboKho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(746, 0);
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
            this.btnThem.Enabled = false;
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
            this.groupControl1.Controls.Add(this.dataGVThongKe);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1046, 489);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Thống kê";
            // 
            // dataGVThongKe
            // 
            this.dataGVThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dataGVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN_SP,
            this.DVT,
            this.GIANHAP,
            this.GIABANLE,
            this.GIABANSI,
            this.SLTON,
            this.SLNHAP,
            this.SLXUAT,
            this.TONGGIANHAP,
            this.TONGGIAXUAT,
            this.TONGGIATON,
            this.MAKHO});
            this.dataGVThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVThongKe.Enabled = false;
            this.dataGVThongKe.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGVThongKe.Location = new System.Drawing.Point(2, 20);
            this.dataGVThongKe.Name = "dataGVThongKe";
            this.dataGVThongKe.Size = new System.Drawing.Size(1042, 467);
            this.dataGVThongKe.TabIndex = 0;
            // 
            // TEN_SP
            // 
            this.TEN_SP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TEN_SP.DataPropertyName = "TEN_SP";
            this.TEN_SP.HeaderText = "Tên sản phẩm";
            this.TEN_SP.Name = "TEN_SP";
            this.TEN_SP.Width = 99;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.Width = 51;
            // 
            // GIANHAP
            // 
            this.GIANHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.HeaderText = "Giá nhập";
            this.GIANHAP.Name = "GIANHAP";
            // 
            // GIABANLE
            // 
            this.GIABANLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIABANLE.DataPropertyName = "GIABANLE";
            this.GIABANLE.HeaderText = "Giá bán lẻ";
            this.GIABANLE.Name = "GIABANLE";
            // 
            // GIABANSI
            // 
            this.GIABANSI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIABANSI.DataPropertyName = "GIABANSI";
            this.GIABANSI.HeaderText = "Giá bán sỉ";
            this.GIABANSI.Name = "GIABANSI";
            // 
            // SLTON
            // 
            this.SLTON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SLTON.DataPropertyName = "SLTON";
            this.SLTON.HeaderText = "Số lượng tồn";
            this.SLTON.Name = "SLTON";
            // 
            // SLNHAP
            // 
            this.SLNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SLNHAP.DataPropertyName = "SLNHAP";
            this.SLNHAP.HeaderText = "Số lượng nhập";
            this.SLNHAP.Name = "SLNHAP";
            this.SLNHAP.Width = 101;
            // 
            // SLXUAT
            // 
            this.SLXUAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SLXUAT.DataPropertyName = "SLXUAT";
            this.SLXUAT.HeaderText = "Số lượng xuất";
            this.SLXUAT.Name = "SLXUAT";
            // 
            // TONGGIANHAP
            // 
            this.TONGGIANHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGGIANHAP.DataPropertyName = "TONGGIANHAP";
            this.TONGGIANHAP.HeaderText = "Tổng tiền nhập";
            this.TONGGIANHAP.Name = "TONGGIANHAP";
            // 
            // TONGGIAXUAT
            // 
            this.TONGGIAXUAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGGIAXUAT.DataPropertyName = "TONGGIAXUAT";
            this.TONGGIAXUAT.HeaderText = "Tổng tiền xuất";
            this.TONGGIAXUAT.Name = "TONGGIAXUAT";
            // 
            // TONGGIATON
            // 
            this.TONGGIATON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGGIATON.DataPropertyName = "TONGGIATON";
            this.TONGGIATON.HeaderText = "Tổng tiền hàng tồn kho";
            this.TONGGIATON.Name = "TONGGIATON";
            // 
            // MAKHO
            // 
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã kho";
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.Visible = false;
            // 
            // frmThongKeTheoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 534);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pnControl);
            this.Name = "frmThongKeTheoKho";
            this.Text = "Thống kê sản phẩm theo kho";
            this.Load += new System.EventHandler(this.frmThongKeTheoKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private dataGridViewSTT dataGVThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABANLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABANSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGGIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGGIAXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGGIATON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;

    }
}