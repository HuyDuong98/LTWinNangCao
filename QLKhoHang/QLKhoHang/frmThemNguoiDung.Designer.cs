namespace QLKhoHang
{
    partial class frmThemNguoiDung
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.groupControlThem = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radiobtNv = new System.Windows.Forms.RadioButton();
            this.radiobtAdmin = new System.Windows.Forms.RadioButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlDanhSach = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOATDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThem)).BeginInit();
            this.groupControlThem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSach)).BeginInit();
            this.groupControlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(73, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(535, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Phân quyền";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(158, 33);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(341, 20);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(158, 72);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(341, 20);
            this.txtMatKhau.TabIndex = 2;
            // 
            // groupControlThem
            // 
            this.groupControlThem.Controls.Add(this.panel1);
            this.groupControlThem.Controls.Add(this.txtTenTaiKhoan);
            this.groupControlThem.Controls.Add(this.btnXoa);
            this.groupControlThem.Controls.Add(this.labelControl1);
            this.groupControlThem.Controls.Add(this.btnThem);
            this.groupControlThem.Controls.Add(this.labelControl2);
            this.groupControlThem.Controls.Add(this.labelControl3);
            this.groupControlThem.Controls.Add(this.txtMatKhau);
            this.groupControlThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlThem.Location = new System.Drawing.Point(0, 0);
            this.groupControlThem.Name = "groupControlThem";
            this.groupControlThem.Size = new System.Drawing.Size(998, 171);
            this.groupControlThem.TabIndex = 4;
            this.groupControlThem.Text = "Thêm người dùng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radiobtNv);
            this.panel1.Controls.Add(this.radiobtAdmin);
            this.panel1.Location = new System.Drawing.Point(620, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 33);
            this.panel1.TabIndex = 7;
            // 
            // radiobtNv
            // 
            this.radiobtNv.AutoSize = true;
            this.radiobtNv.Location = new System.Drawing.Point(185, 4);
            this.radiobtNv.Name = "radiobtNv";
            this.radiobtNv.Size = new System.Drawing.Size(73, 17);
            this.radiobtNv.TabIndex = 0;
            this.radiobtNv.Text = "Nhân viên";
            this.radiobtNv.UseVisualStyleBackColor = true;
            // 
            // radiobtAdmin
            // 
            this.radiobtAdmin.AutoSize = true;
            this.radiobtAdmin.Checked = true;
            this.radiobtAdmin.Location = new System.Drawing.Point(51, 3);
            this.radiobtAdmin.Name = "radiobtAdmin";
            this.radiobtAdmin.Size = new System.Drawing.Size(54, 17);
            this.radiobtAdmin.TabIndex = 0;
            this.radiobtAdmin.TabStop = true;
            this.radiobtAdmin.Text = "Admin";
            this.radiobtAdmin.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.ImageOptions.Image = global::QLKhoHang.Properties.Resources.tsbDelete;
            this.btnXoa.Location = new System.Drawing.Point(239, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = global::QLKhoHang.Properties.Resources.tsbAddNew;
            this.btnThem.Location = new System.Drawing.Point(158, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControlDanhSach
            // 
            this.groupControlDanhSach.Controls.Add(this.dataGridViewNguoiDung);
            this.groupControlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDanhSach.Location = new System.Drawing.Point(0, 171);
            this.groupControlDanhSach.Name = "groupControlDanhSach";
            this.groupControlDanhSach.Size = new System.Drawing.Size(998, 322);
            this.groupControlDanhSach.TabIndex = 5;
            this.groupControlDanhSach.Text = "Danh sách người dùng";
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.HOATDONG,
            this.Password,
            this.PhanQuyen});
            this.dataGridViewNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(2, 20);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(994, 300);
            this.dataGridViewNguoiDung.TabIndex = 0;
            this.dataGridViewNguoiDung.SelectionChanged += new System.EventHandler(this.dataGridViewNguoiDung_SelectionChanged);
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.DataPropertyName = "TENDANGNHAP";
            this.User.HeaderText = "Tên đăng nhập";
            this.User.Name = "User";
            // 
            // HOATDONG
            // 
            this.HOATDONG.DataPropertyName = "HOATDONG";
            this.HOATDONG.HeaderText = "Hoạt động";
            this.HOATDONG.Name = "HOATDONG";
            this.HOATDONG.Visible = false;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "MATKHAU";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhanQuyen.DataPropertyName = "TENNHOM";
            this.PhanQuyen.HeaderText = "Quyền truy cập";
            this.PhanQuyen.Name = "PhanQuyen";
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 493);
            this.Controls.Add(this.groupControlDanhSach);
            this.Controls.Add(this.groupControlThem);
            this.Name = "frmThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tài khoản mới";
            this.Load += new System.EventHandler(this.frmThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThem)).EndInit();
            this.groupControlThem.ResumeLayout(false);
            this.groupControlThem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSach)).EndInit();
            this.groupControlDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupControlThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.GroupControl groupControlDanhSach;
        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOATDONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radiobtNv;
        private System.Windows.Forms.RadioButton radiobtAdmin;
    }
}