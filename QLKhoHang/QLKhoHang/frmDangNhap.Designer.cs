namespace QLKhoHang
{
    partial class frmDangNhap
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
            this.lblTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.lblMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTaiKhoan.Appearance.Options.UseFont = true;
            this.lblTaiKhoan.Appearance.Options.UseForeColor = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(38, 178);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(95, 16);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMatKhau.Appearance.Options.UseFont = true;
            this.lblMatKhau.Appearance.Options.UseForeColor = true;
            this.lblMatKhau.Location = new System.Drawing.Point(38, 211);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(60, 16);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(154, 175);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(228, 22);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(154, 208);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(228, 22);
            this.txtMatKhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Appearance.Options.UseForeColor = true;
            this.btnDangNhap.BackgroundImage = global::QLKhoHang.Properties.Resources.background_button;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDangNhap.Location = new System.Drawing.Point(86, 262);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(118, 44);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(27, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 65);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Quản lý kho hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.BackgroundImage = global::QLKhoHang.Properties.Resources.background_button;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThoat.Location = new System.Drawing.Point(210, 262);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 44);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKhoHang.Properties.Resources._1_2x;
            this.ClientSize = new System.Drawing.Size(430, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.Enter += new System.EventHandler(this.btnDangNhap_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lblMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnThoat;

    }
}