namespace QLKhoHang
{
    partial class txtChiNhapSo
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCNS = new System.Windows.Forms.TextBox();
            // 
            // txtCNS
            // 
            this.txtCNS.Location = new System.Drawing.Point(0, 0);
            this.txtCNS.Name = "txtCNS";
            this.txtCNS.Size = new System.Drawing.Size(100, 20);
            this.txtCNS.TabIndex = 0;
            this.txtCNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCNS;
    }
}
