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
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.cbSeverName = new System.Windows.Forms.ComboBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblSeverName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(252, 117);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 33);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Location = new System.Drawing.Point(144, 117);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(102, 33);
            this.btnLuuLai.TabIndex = 14;
            this.btnLuuLai.Tag = "";
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.UseVisualStyleBackColor = true;
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(144, 71);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(292, 21);
            this.cbDatabase.TabIndex = 13;
            this.cbDatabase.DropDown += new System.EventHandler(this.cbDatabase_DropDown);
            // 
            // cbSeverName
            // 
            this.cbSeverName.FormattingEnabled = true;
            this.cbSeverName.Location = new System.Drawing.Point(144, 38);
            this.cbSeverName.Name = "cbSeverName";
            this.cbSeverName.Size = new System.Drawing.Size(292, 21);
            this.cbSeverName.TabIndex = 6;
            this.cbSeverName.DropDown += new System.EventHandler(this.cbSeverName_DropDown);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(66, 74);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 7;
            this.lblDatabase.Text = "Database";
            // 
            // lblSeverName
            // 
            this.lblSeverName.AutoSize = true;
            this.lblSeverName.Location = new System.Drawing.Point(55, 41);
            this.lblSeverName.Name = "lblSeverName";
            this.lblSeverName.Size = new System.Drawing.Size(64, 13);
            this.lblSeverName.TabIndex = 10;
            this.lblSeverName.Text = "Sever name";
            // 
            // frnCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 187);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuLai);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.cbSeverName);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblSeverName);
            this.Name = "frnCauHinh";
            this.Text = "Cấu hình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frnCauHinh_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.ComboBox cbSeverName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblSeverName;
    }
}