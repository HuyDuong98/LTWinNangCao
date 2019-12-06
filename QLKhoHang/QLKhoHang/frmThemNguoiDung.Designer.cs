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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlThem = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlDanhSach = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOATDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThem)).BeginInit();
            this.groupControlThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSach)).BeginInit();
            this.groupControlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(270, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(270, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(270, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Phân quyền";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(355, 34);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(341, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(355, 73);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(341, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(355, 115);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "admin"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Nhân viên")});
            this.radioGroup1.Size = new System.Drawing.Size(341, 31);
            this.radioGroup1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::QLKhoHang.Properties.Resources.tsbAddNew;
            this.simpleButton1.Location = new System.Drawing.Point(459, 166);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 37);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Thêm";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::QLKhoHang.Properties.Resources.tsbClose;
            this.simpleButton2.Location = new System.Drawing.Point(621, 166);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 37);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Thoát";
            // 
            // groupControlThem
            // 
            this.groupControlThem.Controls.Add(this.textEdit1);
            this.groupControlThem.Controls.Add(this.simpleButton3);
            this.groupControlThem.Controls.Add(this.simpleButton2);
            this.groupControlThem.Controls.Add(this.labelControl1);
            this.groupControlThem.Controls.Add(this.simpleButton1);
            this.groupControlThem.Controls.Add(this.labelControl2);
            this.groupControlThem.Controls.Add(this.radioGroup1);
            this.groupControlThem.Controls.Add(this.labelControl3);
            this.groupControlThem.Controls.Add(this.textEdit2);
            this.groupControlThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlThem.Location = new System.Drawing.Point(0, 0);
            this.groupControlThem.Name = "groupControlThem";
            this.groupControlThem.Size = new System.Drawing.Size(998, 215);
            this.groupControlThem.TabIndex = 4;
            this.groupControlThem.Text = "Thêm người dùng";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = global::QLKhoHang.Properties.Resources.tsbDelete;
            this.simpleButton3.Location = new System.Drawing.Point(540, 166);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 37);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Xóa";
            // 
            // groupControlDanhSach
            // 
            this.groupControlDanhSach.Controls.Add(this.dataGridViewNguoiDung);
            this.groupControlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDanhSach.Location = new System.Drawing.Point(0, 215);
            this.groupControlDanhSach.Name = "groupControlDanhSach";
            this.groupControlDanhSach.Size = new System.Drawing.Size(998, 278);
            this.groupControlDanhSach.TabIndex = 5;
            this.groupControlDanhSach.Text = "Danh sách người dùng";
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.HOATDONG,
            this.Password,
            this.PhanQuyen});
            this.dataGridViewNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(2, 20);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(994, 256);
            this.dataGridViewNguoiDung.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThem)).EndInit();
            this.groupControlThem.ResumeLayout(false);
            this.groupControlThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSach)).EndInit();
            this.groupControlDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControlThem;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.GroupControl groupControlDanhSach;
        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOATDONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
    }
}