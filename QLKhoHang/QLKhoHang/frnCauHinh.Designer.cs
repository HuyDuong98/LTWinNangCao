namespace QLKhoHang
{
    partial class frnCauHinh
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuLai = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.cbSeverName = new System.Windows.Forms.ComboBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSeverName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(274, 232);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 26);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Location = new System.Drawing.Point(173, 232);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(95, 26);
            this.btnLuuLai.TabIndex = 14;
            this.btnLuuLai.Tag = "";
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(285, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(173, 134);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(285, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(173, 192);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(285, 21);
            this.cbDatabase.TabIndex = 13;
            // 
            // cbSeverName
            // 
            this.cbSeverName.FormattingEnabled = true;
            this.cbSeverName.Location = new System.Drawing.Point(173, 105);
            this.cbSeverName.Name = "cbSeverName";
            this.cbSeverName.Size = new System.Drawing.Size(285, 21);
            this.cbSeverName.TabIndex = 6;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(84, 195);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 7;
            this.lblDatabase.Text = "Database";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(84, 166);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(53, 13);
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(84, 137);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User name";
            // 
            // lblSeverName
            // 
            this.lblSeverName.AutoSize = true;
            this.lblSeverName.Location = new System.Drawing.Point(84, 108);
            this.lblSeverName.Name = "lblSeverName";
            this.lblSeverName.Size = new System.Drawing.Size(64, 13);
            this.lblSeverName.TabIndex = 10;
            this.lblSeverName.Text = "Sever name";
            // 
            // frnCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 319);
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
            this.Name = "frnCauHinh";
            this.Text = "frnCauHinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.ComboBox cbSeverName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSeverName;
    }
}