namespace QLKhoHang
{
    partial class frmCauHinh
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.cbSeverName = new System.Windows.Forms.ComboBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSeverName = new System.Windows.Forms.Label();
            this.btnLuuLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(285, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(148, 59);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(285, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(148, 117);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(285, 21);
            this.cbDatabase.TabIndex = 13;
            this.cbDatabase.DropDown += new System.EventHandler(this.cbDatabase_DropDown);
            // 
            // cbSeverName
            // 
            this.cbSeverName.FormattingEnabled = true;
            this.cbSeverName.Location = new System.Drawing.Point(148, 30);
            this.cbSeverName.Name = "cbSeverName";
            this.cbSeverName.Size = new System.Drawing.Size(285, 21);
            this.cbSeverName.TabIndex = 6;
            this.cbSeverName.DropDown += new System.EventHandler(this.cbSeverName_DropDown);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(59, 120);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 7;
            this.lblDatabase.Text = "Database";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(59, 91);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(53, 13);
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(59, 62);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User name";
            // 
            // lblSeverName
            // 
            this.lblSeverName.AutoSize = true;
            this.lblSeverName.Location = new System.Drawing.Point(59, 33);
            this.lblSeverName.Name = "lblSeverName";
            this.lblSeverName.Size = new System.Drawing.Size(64, 13);
            this.lblSeverName.TabIndex = 10;
            this.lblSeverName.Text = "Sever name";
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Location = new System.Drawing.Point(148, 155);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(104, 39);
            this.btnLuuLai.TabIndex = 16;
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(258, 155);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 39);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 217);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuLai);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.cbSeverName);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblSeverName);
            this.Name = "frmCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCauHinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.ComboBox cbSeverName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSeverName;
        private DevExpress.XtraEditors.SimpleButton btnLuuLai;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}