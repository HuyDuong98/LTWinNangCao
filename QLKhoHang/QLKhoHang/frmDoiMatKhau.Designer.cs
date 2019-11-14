namespace QLKhoHang
{
    partial class frmDoiMatKhau
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtXacNhanMK = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.lblXacNhanMK = new DevExpress.XtraEditors.LabelControl();
            this.lblMatKhauMoi = new DevExpress.XtraEditors.LabelControl();
            this.lblMatKhauCu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(399, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Bỏ qua";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(318, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(155, 107);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(319, 20);
            this.txtXacNhanMK.TabIndex = 9;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(155, 75);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(319, 20);
            this.txtMatKhauMoi.TabIndex = 10;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(155, 43);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(319, 20);
            this.txtMatKhauCu.TabIndex = 5;
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.Location = new System.Drawing.Point(48, 110);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(91, 13);
            this.lblXacNhanMK.TabIndex = 7;
            this.lblXacNhanMK.Text = "Xác nhân mật khẩu";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.Location = new System.Drawing.Point(48, 78);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(63, 13);
            this.lblMatKhauMoi.TabIndex = 8;
            this.lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.Location = new System.Drawing.Point(48, 46);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(58, 13);
            this.lblMatKhauCu.TabIndex = 6;
            this.lblMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.lblXacNhanMK);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblMatKhauCu);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMK;
        private DevExpress.XtraEditors.TextEdit txtMatKhauMoi;
        private DevExpress.XtraEditors.TextEdit txtMatKhauCu;
        private DevExpress.XtraEditors.LabelControl lblXacNhanMK;
        private DevExpress.XtraEditors.LabelControl lblMatKhauMoi;
        private DevExpress.XtraEditors.LabelControl lblMatKhauCu;
    }
}